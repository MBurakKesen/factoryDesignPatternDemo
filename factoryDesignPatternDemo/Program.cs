
using factoryDesignPatternDemo.abstraction;
using factoryDesignPatternDemo.concrete.factory;

IGameFactory factory = new GameFactory1();
IGameFactory factory2 = new GameFactory2();

IOyun Volarant = factory.Gaming(Games.PcGame);
Volarant.Program();

IOyun GadOfWar=factory.Gaming(Games.PsGame);
GadOfWar.Program();

IOyun Roblox=factory.Gaming(Games.MobilGame);
Roblox.Program();


IOyun CsGo = factory.Gaming(Games.PcGame);
Volarant.Program();

IOyun Spiderman=factory.Gaming(Games.PsGame);
GadOfWar.Program();

IOyun PubgMobil=factory.Gaming(Games.MobilGame);
Roblox.Program();

