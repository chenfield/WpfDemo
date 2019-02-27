using System.Collections.Generic;
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
        int? Add(User user);

        /// <summary>
        /// 得到用户列表
        /// </summary>
        /// <returns></returns>
        List<User> GetList();

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="user"></param>
        int Update(User user);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="user"></param>
        int Delete(User user);
    }
}
