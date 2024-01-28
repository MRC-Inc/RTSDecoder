using System;
using System.Collections.Generic;

namespace RTSDecoder
{
    static class TrainData
    {
        static public List<MovementData> Main = new List<MovementData>();
    }

    public struct MovementData
    {
        public int Id { get; set; }
        public double Speed { get; set; }
        public double SpeedLimit { get; set; }
        public string SpeedVector { get; set; }
        public DateTime Time { get; set; }
        public DateTime RealTime { get; set; }
        public double Tm { get; set; }
        public double Ur { get; set; }
        public double Tc { get; set; }
        public double Lm { get; set; }
        public string Ept { get; set; }
        public string Sand { get; set; }
        public string Signal { get; set; }
        public int SSignal { get; set; }
        public double Path { get; set; }
        public double Pos { get; set; }
        public double Kmpk { get; set; }
        public double Odo { get; set; }
        public double Km { get; set; }
        public int Locos { get; set; }
        public int Wags { get; set; }
        public int Mass { get; set; }
        public double Length { get; set; }
        public double Fuel { get; set; }
    }
}
