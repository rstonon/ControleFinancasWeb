using ControleFinancasWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancasWeb.Infrastructure.Persistence.Configurations
{
    public class ContaConfiguration : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder
            .HasKey(c => c.Id);

            builder
                .HasOne(c => c.Tipo)
                .WithMany(t => t.Contas)
                .HasForeignKey(c => c.IdTipo)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(c => c.Detalhamento)
                .WithMany(d => d.Contas)
                .HasForeignKey(c => c.IdDetalhamento)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
