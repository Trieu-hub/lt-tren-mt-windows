namespace BLL;

// Một dòng sinh viên đã xử lý sẵn để GUI chỉ việc gán vào lưới
public class SinhVienHienThi
{
    public string MaSV { get; set; } = "";
    public string HoTen { get; set; } = "";
    public string Lop { get; set; } = "";
    public double Diem { get; set; }

    // Tên các lớp học (Class) của sinh viên, cách nhau dấu phẩy
    public string LopHoc { get; set; } = "";

    // Từng lớp học kèm khoa, mỗi lớp một dòng (dùng làm tooltip)
    public string LopHocChiTiet { get; set; } = "";
}
