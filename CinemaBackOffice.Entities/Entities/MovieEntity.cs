using CinemaBackOffice.Entities.Enums;
using System;

namespace CinemaBackOffice.Entities.Entities
{
    public class MovieEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string AgeLimit { get; set; }

        public byte[] Image { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int DirectorId { get; set; }

        public string DirectorName { get; set; }

        public int BoxOfficeId { get; set; }

        public int NumberOfTicketSold { get; set; }

        public Language Language { get; set; }

        public virtual CategoryEntity Category { get; set; }

        public virtual DirectorEntity Director { get; set; }

        public virtual StatisticEntity Statistic { get; set; }

        public virtual BoxOfficeEntity BoxOffice { get; set; }
    }
}