using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEnemyShip.Product
{
    public abstract class EnemyShip
    {
        protected string name;
        protected double amtDamage;

        public void FollowHeroShip()
        {
            throw new NotImplementedException();
        }

        public void DisplayEnemyShip()
        {
            throw new NotImplementedException();
        }

        public void EnemyShipShoots()
        {
            throw new NotImplementedException();
        }

        public void SetDamage(double damage)
        {
            amtDamage = damage;
        }

        public double GetDamage()
        {
            return amtDamage;
        }

        public abstract void SetName(string name);
        public abstract string GetName();
    }
}
