using EntityLayer.Concrete.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Entity
{
    public class Match : MainEntity
    {
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
        public DateTime StartDate { get; set; }
        public string StreamUrl { get; set; }      
        public int FirstTeamId { get; set; }
        public Team FirsTeam { get; set; }
        public int SecondTeamId { get; set; }
        public Team SecondTeam { get; set; }
        public int? WinnerTeamId { get; set; }
        public Team WinnerTeam { get; set; }
        public bool IsCompleted { get; set; }
    }
}
