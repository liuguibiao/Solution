using Microsoft.EntityFrameworkCore;
using Solution.Infrastructure.Base;
using Solution.Infrastructure.Entitys;

namespace Solution.Infrastructure.DBContext.PmiContext
{
    public class PmiWriteContext : PmiBaseDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SolPmi;Integrated Security=True");
        }
    }
}
