using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BCTwo.Models
{
    public class MemberIndexView
    {
        public int MemberID { set; get; }

        [Display(Name = "身分證字號")]
        public string Identity { set; get; }

        [Display(Name = "會員姓名")]
        public string Name { set; get; }

        [Display(Name = "年齡")]
        public int Age { set; get; }

        [Display(Name = "汽車駕照管轄編號")]
        public string LicenseNumber { set; get; }

        [Display(Name = "電子信箱")]
        public string Email { set; get; }
    }
}