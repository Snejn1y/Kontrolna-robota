using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolna_robota
{
    public class Gnome : ArmyUnit
    {
        public double GetGoldCost()
        {
            return 3;
        }

        public double GetBaranCost()
        {
            return 0;
        }

        public double GetKormCost()
        {
            return 0;
        }

        public double GetGoGCost()
        {
            return 0;
        }

        public double GetSamogonCost()
        {
            return 1;
        }

        public double GetSpeed()
        {
            return 17;
        }

        public string PrintSpeed()
        {
            return $"Швидкість = {GetSpeed()}";
        }

        public string PrintCost()
        {
            return $"Золото = {GetGoldCost()} Самогон = {GetSamogonCost()}";
        }
    }
}
