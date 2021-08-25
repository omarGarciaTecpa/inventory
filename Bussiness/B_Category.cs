using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness
{
    public class B_Category
    {
        public List<CategoryEntity> CategoryList()
        {
            using (var dbx = new InventoryContext())
            {
                return dbx.Categories.ToList();
            }
        }

        public void CreateCategory(CategoryEntity oCategory)
        {
            using (var dbx = new InventoryContext())
            {
                dbx.Categories.Add(oCategory);
                dbx.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity oCategory) {
            using (var dbx = new InventoryContext())
            {
                dbx.Categories.Add(oCategory);
                dbx.SaveChanges();
            }
        }
    }
}
