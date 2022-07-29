using System;

namespace GolfShop.Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; private set; }
    }
}