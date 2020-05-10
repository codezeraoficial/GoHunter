﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class JobOfferMapping : IEntityTypeConfiguration<JobOffer>
    {
        public void Configure(EntityTypeBuilder<JobOffer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                 .IsRequired()
                 .HasColumnType("varchar(50)");

            builder.Property(c => c.Description)
                 .IsRequired()
                 .HasColumnType("varchar(1000)");        
            
            builder.Property(c => c.ContractCode)
                 .IsRequired()
                 .HasColumnType("varchar(50)");

            builder.Property(c => c.ContractTime)
                 .IsRequired();      
                                  
            builder.Property(e => e.Occupation)
                 .IsRequired()
                 .HasColumnType("varchar(100)");

            builder.HasMany(e => e.Techs)
                .WithOne(t => t.JobOffer)
                .HasForeignKey(e => e.JobOfferId);

            builder.HasMany(e => e.Skills)
                .WithOne(s => s.JobOffer)
                .HasForeignKey(e => e.JobOfferId);                
                       
            builder.ToTable("JobOffers");
        }
    }
}
