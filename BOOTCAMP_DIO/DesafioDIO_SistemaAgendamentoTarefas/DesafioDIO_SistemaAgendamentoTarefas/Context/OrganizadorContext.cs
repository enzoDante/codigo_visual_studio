using DesafioDIO_SistemaAgendamentoTarefas.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DesafioDIO_SistemaAgendamentoTarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configura o enum para ser salvo como string se preferir
            // modelBuilder.Entity<Tarefa>()
            //     .Property(t => t.Status)
            //     .HasConversion<string>();
        }
    }
}
