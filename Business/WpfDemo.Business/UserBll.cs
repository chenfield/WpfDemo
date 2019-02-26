using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemo.Entities;
using WpfDemo.Data;
using System.ComponentModel.Composition;

namespace WpfDemo.Business
{
    /// <summary>
    /// 用户业务类
    /// </summary>
    [Export(typeof(IUserBll))]
    public class UserBll : IUserBll
    {
        /// <summary>
        /// 用户数据类接口
        /// </summary>
        [Import]
        private IUserDal _userDal;

        ///// <summary>
        ///// 用户业务类初始化
        ///// </summary>
        ///// <param name="userDal"></param>

        //[ImportingConstructor]
        //public UserBll(IUserDal userDal)
        //{
        //    _userDal = userDal;
        //}

        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        /// <summary>
        /// 得到用户列表
        /// </summary>
        /// <returns></returns>
        public List<User> GetList()
        {
            return _userDal.GetList();
        }
    }
}
