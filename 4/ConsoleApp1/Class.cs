using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class
    {
        private Lecturer _lecturer;
        public Lecturer TheLecturer { get; set; }
        private Students _students;
        public Students TheStudents { get; set; }

        public Class(Lecturer lecturer, Students students)
        {
            this.TheLecturer = lecturer;
            this.TheStudents = students;
        }
    }
}
