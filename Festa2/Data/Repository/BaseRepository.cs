using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<M> where M:BaseModel
    {
        public void Create(M model)
        {
            using (var context = new FestaContext())
            {
                context.Set<M>().Add(model);
                context.SaveChanges();
            }
        }
        public List<M> Read()
        {
            List<M> ms = new List<M>();
            using (var context = new FestaContext())
            {
                ms = context.Set<M>().ToList();
            }
            return ms;
        }
        public M Read(int id)
        {
            M model = Activator.CreateInstance<M>();
            using (var context = new FestaContext())
            {
                model = context.Set<M>().Find(id);
            }
            return model;
        }
        public void Update(M model)
        {
            using (var context = new FestaContext())
            {
                context.Entry<M>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new FestaContext())
            {
                context.Entry<M>(Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
