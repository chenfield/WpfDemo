using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemo.Entities;

namespace WpfDemo.Data
{
    /// <summary>
    /// 用户数据操作接口
    /// </summary>
    public interface IUserDal
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
