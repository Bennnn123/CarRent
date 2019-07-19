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
        [Display(Name = "�����Ҧr��")]
        public string Identity { get; set; }

        [Required]
        [Display(Name = "�K�X")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "�m�W")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "�T���r�Ӻ��ҽs��")]
        public string LicenseNumber { get; set; }
        [Display(Name = "�~��")]
        public int Age { get; set; }
        [Display(Name = "���y�a�}")]
        public string Address { get; set; }
        [Display(Name = "�q�T�a�}")]
        public string Address2 { get; set; }
        [Display(Name = "�ͤ�")]
        public string Birthday { get; set; }
        [Display(Name = "�q�l�H�c")]
        public string Email { get; set; }
        [Display(Name = "�a�ιq��")]
        public string Phone { get; set; }
        [Display(Name = "���")]
        public string Phone2 { get; set; }
    }
}
