using Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Mappers
{
    class ApplicationUserMapper : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserMapper()
        {
            this.ToTable("AspNetUsers", "Users");

            this.Property(c => c.FirstName).IsRequired();
            this.Property(c => c.FirstName).HasMaxLength(100);

            this.Property(c => c.LastName).IsRequired();
            this.Property(c => c.LastName).HasMaxLength(100);

            this.Property(c => c.Level).IsRequired();

            this.Property(c => c.JoinDate).IsRequired();
        }
    }
}
