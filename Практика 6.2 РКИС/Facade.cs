using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6._2_РКИС
{
    internal class Facade
    {
        private readonly Engine engineWork;
        private readonly Headlights headlightsWork;
        private readonly Fuel fuelWork;
        private readonly BoardComputer boardcomputer;
        private readonly Action<String> action;
        public Facade(Action<String>_action) 
        {
            _action = action;
            engineWork = new Engine(action);
            headlightsWork = new Headlights(action);
            fuelWork = new Fuel(action);
            boardcomputer = new BoardComputer(action);
        }
        //public void Start() 
        //{
        //    engineWork.Start();
        //    fuelWork.StartFuel();
        //    headlightsWork.StartHeadlights();
        //}
        //public void Stop() 
        //{
        //    engineWork.Stop();
        //    fuelWork.StopFuel();
        //    headlightsWork.StopHeadlights();
        //}
        public void OnHeadlights() 
        {
            headlightsWork.StartHeadlights();
        }
        public void OffHeadlights()
        {
            headlightsWork.StopHeadlights();
        }
        public void Diagnostic() 
        {
            boardcomputer.StartDiagnostic();
        }
        public void OnFuel() 
        {
            fuelWork.StartFuel();
        }
        public void OffFuel()
        {
            fuelWork.StopFuel();
        }
        public void StartEngine() 
        {
            engineWork.Start();
        }
        public void StopEngine()
        {
            engineWork.Start();
        }
        public string GetStatus() 
        {
            return
                $"Фары:{(headlightsWork.HeadlightsWork ? "ВКЛ" : "ВЫКЛ")}{Environment.NewLine}" +
               $"Двигатель:{(engineWork.EngineWork ? "ВКЛ" : "ВЫКЛ")}{Environment.NewLine}" +
               $"Подача топлива:{(fuelWork.FuelWork ? "ВКЛ" : "ВЫКЛ")}{Environment.NewLine}";
                
        }


    }
}
