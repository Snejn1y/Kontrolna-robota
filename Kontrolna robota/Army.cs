using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolna_robota
{
    public class Army
    {
        private List<ArmyUnit> units = new List<ArmyUnit>();

        public void AddUnit(ArmyUnit unit)
        {
            units.Add(unit);
        }

        private double GetTotalGoldCost()
        {
            double totalCost = 0;
            foreach (ArmyUnit unit in units)
            {
                totalCost += unit.GetGoldCost();
            }
            return totalCost;
        }

        private double GetTotalBaranCost()
        {
            double totalCost = 0;
            foreach (ArmyUnit unit in units)
            {
                totalCost += unit.GetBaranCost();
            }
            return totalCost;
        }

        private double GetTotalGoGCost()
        {
            double totalCost = 0;
            foreach (ArmyUnit unit in units)
            {
                totalCost += unit.GetGoGCost();
            }
            return totalCost;
        }

        private double GetTotalSamagonCost()
        {
            double totalCost = 0;
            foreach (ArmyUnit unit in units)
            {
                totalCost += unit.GetSamogonCost();
            }
            return totalCost;
        }

        private double GetAverageSpeed()
        {
            double totalSpeed = 0;
            foreach (ArmyUnit unit in units)
            {
                totalSpeed += unit.GetSpeed();
            }
            return totalSpeed / units.Count;
        }

        public string PrintTotalSpeed()
        {
            return $"Загальна швидкість = {GetAverageSpeed()}";
        }

        public string PrintTotalCost()
        {
            return $"Золото = {GetTotalGoldCost()} Барани = {GetTotalBaranCost()} Дівчата або зноми = {GetTotalGoGCost()} Самогон = {GetTotalSamagonCost()}";
        }

    }
}
