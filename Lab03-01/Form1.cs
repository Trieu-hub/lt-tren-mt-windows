using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi form vừa mở: hiện ngày giờ ngay, không phải chờ timer chạy hết 1 giây đầu
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateClock();
        }

        // Mỗi giây cập nhật lại ngày giờ trên thanh trạng thái
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        // Hiển thị ngày giờ hiện tại lên thanh trạng thái.
        // Dùng InvariantCulture để luôn hiện AM/PM (máy tiếng Việt sẽ hiện SA/CH)
        private void UpdateClock()
        {
            DateTime now = DateTime.Now;
            string date = now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            string time = now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
            toolStripStatusLabel1.Text = "Hôm nay là ngày " + date + " - Bây giờ là " + time;
        }

        // File > Open: chọn file media rồi phát bằng Windows Media Player
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Media files|*.avi;*.mpeg;*.mpg;*.wav;*.mid;*.midi;*.mp4;*.mp3|All files|*.*";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                // TODO: sau khi kéo Windows Media Player vào Form1, bỏ dấu // ở dòng dưới
                // axWindowsMediaPlayer1.URL = dlg.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được tập tin:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // File > Exit: thoát chương trình
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
