using System;
using System.Collections.Generic;
using System.Text;

namespace EldrichHorrorTracker.Assets
{
    class Location
    {
        public string Identifier { get; set; }
        public int ClueCount { get; set; }
        public int EldrichTokenCount { get; set; }
        public bool GateToken { get; set; }
        public bool RumorToken { get; set; }
        public bool ExclamationToken { get; set; }
        public List<string> MonsterNames { get; set; }
    }
}
