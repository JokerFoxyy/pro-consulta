﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class PacienteConfiguration:IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Pacientes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired(true).HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Documento).IsRequired(true).HasColumnType("NVARCHAR(50)");

            builder.Property(x => x.Email).IsRequired(true).HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Celular).IsRequired(true).HasColumnType("nVARCHAR(11)");

            builder.HasIndex(x => x.Documento).IsUnique();

            builder.HasMany(a => a.Agendamentos).WithOne(p => p.Paciente).HasForeignKey(a => a.PacientId).OnDelete(DeleteBehavior.Restrict);
        }

    }
}
