using ProjetoBase.Persistence.Entity.TemplateConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBase.Domain.Entities;

namespace ProjetoBase.Persistence.Entity.Configuration
{
    public class SetorConfiguration : PersistenceTypeConfiguration<Setor>
    {
        public SetorConfiguration(EntityTypeBuilder<Setor> builder)
            : base(builder) { }

        public override void ConfiguraCampos(EntityTypeBuilder<Setor> builder)
        { }

        public override void ConfiguraChavePrimaria(EntityTypeBuilder<Setor> builder)
        {
            builder.HasKey(p => p.SetorId);
        }

        public override void ConfiguraNomeTabela(EntityTypeBuilder<Setor> builder)
        {
            builder.ToTable("SETORES");
        }

        public override void ConfiguraRelacionamentos(EntityTypeBuilder<Setor> builder)
        { }
    }
}
