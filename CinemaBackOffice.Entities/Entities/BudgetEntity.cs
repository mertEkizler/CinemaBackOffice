using CinemaBackOffice.Entities.Entities.Common;
using System;

namespace CinemaBackOffice.Entities.Entities
{
    public class BudgetEntity : IEntity
    {
        public Guid Id { get; set; }

        public string TotalBudget { get; set; }

        public DateTime Year { get; set; }
    }
}