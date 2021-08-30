using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product : BusinessBase<ProductEntity>
    {
        public override ProductEntity GetById(string objectInstanceId)
        {
            using (var context = new InventoryContext())
            {
                return context.Set<ProductEntity>().LastOrDefault(x=> x.ProductId == objectInstanceId);   //Set<T>() crea un  DbSet de tipo T 
            }
        }
    }
}
