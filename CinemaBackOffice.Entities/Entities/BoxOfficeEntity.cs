using CinemaBackOffice.Entities.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaBackOffice.Entities.Entities
{
    public class BoxOfficeEntity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NumberOfMovie { get; set; }

        public virtual ICollection<MovieEntity> MovieEntities { get; set; }

        public virtual ICollection<ViewerEntity> ViewerEntities { get; set; }
    }
}