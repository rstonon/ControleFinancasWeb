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
    public class DetalhamentoConfiguration : IEntityTypeConfiguration<Detalhamento>
    {
        public void Configure(EntityTypeBuilder<Detalhamento> builder)
        {
            builder
                .HasKey(d => d.Id);

            builder
                .HasOne(c => c.Tipo)
                .WithMany(t => t.Detalhamentos)
                .HasForeignKey(c => c.IdTipo)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
