using System;
using System.Collections.Generic;

namespace SimpleFramework.Core.Data
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        //TODO: add context DI

        public ICollection<TEntity> GetEntities()
        {
            throw new NotImplementedException();
        }
    }
}
