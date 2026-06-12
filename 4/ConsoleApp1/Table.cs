using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Table
    {
        // Fields
        private string _material="";
        public string Material { get; set; }
        private string _color="";
        public string Color { get; set; }
        private int _numberOfLegs=0;
        public int NumberOfLegs { get; set; }
        public Position Pos { get; set; }



        // Constructor
        public Table(string material, string color, int numberOfLegs, Position position)
        {
            this.Material = material;
            this.Color = color;
            this.NumberOfLegs = numberOfLegs;
            this.Pos = position;
        }

        // Method to display chair information
        public void DisplayInfo()
        {
            Console.WriteLine($"Table Material: {_material}");
            Console.WriteLine($"Table Color: {_color}");
            Console.WriteLine($"Number of Legs: {_numberOfLegs}");
            Console.WriteLine($"Position: ({Pos.x}, {Pos.y})");
        }
        public void MoveToPosition(Position newPosition)
        {
            Pos = newPosition;
            Console.WriteLine($"Table moved to new position: ({Pos.x}, {Pos.y})");
        }

        public void MoveLeft()
        {
            Pos.x -= 1;
        }
        public void MoveRight()
        {
            Pos.x += 1;
        }
    }
}
