using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Lights
    {
        // Fields
        // dynamic array to hold multiple Speaker objects
        private List<Light> LightList;

        // Constructor
        public Lights()
        {
            LightList = new List<Light>();
        }
        // Method to add a Light to the list
        public void AddLight(Light light)
        {
            LightList.Add(light);
        }
        // Method to remove a Light from the list
        public void RemoveSpeaker(Light light)
        {
            LightList.Remove(light);
        }
        // Method to display information of all Lights
        public void DisplayAllLights()
        {
            foreach (var light in LightList)
            {
                light.DisplayInfo();
                Console.WriteLine(); // Add a blank line for better readability
            }
        }
    }
}
