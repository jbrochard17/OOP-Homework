using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class TVs
    {
        // Fields
        // dynamic array to hold multiple TV objects
        private List<TV> TVList;

        // Constructor
        public TVs()
        {
            TVList = new List<TV>();
        }
        // Method to add a tv to the list
        public void AddTV(TV tv)
        {
            TVList.Add(tv);
        }
        // Method to remove a tv from the list
        public void RemoveTV(TV tv)
        {
            TVList.Remove(tv);
        }
        // Method to display information of all tvs
        public void DisplayAllTVs()
        {
            foreach (var tv in TVList)
            {
                tv.DisplayInfo();
                Console.WriteLine(); // Add a blank line for better readability
            }
        }
    }
}
