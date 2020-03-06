using System;
using System.Collections.Generic;

namespace TeamSelectie
{
    class Program
    {
        static void Main(string[] args)
        {



            PlayerFactory p = new PlayerFactory();
            //p.ReadData();
            //List<Speler> spelers = p.ReadData();
            
            Team t = new Team();
            t.Addplayers(p.CreateListPlayers());

            //foreach (var f in t.Players)
            //    Console.WriteLine(f);

            Func<Player, int> CapsOrderMethod = delegate (Player p)
            {
                return p.Caps;
            };

            Func<Player, int> RatingOrderMethod = delegate (Player p)
            {
                return p.Rating;
            };


            IStrategyBehaviour standard = new StandardStrategy(4, 4, 2, t.Players, CapsOrderMethod);
            IStrategyBehaviour best = new StandardStrategy(4, 4, 2, t.Players, RatingOrderMethod);
            IStrategyBehaviour rotation = new RotationStrategy(4, 4, 2, t.Players, CapsOrderMethod);



            Strategy strategy = new Strategy(standard, 4, 4, 2, t.Players);
            List<Player> eindlijst = strategy.Select();
            foreach (Player player in eindlijst)
            {
                Console.WriteLine(player.ToString());
            }
            try
            {
                //Selection selectie = new Selection();
                //selectie.Controle(12);
                PlayerFactory pf = new PlayerFactory();
                Player player = pf.CreatePlayer("Defender, Thomas Vermaelen, 34, CentralDefence, LeftBack, 83, 57");
                player.IsGeblesseerd("ja");
            }
            catch (SelectionExceptions ex)
            {
                Console.WriteLine(ex.ToString());

            }
            catch (PlayerExceptions ex)
            {
            }
        }
    }
}
