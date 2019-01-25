using Microsoft.EntityFrameworkCore;
using Solution.Infrastructure.DBContext.PmiContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Solution.Infrastructure.Base
{
    public class DbBase
    {
        public readonly PmiReadContext _pmiReadContext;
        public readonly PmiWriteContext _pmiWriteContext;
        public DbBase()
        {
            _pmiReadContext = new PmiReadContext();
            _pmiWriteContext = new PmiWriteContext();
        }

        public List<T> SqlQuery<T>(string sql) where T : class, new()
        {
            return _pmiReadContext.Database.SqlQuery<T>(sql).ToList();
        }

        public async System.Threading.Tasks.Task<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<T>> AddAsync<T>(T entity) where T : class, new()
        {
            var re = await _pmiWriteContext.Set<T>().AddAsync(entity);
            await _pmiWriteContext.SaveChangesAsync();
            return re;
        }
    }
}
