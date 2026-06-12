using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Speakers
    {
        // Fields
        // dynamic array to hold multiple Speaker objects
        private List<Speaker> SpeakerList;

        // Constructor
        public Speakers()
        {
            SpeakerList = new List<Speaker>();
        }
        // Method to add a Speaker to the list
        public void AddSpeaker(Speaker speaker)
        {
            SpeakerList.Add(speaker);
        }
        // Method to remove a Speaker from the list
        public void RemoveSpeaker(Speaker speaker)
        {
            SpeakerList.Remove(speaker);
        }
        // Method to display information of all Speakers
        public void DisplayAllSpeakers()
        {
            foreach (var speaker in SpeakerList)
            {
                speaker.DisplayInfo();
                Console.WriteLine(); // Add a blank line for better readability
            }
        }
    }
}
