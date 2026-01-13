using System;
using System.Globalization;
using System.Collections.Generic;
public class Local
    {
        public string? name;
        public DateTime timeLocal;
        public TimeOnly morning;
        public TimeOnly afternoon;
        public TimeOnly evening;
        public TimeOnly night;
        public TimeOnly currentTime;

        public void GreetLocal()
        {
            
            if (currentTime.IsBetween(morning, afternoon))
            {
                Console.WriteLine($"Good morning {name}, it's currently {timeLocal:D} and the time is {timeLocal:t}");
            }
            else if (currentTime.IsBetween(afternoon, evening))
            {
                Console.WriteLine($"Good afternoon {name}, it's currently {timeLocal:D} and the time is {timeLocal:t}");
            }
            else if (currentTime.IsBetween(evening, night))
            {
                Console.WriteLine($"Good evening {name}, it's currently {timeLocal:D} and the time is {timeLocal:t}");
            }
            else
            {
                Console.WriteLine($"{name}! Why are you still up? It is {timeLocal:t}, time to sleep!");
            }
        }
    }