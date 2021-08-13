using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    class InOutEntity
    {
        [Key]
        [StringLength(50)]
        public string InOutId { get; set; }

        public DateTime InOutDate { get; set; }

        public int InOutQuantity { get; set; }

        public bool InOutIsInput { get; set; }


    }
}
