using CinemaBackOffice.Entities.Entities.Common;
using System.Collections.Generic;

namespace CinemaBackOffice.Entities.Entities
{
    public class StatisticEntity : IEntity
    {
        public int Id { get; set; }

        public int ViewerId { get; set; }

        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public virtual ICollection<MovieEntity> Movies { get; set; }

        public virtual ICollection<ViewerEntity> Viewers { get; set; }
    }
}