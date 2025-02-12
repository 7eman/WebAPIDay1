using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumer
{
    public class course_data
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string? Crs_name { get; set; }

        [MaxLength(150)]
        public string? Crs_desc { get; set; }

        public int? Duration { get; set; }
    }
}
