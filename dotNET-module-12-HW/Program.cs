using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_12_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Race game = new Race();

            SportsCar sportsCar = new SportsCar("Sports Car", 10);
            PassengerCar passengerCar = new PassengerCar("Passenger Car", 8);
            Truck truck = new Truck("Truck", 5);
            Bus bus = new Bus("Bus", 6);

            sportsCar.RaceEvent += game.RaceFinishedHandler;
            passengerCar.RaceEvent += game.RaceFinishedHandler;
            truck.RaceEvent += game.RaceFinishedHandler;
            bus.RaceEvent += game.RaceFinishedHandler;

            game.StartRaceEvent += sportsCar.Move;
            game.StartRaceEvent += passengerCar.Move;
            game.StartRaceEvent += truck.Move;
            game.StartRaceEvent += bus.Move;

            game.StartRaceEvent += game.RaceStartedHandler;

            game.StartRace();
        }
    }
}
