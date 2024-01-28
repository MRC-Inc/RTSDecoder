using System;
using System.Collections.Generic;

namespace RTSDecoder
{
    internal class WizardData
    {
        static public List<CheckData> Main = new List<CheckData>();
    }

    public struct CheckData
    {
        public DateTime GameTime { get; set; }
        public DateTime RealTime { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public IEnumerable<MovementData> Values { get; set; }
    }
}
