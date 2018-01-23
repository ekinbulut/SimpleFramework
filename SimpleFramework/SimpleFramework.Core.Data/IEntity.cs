using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFramework.Core.Data
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime CreateDate { get; set; }

        DateTime UpdateDate { get; set; }

        bool Status { get; set; }
    }
}
