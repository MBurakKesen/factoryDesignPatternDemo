using factoryDesignPatternDemo.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryDesignPatternDemo.concrete.factory
{

    public class GameFactory1:IGameFactory
    {
        IOyun oyun;
        public IOyun Gaming(Games game)
        {
            switch (game)
            {
                case Games.PcGame:
                    oyun = new PcGame();
                    break;
                case Games.PsGame:
                    oyun = new PsGame();
                    break;
                case Games.MobilGame:
                    oyun = new MobilGame();
                    break;
            }
            return oyun;
        }
    }
}
