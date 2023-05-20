using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            TimeSpan stw = beginWorkingTime;

            List<string> periods = new List<string>();

            while (stw.Add(TimeSpan.FromMinutes(consultationTime)) < endWorkingTime)
            {
                for (int i = 0; i < startTimes.Length; i++)
                {
                    if (stw != startTimes[i])
                    {
                        periods.Add(stw + "-" + stw.Add(TimeSpan.FromMinutes(consultationTime)));
                    }
                    else
                    {
                        TimeSpan busy = startTimes[i] + TimeSpan.FromMinutes(durations[i]);
                        stw.Add(busy);
                    }
                }


                stw.Add(TimeSpan.FromMinutes(consultationTime));
            }
            
            return periods.ToArray();
        }
    }
}
