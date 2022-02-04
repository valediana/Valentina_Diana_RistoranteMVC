using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RistoranteMVC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.RepositoryEF.Configurations
{
    internal class PiattoConfiguration : IEntityTypeConfiguration<Piatto>
    {
        public void Configure(EntityTypeBuilder<Piatto> builder)
        {
            builder.ToTable("Piatto");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p=>p.Descrizione).IsRequired();
            builder.Property(p=>p.Tipologia).IsRequired();
            

            builder.HasOne(p=>p.Menu).WithMany(m=>m.PiattiMenu).HasForeignKey(p =>p.MenuId);
        }
    }
}
