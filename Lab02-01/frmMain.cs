using System.ComponentModel;

namespace Lab02_01;

public partial class frmMain : Form
{
    // Dữ liệu lưu trong bộ nhớ; BindingList tự báo cho lưới khi thêm/sửa/xóa
    private readonly BindingList<NhanVien> dsNhanVien = new BindingList<NhanVien>();

    public frmMain()
    {
        InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        dsNhanVien.Add(new NhanVien { MaNV = "NV001", TenNV = "Nguyễn Thị Thu Hiền", LuongCB = 8500000 });

        // Chỉ dùng 3 cột đã khai báo trong Designer, không tự sinh cột
        dgvNhanVien.AutoGenerateColumns = false;
        dgvNhanVien.DataSource = dsNhanVien;
    }

    // Thêm: mở form Nhân viên rỗng, đồng ý thì thêm vào danh sách và chọn dòng vừa thêm
    private void btnThem_Click(object sender, EventArgs e)
    {
        using (frmNhanVien frm = new frmNhanVien(null, LayDanhSachMaNV()))
        {
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                dsNhanVien.Add(frm.Result);
                ChonDong(dsNhanVien.Count - 1);
            }
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        SuaNhanVien();
    }

    // Double-click một dòng dữ liệu cũng là Sửa (bỏ qua dòng tiêu đề)
    private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            SuaNhanVien();
        }
    }

    // Xóa: hỏi xác nhận rồi mới xóa dòng đang chọn
    private void btnXoa_Click(object sender, EventArgs e)
    {
        int index = LayDongDangChon();
        if (index < 0)
        {
            MessageBox.Show(this, "Vui lòng chọn nhân viên cần xóa", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DialogResult traLoi = MessageBox.Show(this,
            $"Bạn có chắc muốn xóa nhân viên {dsNhanVien[index].MaNV}?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (traLoi == DialogResult.Yes)
        {
            dsNhanVien.RemoveAt(index);
        }
    }

    private void btnDong_Click(object sender, EventArgs e)
    {
        Close();
    }

    // Sửa: mở form Nhân viên với dữ liệu dòng đang chọn, đồng ý thì cập nhật lại dòng đó
    private void SuaNhanVien()
    {
        int index = LayDongDangChon();
        if (index < 0)
        {
            MessageBox.Show(this, "Vui lòng chọn nhân viên cần sửa", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using (frmNhanVien frm = new frmNhanVien(dsNhanVien[index], LayDanhSachMaNV()))
        {
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // Gán lại phần tử để BindingList báo lưới vẽ lại dòng này
                dsNhanVien[index] = frm.Result;
                ChonDong(index);
            }
        }
    }

    // Vị trí dòng đang chọn trên lưới, -1 nếu chưa chọn dòng nào
    private int LayDongDangChon()
    {
        if (dgvNhanVien.SelectedRows.Count == 0)
        {
            return -1;
        }
        return dgvNhanVien.SelectedRows[0].Index;
    }

    private List<string> LayDanhSachMaNV()
    {
        return dsNhanVien.Select(nv => nv.MaNV).ToList();
    }

    private void ChonDong(int index)
    {
        dgvNhanVien.CurrentCell = dgvNhanVien.Rows[index].Cells[0];
        dgvNhanVien.Rows[index].Selected = true;
    }
}
