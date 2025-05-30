using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6._2_РКИС
{
    internal class BoardComputer
    {
        private readonly Action<String> action;
        public BoardComputer(Action<String> _action)
        {
            action = _action;
        }
        public bool StartDiagnostic()
        {
            Random random = new Random();
            int eventN = random.Next(1, 3);
            switch (eventN)
            {
                case 1:
                    action("Заглохли");
                    return false;
                case 2:
                    action("Всё отлично!");
                    return true;
                default:
                    action("Неизвестная ошибка");
                    return false;
            }
        }
    }
}
