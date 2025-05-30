using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6._2_РКИС
{
    internal class Engine
    {
        public bool EngineWork{ get; set; }
        private readonly Action<String> action;
        public Engine(Action<String> _action) 
        {
            action = _action;
        }
        public void Start()
        {
            EngineWork = true;
            action("Двигатель завёлся!");
        }

        public void Stop()
        {
            EngineWork = false;
            action("Двигатель остановил работу!");
        }

    }
}
