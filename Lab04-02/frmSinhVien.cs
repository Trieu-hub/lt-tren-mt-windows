using BLL;

namespace LoadSinhVien;

// Lớp GUI: chỉ hiển thị. Không có câu SQL hay DbContext ở đây, mọi dữ liệu đều lấy qua SinhVienBLL
public partial class frmSinhVien : Form
{
    private readonly SinhVienBLL bll = new SinhVienBLL();

    public frmSinhVien()
    {
        InitializeComponent();

        // Chỉ dùng các cột đã khai báo trong Designer, không tự sinh cột
        dgvSinhVien.AutoGenerateColumns = false;
    }

    // Mở form là nạp danh sách luôn
    private void frmSinhVien_Shown(object sender, EventArgs e)
    {
        NapLuoi();
    }

    // Load sinh viên: đọc lại danh sách
    private void btnLoad_Click(object sender, EventArgs e)
    {
        if (NapLuoi())
        {
            lblThongBao.Text = "Đã load lại danh sách từ MySQL";
        }
    }

    // Rê chuột vào ô lớp học: hiện từng lớp kèm khoa
    private void dgvSinhVien_CellToolTipTextNeeded(object? sender, DataGridViewCellToolTipTextNeededEventArgs e)
    {
        if (e.ColumnIndex == colLopHoc.Index && e.RowIndex >= 0
            && dgvSinhVien.Rows[e.RowIndex].DataBoundItem is SinhVienHienThi sv)
        {
            e.ToolTipText = sv.LopHocChiTiet;
        }
    }

    // Gán danh sách từ BLL vào lưới, trả về false nếu không đọc được CSDL
    private bool NapLuoi()
    {
        try
        {
            dgvSinhVien.DataSource = bll.LayDanhSach();
            dgvSinhVien.ClearSelection();
            lblTongSo.Text = $"Tổng số: {dgvSinhVien.Rows.Count} sinh viên";
            return true;
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
