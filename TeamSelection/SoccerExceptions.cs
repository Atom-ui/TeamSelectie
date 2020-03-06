using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public class SoccerExceptions : Exception
    {
        public SoccerExceptions(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
