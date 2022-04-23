using CinemaBackOffice.Entities.Entities.Common;
using CinemaBackOffice.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace CinemaBackOffice.Entities.Entities
{
    public class MovieEntity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        [NotMapped]
        public Language? Language { get; set; }

        [StringLength(128)]
        [Column(nameof(Language))]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string LanguageString
        {
            get
            {
                if (Language == null)
                {
                    return null;
                }
                return Language.ToString();
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Language = (Language)Enum.Parse(typeof(Language), value, true);
                }
            }
        }

        public virtual DirectorEntity Director { get; set; }

        public virtual CategoryEntity Category { get; set; }

        public virtual ICollection<ViewerEntity> Viewers { get; set; }     

        public virtual ICollection<StatisticEntity> Statistics { get; set; }

        public virtual ICollection<BoxOfficeEntity> BoxOffices { get; set; }
    }
}