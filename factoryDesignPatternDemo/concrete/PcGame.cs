using factoryDesignPatternDemo.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryDesignPatternDemo.concrete
{
    public class PcGame : IOyun
    {
        public void Program()
        {
            Console.WriteLine("Pc game playing");
        }
    }
}
