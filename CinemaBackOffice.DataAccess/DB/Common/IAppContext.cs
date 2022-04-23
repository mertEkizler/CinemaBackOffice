using CinemaBackOffice.Entities.Entities;
using System.Data.Entity;

namespace CinemaBackOffice.DataAccess.DB.Common
{
    public interface IAppContext
    {
        IDbSet<BoxOfficeEntity> BoxOffices { get; set; }

        IDbSet<BudgetEntity> Budgets { get; set; }

        IDbSet<BuffetEntity> Buffets { get; set; }

        IDbSet<BuffetProductCategoryEntity> BuffetProductCategories { get; set; }

        IDbSet<CategoryEntity> Categories { get; set; }

        IDbSet<DirectorEntity> Directors { get; set; }

        IDbSet<EmployeeEntity> Employees { get; set; }

        IDbSet<ManagementEntity> Managements { get; set; }

        IDbSet<MovieEntity> Movies { get; set; }

        IDbSet<StatisticEntity> Statistics { get; set; }

        IDbSet<ViewerEntity> Viewers { get; set; }
    }
}