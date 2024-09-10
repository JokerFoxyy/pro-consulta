using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProConsulta.Models;

namespace ProConsulta.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        internal void seed()
        {
            _modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id="8305f33b-5412-47d0-b4ab-17cf6867f2e2",
                    Name="Atendente",
                    NormalizedName="ATENDENTE"
                },
                new IdentityRole()
                {
                    Id = "00043fbd-e5e1-49eb-8e36-837561d584f1",
                    Name = "Medico",
                    NormalizedName = "MEDICO"
                }

                );

            var hasher = new PasswordHasher<IdentityUser>();
            _modelBuilder.Entity<Atendente>().HasData(
                new Atendente
                {
                    Id="95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                    Nome="Pro Consulta",
                    Email="proconsulta@hotmail.com.br",
                    EmailConfirmed=true,
                    UserName="proconsulta@hotmail.com.br",
                    NormalizedEmail="PROCONSULTA@HOTMAIL.COM.BR",
                    NormalizedUserName="PROCONSULTA@HOTMAIL.COM.BR",
                    PasswordHash=hasher.HashPassword(null,"Pa$$w0rd")

                }
                 );
            _modelBuilder.Entity<IdentityUserRole<string>>().HasData
                (
                    new IdentityUserRole<string>
                    {
                        RoleId = "8305f33b-5412-47d0-b4ab-17cf6867f2e2",
                        UserId = "95433ac4-2fe9-468f-b80d-b05ec3724d1d"
                    }
                );

            _modelBuilder.Entity<Especialidade>().HasData
                (
                new Especialidade
                {
                    Id = 1,
                    Nome = "Cardiologia",
                    Descricao="Especialidade que cuida de doenças do coração"
                },
                 new Especialidade
                 {
                     Id = 2,
                     Nome = "Neurologia",
                     Descricao = "Especialidade que cuida de doenças do cerebro"
                 },
                 new Especialidade
                 {
                     Id = 3,
                     Nome = "Nefrologia",
                     Descricao = "Especialidade que cuida de doenças do rim"
                 }

                ); 
        }
    }
}
