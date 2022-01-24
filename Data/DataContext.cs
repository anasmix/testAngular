using Microsoft.EntityFrameworkCore;
using testSqlLite.Models;

namespace testSqlLite.Data
{
    public class DataContext :DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) :base (options){} 
         public DbSet<Users> User { get; set; }
 

    }
}