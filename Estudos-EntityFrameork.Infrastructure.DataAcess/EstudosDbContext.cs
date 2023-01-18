using Estudos_EntityFrameork.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Estudos_EntityFrameork.Infrastructure.DataAcess
{
    public class EstudosDbContext : DbContext
    {
        public EstudosDbContext(DbContextOptions<EstudosDbContext> options):base(options)
        {

        }

        public DbSet<Carros> Carros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
