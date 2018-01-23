using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFramework.Core.Data
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        ICollection<TEntity> GetEntities();
    }
}
