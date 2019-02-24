using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WpfDemo.Entities
{
    //[Table("User")]
    public class User
    {
        public enum TestENUM : long { A, B, C };

        [Key]//, DatabaseGenerated(DatabaseGeneratedOption.Identity)
        public Int64 Id { get; set; }

        //[StringLength(30)]
        public string Name { get; set; }
    }
}
