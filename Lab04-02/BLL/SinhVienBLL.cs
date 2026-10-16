using DAL;

namespace BLL;

// Lớp BLL: nhận dữ liệu thô từ DAL, xử lý nghiệp vụ (sắp xếp, ghép danh sách lớp học) rồi trả cho GUI
public class SinhVienBLL
{
    private readonly SinhVienDAL dal = new SinhVienDAL();

    public List<SinhVienHienThi> LayDanhSach()
    {
        return dal.LayTatCa()
            .OrderBy(sv => sv.MaSV)
            .Select(sv =>
            {
                List<Class> lopHoc = sv.Classes.OrderBy(c => c.Name).ToList();
                return new SinhVienHienThi
                {
                    MaSV = sv.MaSV,
                    HoTen = sv.HoTen,
                    Lop = sv.Lop,
                    Diem = sv.Diem,
                    LopHoc = string.Join(", ", lopHoc.Select(c => c.Name)),
                    LopHocChiTiet = string.Join(Environment.NewLine, lopHoc.Select(c => $"{c.Name} - Khoa {c.Khoa}"))
                };
            })
            .ToList();
    }
}
