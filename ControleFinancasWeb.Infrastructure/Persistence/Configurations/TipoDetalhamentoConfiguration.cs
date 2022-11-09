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
    public class TipoDetalhamentoConfiguration : IEntityTypeConfiguration<CategoriaSubcategoria>
    {
        public void Configure(EntityTypeBuilder<CategoriaSubcategoria> builder)
        {
            builder
                .HasKey(td => td.Id);
        }
    }
}
