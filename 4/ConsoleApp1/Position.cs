using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Position
    {
        private int _x;
        public int x { get; set; }
        private int _y;
        public int y { get; set; }
        Position(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
