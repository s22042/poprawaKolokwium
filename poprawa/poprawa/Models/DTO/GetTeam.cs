using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poprawa.Models.DTO
{
    public class GetTeam
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Organization { get; set; }
        public ICollection<Membership> Members { get; set; }
    }
}
