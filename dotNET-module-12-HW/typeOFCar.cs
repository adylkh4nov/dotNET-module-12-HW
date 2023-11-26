using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_12_HW
{
    public class SportsCar : Car
    {
        public SportsCar(string name, int speed) : base(name, speed) { }
    }

    public class PassengerCar : Car
    {
        public PassengerCar(string name, int speed) : base(name, speed) { }
    }

    public class Truck : Car
    {
        public Truck(string name, int speed) : base(name, speed) { }
    }

    public class Bus : Car
    {
        public Bus(string name, int speed) : base(name, speed) { }
    }

}
