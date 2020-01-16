﻿
using Jobber.IO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jobber.IO.Data.Mappings
{
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {

        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                 .IsRequired()
                 .HasColumnType("varchar(50)");

            builder.Property(c => c.Document)
                 .IsRequired()
                 .HasColumnType("varchar(20)");

            builder.Property(c => c.Image)
                 .IsRequired()
                 .HasColumnType("varchar(100)");         

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar(60)");   
                        
            builder.HasOne(c => c.Address)
                .WithOne(a => a.Company);

            builder.HasMany(e => e.Jobbers)
                .WithOne(s => s.Company)
                .HasForeignKey(e => e.CompanyId);

            builder.ToTable("Companies");
        }
    }
}
