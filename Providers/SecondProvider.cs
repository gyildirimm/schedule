using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Providers
{
    internal class SecondProvider : IProvider
    {
        public void Run()
        {
            Console.WriteLine("SecondProvider Run");
        }
    }
}
