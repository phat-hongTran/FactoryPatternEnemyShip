// See https://aka.ms/new-console-template for more information
using FactoryPatternEnemyShip;
using FactoryPatternEnemyShip.Factory;
using FactoryPatternEnemyShip.Product;

Console.WriteLine("Hello, World!");

RocketEnemyShipFactory rocketEnemyShipFactory = new RocketEnemyShipFactory();
Client rocketClient = new Client(rocketEnemyShipFactory, "Rocket");
EnemyShip rocketShip = rocketClient.GetShip();
rocketShip.GetName();
rocketShip.SetName("Rocket 2");

UFOEnemyShipFactory ufoEnemyShipFactory = new UFOEnemyShipFactory();
Client ufoClient = new Client(ufoEnemyShipFactory, "UFO");
EnemyShip ufoShip = ufoClient.GetShip();
ufoShip.GetName();
ufoShip.SetName("UFO 2");