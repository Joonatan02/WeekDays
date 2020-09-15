using System;

namespace WeekDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it today?");
            string day = Console.ReadLine().ToLower();

            {
                if (day == "monday" || day == "tuesday" || day == "wendesday" || day == "thursday" || day == "friday")
                {
                    Console.WriteLine("Today is workday");
                }
                else if (day == "saturday" || day == "sunday")
                {
                    Console.WriteLine("Today is a restday");
                }
                else
                    Console.WriteLine("You didint eneter a day");
                    
                    
            }

               
            
            


        }

    }
}
