using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class FormAddStudent : Form
    {
        // Danh sách sinh viên đã có của FormMain, dùng để kiểm tra trùng mã số
        private List<Student> existingStudents;

        // Sinh viên vừa nhập. FormMain đọc property này khi form đóng với DialogResult.OK
        public Student NewStudent { get; private set; }

        public FormAddStudent(List<Student> existingStudents)
        {
            InitializeComponent();
            this.existingStudents = existingStudents;
            cmbFaculty.SelectedIndex = 0;   // chọn sẵn khoa đầu tiên
        }

        // Nút Thêm Mới: dữ liệu hợp lệ thì tạo NewStudent và đóng form với kết quả OK
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double score;
            if (!IsInputValid(out score))
                return;

            NewStudent = new Student();
            NewStudent.StudentId = txtStudentId.Text.Trim();
            NewStudent.FullName = txtFullName.Text.Trim();
            NewStudent.Faculty = cmbFaculty.Text;
            NewStudent.AverageScore = score;

            this.DialogResult = DialogResult.OK;   // gán DialogResult thì form tự đóng
        }

        // Nút Thoát: đóng form, không thêm sinh viên
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Kiểm tra lần lượt từng điều kiện, sai ở đâu báo lỗi ở đó.
        // Hợp lệ thì trả về true và điểm đã đổi sang số nằm trong score
        private bool IsInputValid(out double score)
        {
            score = 0;

            // 1. Không được để trống
            if (txtStudentId.Text.Trim() == "")
                return ShowError("Vui lòng nhập Mã Số SV.", txtStudentId);
            if (txtFullName.Text.Trim() == "")
                return ShowError("Vui lòng nhập Tên Sinh Viên.", txtFullName);
            if (txtAverageScore.Text.Trim() == "")
                return ShowError("Vui lòng nhập Điểm TB.", txtAverageScore);

            // 2. Mã số không được trùng với sinh viên đã có
            if (IsDuplicateId(txtStudentId.Text.Trim()))
                return ShowError("Mã Số SV này đã tồn tại.", txtStudentId);

            // 3. Điểm phải là số trong khoảng 0 - 10
            if (!TryParseScore(txtAverageScore.Text, out score))
                return ShowError("Điểm TB phải là số, ví dụ 8.5 hoặc 8,5.", txtAverageScore);

            bool inRange = score >= 0 && score <= 10;
            if (!inRange)
                return ShowError("Điểm TB phải nằm trong khoảng từ 0 đến 10.", txtAverageScore);

            return true;
        }

        // Tìm trong danh sách đã có xem mã số bị trùng chưa (không phân biệt hoa thường)
        private bool IsDuplicateId(string studentId)
        {
            foreach (Student student in existingStudents)
            {
                if (string.Equals(student.StudentId, studentId, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        // Đổi chuỗi điểm sang số. Máy tiếng Việt gõ dấu phẩy thập phân
        // nên thay ',' bằng '.' rồi đọc theo InvariantCulture
        private bool TryParseScore(string text, out double score)
        {
            text = text.Trim().Replace(',', '.');
            return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out score);
        }

        // Báo lỗi, đưa con trỏ về ô nhập bị sai. Luôn trả về false để dùng trực tiếp trong IsInputValid
        private bool ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            return false;
        }
    }
}
