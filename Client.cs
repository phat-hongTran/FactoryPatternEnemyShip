using FactoryPatternEnemyShip.Factory;
using FactoryPatternEnemyShip.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEnemyShip
{
    public class Client
    {
        private readonly EnemyShip ship;
        public Client(EnemyShipFactory factory, string shipName)
        {
            ship = factory.MakeEnemyShip(shipName);
        }

        public EnemyShip GetShip()
        {
            return ship;
        }
    }
}
