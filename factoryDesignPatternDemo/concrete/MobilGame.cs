using factoryDesignPatternDemo.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryDesignPatternDemo.concrete
{
    public class MobilGame : IOyun
    {
        public void Program()
        {
            Console.WriteLine("Mobil game playing");
        }
    }
}
