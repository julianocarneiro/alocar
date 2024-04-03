using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.EntitiesConfiguration
{
    public class VehicleConfiguration: IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Brand).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.ManufactureModel).HasMaxLength(4).IsRequired(false);
            builder.Property(x => x.ManufactureYear).HasMaxLength(4).IsRequired(false);
            builder.Property(x => x.Color).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.Plate).HasMaxLength(20).IsRequired(false);

            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();
        }

    }

}
