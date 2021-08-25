using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness
{
    public interface IBaseService<T> where T: BaseEntity
    {
        public List<T> ListItems();

        public void CreateItem(T objectInstance);


        public void UpdateItem(T objectInstance);


        public void DeleteItem(T objectInstance);
    }
}
