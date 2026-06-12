using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Lecturer
    {
        private string _name = "";
        public string Name { get; set; }
        private int _age = 0;
        public int Age { get; set; }

        private int _lecturerID = 0;
        public int LecturerID { get; set; }
        public Position Pos { get; set; }

        public Lecturer(string name, int age, int lecturerID, Position pos)
        {
            this.Name = name;
            this.Age = age;
            this.LecturerID = lecturerID;
            Pos = pos;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Lecturer Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Lecturer ID: {LecturerID}");
            Console.WriteLine($"Position: ({Pos.x}, {Pos.y})");
        }

        public void MoveToPosition(Position newPosition)
        {
            Pos = newPosition;
            Console.WriteLine($"Lecturer moved to new position: ({Pos.x}, {Pos.y})");
        }
    }
}
