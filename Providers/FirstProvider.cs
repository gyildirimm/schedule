using Schedule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Providers
{
    internal class FirstProvider : IProvider
    {
        public void Run()
        {
            Console.WriteLine("FirstProvider Run");
        }
    }
}
