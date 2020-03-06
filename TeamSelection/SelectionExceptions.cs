using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public class SelectionExceptions : SoccerExceptions
    {
        public SelectionExceptions(string message) : base("okselection")
        {

        }
        public void schrijf()
        {
            Console.WriteLine("ok");
        }

    }
}
