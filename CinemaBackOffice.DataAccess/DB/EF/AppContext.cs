using CinemaBackOffice.DataAccess.DB.Common;
using CinemaBackOffice.DataAccess.Migrations;
using CinemaBackOffice.Entities.Entities;
using System.Data.Entity;

namespace CinemaBackOffice.DataAccess.EntityFramework.DB
{
    public class AppContext : DbContext, IAppContext
    {
        public AppContext()
        : base("CinemaBackOffice")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoxOfficeEntity>().ToTable("BoxOffices");
            modelBuilder.Entity<BoxOfficeEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<BudgetEntity>().ToTable("Budgets");
            modelBuilder.Entity<BudgetEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<BuffetEntity>().ToTable("Buffets");
            modelBuilder.Entity<BuffetEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<BuffetProductCategoryEntity>().ToTable("BuffetProductCategories");
            modelBuilder.Entity<BuffetProductCategoryEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<CategoryEntity>().ToTable("Categories");
            modelBuilder.Entity<CategoryEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<DirectorEntity>().ToTable("Directors");
            modelBuilder.Entity<DirectorEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<EmployeeEntity>().ToTable("Employees");
            modelBuilder.Entity<EmployeeEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<ManagementEntity>().ToTable("Managements");
            modelBuilder.Entity<ManagementEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<MovieEntity>().ToTable("Movies");
            modelBuilder.Entity<MovieEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<StatisticEntity>().ToTable("Statistics");
            modelBuilder.Entity<StatisticEntity>().HasKey(x => x.Id);

            modelBuilder.Entity<ViewerEntity>().ToTable("Viewers");
            modelBuilder.Entity<ViewerEntity>().HasKey(x => x.Id);

            //modelBuilder.Entity<DocumentSetProvisioningSolutionSecurityLevelEntity>()
            //    .HasRequired<DocumentSetProvisioningSolutionEntity>(s => s.ProvisioningSolution)
            //    .WithMany(g => g.SecurityLevels)
            //    .HasForeignKey(s => s.ProvisioningSolutionId);

            //modelBuilder.Entity<DocumentSetFieldEntity>()
            //    .HasRequired<DocumentSetProvisioningSolutionEntity>(s => s.ProvisioningSolution)
            //    .WithMany(g => g.Fields)
            //    .HasForeignKey(s => s.ProvisioningSolutionId);

            
        }

        public virtual IDbSet<BoxOfficeEntity> BoxOffices { get; set; }

        public virtual IDbSet<BudgetEntity> Budgets { get; set; }

        public virtual IDbSet<BuffetEntity> Buffets { get; set; }

        public virtual IDbSet<BuffetProductCategoryEntity> BuffetProductCategories { get; set; }

        public virtual IDbSet<CategoryEntity> Categories { get; set; }

        public virtual IDbSet<DirectorEntity> Directors { get; set; }

        public virtual IDbSet<EmployeeEntity> Employees { get; set; }

        public virtual IDbSet<ManagementEntity> Managements { get; set; }

        public virtual IDbSet<MovieEntity> Movies { get; set; }

        public virtual IDbSet<StatisticEntity> Statistics { get; set; }

        public virtual IDbSet<ViewerEntity> Viewers { get; set; }
    }
}