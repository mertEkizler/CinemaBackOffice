using CinemaBackOffice.Entities.Entities.Common;
using System;

namespace CinemaBackOffice.Entities.Entities
{
    public class EmployeeEntity : TeamMember, IEntity
    {
        public Guid Id { get; set; }
    }
}