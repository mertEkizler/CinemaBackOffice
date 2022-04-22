namespace CinemaBackOffice.Entities.Entities
{
    public class ViewerEntity
    {
        public int Id { get; set; }

        public int NumberOfPeople { get; set; }

        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public virtual MovieEntity Movie { get; set; }
    }
}