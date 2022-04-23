using CinemaBackOffice.Entities.Entities.Common;
using System.Collections.Generic;

namespace CinemaBackOffice.Entities.Entities
{
    public class BoxOfficeEntity : IEntity
    {
        public int Id { get; set; }

        public string NumberOfMovie { get; set; }

        public virtual ICollection<MovieEntity> MovieEntities { get; set; }

        public virtual ICollection<ViewerEntity> ViewerEntities { get; set; }
    }
}