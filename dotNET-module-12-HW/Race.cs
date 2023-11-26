using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_12_HW
{
    public class Race
    {
        public delegate void StartRaceDelegate();

        public event StartRaceDelegate StartRaceEvent;

        public void StartRace()
        {
            StartRaceEvent?.Invoke();
        }

        public void RaceStartedHandler()
        {
            Console.WriteLine("Race has started!");
        }

        public void RaceFinishedHandler(string message)
        {
            Console.WriteLine(message);
        }
    }

}
