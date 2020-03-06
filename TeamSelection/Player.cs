using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public class Player : IPlayer
    {
        public string _isKapitein;

        public Player(string typeSpeler, string naam, int rugnummer, List<string> posities, int rating, int caps)
        {
            TypeSpeler = typeSpeler;
            Naam = naam;
            Rugnummer = rugnummer;
            Posities = posities;
            Rating = rating;
            Caps = caps;
        }

        public string TypeSpeler { get; set; }
        public string Naam { get; set; }
        public int Rugnummer { get; set; }
        public List<string> Posities { get; set; }
        public int Rating { get; set; }
        public int Caps { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Player speler &&
                   _isKapitein == speler._isKapitein &&
                   TypeSpeler == speler.TypeSpeler &&
                   Naam == speler.Naam &&
                   Rugnummer == speler.Rugnummer &&
                   EqualityComparer<List<string>>.Default.Equals(Posities, speler.Posities) &&
                   Rating == speler.Rating &&
                   Caps == speler.Caps;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_isKapitein, TypeSpeler, Naam, Rugnummer, Posities, Rating, Caps);
        }

        public bool IsGeblesseerd(string value)
        {
            if (value == "ja")
            {
                throw new PlayerExceptions($"Player {this.Naam.Trim()} met {this.Rugnummer} is geblesseerd.");

            }
            return false;
        }
        public override string ToString()
        {
            return ($"{TypeSpeler}, {Naam}, {Rugnummer}, {Posities.Count}, {Rating}, {Caps}.");
        }
    }
}
