using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEntity
{
    [Table("District")]
    public class DistrictModel
    {
        public int DisrictId { get; set; }
        public int StateId { get; set; }
        public string DistrictName { get; set; }
    }
}
