using System;
using System.Collections.Generic;
using System.Text;

namespace EldrichHorrorTracker.Assets
{
    class Player
    {
        public string Name { get; set; }
        public string LocationIdentifier { get; set; }
        public int Health { get; set; }
        public int Sanity { get; set; }
        public int TrainTicketCount { get; set; }
        public int PlaneTicketCount { get; set; }
        public bool IsLeader { get; set; }
        public List<string> Assets { get; set; }
        public List<string> Artifacts { get; set; }
        public List<string> Conditions { get; set; }
        public List<string> Improvements { get; set; }
    }
}
