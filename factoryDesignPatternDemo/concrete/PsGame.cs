using factoryDesignPatternDemo.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryDesignPatternDemo.concrete
{
    public class PsGame : IOyun
    {
        public void Program()
        {
            Console.WriteLine("Ps game playing");
        }
    }
}
