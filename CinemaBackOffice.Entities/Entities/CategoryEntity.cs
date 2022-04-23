using CinemaBackOffice.Entities.Entities.Common;
using System.Collections.Generic;

namespace CinemaBackOffice.Entities.Entities
{
    public class CategoryEntity : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<MovieEntity> Movies { get; set; }
    }
}