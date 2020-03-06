﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public class Midfielder : Player
    {
        public Midfielder(string typeSpeler, string naam, int rugnummer, List<string> posities, int rating, int caps) : base(typeSpeler, naam, rugnummer, posities, rating, caps)
        {
            TypeSpeler = typeSpeler;
            Naam = naam;
            Rugnummer = rugnummer;
            Posities = posities;
            Rating = rating;
            Caps = caps;
        }
    }
}
