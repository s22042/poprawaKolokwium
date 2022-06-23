using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace poprawa.Models
{
    public class Organization
    {
        [Key]
        public int OrganizationID { get; set; }
        [Required, MaxLength(100)]
        public string OrganizationName { get; set; }
        [Required, MaxLength(50)]
        public string OrganizationDomain { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
