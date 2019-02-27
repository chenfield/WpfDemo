using System.Data.Entity;
using WpfDemo.Entities;

namespace WpfDemo.Data
{
    /// <summary>
    /// EF 控制类
    /// </summary>
    public class EF6Context : DbContext
    {
        /// <summary>
        /// 初始化连接数据库
        /// </summary>
        /// <param name="databaseName"></param>
        public EF6Context(string databaseName = "demo")
            : base(databaseName)
        {
        }
        
        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<User> Users { set; get; }
    }
}
