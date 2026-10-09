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
