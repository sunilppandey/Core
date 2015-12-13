using Core.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Mappers
{
    class ClientMapper : EntityTypeConfiguration<Client>
    {
        public ClientMapper()
        {
            this.ToTable("Client", "Users");

            this.Property(x => x.Secret).IsRequired();

            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Name).HasMaxLength(100);

            this.Property(x => x.AllowedOrigin).HasMaxLength(100);
        }
    }
}
