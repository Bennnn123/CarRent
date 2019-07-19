namespace BCTwo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")]
    public partial class Member
    {
        public int MemberID { get; set; }

        [Required]
        [Display(Name = "身分證字號")]
        public string Identity { get; set; }

        [Required]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "汽車駕照管轄編號")]
        public string LicenseNumber { get; set; }
        [Display(Name = "年齡")]
        public int Age { get; set; }
        [Display(Name = "戶籍地址")]
        public string Address { get; set; }
        [Display(Name = "通訊地址")]
        public string Address2 { get; set; }
        [Display(Name = "生日")]
        public string Birthday { get; set; }
        [Display(Name = "電子信箱")]
        public string Email { get; set; }
        [Display(Name = "家用電話")]
        public string Phone { get; set; }
        [Display(Name = "手機")]
        public string Phone2 { get; set; }
    }
}
