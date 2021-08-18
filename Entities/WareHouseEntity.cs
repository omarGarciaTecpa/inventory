using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WareHouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WareHouseId { get; set; }


        [Required]
        [StringLength(100)]
        public string WareHouseName { get; set; }

        [Required]
        [StringLength(300)]
        public string WareHouseAdress { get; set; }


        public ICollection<StorageEntity> Storages { get; set; }
    }
}
