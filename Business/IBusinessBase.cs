using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IBusinessBase<T> where T : BaseEntity, new()
    {
        public List<T> List();

        public T GetById(string objectInstanceId);

        public void Create(T objectInstance);

        public void Update(T objectInstance);

        public void Delete(T objectInstance);
    }
}
