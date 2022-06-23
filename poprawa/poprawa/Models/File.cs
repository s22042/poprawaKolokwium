using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace poprawa.Models
{
    public class File
    {
        public int FileId { get; set; }
        public int TeamId { get; set; }
        [Required, MaxLength(100)]
        public string FileName { get; set; }
        [Required, MaxLength(4)]
        public string FileExtension { get; set; }
        [Required]
        public int FileSize { get; set; }
        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }
    }
}
