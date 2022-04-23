using CinemaBackOffice.Entities.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace CinemaBackOffice.Entities.Entities.Common
{
    public abstract class TeamMember
    {
        public string Name { get; set; }

        public int Age { get; set; }

        [NotMapped]
        public Gender? Gender { get; set; }

        [StringLength(128)]
        [Column(nameof(Language))]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string LanguageString
        {
            get
            {
                if (Gender == null)
                {
                    return null;
                }
                return Gender.ToString();
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Gender = (Gender)Enum.Parse(typeof(Gender), value, true);
                }
            }
        }

        public string Title { get; set; }

        public int Salary { get; set; }

        public string Mail { get; set; }

        public string CellPhone { get; set; }
    }
}