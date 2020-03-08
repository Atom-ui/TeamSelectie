using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public class Selection
    {
        public Selection(List<Player> ploeg)
        {
            Ploeg = ploeg;
            MaakKapitein();
        }

        public List<Player> Ploeg { get; set; }
        public void Controle(int value)
        {
            if (value != 11)
                throw new SelectionExceptions("ok");
        }
        public void CreatePloeg(List<Player> p)
        {
            Ploeg = p;
        }
        public void MaakKapitein()
        {
            Player kapitein = null;
            for (int i = 1; i < Ploeg.Count; i++)
            {
                if (Ploeg[i].Caps < Ploeg[i - 1].Caps)
                {
                    kapitein = Ploeg[i - 1];
                }
            }
            int index = Ploeg.IndexOf(kapitein);
            Ploeg[index]._isKapitein = true;
        }
        public void IsGeblesseerd(Player p, string value)
        {

        }
    }
}
