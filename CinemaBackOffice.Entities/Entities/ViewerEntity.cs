using CinemaBackOffice.Entities.Entities.Common;
using System.Collections;
using System.Collections.Generic;

namespace CinemaBackOffice.Entities.Entities
{
    public class ViewerEntity : IEntity
    {
        public int Id { get; set; }

        public int NumberOfPeople { get; set; }

        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public virtual MovieEntity Movie { get; set; }

        public virtual ICollection<BoxOfficeEntity> BoxOffices { get; set; }

        public virtual ICollection<StatisticEntity> Statistics { get; set; }
    }
}