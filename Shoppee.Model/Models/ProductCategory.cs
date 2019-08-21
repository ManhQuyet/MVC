using Shoppee.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppee.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public int? ParentId { set; get; }
        public string Image { set; get; }
        public int? Description { set; get; }
        public int? DisplayOrder { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}
