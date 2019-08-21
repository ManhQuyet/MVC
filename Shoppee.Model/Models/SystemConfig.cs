using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppee.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [key]
        public int Id { set; get; }

        [Required]
        [Column(TypeName ="vvarchar")]
        [MaxLength(50)]
        public string Code { set; get; }

        [MaxLength(50)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}
