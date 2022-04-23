using CinemaBackOffice.Entities.Enums;

namespace CinemaBackOffice.Entities.Entities.Common
{
    public abstract class TeamMember
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Gender? Gender { get; set; }

        public string Title { get; set; }

        public int Salary { get; set; }

        public string Mail { get; set; }

        public string CellPhone { get; set; }
    }
}