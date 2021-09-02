using System;
using System.Collections.Generic;
using System.Text;

namespace EldrichHorrorTracker.Assets
{
    class Board
    {
        public string ChosenOne { get; set; }
        public List<string> SolvedMysteries { get; set; }
        public string CurrentMystery { get; set; }
        public string CurrentMysteryProgress { get; set; }
        public string ExpeditionLocation { get; set; }
        public int DoomTrackerLocation { get; set; }
        public OmenTrackSymbols OmenTrackLocation { get; set; }
        public List<string> RemainingMythos { get; set; }
        public List<string> OngoingMythos { get; set; }
        public List<Player> Players { get; set; }
        public List<Location> Locations { get; set; }
    }

    enum OmenTrackSymbols
    {
        GreenBall,
        BlueLineRight,
        BlueLineLeft,
        RedBall
    }
}
