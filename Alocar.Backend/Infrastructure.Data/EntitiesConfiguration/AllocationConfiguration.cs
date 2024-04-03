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
    public class AllocationConfiguration: IEntityTypeConfiguration<Allocation>
    {
        public void Configure(EntityTypeBuilder<Allocation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ClientId).IsRequired();
            builder.Property(x => x.VehicleId).IsRequired();
            builder.Property(x => x.Finished).IsRequired();
            builder.Property(x => x.AllocationDate).IsRequired();
            builder.Property(x => x.ReturnDate).IsRequired();
                
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();

            builder.HasOne(x => x.Client)
                .WithMany(x => x.Allocations)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Vehicle)
                .WithMany(x => x.Allocations)
                .HasForeignKey(x => x.VehicleId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}
