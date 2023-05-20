using ConsoleApp1;
Console.WriteLine("adawda");
Class1 calculations = new Class1();
TimeSpan[] startTimes = new TimeSpan[]
{
                new TimeSpan(10,0,0),
                new TimeSpan(11,0,0),
                new TimeSpan(15, 0,0),
                new TimeSpan(15,30,0),
                new TimeSpan(16,50,0),
};
int[] durations = new int[] { 60, 30, 10, 10, 40 };
TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);
int consulationTime = 30;
var actual = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consulationTime);
Console.WriteLine(actual);