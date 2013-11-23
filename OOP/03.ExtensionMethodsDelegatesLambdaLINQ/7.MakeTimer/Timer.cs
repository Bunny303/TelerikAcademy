using System;
using System.Linq;
using System.Threading;

namespace _7.MakeTimer
{
    public class Timer
    {
        public delegate void TimerDelegate();
                
        public static void ExecutedMethod(TimerDelegate method, int seconds, int duration)
        {
            long start = 0;
            while (start <= duration )
            {
                method();
                Thread.Sleep(seconds * 1000);
                start = start + seconds;
            }
                
        }
        
    }
}
