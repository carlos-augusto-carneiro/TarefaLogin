using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTarefaLogin.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefaLogin.Data.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> config) : base(config)
        {}

        public DbSet<Login> Logins { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>().HasOne( l => l.Login).WithMany( t => t.TarefaId).HasForeignKey( x => x.LoginId);
        }
    }
}