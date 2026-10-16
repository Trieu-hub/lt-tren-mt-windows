-- Tạo CSDL qlsinhvien, bảng sinhvien và dữ liệu mẫu cho form "Load sinh viên".
-- Chạy file này một lần trong MySQL Workbench (File > Open SQL Script, rồi bấm nút tia sét).
-- Chạy lại nhiều lần cũng không sao: không xóa gì, dòng trùng mã sẽ được bỏ qua.
SET NAMES utf8mb4;

CREATE DATABASE IF NOT EXISTS qlsinhvien CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE qlsinhvien;

CREATE TABLE IF NOT EXISTS sinhvien (
    MaSV  VARCHAR(10)  NOT NULL PRIMARY KEY,
    HoTen VARCHAR(100) NOT NULL,
    Lop   VARCHAR(20)  NOT NULL,
    Diem  DOUBLE       NOT NULL
);

INSERT IGNORE INTO sinhvien (MaSV, HoTen, Lop, Diem) VALUES
    ('SV001', 'Nguyễn Văn An',   'CNTT1', 8.5),
    ('SV002', 'Trần Thị Bình',   'CNTT1', 7.0),
    ('SV003', 'Lê Hoàng Cường',  'CNTT2', 9.0),
    ('SV004', 'Phạm Thu Dung',   'CNTT2', 6.5),
    ('SV005', 'Võ Minh Đức',     'CNTT3', 7.5),
    ('SV006', 'Đặng Ngọc Hạnh',  'CNTT3', 8.0);

-- ===== Lớp học (Class) và quan hệ n-n với sinh viên =====
-- Một sinh viên học nhiều lớp, một lớp có nhiều sinh viên -> cần bảng trung gian sinhvien_class.
CREATE TABLE IF NOT EXISTS `class` (
    Id   INT          NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Khoa VARCHAR(100) NOT NULL
);

-- ON DELETE CASCADE: xóa sinh viên (hoặc lớp) thì các dòng ghi danh của nó tự xóa theo
CREATE TABLE IF NOT EXISTS sinhvien_class (
    MaSV    VARCHAR(10) NOT NULL,
    ClassId INT         NOT NULL,
    PRIMARY KEY (MaSV, ClassId),
    FOREIGN KEY (MaSV)    REFERENCES sinhvien(MaSV) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (ClassId) REFERENCES `class`(Id)    ON DELETE CASCADE
);

INSERT IGNORE INTO `class` (Id, Name, Khoa) VALUES
    (1, 'Lập trình Windows',  'Công nghệ thông tin'),
    (2, 'Cơ sở dữ liệu',      'Công nghệ thông tin'),
    (3, 'Toán rời rạc',       'Khoa học cơ bản'),
    (4, 'Tiếng Anh chuyên ngành', 'Ngoại ngữ');

INSERT IGNORE INTO sinhvien_class (MaSV, ClassId) VALUES
    ('SV001', 1), ('SV001', 2), ('SV001', 4),
    ('SV002', 1), ('SV002', 3),
    ('SV003', 2), ('SV003', 3),
    ('SV004', 1),
    ('SV005', 2), ('SV005', 4),
    ('SV006', 3), ('SV006', 4);
