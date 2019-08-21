using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppee.Model.Models
{
    [table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostId { set; get; }

        [Key]
        [Column(TypeName="varchar")]
        [MaxLength(50)]
        public string TagId { set; get; }

        [ForeignKey("PostId")]
        public virtual Tag tag { set; get; } 

        [ForeignKey ("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
