using System;

namespace SimpleFramework.Core.Data
{
    public class Entity : IEntity
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public bool Status { get; set; }
    }
}
