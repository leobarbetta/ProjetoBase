﻿using Microsoft.EntityFrameworkCore;
using ProjetoBase.Domain.Entities;
using ProjetoBase.Persistence.Entity.Configuration;

namespace ProjetoBase.Persistence.Entity.Context
{
    public class ProjetoBaseCoreDbContext : DbContext
    {
        public ProjetoBaseCoreDbContext(DbContextOptions<ProjetoBaseCoreDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForSqlServerUseIdentityColumns();

            base.OnModelCreating(modelBuilder);

            new SetorConfiguration(modelBuilder.Entity<Setor>());
        }
    }
}
