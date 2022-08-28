using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // T IEntity olabilir veya IEntity i implemnte eden bir nesne olabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()//generic constraint
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter); // filtre verilmemişse tüm data getirilir

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
            
    }
}
