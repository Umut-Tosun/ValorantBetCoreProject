using EntityLayer.Concrete.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Entity
{
    public class Tournament : MainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string BannerUrl { get; set; }  
        List<Team> Teams { get; set; }
        public bool IsFinish { get; set; }
    }
}
