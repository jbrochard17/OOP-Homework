using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Tables
    {
        // Fields
        // dynamic array to hold multiple Table objects
        private List<Table> tableList;

        // Constructor
        public Tables()
        {
            tableList = new List<Table>();
        }
        // Method to add a table to the list
        public void AddTable(Table table)
        {
            tableList.Add(table);
        }
        // Method to remove a table from the list
        public void RemoveTable(Table table)
        {
            tableList.Remove(table);
        }
        // Method to display information of all tables
        public void DisplayAllTables()
        {
            foreach (var table in tableList)
            {
                table.DisplayInfo();
                Console.WriteLine(); // Add a blank line for better readability
            }
        }
    }
}
