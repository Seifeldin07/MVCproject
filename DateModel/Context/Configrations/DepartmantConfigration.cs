using CompanyDate.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDate.Context.Configrations
{
    public class DepartmantConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn(10, 10);
            builder.HasIndex(x=>x.Name).IsUnique();
        }
    }
}
