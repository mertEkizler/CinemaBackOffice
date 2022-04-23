using CinemaBackOffice.Entities.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaBackOffice.Entities.Entities
{
    public class BuffetEntity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string ProductPrice { get; set; }

        public int ProductCategoryId { get; set; }

        public string ProductCategoryName { get; set; }

        public virtual BuffetProductCategoryEntity BuffetProductCategory { get; set; }
    }
}