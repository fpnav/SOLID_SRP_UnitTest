using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Domain.Entities;


namespace Data
{
    public class ConfigMigration : DbMigrationsConfiguration<Context>
    {
        public ConfigMigration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context context)
        {
#if DEBUG
            if (!context.Alunos.Any())
            {
                var aluno = new Aluno
                {
                    Ra = 123456,
                    Id = 111222,
                    DataNascimento = new DateTime(),
                    Email = "teste@teste.com",
                    Nome = "Asdrubal De Orleans e Bragança",
                    Cpf = "123456789"
                };

                context.Alunos.Add(aluno);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            }
#endif

        }
    }

    public class CreateNotifierDatabaseIfNotExists : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            // the code of the seeding is go here
        }
    }
}