using System.Text;

namespace Lab01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị và nhập được tiếng Việt có dấu
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Nhập danh sách ít nhất 5 học sinh từ bàn phím
            List<Student> studentList = new List<Student>();

            Console.Write("Nhập số lượng học sinh (ít nhất 5): ");
            int n = int.Parse(Console.ReadLine());
            while (n < 5)
            {
                Console.Write("Phải có ít nhất 5 học sinh, nhập lại: ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n=== Nhập thông tin học sinh thứ {0} ===", i + 1);
                Student student = new Student();
                student.Input();
                studentList.Add(student);
            }
            Console.WriteLine();

            // a. In toàn bộ danh sách học sinh
            Console.WriteLine("=== a. Danh sách toàn bộ học sinh ===");
            DisplayStudentList(studentList);

            // b. Học sinh có tuổi từ 15 đến 18
            Console.WriteLine("\n=== b. Học sinh có tuổi từ 15 đến 18 ===");
            var studentsAge15To18 = studentList.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            DisplayStudentList(studentsAge15To18);

            // c. Học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\n=== c. Học sinh có tên bắt đầu bằng chữ \"A\" ===");
            var studentsNameA = studentList.Where(s => s.Name.StartsWith("A")).ToList();
            DisplayStudentList(studentsNameA);

            // d. Tổng tuổi của tất cả học sinh
            Console.WriteLine("\n=== d. Tổng tuổi của tất cả học sinh ===");
            int totalAge = studentList.Sum(s => s.Age);
            Console.WriteLine("Tổng tuổi: {0}", totalAge);

            // e. Học sinh có tuổi lớn nhất
            Console.WriteLine("\n=== e. Học sinh có tuổi lớn nhất ===");
            int maxAge = studentList.Max(s => s.Age);
            var oldestStudents = studentList.Where(s => s.Age == maxAge).ToList();
            DisplayStudentList(oldestStudents);

            // f. Sắp xếp danh sách theo tuổi tăng dần
            Console.WriteLine("\n=== f. Danh sách học sinh sắp xếp theo tuổi tăng dần ===");
            var sortedStudents = studentList.OrderBy(s => s.Age).ToList();
            DisplayStudentList(sortedStudents);
        }

        static void DisplayStudentList(List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                student.Show();
            }
        }
    }
}
