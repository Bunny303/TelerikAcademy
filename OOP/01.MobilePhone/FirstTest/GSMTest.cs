using System;
using GSMStuffs;

namespace FirstTest
{
    class GSMTest
    {
        static void Main()
        {
            Display testDisplay = new Display(3.6, 16000);
            Battery testBattery = new Battery("E530MTH", 5.6, 7.4, BatteryType.NiCd);

            GSM[] testGSM = new GSM[2];
            
            testGSM[0] = new GSM("5230", "Nokia");
            testGSM[1] = new GSM("5230", "Nokia", 280, "Bunny", testBattery, testDisplay);

            foreach (var gsm in testGSM)
            {
                Console.WriteLine(gsm.ToString()); 
            }
        }
    }
}
