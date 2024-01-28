using System;
using System.Collections.Generic;
using System.Linq;

namespace RTSDecoder
{
    internal class AutoDecoder
    {
        List<CheckData> _checkDataList = WizardData.Main;
        List<MovementData> _dataList = TrainData.Main;

        string _type = "Unknown";
        string _description = "Пустое значение";
        IEnumerable<MovementData> _values;

        public void CheckSpeed(int movingTypeIndex, DateTime gameTime, DateTime realTime, double speed, double speedLimit)
        {
            if (speedLimit == 5) { speedLimit = 20; }
            if ((speed - 1) > speedLimit)
            {
                double exceeding = speed - speedLimit;

                _type = "Exceeding";
                _description = "Превышение максимально допустимой скорости на " + Math.Round(exceeding, 2) + " км/ч. (Факт: " + Math.Round(speed, 2) + " км/ч, Доп: " + speedLimit + " км/ч)";
                _values = _dataList.Where(item => item.Time == gameTime);

                CheckData data = new CheckData
                {
                    GameTime = gameTime,
                    RealTime = realTime,
                    Type = _type,
                    Description = _description,
                    Values = _values
                };
                _checkDataList.Add(data);
            }
        }

        public void CheckSpeedToSignal(int movingTypeIndex, DateTime gameTime, DateTime realTime, string signal, double ssignal, double speed)
        {
            double sLimit = 5 + (speed / 3.6);
            if ((signal == "Ж" & ssignal < sLimit & (speed - 1) > 60) | (signal == "Ж-Ж" & ssignal < sLimit & (speed - 1) > 40) | (signal == "КЖ" & ssignal < sLimit & (speed - 1) > 20))
            {
                int speedLimitToSignal = 60;
                if (signal == "Ж-Ж") { speedLimitToSignal = 40; }
                double exceeding = speed - speedLimitToSignal;

                _type = "ExceedingToSignal";
                _description = "Превышение максимально допустимой скорости проследования 'Ж', 'Ж-Ж', 'К' огней на " + Math.Round(exceeding, 2) + " км/ч. (Факт: " + Math.Round(speed, 2) + " км/ч, Доп: " + speedLimitToSignal + " км/ч, Лок: " + signal + ", До сигнала: " + Math.Round(ssignal, 3) + " м)";
                _values = _dataList.Where(item => item.Time == gameTime);
                
                CheckData data = new CheckData
                {
                    GameTime = gameTime,
                    RealTime = realTime,
                    Type = _type,
                    Description = _description,
                    Values = _values
                };
                _checkDataList.Add(data);
            }
        }

        private string _prevSignal;
        public void CheckSignalEblan(int movingTypeIndex, DateTime gameTime, DateTime realTime, string signal, double speed)
        {
            if (signal == "К" & _prevSignal == "КЖ")
            {
                _type = "Eblan";
                _description = "Проезд сигнала с запрещающим показанием. (Факт: " + Math.Round(speed, 2) + " км/ч, Лок: " + signal + ")";
                _values = _dataList.Where(item => item.Time == gameTime);

                CheckData data = new CheckData
                {
                    GameTime = gameTime,
                    RealTime = realTime,
                    Type = _type,
                    Description = _description,
                    Values = _values
                };
                _checkDataList.Add(data);
                _prevSignal = null;
            }
            else
            {
                _prevSignal = signal;
            }
        }
    }
}
