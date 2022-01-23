using System;

namespace Classes
{
    public class Battery
    {
        private string BatteryModel {get; set;}
        private string BatteryIdleTime{get; set;}
        private int BatteryTalkHour{get; set;}
        private BatteryType BatterySpecie{get; set;}

        public Battery(string batteryModel, string batteryIdleTime, int batteryTalkHour)
        {
           BatteryModel = batteryModel;
           BatteryIdleTime = batteryIdleTime;
            BatteryTalkHour = batteryTalkHour;
        }
    }
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }
}