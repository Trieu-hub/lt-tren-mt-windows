namespace DAL;

public class SinhVien
{
    public string MaSV { get; set; } = "";
    public string HoTen { get; set; } = "";
    public string Lop { get; set; } = "";
    public double Diem { get; set; }

    // Navigation sang phía lớp học của quan hệ n-n, chỉ có dữ liệu khi truy vấn có Include(sv => sv.Classes)
    public ICollection<Class> Classes { get; set; } = new List<Class>();
}
