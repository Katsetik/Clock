using ClockFunctional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();
            clock.Ticked += (sender, e) =>
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("{0}:{1}:{2}", e.Hour, e.Minute, e.Second);
            };
            clock.Tick();
        }
    }
}
