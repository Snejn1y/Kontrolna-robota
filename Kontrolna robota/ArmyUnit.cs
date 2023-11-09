using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolna_robota
{
    public interface ArmyUnit
    {
        double GetGoldCost();

        double GetBaranCost();

        double GetKormCost();

        double GetGoGCost();

        double GetSamogonCost();

        double GetSpeed();

        string PrintSpeed();

        string PrintCost();
    }
}
