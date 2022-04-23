using CinemaBackOffice.Entities.Entities.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaBackOffice.Entities.Entities
{
    public class ManagementEntity : TeamMember, IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
    }
}