using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        // Đường dẫn tập tin đang soạn. null = văn bản mới, chưa từng lưu hoặc mở
        private string currentFilePath = null;

        public Form1()
        {
            InitializeComponent();
        }

        // 2.1 Nạp danh sách font, cỡ chữ rồi đặt định dạng mặc định
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily family in new InstalledFontCollection().Families)
                cmbFonts.Items.Add(family.Name);

            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
                cmbSize.Items.Add(size);

            SetDefaultFormat();
        }

        // Đặt định dạng mặc định Tahoma 14 cho thanh công cụ và vùng soạn thảo
        private void SetDefaultFormat()
        {
            Font defaultFont = new Font("Tahoma", 14, FontStyle.Regular);
            cmbFonts.Text = "Tahoma";
            cmbSize.Text = "14";
            rtbContent.Font = defaultFont;
            rtbContent.SelectionFont = defaultFont;
        }

        // ===== 2.2 Tạo văn bản mới =====

        private void mnuNew_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        // Xóa nội dung, trả định dạng về mặc định và quên tập tin đang mở
        private void NewDocument()
        {
            rtbContent.Clear();
            SetDefaultFormat();
            currentFilePath = null;
            tsbBold.Checked = false;
            tsbItalic.Checked = false;
            tsbUnderline.Checked = false;
        }

        // ===== 2.3 Mở tập tin =====

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        // Chọn tập tin .rtf hoặc .txt rồi nạp vào vùng soạn thảo
        private void OpenDocument()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text (*.rtf)|*.rtf|Text (*.txt)|*.txt";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                ReadFile(dlg.FileName);
                currentFilePath = dlg.FileName;
            }
            catch (Exception ex)
            {
                ShowError("Không mở được tập tin:\n" + ex.Message);
            }
        }

        // ===== 2.4 Lưu nội dung văn bản =====

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        // Văn bản mới thì hỏi nơi lưu, văn bản đã có đường dẫn thì lưu đè
        private void SaveDocument()
        {
            try
            {
                if (currentFilePath == null)
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "Rich Text (*.rtf)|*.rtf";
                    if (dlg.ShowDialog() != DialogResult.OK)
                        return;

                    WriteFile(dlg.FileName);
                    currentFilePath = dlg.FileName;
                }
                else
                {
                    WriteFile(currentFilePath);
                    MessageBox.Show("Lưu văn bản thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowError("Không lưu được tập tin:\n" + ex.Message);
            }
        }

        // ===== Đọc / ghi tập tin theo đuôi file =====

        // Tập tin .txt là văn bản thuần, còn lại coi là Rich Text
        private bool IsTextFile(string path)
        {
            return Path.GetExtension(path).ToLower() == ".txt";
        }

        // Nạp tập tin vào rtbContent (nạp .txt bằng kiểu RichText sẽ ném ArgumentException).
        // .txt đọc theo UTF-8 vì RichTextBoxStreamType.PlainText dùng bảng mã ANSI, làm hỏng chữ tiếng Việt có dấu
        private void ReadFile(string path)
        {
            if (IsTextFile(path))
                rtbContent.Text = File.ReadAllText(path);
            else
                rtbContent.LoadFile(path, RichTextBoxStreamType.RichText);
        }

        // Ghi nội dung rtbContent ra tập tin. File .txt chỉ giữ chữ, không giữ định dạng
        private void WriteFile(string path)
        {
            if (IsTextFile(path))
                File.WriteAllText(path, rtbContent.Text.Replace("\n", "\r\n"));
            else
                rtbContent.SaveFile(path, RichTextBoxStreamType.RichText);
        }

        // ===== 2.5 Định dạng B / I / U, font và cỡ chữ =====

        private void tsbBold_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void tsbUnderline_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        // Bật/tắt một kiểu chữ cho vùng chọn bằng XOR, các kiểu khác giữ nguyên
        private void ToggleStyle(FontStyle style)
        {
            Font current = GetSelectionFont();
            ChangeSelectionFont(current.Name, current.Size, current.Style ^ style);
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyToolbarFont();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyToolbarFont();
        }

        // Áp dụng font và cỡ chữ đang chọn trên thanh công cụ, giữ nguyên kiểu B/I/U hiện tại
        private void ApplyToolbarFont()
        {
            // Lúc Form_Load mới chọn xong một trong hai ô thì chưa đủ thông tin để đổi font
            if (cmbFonts.SelectedItem == null || cmbSize.SelectedItem == null)
                return;

            Font current = GetSelectionFont();
            ChangeSelectionFont(cmbFonts.Text, Convert.ToSingle(cmbSize.SelectedItem), current.Style);
            rtbContent.Focus();
        }

        // Lấy font của vùng chọn. Vùng chọn có nhiều font thì SelectionFont = null,
        // khi đó dùng font gốc của rtbContent
        private Font GetSelectionFont()
        {
            Font font = rtbContent.SelectionFont;
            if (font == null)
                font = rtbContent.Font;
            return font;
        }

        // Gán font mới cho vùng chọn rồi cập nhật lại các nút B/I/U.
        // Có font không hỗ trợ đủ kiểu chữ, khi đó new Font ném ArgumentException
        private void ChangeSelectionFont(string fontName, float size, FontStyle style)
        {
            try
            {
                rtbContent.SelectionFont = new Font(fontName, size, style);
            }
            catch (ArgumentException)
            {
                ShowError("Font \"" + fontName + "\" không hỗ trợ kiểu chữ này.");
            }
            UpdateStyleButtons();
        }

        // Khi di chuyển con trỏ hoặc đổi vùng chọn: cập nhật trạng thái các nút B/I/U
        private void rtbContent_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStyleButtons();
        }

        // Cho các nút B/I/U sáng hoặc tắt theo font của vùng chọn
        private void UpdateStyleButtons()
        {
            Font font = rtbContent.SelectionFont;
            if (font == null)
                return;

            tsbBold.Checked = font.Bold;
            tsbItalic.Checked = font.Italic;
            tsbUnderline.Checked = font.Underline;
        }

        // ===== Định dạng > Font... =====

        // Mở hộp thoại Font, bấm OK thì áp dụng font và màu cho vùng chọn
        private void mnuFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            fontDlg.Font = GetSelectionFont();
            fontDlg.Color = rtbContent.SelectionColor;
            fontDlg.Apply += new EventHandler(fontDlg_Apply);

            if (fontDlg.ShowDialog() != DialogResult.Cancel)
                ApplyFontDialog(fontDlg);
        }

        // Nút Apply của hộp thoại Font: áp dụng ngay mà không đóng hộp thoại
        private void fontDlg_Apply(object sender, EventArgs e)
        {
            ApplyFontDialog((FontDialog)sender);
        }

        // Lấy font và màu từ hộp thoại Font gán cho vùng chọn
        private void ApplyFontDialog(FontDialog fontDlg)
        {
            rtbContent.SelectionFont = fontDlg.Font;
            rtbContent.SelectionColor = fontDlg.Color;
            UpdateStyleButtons();
        }

        // ===== Khác =====

        // Hệ thống > Thoát: đóng form
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Báo lỗi bằng MessageBox
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
