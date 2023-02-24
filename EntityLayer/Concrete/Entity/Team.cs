using EntityLayer.Concrete.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Entity
{
    public class Team : MainEntity
    {
        public string Name { get; set; }
        public string Founder { get; set; }
        public string About { get; set; }
        public string BannerUrl { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        List<Match> Matches { get; set; }
        public bool Status { get; set; }

    }
}
