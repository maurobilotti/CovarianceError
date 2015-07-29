using System.Collections.Generic;
using System.Linq;

namespace MyApplication.ClassLibrary
{
    public class EntityManager
    {
        public List<IBaseEntity<IConcretable>> Elements { get; private set; }

        public IResult<IConcretable> GetFirstEntity()
        {
            return this.Elements.FirstOrDefault().GetResult();
        }
    }

    public abstract class BaseEntity<TEntity> : IBaseEntity<TEntity> where TEntity : class, new()
    {
        public IResult<TEntity> GetResult()
        {
            return this.InternalGetResult();
        }

        protected virtual IResult<TEntity> InternalGetResult()
        {
            //some logic to get the Entity specified plus a list of errors.
            return (IResult<TEntity>)new Result() { Entity = (IConcretable)new TEntity(), Errors = new List<string>() };
        }

        //some other implemented methods
    }

    public interface IBaseEntity<out TEntity> where TEntity : class
    {
        IResult<TEntity> GetResult();
        //some other methods
    }    

    public interface IResult<out TEntity> where TEntity : class
    {
        TEntity Entity { get; }        

        IEnumerable<string> Errors { get; set; }
    }

    public class Result : IResult<IConcretable>
    {
        public IConcretable Entity { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }

    public interface IConcretable
    {
        //auxiliar class to represent any concrete entity because 'TEntity : class'
    }	
}
