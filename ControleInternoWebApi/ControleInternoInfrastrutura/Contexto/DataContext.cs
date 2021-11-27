using ControleInternoDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInternoInfrastrutura.Contexto
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>().ToTable("Funcionarios");
            modelBuilder.Entity<Funcionario>().Property(f => f.Nome).HasMaxLength(50).HasColumnType("varchar");
            modelBuilder.Entity<Funcionario>().Property(f => f.Documento).HasMaxLength(18).HasColumnType("varchar");
            modelBuilder.Entity<Funcionario>().Property(f => f.DataDeAdmissao);
            modelBuilder.Entity<Funcionario>().Property(f => f.DataDeNascimento);
            modelBuilder.Entity<Funcionario>().Property(f => f.Salario);
            modelBuilder.Entity<Funcionario>().Property(f => f.NumeroDeMatricula);
            modelBuilder.Entity<Funcionario>().Property(f => f.Status);
            modelBuilder.Entity<Funcionario>().HasKey(t => t.NumeroDeMatricula);

        }

    }

}
