using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BCTwo.Models
{
    public class EmployeeIndexView
    {
        public int ID { set; get; }


        [Display(Name = "員工姓名")]
        public string Name { set; get; }


        [Display(Name = "帳號")]
        public string UserName { set; get; }


        [Display(Name = "電子郵件")]
        public string Email { set; get; }


        [Display(Name = "職稱")]
        public string Position { set; get; }


        [Display(Name = "狀態")]
        public string Status { set; get; }
    }
}