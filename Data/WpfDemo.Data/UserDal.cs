using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WpfDemo.Entities;

namespace WpfDemo.Data
{
    /// <summary>
    /// 用户数据操作类 
    /// </summary>
    public class UserDal : IUserDal
    {
        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            using (EF6Context context = new EF6Context())
            {
                context.Users.Add(new User { Name = user.Name });
                context.SaveChanges();
            }
        }

        /// <summary>
        /// 得到用户列表
        /// </summary>
        /// <returns></returns>
        public List<User> GetList()
        {
            List<User> items;

            using (EF6Context context = new EF6Context())
            {
                items = context.Set<User>().ToList();
            }

            return items;
        }
    }
}
