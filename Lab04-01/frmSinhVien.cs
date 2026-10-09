using System.Data;
using MySql.Data.MySqlClient;

namespace LoadSinhVien;

public partial class frmSinhVien : Form
{
    public frmSinhVien()
    {
        InitializeComponent();

        // Chỉ dùng 4 cột đã khai báo trong Designer, không tự sinh cột
        dgvSinhVien.AutoGenerateColumns = false;

        HienThiDongDangChon();
    }

    // Mở form là nạp danh sách luôn. Dùng Shown thay vì Load vì lưới chỉ bỏ chọn được sau khi đã hiện ra
    private void frmSinhVien_Shown(object sender, EventArgs e)
    {
        try
        {
            NapLuoi(null);
        }
        catch (MySqlException ex)
        {
            BaoLoiCSDL(ex);
        }
    }

    // Load sinh viên: đọc lại bảng sinhvien từ MySQL
    private void btnLoad_Click(object sender, EventArgs e)
    {
        try
        {
            NapLuoi(null);
            lblThongBao.Text = "Đã load lại danh sách từ MySQL";
        }
        catch (MySqlException ex)
        {
            BaoLoiCSDL(ex);
        }
    }

    // Thêm: chỉ bấm được khi chưa chọn dòng nào, thêm xong chọn luôn dòng vừa thêm
    private void btnThem_Click(object sender, EventArgs e)
    {
        SinhVien? sv = DocONhap();
        if (sv == null)
        {
            return;
        }

        try
        {
            ThemSinhVien(sv);
            NapLuoi(sv.MaSV);
            lblThongBao.Text = $"Đã thêm sinh viên {sv.MaSV}";
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            // 1062: trùng khóa chính
            BaoNhapSai($"Mã SV {sv.MaSV} đã tồn tại", txtMaSV);
        }
        catch (MySqlException ex)
        {
            BaoLoiCSDL(ex);
        }
    }

    // Sửa: cập nhật sinh viên đang chọn theo dữ liệu trên các ô nhập
    private void btnSua_Click(object sender, EventArgs e)
    {
        SinhVien? sv = DocONhap();
        if (sv == null)
        {
            return;
        }

        try
        {
            int soDong = SuaSinhVien(sv);
            NapLuoi(sv.MaSV);
            lblThongBao.Text = soDong > 0 ? $"Đã sửa sinh viên {sv.MaSV}" : KhongConTrongCSDL(sv.MaSV);
        }
        catch (MySqlException ex)
        {
            BaoLoiCSDL(ex);
        }
    }

    // Xóa: hỏi xác nhận rồi mới xóa sinh viên đang chọn
    private void btnXoa_Click(object sender, EventArgs e)
    {
        DataRowView? dong = DongDangChon();
        if (dong == null)
        {
            return;
        }
        string maSV = (string)dong["MaSV"];

        DialogResult traLoi = MessageBox.Show(this,
            $"Bạn có chắc muốn xóa sinh viên {maSV} - {dong["HoTen"]}?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (traLoi != DialogResult.Yes)
        {
            return;
        }

        try
        {
            int soDong = XoaSinhVien(maSV);
            NapLuoi(null);
            lblThongBao.Text = soDong > 0 ? $"Đã xóa sinh viên {maSV}" : KhongConTrongCSDL(maSV);
        }
        catch (MySqlException ex)
        {
            BaoLoiCSDL(ex);
        }
    }

    // Nhập mới: bỏ chọn dòng trên lưới, xóa trắng các ô nhập để gõ sinh viên mới
    private void btnNhapMoi_Click(object sender, EventArgs e)
    {
        dgvSinhVien.ClearSelection();
        HienThiDongDangChon();
        txtMaSV.Focus();
    }

    private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
    {
        HienThiDongDangChon();
    }

    // Nạp lại lưới từ CSDL. maSVCanChon: mã của dòng cần chọn sau khi nạp, null thì không chọn dòng nào
    private void NapLuoi(string? maSVCanChon)
    {
        dgvSinhVien.DataSource = LaySinhVien();
        lblTongSo.Text = $"Tổng số: {dgvSinhVien.Rows.Count} sinh viên";

        dgvSinhVien.ClearSelection();
        foreach (DataGridViewRow row in dgvSinhVien.Rows)
        {
            if (string.Equals(Convert.ToString(row.Cells[0].Value), maSVCanChon, StringComparison.OrdinalIgnoreCase))
            {
                dgvSinhVien.CurrentCell = row.Cells[0];
                row.Selected = true;
                break;
            }
        }
    }

    private DataRowView? DongDangChon()
    {
        if (dgvSinhVien.SelectedRows.Count == 0)
        {
            return null;
        }
        return dgvSinhVien.SelectedRows[0].DataBoundItem as DataRowView;
    }

    // Đang chọn một dòng: đưa dữ liệu dòng đó lên các ô nhập để Sửa/Xóa.
    // Không chọn dòng nào: các ô nhập để trống, chờ Thêm sinh viên mới.
    private void HienThiDongDangChon()
    {
        DataRowView? dong = DongDangChon();
        if (dong != null)
        {
            txtMaSV.Text = (string)dong["MaSV"];
            txtHoTen.Text = (string)dong["HoTen"];
            txtLop.Text = (string)dong["Lop"];
            // Điểm sửa tay trong CSDL có thể nằm ngoài 0-10, ép về khoảng ô nhập cho phép
            nudDiem.Value = (decimal)Math.Clamp(Convert.ToDouble(dong["Diem"]), 0, 10);
        }
        else
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtLop.Clear();
            nudDiem.Value = 0;
        }

        // Mã SV là khóa nên không cho sửa khi đang chọn một sinh viên có sẵn
        bool dangChon = dong != null;
        txtMaSV.ReadOnly = dangChon;
        btnThem.Enabled = !dangChon;
        btnSua.Enabled = dangChon;
        btnXoa.Enabled = dangChon;
        grpThongTin.Text = dangChon
            ? $"Thông tin sinh viên (đang chọn {txtMaSV.Text})"
            : "Thông tin sinh viên (nhập mới)";
    }

