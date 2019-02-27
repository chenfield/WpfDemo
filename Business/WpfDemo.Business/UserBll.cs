using System;
using System.Collections.Generic;
using WpfDemo.Entities;
using WpfDemo.Data;
using System.ComponentModel.Composition;

namespace WpfDemo.Business
{
    /// <summary>
    /// 用户业务类
    /// </summary>
    [Export(typeof(IUserBll)), PartCreationPolicy(CreationPolicy.Shared)]
    public class UserBll : IUserBll
    {
        /// <summary>
        /// 用户数据类接口
        /// </summary>
        [Import]
        private Lazy<IUserDal> _userDal;

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
        public int? Add(User user)
        {
            if (user == null)
                throw new Exception("不能增加空用户！");

            return _userDal.Value.Add(user);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Delete(User user)
        {
            if (user == null)
                throw new Exception("不能删除空用户！");

            return _userDal.Value.Delete(user);
        }

        /// <summary>
        /// 得到用户列表
        /// </summary>
        /// <returns></returns>
        public List<User> GetList()
        {
            return _userDal.Value.GetList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Update(User user)
        {
            if (user == null)
                throw new Exception("不能更新空用户！");

            return _userDal.Value.Update(user);
        }
    }
}
