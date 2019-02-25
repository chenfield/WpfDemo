using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WpfDemo.Entities;

namespace WpfDemo.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class EF6Context : DbContext
    {
        public EF6Context(string databaseName = "demo")
            : base(databaseName)
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DbSet<User> Users { set; get; }
    }
}
