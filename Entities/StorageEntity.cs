using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }


        [Required]
        public int PartialQuantity { get; set; }

        
        
        //Relacion con Producto  =============================================
        public string ProductId { get; set; }

        public ProductEntity Product { get; set; }

        //Relacion con Warehouse ==============================================
        public string WareHouseId { get; set; }
        public WareHouseEntity WareHouse { get; set; }

        //Relacion con InOuts  =================================================
        public ICollection<InOutEntity> InOuts { get; set; }

    }
}
