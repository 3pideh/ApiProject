using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {
       
    }
}
