using FactoryPatternEnemyShip.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEnemyShip.Factory
{
    public class RocketEnemyShipFactory : EnemyShipFactory
    {
        public EnemyShip ship;
        public EnemyShip MakeEnemyShip(string shipName)
        {
            ship = new RocketEnemyShip();
            ship.SetName(shipName);
            return ship;
        }
    }
}
