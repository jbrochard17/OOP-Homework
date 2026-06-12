using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Speaker
    {
        // Fields
        private string _color = "";
        public string Color { get; set; }
        private bool _isOn = false;
        public bool IsOn { get; set; }
        public Position Pos { get; set; }



        // Constructor
        public Speaker(string color, bool on, Position position)
        {
            this.Color = color;
            this.IsOn = on;
            this.Pos = position;
        }

        // Method to display TV information
        public void DisplayInfo()
        {
            Console.WriteLine($"Speaker Color: {Color}");
            Console.WriteLine($"Speaker is on: {IsOn}");
            Console.WriteLine($"Position: ({Pos.x}, {Pos.y})");
        }
        public void MoveToPosition(Position newPosition)
        {
            Pos = newPosition;
            Console.WriteLine($"Speaker moved to new position: ({Pos.x}, {Pos.y})");
        }

        public void MoveLeft()
        {
            Pos.x -= 1;
        }
        public void MoveRight()
        {
            Pos.x += 1;
        }
        public void TogglePower()
        {
            IsOn = !IsOn;
            Console.WriteLine($"Speaker is now {(IsOn ? "On" : "Off")}");
        }
    }
}
