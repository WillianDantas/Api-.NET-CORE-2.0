using ApiService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Map
{
    public class ProcessoMap : IEntityTypeConfiguration<Processo>
    {


        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.ToTable("Processo");

            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Codigo)
            .HasColumnName("Codigo")
            .IsRequired();

            builder.Property(x => x.NumeroDoProcesso)
            .HasColumnName("NumeroDoProcesso")
            .IsRequired();

            builder.Property(x => x.DataDeCriacaoDoProcesso)
            .HasColumnName("DataDeCriacaoDoProcesso");

            builder.Property(x => x.Valor)
          .HasColumnName("Valor");

            builder.Property(x => x.Escritorio)
          .HasColumnName("Escritorio");


        }
    }
}
