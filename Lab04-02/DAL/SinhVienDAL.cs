using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace DAL;

// Lớp DAL: chỉ làm việc với CSDL (đọc bảng sinhvien), không xử lý nghiệp vụ hay giao diện
public class SinhVienDAL
{
    // Lấy tất cả sinh viên, Include(sv => sv.Classes) nạp luôn các lớp học của từng sinh viên
    // qua bảng trung gian sinhvien_class (quan hệ n-n). Không có Include thì sv.Classes sẽ rỗng.
    public List<SinhVien> LayTatCa()
    {
        try
        {
            using (QLSinhVienContext db = new QLSinhVienContext())
            {
                return db.SinhViens
                    .Include(sv => sv.Classes)
                    .AsNoTracking()
                    .ToList();
            }
        }
        catch (MySqlException ex)
        {
            // Đổi lỗi riêng của MySQL thành lỗi chung, để BLL và GUI không phải biết đang dùng MySQL
            throw new InvalidOperationException("Không đọc được CSDL MySQL:\n" + ex.Message + GoiY(ex.Number), ex);
        }
    }

    // Gợi ý cách sửa cho mấy lỗi hay gặp khi chạy lần đầu
    private static string GoiY(int maLoi)
    {
        switch (maLoi)
        {
            case 1042: return "\n\nKiểm tra dịch vụ MySQL đã chạy chưa và Server/Port trong DAL\\KetNoi.cs.";
            case 1045: return "\n\nKiểm tra lại Uid/Pwd trong DAL\\KetNoi.cs.";
            case 1049:
            case 1146: return "\n\nChạy file qlsinhvien.sql trong MySQL Workbench để tạo CSDL.";
            default: return "";
        }
    }
}
