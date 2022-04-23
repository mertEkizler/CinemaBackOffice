using CinemaBackOffice.Entities.Entities.Common;
using System.Collections.Generic;

namespace CinemaBackOffice.Entities.Entities
{
    public class BuffetProductCategoryEntity : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<BuffetEntity> BuffetEntities { get; set; }
    }
}