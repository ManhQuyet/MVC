using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppee.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string URL { set; get; }
        public int? DisplayOrder { set; get;}
        [Required]
        public int GroupId { set; get; }
        [ForeignKey("GroupId")]
        public virtual MenuGroup MenuGroup { set; get; }
        public string Target { set; get; }
        [Required]
        public bool Status { set; get; }
    }
}