    // Lấy dữ liệu từ các ô nhập; ô nào bỏ trống thì báo, đưa con trỏ về ô đó và trả về null
    private SinhVien? DocONhap()
    {
        string maSV = txtMaSV.Text.Trim();
        string hoTen = txtHoTen.Text.Trim();
        string lop = txtLop.Text.Trim();

        if (maSV == "")
        {
            BaoNhapSai("Vui lòng nhập Mã SV", txtMaSV);
            return null;
        }
        if (hoTen == "")
        {
            BaoNhapSai("Vui lòng nhập họ tên", txtHoTen);
            return null;
        }
        if (lop == "")
        {
            BaoNhapSai("Vui lòng nhập lớp", txtLop);
            return null;
        }

        // Ô điểm chỉ hiện 1 số lẻ (gõ 6.25 sẽ hiện 6.3) nên làm tròn y như vậy để lưu đúng số đang hiện
        double diem = (double)Math.Round(nudDiem.Value, nudDiem.DecimalPlaces, MidpointRounding.AwayFromZero);
        return new SinhVien { MaSV = maSV, HoTen = hoTen, Lop = lop, Diem = diem };
    }

    // ===== Bốn method CRUD trên bảng sinhvien =====

    // Read: DataAdapter tự mở kết nối, chạy câu SELECT, đổ kết quả vào DataTable rồi đóng kết nối
    private DataTable LaySinhVien()
    {
        using (MySqlConnection conn = new MySqlConnection(KetNoi.ChuoiKetNoi))
        using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT MaSV, HoTen, Lop, Diem FROM sinhvien ORDER BY MaSV", conn))
        {
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    // Create: trả về số dòng đã thêm
    private int ThemSinhVien(SinhVien sv)
    {
        return ChayLenh("INSERT INTO sinhvien (MaSV, HoTen, Lop, Diem) VALUES (@MaSV, @HoTen, @Lop, @Diem)",
            new MySqlParameter("@MaSV", sv.MaSV),
            new MySqlParameter("@HoTen", sv.HoTen),
            new MySqlParameter("@Lop", sv.Lop),
            new MySqlParameter("@Diem", sv.Diem));
    }

    // Update: sửa theo khóa MaSV, trả về 0 nếu mã đó không còn trong bảng
    private int SuaSinhVien(SinhVien sv)
    {
        return ChayLenh("UPDATE sinhvien SET HoTen = @HoTen, Lop = @Lop, Diem = @Diem WHERE MaSV = @MaSV",
            new MySqlParameter("@HoTen", sv.HoTen),
            new MySqlParameter("@Lop", sv.Lop),
            new MySqlParameter("@Diem", sv.Diem),
            new MySqlParameter("@MaSV", sv.MaSV));
    }

    // Delete: xóa theo khóa MaSV, trả về 0 nếu mã đó không còn trong bảng
    private int XoaSinhVien(string maSV)
    {
        return ChayLenh("DELETE FROM sinhvien WHERE MaSV = @MaSV",
            new MySqlParameter("@MaSV", maSV));
    }

    // Chạy một câu INSERT/UPDATE/DELETE, trả về số dòng bị tác động.
    // Giá trị luôn truyền qua tham số @..., không nối chuỗi vào câu SQL.
    private int ChayLenh(string sql, params MySqlParameter[] thamSo)
    {
        using (MySqlConnection conn = new MySqlConnection(KetNoi.ChuoiKetNoi))
        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
        {
            cmd.Parameters.AddRange(thamSo);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }

    // ===== Thông báo =====

    // Báo lỗi nhập và đưa con trỏ về ô nhập sai
    private void BaoNhapSai(string thongBao, TextBox oSai)
    {
        MessageBox.Show(this, thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        oSai.Focus();
        oSai.SelectAll();
    }

    private void BaoLoiCSDL(MySqlException ex)
    {
        MessageBox.Show(this, "Không làm việc được với MySQL:\n" + ex.Message + GoiY(ex.Number), "Lỗi",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    // Sửa/Xóa không trúng dòng nào: sinh viên đã bị xóa ở nơi khác (ví dụ trong Workbench)
    private static string KhongConTrongCSDL(string maSV)
    {
        return $"Sinh viên {maSV} không còn trong CSDL, đã load lại danh sách";
    }

    // Gợi ý cách sửa cho mấy lỗi hay gặp khi chạy lần đầu
    private static string GoiY(int maLoi)
    {
        switch (maLoi)
        {
            case 1042: return "\n\nKiểm tra dịch vụ MySQL đã chạy chưa và Server/Port trong KetNoi.cs.";
            case 1045: return "\n\nKiểm tra lại Uid/Pwd trong KetNoi.cs.";
            case 1049:
            case 1146: return "\n\nChạy file qlsinhvien.sql trong MySQL Workbench để tạo CSDL.";
            default: return "";
        }
    }
}
