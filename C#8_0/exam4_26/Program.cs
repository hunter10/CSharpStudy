using System;

namespace exam4_26
{
    [Flags]
    enum Days
    {
        Sunday = 1, Monday = 2, Tuesday = 4, 
        Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Tuesday;
            Days workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;

            Console.WriteLine("today:" + today);
            Console.WriteLine(workingDays.HasFlag(Days.Sunday)); // 일요일을 포함하고 있는가?
            Console.WriteLine(workingDays.HasFlag(today));       // today을 포함하고 있는가?
            Console.WriteLine(workingDays);
        }
    }
}
