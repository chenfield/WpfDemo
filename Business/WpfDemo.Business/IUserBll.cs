using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemo.Entities;

namespace WpfDemo.Business
{
    /// <summary>
    /// 用户业务类接口
    /// </summary>
    public interface IUserBll
    {
        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="user"></param>
        void Add(User user);

        /// <summary>
        /// 得到用户列表
        /// </summary>
        /// <returns></returns>
        List<User> GetList();
    }
}
