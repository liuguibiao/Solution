using Microsoft.EntityFrameworkCore;
using Solution.Infrastructure.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Infrastructure.Base
{
    public class PmiBaseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SolPmi;Integrated Security=True");
        }

        public virtual DbSet<TextEntity> Text { get; set; }

        public virtual DbSet<TsetEntity> Test { get; set; }
    }
}
