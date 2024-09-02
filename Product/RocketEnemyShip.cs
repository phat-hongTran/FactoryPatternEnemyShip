using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEnemyShip.Product
{
    public class RocketEnemyShip : EnemyShip
    {
        public override string GetName()
        {
            return "Rocket Enemy Ship name is " + this.name;
        }

        public override void SetName(string name)
        {
            this.name = name;
            Console.WriteLine("Rocket Enemy Ship name is set to " + this.name);
        }
    }
}
