using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HTHA1721050883.Models
{
    public class Student:Person
    {
        [StringLength(50)]
        [Display(Name = "Trường đại học")]

        public string University { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ")]

        public string Address { get; set; }
    }
}
