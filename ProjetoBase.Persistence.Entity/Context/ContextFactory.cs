﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProjetoBase.Persistence.Entity.Context
{
    class ContextFactory : IDesignTimeDbContextFactory<ProjetoBaseCoreDbContext>
    {
        private const string CONNECTIONSTRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=ProjetoBaseCore;Integrated Security=True;user id=Teste; password=Teste;";

        public ProjetoBaseCoreDbContext CreateDbContext(string[] args)
        {
            var construtor = new DbContextOptionsBuilder<ProjetoBaseCoreDbContext>();
            construtor.UseSqlServer(CONNECTIONSTRING);
            return new ProjetoBaseCoreDbContext(construtor.Options);
        }
    }
}
