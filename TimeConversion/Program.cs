using System;

namespace TimeConversion
{
    class Program
    {
        public static string TimeConversion(string s) {
            var inputUse = s.Substring(0, s.Length - 2);
            var amPm = s.Substring(s.Length-2, 2);
            var hour = Convert.ToInt32(s.Substring(0, 2));
            var dateTime = DateTime.Parse(inputUse);

            if(amPm == "PM" && hour != 12)
                return String.Format("{0:HH:mm:ss}", dateTime.AddHours(12));
            else if(amPm == "AM" && hour == 12)
                return String.Format("{0:HH:mm:ss}", dateTime.AddHours(-12));
            else
                return String.Format("{0:HH:mm:ss}", dateTime);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TimeConversion("07:05:45PM"));
        }
    }
}
