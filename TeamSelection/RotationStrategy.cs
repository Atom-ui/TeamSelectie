using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TeamSelectie
{
    public class RotationStrategy : IStrategyBehaviour
    {
        public Func<Player, int> orderMethod { get; set; }
        public RotationStrategy(int numberOfDefenders, int numberOfMidFielders, int numberOfForwards, List<Player> teamList, Func<Player, int> orderMethod)
        {
            this.orderMethod = orderMethod;
        }

        public List<Player> Select(List<Player> teamList, int numberOfDefenders, int numberOfMidFielders, int numberOfForwards)
        {
            List<Player> finishedTeamList = new List<Player>();

            finishedTeamList.AddRange(teamList.OfType<Defender>().OrderBy(orderMethod).Take(numberOfDefenders));
            finishedTeamList.AddRange(teamList.OfType<Midfielder>().OrderBy(orderMethod).Take(numberOfMidFielders));
            finishedTeamList.AddRange(teamList.OfType<Forward>().OrderBy(orderMethod).Take(numberOfForwards));
            finishedTeamList.Add(teamList.OfType<Goalkeeper>().OrderBy(orderMethod).First());

            return finishedTeamList;
        }
    }
}
