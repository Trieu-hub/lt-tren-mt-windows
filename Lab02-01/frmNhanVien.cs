namespace Lab02_01;

public partial class frmNhanVien : Form
{
    private readonly bool cheDoSua;
    private readonly List<string> dsMaNV;

    // Dữ liệu người dùng đã nhập, form chính lấy sau khi DialogResult == OK
    public NhanVien Result { get; private set; } = new NhanVien();

    // nv == null: chế độ Thêm; nv có giá trị: chế độ Sửa
    // dsMaNV: các MSNV đã tồn tại, dùng để kiểm tra trùng khi Thêm
    public frmNhanVien(NhanVien? nv, List<string> dsMaNV)
    {
        InitializeComponent();

        this.dsMaNV = dsMaNV;
        cheDoSua = nv != null;

        if (nv != null)
        {
            txtMSNV.Text = nv.MaNV;
            txtTenNV.Text = nv.TenNV;
            txtLuongCB.Text = nv.LuongCB.ToString();

            // MSNV là khóa nên không cho sửa, đặt con trỏ sẵn ở ô tên
            txtMSNV.ReadOnly = true;
            ActiveControl = txtTenNV;
        }
    }

    // Đồng ý: kiểm tra dữ liệu, hợp lệ mới đóng form với kết quả OK
    private void btnDongY_Click(object sender, EventArgs e)
    {
        string maNV = txtMSNV.Text.Trim();
        string tenNV = txtTenNV.Text.Trim();
        string luongText = txtLuongCB.Text.Trim();

        if (maNV == "")
        {
            BaoLoi("Vui lòng nhập MSNV", txtMSNV);
            return;
        }
        if (!cheDoSua && dsMaNV.Contains(maNV, StringComparer.OrdinalIgnoreCase))
        {
            BaoLoi($"MSNV {maNV} đã tồn tại", txtMSNV);
            return;
        }
        if (tenNV == "")
        {
            BaoLoi("Vui lòng nhập tên nhân viên", txtTenNV);
            return;
        }
        if (luongText == "")
        {
            BaoLoi("Vui lòng nhập lương căn bản", txtLuongCB);
            return;
        }
        if (!decimal.TryParse(luongText, out decimal luongCB) || luongCB <= 0)
        {
            BaoLoi("Lương căn bản phải là số lớn hơn 0", txtLuongCB);
            return;
        }

        Result = new NhanVien { MaNV = maNV, TenNV = tenNV, LuongCB = luongCB };
        DialogResult = DialogResult.OK;
    }

    // Bỏ qua: đóng form, form chính không thay đổi dữ liệu
    private void btnBoQua_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    // Báo lỗi và đưa con trỏ về ô nhập sai, form vẫn mở
    private void BaoLoi(string thongBao, TextBox oSai)
    {
        MessageBox.Show(this, thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        oSai.Focus();
        oSai.SelectAll();
    }
}
