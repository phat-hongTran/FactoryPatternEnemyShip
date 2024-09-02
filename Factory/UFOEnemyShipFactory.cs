using FactoryPatternEnemyShip.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEnemyShip.Factory
{
    public class UFOEnemyShipFactory : EnemyShipFactory
    {
        public EnemyShip ship;
        public EnemyShip MakeEnemyShip(string shipName)
        {
            ship = new UFOEnemyShip();
            ship.SetName(shipName);
            return ship;
        }
    }
}
