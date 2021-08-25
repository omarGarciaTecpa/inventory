using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities;

namespace Bussiness
{
    class BaseService<T> : IBaseService<T> where T: BaseEntity, new()
    {
        public List<T> ListItems()
        {
            using (var dbx = new InventoryContext())
            {
                return dbx.Set<T>().ToList<T>();
            }
        }

        public void CreateItem(T objectInstance)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(T objectInstance)
        {
            throw new NotImplementedException();
        }



        public void UpdateItem(T objectInstance)
        {
            throw new NotImplementedException();
        }
    }
}
