using Shoppee.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shoppee.Model.Models
{
    [Table("Products")]
    public class Product :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public int CategoryId { set; get; }
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}
