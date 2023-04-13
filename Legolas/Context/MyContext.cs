using Legolas.Entity;
using Microsoft.EntityFrameworkCore;

namespace Legolas.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuariosEntity>().HasData(
            new UsuariosEntity
            {
                Id = 1,
                Usuario = "Manager",
                Nome = "Essential",
                Senha = Essential.Criptografia.Criptografar("123"),
                Ativo = true,
                Master = true,
                Engenhero = false,
                Administracao = false
            });
        }
        public DbSet<UsuariosEntity> Usuarios { get; set; }
    }
}
