﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity: BaseEntity
    {
        [Key]
        [StringLength(50)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }


        //Relacion con categoria  ========================================================
        public string CategoryId { get; set; }

        public CategoryEntity Category { get; set; }

        //Relacion con storage
        public ICollection<StorageEntity> Storages { get; set; }
}
}
