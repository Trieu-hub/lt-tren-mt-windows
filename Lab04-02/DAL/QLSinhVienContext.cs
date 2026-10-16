using Microsoft.EntityFrameworkCore;

namespace DAL;

// DbContext của Entity Framework Core, ánh xạ các class C# vào các bảng trong CSDL qlsinhvien
public class QLSinhVienContext : DbContext
{
    public DbSet<SinhVien> SinhViens => Set<SinhVien>();
    public DbSet<Class> Classes => Set<Class>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(KetNoi.ChuoiKetNoi);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SinhVien>(sv =>
        {
            sv.ToTable("sinhvien");
            sv.HasKey(x => x.MaSV);
        });

        modelBuilder.Entity<Class>(c =>
        {
            c.ToTable("class");
            c.HasKey(x => x.Id);
        });

        // Quan hệ n-n: SinhVien.Classes <-> Class.SinhViens qua bảng trung gian sinhvien_class(MaSV, ClassId).
        // Bảng trung gian không cần class C# riêng, EF tự quản lý.
        modelBuilder.Entity<SinhVien>()
            .HasMany(sv => sv.Classes)
            .WithMany(c => c.SinhViens)
            .UsingEntity<Dictionary<string, object>>(
                "sinhvien_class",
                phai => phai.HasOne<Class>().WithMany().HasForeignKey("ClassId"),
                trai => trai.HasOne<SinhVien>().WithMany().HasForeignKey("MaSV"),
                bang =>
                {
                    bang.ToTable("sinhvien_class");
                    bang.HasKey("MaSV", "ClassId");
                });
    }
}
