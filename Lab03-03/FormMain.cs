using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class FormMain : Form
    {
        // Danh sách sinh viên. DataGridView chỉ dùng để hiển thị danh sách này
        private List<Student> students = new List<Student>();

        public FormMain()
        {
            InitializeComponent();
        }

        // Nạp lại lưới: chỉ hiện sinh viên có tên chứa nội dung ô tìm kiếm (không phân biệt hoa thường),
        // số thứ tự đánh lại từ 1 theo các dòng đang hiển thị
        private void LoadGrid()
        {
            string keyword = txtSearch.Text;
            int index = 1;

            dgvStudents.Rows.Clear();
            foreach (Student student in students)
            {
                if (student.FullName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    dgvStudents.Rows.Add(index, student.StudentId, student.FullName,
                        student.Faculty, student.AverageScore);
                    index++;
                }
            }
        }

        // Gõ vào ô tìm kiếm thì lọc lại lưới ngay
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        // Chức Năng > Thêm mới
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        // Nút Thêm Mới trên thanh công cụ
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        // Mở FormAddStudent, truyền danh sách hiện có để form kiểm tra trùng mã số.
        // Form trả về OK thì lấy sinh viên mới thêm vào danh sách rồi nạp lại lưới
        private void AddStudent()
        {
            FormAddStudent form = new FormAddStudent(students);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                students.Add(form.NewStudent);
                LoadGrid();
            }
        }

        // Chức Năng > Thoát: thoát chương trình
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
