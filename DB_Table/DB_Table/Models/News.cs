using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Table.Models
{
    public class News
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Img { get; set; }
        [Column(TypeName ="date")]
        public int Review { get; set; }
        [Column(TypeName ="bit")]
        public int Like { get; set; }
        [Column(TypeName = "bit")]
        public int DisLike { get; set; }
        public int ReviewCount { get; set; }
    }
}
