using Microsoft.EntityFrameworkCore;
using Solution.Infrastructure.Base;
using Solution.Infrastructure.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solution.Infrastructure.DBContext.PmiContext
{
    public class PmiReadContext : PmiBaseDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SolPmiRead1;Integrated Security=True");
        }

        public override int SaveChanges()
        {
            throw new InvalidOperationException("只读数据库,不允许写入");
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            throw new InvalidOperationException("只读数据库,不允许写入");
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new InvalidOperationException("只读数据库,不允许写入");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new InvalidOperationException("只读数据库,不允许写入");
        }
    }
}
