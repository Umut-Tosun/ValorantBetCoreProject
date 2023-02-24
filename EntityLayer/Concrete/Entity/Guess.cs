using EntityLayer.Concrete.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Entity
{
    public class Guess : MainEntity
    {
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; }
        public int WinnerTeamId { get; set; }
        public Team Team { get; set; }
        public int BalancePlayed { get; set; }
        public bool status { get; set; }
    }
}
