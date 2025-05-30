using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6._2_РКИС
{
    internal class Fuel
    {
        public bool FuelWork{ get; set; }
        private readonly Action<String> action;
        public Fuel(Action<String> _action)
        {
            action = _action;
        }

        public void StartFuel()
        {
            FuelWork = true;
            action("Подача топлива пошла полным ходом!");
        }

        public void StopFuel()
        {
            FuelWork = false;
            action("Подача топлива прекращена, мы остановились :(");
        }

    }
}
