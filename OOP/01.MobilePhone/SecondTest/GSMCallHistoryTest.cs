using System;
using System.Collections.Generic;
using GSMStuffs;

namespace SecondTest
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            // Create an instance of the GSM class.
            Display testDisplay = new Display(3.6, 16000);
            Battery testBattery = new Battery("E530MTH", 5.6, 7.4, BatteryType.NiCd);
            List<Call> testCalls = new List<Call>();
            GSM testGSM = new GSM("5230", "Nokia", 280, "Bunny", testBattery, testDisplay, testCalls);
            
            //Add few calls.
            testGSM.AddCall( DateTime.Now, "0886358954", 36);
            testGSM.AddCall(DateTime.Now, "0885684589", 125);
            testGSM.AddCall(DateTime.Now, "0886387954", 398);

            // Display the information about the calls.
            foreach (var call in testGSM.CallHistory)
            {
                Console.WriteLine("Date and time: {0}", call.DateAndTime);
                Console.WriteLine("Dialed number: {0}", call.DialedNumber);
                Console.WriteLine("Call durations: {0}", call.Duration);
            }

            // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("{0:C}",testGSM.CallsTotalPrice(0.37));

            // Remove the longest call from the history and calculate the total price again.
            int maxCall = int.MinValue;
            string maxNumber = null;
            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                if (testGSM.CallHistory[i].Duration > maxCall)
                {
                    maxCall = testGSM.CallHistory[i].Duration;
                    maxNumber = testGSM.CallHistory[i].DialedNumber;
                }
            }
            testGSM.RemoveCall(maxNumber, maxCall);
            Console.WriteLine("{0:C}", testGSM.CallsTotalPrice(0.37));

            //Finally clear the call history and print it.
            testGSM.ClearHistory();
        }
    }
}
