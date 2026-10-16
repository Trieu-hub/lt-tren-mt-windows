namespace DAL;

// Lớp học: một lớp có nhiều sinh viên, một sinh viên học nhiều lớp (quan hệ n-n)
public class Class
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Khoa { get; set; } = "";

    // Navigation sang phía sinh viên của quan hệ n-n
    public ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
