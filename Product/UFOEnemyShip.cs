using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEnemyShip.Product
{
    public class UFOEnemyShip : EnemyShip
    {
        public override string GetName()
        {
            return "UFO Enemy Ship name is " + this.name;
        }

        public override void SetName(string name)
        {
            this.name = name;
            Console.WriteLine("UFO Enemy Ship name is set to " + this.name);
        }
    }
}
