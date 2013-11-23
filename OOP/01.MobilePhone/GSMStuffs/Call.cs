using System;

namespace GSMStuffs
{
    // 8. Define class
    public class Call
    {
        public DateTime DateAndTime { get; set; }
        public string DialedNumber { get; set; }
        public int Duration { get; set; }

        public Call(DateTime dateAndTime, string dialedNumber, int duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }
    }
}
