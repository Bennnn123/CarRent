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
        [Display(Name = "�m�W")]
        public string Name { get; set; }
        [Display(Name = "�b��")]
        public string UserName { get; set; }
        [Display(Name = "�K�X")]
        public string Password { get; set; }
        [Display(Name = "�ʧO")]
        public string Gender { get; set; }
        [Display(Name = "�~��")]
        public int Age { get; set; }
        [Display(Name = "�q�l�H�c")]
        public string Email { get; set; }
        [Display(Name = "�a�}")]
        public string Address { get; set; }
        [Display(Name = "¾��W��")]
        public string Position { get; set; }
        [Display(Name = "��¾��")]
        public string Onboard { get; set; }
        [Display(Name = "��¾��")]
        public string Offboard { get; set; }
        [Display(Name = "���A")]
        public string Status { get; set; }
    }
}
