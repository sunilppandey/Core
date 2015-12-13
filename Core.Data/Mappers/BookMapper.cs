using Core.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Mappers
{
    class BookMapper : EntityTypeConfiguration<Book>
    {
        public BookMapper()
        {
            this.ToTable("Book", "Users");

            this.Property(x => x.Title).IsRequired();
            this.Property(x => x.Title).HasMaxLength(100);

            this.Property(x => x.Author).IsRequired();
            this.Property(x => x.Author).HasMaxLength(100);

            this.Property(x => x.Description).IsRequired();
            this.Property(x => x.Description).HasMaxLength(100);

            this.Property(x => x.ModifiedDate).IsOptional();
        }
    }
}
