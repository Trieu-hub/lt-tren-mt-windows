using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        // Đường dẫn file đang mở ("" = văn bản mới, chưa lưu)
        string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện bằng code
            this.Load += Form1_Load;

            mnuNew.Click += New_Click;
            tsbNew.Click += New_Click;
            mnuOpen.Click += Open_Click;
            tsbOpen.Click += Open_Click;
            mnuSave.Click += Save_Click;
            tsbSave.Click += Save_Click;
            mnuExit.Click += mnuExit_Click;
            mnuFormat.Click += mnuFormat_Click;

            tsbBold.Click += tsbBold_Click;
            tsbItalic.Click += tsbItalic_Click;
            tsbUnderline.Click += tsbUnderline_Click;

            cmbFonts.SelectedIndexChanged += cmbFontOrSize_Changed;
            cmbSize.SelectedIndexChanged += cmbFontOrSize_Changed;

            richText.TextChanged += richText_TextChanged;
        }

        // 2.1 Nạp danh sách font, cỡ chữ và đặt mặc định
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
                cmbFonts.Items.Add(font.Name);

            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
                cmbSize.Items.Add(s);

            SetDefaultFont();
        }

        // Font mặc định: Tahoma, 14
        private void SetDefaultFont()
        {
            richText.Font = new Font("Tahoma", 14);
            cmbFonts.SelectedItem = "Tahoma";
            cmbSize.SelectedItem = 14;
        }

        // 2.2 Tạo văn bản mới
        private void New_Click(object sender, EventArgs e)
        {
            richText.Clear();
            SetDefaultFont();
            tsbBold.Checked = false;
            tsbItalic.Checked = false;
            tsbUnderline.Checked = false;
            currentFilePath = "";
        }

        // 2.3 Mở tập tin .txt / .rtf
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text (*.rtf)|*.rtf|Text (*.txt)|*.txt";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            if (Path.GetExtension(dlg.FileName).ToLower() == ".rtf")
                richText.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);
            else
                richText.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);

            currentFilePath = dlg.FileName;
        }

        // 2.4 Lưu văn bản
        private void Save_Click(object sender, EventArgs e)
        {
            if (currentFilePath == "")
            {
                // Chưa có file -> hỏi nơi lưu, lưu dạng .rtf
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Rich Text (*.rtf)|*.rtf";
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                richText.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText);
                currentFilePath = dlg.FileName;
            }
            else
            {
                // Đã có file -> lưu đè đúng định dạng
                if (Path.GetExtension(currentFilePath).ToLower() == ".rtf")
                    richText.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                else
                    richText.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);

                MessageBox.Show("Lưu văn bản thành công");
            }
        }

        // Thoát
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Menu Định dạng: mở FontDialog
        private void mnuFormat_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        // 2.5 Bật/tắt một kiểu chữ (B/I/U) cho vùng chọn
        private void ToggleStyle(FontStyle style)
        {
            if (richText.SelectionFont == null)
                return;

            Font f = richText.SelectionFont;
            // XOR: có thì bỏ, chưa có thì thêm, giữ nguyên các kiểu khác
            richText.SelectionFont = new Font(f, f.Style ^ style);
        }

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

        // Đổi font hoặc cỡ chữ cho vùng chọn, giữ kiểu chữ hiện tại
        private void cmbFontOrSize_Changed(object sender, EventArgs e)
        {
            if (cmbFonts.SelectedItem == null || cmbSize.SelectedItem == null)
                return;

            FontStyle style = FontStyle.Regular;
            if (richText.SelectionFont != null)
                style = richText.SelectionFont.Style;

            string name = cmbFonts.SelectedItem.ToString();
            float size = Convert.ToSingle(cmbSize.SelectedItem);
            richText.SelectionFont = new Font(name, size, style);
            richText.Focus();
        }

        // Đếm số từ
        private void richText_TextChanged(object sender, EventArgs e)
        {
            char[] separators = { ' ', '\n', '\r', '\t' };
            string[] words = richText.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            lblWordCount.Text = "Tổng số từ: " + words.Length;
        }
    }
}
