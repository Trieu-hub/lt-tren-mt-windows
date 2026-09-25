namespace BaiTapListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Nhấn btnThem -> thêm 1 dòng mới vào lvSinhVien
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap())
            {
                return;
            }

            // Cột đầu tiên là Text của item, các cột sau là SubItems
            ListViewItem item = new ListViewItem(txtLastName.Text.Trim());
            item.SubItems.Add(txtFirstName.Text.Trim());
            item.SubItems.Add(txtPhone.Text.Trim());
            lvSinhVien.Items.Add(item);

            LamMoi();
        }

        // Nhấn btnXoa -> hỏi xác nhận, Yes thì xoá dòng đang chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
                LamMoi();
            }
        }

        // Nhấn btnSua -> cập nhật dòng đang chọn bằng nội dung các TextBox
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!KiemTraNhap())
            {
                return;
            }

            ListViewItem item = lvSinhVien.SelectedItems[0];
            item.Text = txtLastName.Text.Trim();
            item.SubItems[1].Text = txtFirstName.Text.Trim();
            item.SubItems[2].Text = txtPhone.Text.Trim();

            LamMoi();
        }

        // Chọn 1 dòng trên ListView -> đổ dữ liệu lên các TextBox
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem item = lvSinhVien.SelectedItems[0];
            txtLastName.Text = item.Text;
            txtFirstName.Text = item.SubItems[1].Text;
            txtPhone.Text = item.SubItems[2].Text;
        }

        // Kiểm tra không được để trống thông tin
        private bool KiemTraNhap()
        {
            if (txtLastName.Text.Trim() == "" || txtFirstName.Text.Trim() == "" || txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Last Name, First Name và Phone!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Xoá trắng các TextBox, bỏ chọn trên ListView
        private void LamMoi()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();
            lvSinhVien.SelectedItems.Clear();
            txtLastName.Focus();
        }
    }
}
