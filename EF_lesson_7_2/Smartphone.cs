using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_7_2
{
    [Table("Smartphones")]
    public class Smartphone : Phone
    {
        public string OS { get; set; }
    }
}
