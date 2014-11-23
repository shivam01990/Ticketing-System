using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEntity
{
    [Table("States")]
    public class StateModel
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}
