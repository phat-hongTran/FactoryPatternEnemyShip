using FactoryPatternEnemyShip.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEnemyShip.Factory
{
    public interface EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(string shipName);
    }
}
