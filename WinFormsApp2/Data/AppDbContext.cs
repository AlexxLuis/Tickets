using Microsoft.EntityFrameworkCore;
using Tickets.Models;
using System;
using System.IO;

namespace Tickets.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "TicketDB.db");

            
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath));

            options.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>()
                .HasIndex(f => f.Cpf)
                .IsUnique();

            modelBuilder.Entity<Funcionario>()
                .Property(f => f.Situacao)
                .HasMaxLength(1);

            modelBuilder.Entity<Ticket>()
            .HasOne(t => t.Funcionario) // Um Ticket pertence a um Funcionario
            .WithMany() // Um Funcionario pode ter muitos Tickets
            .HasForeignKey(t => t.FuncionarioId); // A chave estrangeira é FuncionarioId

        }
    }
}
