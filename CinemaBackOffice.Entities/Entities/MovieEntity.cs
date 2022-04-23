using CinemaBackOffice.Entities.Entities.Common;
using CinemaBackOffice.Entities.Enums;
using System;
using System.Collections.Generic;

namespace CinemaBackOffice.Entities.Entities
{
    public class MovieEntity : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string AgeLimit { get; set; }

        public string MovieDuration { get; set; }

        public byte[] Image { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int DirectorId { get; set; }

        public string DirectorName { get; set; }

        public int NumberOfTicketSold { get; set; }

        public int TotalViewers { get; set; }

        public Language Language { get; set; }

        public virtual DirectorEntity Director { get; set; }

        public virtual CategoryEntity Category { get; set; }

        public virtual ICollection<ViewerEntity> Viewers { get; set; }     

        public virtual ICollection<StatisticEntity> Statistics { get; set; }

        public virtual ICollection<BoxOfficeEntity> BoxOffices { get; set; }
    }
}