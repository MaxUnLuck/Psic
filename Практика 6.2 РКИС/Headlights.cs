using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6._2_РКИС
{
    internal class Headlights
    {
        public bool HeadlightsWork { get; set; }
        private readonly Action<String> action;
        public Headlights(Action<String> _action)
        {
            action = _action;
        }

        public void StartHeadlights() 
        {
            HeadlightsWork = true;
            action("Фары включены!");
        }
        public void StopHeadlights() 
        {
            HeadlightsWork = false;
            action("Фары отключены!");
        }
    }
}
