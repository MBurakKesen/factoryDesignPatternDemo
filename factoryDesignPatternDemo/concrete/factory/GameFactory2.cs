using factoryDesignPatternDemo.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace factoryDesignPatternDemo.concrete.factory
{
    public class GameFactory2 : IGameFactory
    {
        public IOyun Gaming(Games game)
        {
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == game.ToString());
            IOyun oyun = (IOyun)Activator.CreateInstance(type);
            return oyun;
        }
    }
}
