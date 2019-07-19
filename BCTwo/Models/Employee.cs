namespace BCTwo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int ID { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "帳號")]
        public string UserName { get; set; }
        [Display(Name = "密碼")]
        public string Password { get; set; }
        [Display(Name = "性別")]
        public string Gender { get; set; }
        [Display(Name = "年齡")]
        public int Age { get; set; }
        [Display(Name = "電子信箱")]
        public string Email { get; set; }
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Display(Name = "職位名稱")]
        public string Position { get; set; }
        [Display(Name = "到職日")]
        public string Onboard { get; set; }
        [Display(Name = "離職日")]
        public string Offboard { get; set; }
        [Display(Name = "狀態")]
        public string Status { get; set; }
    }
}
