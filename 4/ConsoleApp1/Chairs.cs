using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Chairs
    {
        // Fields
        // dynamic array to hold multiple Chair objects
        private List<Chair> chairList;

        // Constructor
        public Chairs()
        {
            chairList = new List<Chair>();
        }
        // Method to add a chair to the list
        public void AddChair(Chair chair)
        {
            chairList.Add(chair);
        }
        // Method to remove a chair from the list
        public void RemoveChair(Chair chair)
        {
            chairList.Remove(chair);
        }
        // Method to display information of all chairs
        public void DisplayAllChairs()
        {
            foreach (var chair in chairList)
            {
                chair.DisplayInfo();
                Console.WriteLine(); // Add a blank line for better readability
            }
        }
    }
}
