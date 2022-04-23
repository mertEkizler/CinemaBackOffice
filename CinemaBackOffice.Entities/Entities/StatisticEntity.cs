using CinemaBackOffice.Entities.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaBackOffice.Entities.Entities
{
    public class StatisticEntity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ViewerId { get; set; }

        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public virtual ICollection<MovieEntity> Movies { get; set; }

        public virtual ICollection<ViewerEntity> Viewers { get; set; }
    }
}