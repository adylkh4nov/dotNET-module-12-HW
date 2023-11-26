using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_12_HW
{
    public abstract class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public delegate void RaceEventHandler(string message);
        public event RaceEventHandler RaceEvent;

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public virtual void Move()
        {
            Random rnd = new Random();
            int distance = 0;
            while (distance < 100)
            {
                distance += Speed;
                RaceEvent?.Invoke($"{Name} moved {distance} km...");
                System.Threading.Thread.Sleep(100);
            }
            RaceEvent?.Invoke($"{Name} finished the race!");
        }
    }
}
