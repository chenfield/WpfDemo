using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfDemo.Entities
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    [Table("User")]
    public class User
    {
        [Key]
        public Int64 Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [StringLength(30)]
        public string Name { get; set; }
    }
}
