﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProjetoBase.Persistence.Entity.Context;
using System;

namespace ProjetoBase.Persistence.Entity.Migrations
{
    [DbContext(typeof(ProjetoBaseCoreDbContext))]
    partial class ProjetoBaseCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoBase.Domain.Entities.Setor", b =>
                {
                    b.Property<int>("SetorId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAtivo");

                    b.Property<string>("Nome");

                    b.Property<string>("Sigla");

                    b.HasKey("SetorId");

                    b.ToTable("SETORES");
                });
#pragma warning restore 612, 618
        }
    }
}