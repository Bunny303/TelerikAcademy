using System;

namespace GSMStuffs
{
    // 3. Define enumerator
    public enum BatteryType { Lion, NiMH, NiCd }

    // 1.Define class Battery
    public class Battery
    {
        public string Model { get; set; }
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType BatteryModel { get; set; }

        // 2.Define parametless constructor
        public Battery()
        { }

        // 2. Define constructor
        public Battery(string model, double? idle, double? talk, BatteryType batteryModel)
        {
            this.Model = model;
            this.hoursIdle = idle;
            this.hoursTalk = talk;
            this.BatteryModel = batteryModel;
        }

        // 5. Property
        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if ((value > 0) || (value == null))
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException("Hours idle have to be positive!");
                }
            }
        }

        // 5. Property
        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if ((value > 0) || (value == null))
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException("Hours talk have to be positive!");
                }
            }
        }           
    }
}
