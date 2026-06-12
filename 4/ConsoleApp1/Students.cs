using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Students
    {
        // Fields
        // dynamic array to hold multiple Student objects
        private List<Student> StudentList;

        // Constructor
        public Students()
        {
            StudentList = new List<Student>();
        }
        // Method to add a Student to the list
        public void AddStudent(Student student)
        {
            StudentList.Add(student);
        }
        // Method to remove a Student from the list
        public void RemoveStudent(Student student)
        {
            StudentList.Remove(student);
        }
        // Method to display information of all Students
        public void DisplayAllStudents()
        {
            foreach (var student in StudentList)
            {
                student.DisplayInfo();
                Console.WriteLine(); // Add a blank line for better readability
            }
        }
    }
}
