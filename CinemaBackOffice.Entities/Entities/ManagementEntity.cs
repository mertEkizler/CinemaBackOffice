using CinemaBackOffice.Entities.Entities.Common;
using System;

namespace CinemaBackOffice.Entities.Entities
{
    public class ManagementEntity : TeamMemberEntity, IEntity
    {
        public Guid Id { get; set; }
    }
}