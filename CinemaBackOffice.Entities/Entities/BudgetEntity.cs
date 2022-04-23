using CinemaBackOffice.Entities.Entities.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaBackOffice.Entities.Entities
{
    public class BudgetEntity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public string TotalBudget { get; set; }

        public DateTime Year { get; set; }
    }
}