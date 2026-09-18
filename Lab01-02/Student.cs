using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_02
{
    internal class Student
    {
        private string Id;
        private string Name;
        private int Age;

        // Properties
        public string Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int Age1 { get => Age; set => Age = value; }

        // Constructor
        public Student()
        {
            Id = "";
            Name = "";
            Age = 0;
        }
        public Student(string Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        // Method
        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            Id = Console.ReadLine();
            Console.Write("Nhap ho va ten SV: ");
            Name = Console.ReadLine();
            Console.Write("Nhap tuoi SV: ");
            Age = int.Parse(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("MSSV:{0} Ho Ten:{1} Tuoi:{2}", this.Id, this.Name, this.Age);
        }

    }
}