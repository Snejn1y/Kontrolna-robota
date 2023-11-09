using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolna_robota
{
    public class Dragon : ArmyUnit
    {
        public double GetGoldCost()
        {
            return 0; 
        }

        public double GetBaranCost()
        {
            return 0;
        }

        public double GetKormCost()
        {
            return 1;
        }

        public double GetGoGCost()
        {
            return 1;  
        }

        public double GetSamogonCost()
        {
            return 0;
        }

        public double GetSpeed()
        {
            return 60;
        }

        public string PrintSpeed()
        {
            return $"Швидкість = {GetSpeed()}";
        }

        public string PrintCost()
        {
            return $"Корм = {GetKormCost()} Дівчата або гноми = {GetGoGCost()}";
        }
    }
}
