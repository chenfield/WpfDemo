using System.Collections.Generic;
using Dapper;
using WpfDemo.Entities;
using System.ComponentModel.Composition;

namespace WpfDemo.Data
{
    /// <summary>
    /// 用户数据操作类 
    /// </summary>
    [Export(typeof(IUserDal)), PartCreationPolicy(CreationPolicy.Shared)]
    public class UserDal : IUserDal
    {
        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="user"></param>
        public int? Add(User user)
        {
            int? result;

            using (var connection = Connectionobj.GetOpenConnection())
            {
                result = connection.Insert(user);
            }

            return result;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="user"></param>
        public int Delete(User user)
        {
            int result;

            using (var connection = Connectionobj.GetOpenConnection())
            {
               result =  connection.Delete(user);
            }

            return result;
        }

        /// <summary>
        /// 得到用户列表
        /// </summary>
        /// <returns></returns>
        public List<User> GetList()
        {
            List<User> items;

            using (var connection = Connectionobj.GetOpenConnection())
            {
                items = connection.GetList<User>(new { }).AsList();
            }

            return items;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="user"></param>
        public int Update(User user)
        {
            int result;

            using (var connection = Connectionobj.GetOpenConnection())
            {
                result = connection.Update(user);
            }

            return result;
        }
    }
}
