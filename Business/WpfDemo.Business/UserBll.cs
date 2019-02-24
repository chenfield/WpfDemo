using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemo.Entities;
using WpfDemo.Data;

namespace WpfDemo.Business
{
    public class UserBll
    {
        UserDal dal = new UserDal();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            dal.Add(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return dal.GetUsers();
        }
    }
}
