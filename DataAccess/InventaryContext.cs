using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess
{
    class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; } 

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        public DbSet<InOutEntity> InOuts { get; set; }

        public DbSet<WareHouseEntity> WareHouses { get; set; }
    }
}
