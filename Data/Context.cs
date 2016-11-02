using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Domain.Entities;

namespace Data
{
    public class Context : DbContext
    {
        //Construtor para referenciar connectionstring do BD
        public Context(): base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<Context, ConfigMigration>()
                );
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Para deixar o EF com tipo de data igual ao SqlServer
            modelBuilder.Properties<DateTime>()
                .Configure(c => c.HasColumnType("datetime2"));
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
