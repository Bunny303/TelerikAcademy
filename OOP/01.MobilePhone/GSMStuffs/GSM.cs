using System;
using System.Collections.Generic;
using System.Text;


namespace GSMStuffs
{
    public class GSM
    {
        // 1. Define fields
        private string model;
        private string manufacturer;
        private decimal? price;
        public string Owner { get; set; } //automatic property
        public Battery Battery { get; set; }
        public Display Display { get; set; }

        static private GSM iPhone = new GSM("IPhone4s", "Apple", 850); // 6. static field 

        public List<Call> CallHistory { get; set; } // 9. Define automatic property 
        
        // 2.Define constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
            this.CallHistory = null;
        }
        public GSM(string model, string manufacturer, decimal price) : this(model, manufacturer)
        {
            this.price = price;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
            this.CallHistory = null;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display) : this(model, manufacturer, price)
        {
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = null;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display,  List<Call> callHistory)
            : this(model, manufacturer, price, owner, battery, display)
        {
            this.CallHistory = callHistory;
        }

        // 5. Define property
        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model is mandatory!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        //  5.Define property
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The manufacturer is mandatory!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        // 5. Define property
        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if ((value > 0)||(value==null))
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("Invalid price!");
                }
            }
        }
        
        // 4.Define method 
        public override string ToString()
        {
            StringBuilder forPrint = new StringBuilder();
            forPrint.AppendLine("Model: " + this.Model);
            forPrint.AppendLine("Manufacturer: " + this.Manufacturer);
            forPrint.AppendLine("Owner: " + this.Owner);
            forPrint.AppendLine("Price: " + this.Price);
            
            if (this.Battery != null)
            {
                forPrint.AppendLine("Battery model: " + this.Battery.Model);
                forPrint.AppendLine("Battery hours talk: " + this.Battery.HoursTalk);
                forPrint.AppendLine("Battery hours idle: " + this.Battery.HoursIdle);
            }
            if (this.Display != null)
            {
                forPrint.AppendLine("Display size: " + this.Display.Size);
                forPrint.AppendLine("Display colors: " + this.Display.Colors);
            }
            return forPrint.ToString();
        }

        // 10. Define method 
        public void AddCall(DateTime time, string number, int duration)
        {
            Call myCall = new Call(time, number, duration);
            CallHistory.Add(myCall);
        }

        // 10. Define method
        public void RemoveCall(string number, int duration)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if ((CallHistory[i].DialedNumber == number)&&(CallHistory[i].Duration == duration))
                {
                    CallHistory.RemoveAt(i);
                }
            }
        }

        // 10. Define method
        public void ClearHistory()
        {
            CallHistory.Clear();
        }

        // 11.Define method
        public double CallsTotalPrice (double pricePerMinute)
        {
            int timeAllCalls = 0;
            foreach (var call in CallHistory)
            {
                timeAllCalls = timeAllCalls + call.Duration;
            }
            double price = (pricePerMinute / 60) * timeAllCalls;
            return price;
        }
    }
}
