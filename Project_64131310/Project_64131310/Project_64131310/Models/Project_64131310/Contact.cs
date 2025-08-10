using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebBanHangOnline.Models;

namespace Project_64131310.Models.Project_64131310
{
    [Table("tb_Contact")]
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        public string Name { get; set; }
        
        public string Website { get; set; }
        
        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}