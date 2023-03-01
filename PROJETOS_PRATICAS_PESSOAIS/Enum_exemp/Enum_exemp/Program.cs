using System;

namespace Enum_exemp
{
    class Program
    {
        public enum Season { WINTER, SPRING, SUMMER, FALL}
        static void Main(string[] args)
        {
            int x = (int)Season.WINTER;
            int y = (int)Season.SUMMER;
            Console.WriteLine($"winter = {x}");
            Console.WriteLine($"Summer = {y}");
        }
    }
}
