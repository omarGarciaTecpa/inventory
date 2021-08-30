using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BusinessBase<T> : IBusinessBase<T> where T : BaseEntity, new()
    {

        //Usamos virtual para que, en caso de ser necesario podamos hacer un override en las clases derivadas
        public virtual List<T> List() 
        {
            using (var context = new InventoryContext())
            {
                return context.Set<T>().ToList();   //Set<T>() crea un  DbSet de tipo T 
            }
        }

        //Se debe hacer override en las clases que heredan de esta
        public virtual T GetById(string objectInstanceId)
        {
            throw new NotImplementedException();
        }



        //Usamos virtual para que, en caso de ser necesario podamos hacer un override en las clases derivadas
        public virtual void Create(T objectInstance)
        {
            using (var context = new InventoryContext()) {
                context.Set<T>().Add(objectInstance); //Set<T>() crea un  DbSet de tipo T                 
                context.SaveChanges();
            }
        }

        //Usamos virtual para que, en caso de ser necesario podamos hacer un override en las clases derivadas
        public virtual void Update(T objectInstance)
        {
            using (var context = new InventoryContext())
            {
                context.Set<T>().Update(objectInstance); //Set<T>() crea un  DbSet de tipo T 
                context.SaveChanges();
            };
        }

        //Usamos virtual para que, en caso de ser necesario podamos hacer un override en las clases derivadas
        public virtual void Delete(T objectInstance)
        {
            //Este no se manejo en este momento
        }

    }
}
