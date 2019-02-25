﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel.Composition;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemo.UI.User
{
    /// <summary>
    /// 用户列表页
    /// </summary>
    [Export(typeof(IUserListView))]
    public partial class UserListView : UserControl, IUserListView
    {
        public UserListView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户操作类
        /// </summary>
        public IUserListViewModel ViewModel
        {
            get { return DataContext as IUserListViewModel; }
            set { DataContext = value; }
        }
    }
}
