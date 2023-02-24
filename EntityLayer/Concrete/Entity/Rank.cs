using EntityLayer.Concrete.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Entity
{
    public class Rank : MainEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<AppUser> Users { get; set; }
    }
}
