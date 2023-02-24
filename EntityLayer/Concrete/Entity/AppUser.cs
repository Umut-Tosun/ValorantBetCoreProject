using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Entity
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int balance { get; set; }
        public string ImageUrl { get; set; }
        public int RankId { get; set; }
        public Rank Rank { get; set; }
        public List<Guess> Guesses { get; set; }
    }
}
