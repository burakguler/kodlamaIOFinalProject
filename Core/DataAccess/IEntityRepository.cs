using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<Type> where Type:class,IEntity,new() //generic constraint -- class meaning; it should declared with reference type                                                                    
    {                                                                       //generic constraint -- IEntity meaning; it should implement IEntity and it's inheritances
                                                                            //generic constraint -- new() meaning; it should be renewable that means we can create new instance of it
        List<Type> GetAll(Expression<Func<Type,bool>> filter=null); //filter can nullable 
        Type Get(Expression<Func<Type, bool>> filter); //filter can not nullable
        void Add(Type entity);
        void Update(Type entity);
        void Delete(Type entity);
    }
}
