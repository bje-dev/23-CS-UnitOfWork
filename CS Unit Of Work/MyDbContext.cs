using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNITOFWORK_AND_REPOSITORY_PATTERN.Entities;

namespace CS_Unit_Of_Work
{
    public class MyDbContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public MyDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
    }
}
