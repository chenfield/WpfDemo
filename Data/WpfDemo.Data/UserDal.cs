using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WpfDemo.Entities;

namespace WpfDemo.Data
{
    public class UserDal
    {
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            var items = new List<User>();

            using (EF6Context context = new EF6Context())
            {
                items = context.Users.ToList();
            }

            return items;
        }
    }
}
