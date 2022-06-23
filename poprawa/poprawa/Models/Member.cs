using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace poprawa.Models
{
    public class Member
    {   [Key]
        public int MemberId { get; set; }
        [Required]
        public int OrganizationId { get; set; }
        [Required, MaxLength(20)]
        public string MemberName { get; set; }
        [Required, MaxLength(50)]
        public string MemberSurname { get; set; }
        [MaxLength(20)]
        public string MemberNickName { get; set; }
        [ForeignKey("OrganizationId")]
        public virtual Organization Organization { get; set; }
    }
}
