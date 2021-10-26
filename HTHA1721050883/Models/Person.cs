using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HTHA1721050883.Models
{
    public class Person
    {
        [StringLength(20)]
        [Display(Name = "ID")]
        [Key]
        public string PersonID { get; set; }

        [StringLength(50)]
        [Display(Name = "Họ Và Tên")]

        public string PersonName { get; set; }
    }
}