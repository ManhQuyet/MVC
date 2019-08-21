using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppee.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductId { set; get; }

        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        public string TagId { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Products { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
