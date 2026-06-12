using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student
    {
        private string _name = "";
        public string Name { get; set; }
        private int _age = 0;
        public int Age { get; set; }
        private string _major = "";
        public string Major { get; set; }
        private int _studentID = 0;
        public int StudentID { get; set; }
        public Position Pos { get; set; }

        public Student(string name, int age, string major, int studentID, Position pos)
        {
            this.Name = name;
            this.Age = age;
            this.Major = major;
            this.StudentID = studentID;
            Pos = pos;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Major: {Major}");
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Position: ({Pos.x}, {Pos.y})");
        }

        public void MoveToPosition(Position newPosition)
        {
            Pos = newPosition;
            Console.WriteLine($"Student moved to new position: ({Pos.x}, {Pos.y})");
        }
    }
}
