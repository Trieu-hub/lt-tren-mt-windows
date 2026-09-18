using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("========== MENU ==========");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Tim sinh vien tu 15 den 18 tuoi");
                Console.WriteLine("4. Tim sinh vien co ten bat dau bang A");
                Console.WriteLine("5. Tinh tong tuoi sinh vien");
                Console.WriteLine("6. Tim sinh vien co tuoi lon nhat");
                Console.WriteLine("7. Sap xep sinh vien theo tuoi tang dan");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang (0-7): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);
                        break;

                    case "2":
                        ShowStudentList(studentList);
                        break;

                    case "3":
                        FindStudentAge15To18(studentList);
                        break;

                    case "4":
                        FindStudentNameA(studentList);
                        break;

                    case "5":
                        SumAge(studentList);
                        break;

                    case "6":
                        FindOldestStudent(studentList);
                        break;

                    case "7":
                        SortStudentByAge(studentList);
                        break;

                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Tuy chon khong hop le. Vui long chon lai.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // 1. Them sinh vien
        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("Nhap thong tin sinh vien:");

            Student student = new Student();

            student.Input();

            studentList.Add(student);

            Console.WriteLine("Them sinh vien thanh cong!");
        }

        // 2. Hien thi danh sach
        static void ShowStudentList(List<Student> studentList)
        {
            Console.WriteLine("Danh sach sinh vien:");

            foreach (Student student in studentList)
            {
                student.show();
            }
        }

        // 3. Tim sinh vien tu 15 den 18 tuoi
        static void FindStudentAge15To18(List<Student> studentList)
        {
            Console.WriteLine("Sinh vien tu 15 den 18 tuoi:");

            var result = studentList
                .Where(student => student.Age1 >= 15 && student.Age1 <= 18);

            foreach (Student student in result)
            {
                student.show();
            }
        }

        // 4. Tim sinh vien co ten bat dau bang A
        static void FindStudentNameA(List<Student> studentList)
        {
            Console.WriteLine("Sinh vien co ten bat dau bang A:");

            var result = studentList
                .Where(student => student.Name1.StartsWith("A"));

            foreach (Student student in result)
            {
                student.show();
            }
        }

        // 5. Tinh tong tuoi
        static void SumAge(List<Student> studentList)
        {
            Console.WriteLine("Tong tuoi cua tat ca sinh vien:");

            int sum = studentList.Sum(student => student.Age1);

            Console.WriteLine("Tong tuoi = " + sum);
        }

        // 6. Tim sinh vien co tuoi lon nhat
        static void FindOldestStudent(List<Student> studentList)
        {
            Console.WriteLine("Sinh vien co tuoi lon nhat:");

            int maxAge = studentList.Max(student => student.Age1);

            var result = studentList
                .Where(student => student.Age1 == maxAge);

            foreach (Student student in result)
            {
                student.show();
            }
        }

        // 7. Sap xep tuoi tang dan
        static void SortStudentByAge(List<Student> studentList)
        {
            Console.WriteLine("Danh sach sinh vien sap xep tuoi tang dan:");

            var result = studentList
                .OrderBy(student => student.Age1);

            foreach (Student student in result)
            {
                student.show();
            }
        }
    }
}