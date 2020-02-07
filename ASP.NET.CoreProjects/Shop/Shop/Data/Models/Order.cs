using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введіть імя")]
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина імені не менше 5 символів")]
        public string name { get; set; }

        [Display(Name = "Введіть прізвище")]
        [StringLength(30)]
        [Required(ErrorMessage = "Довжина прізвища не менше 5 символів")]
        public string surname { get; set; }

        [Display(Name = "Введіть адресу")]
        [StringLength(40)]
        [Required(ErrorMessage = "Довжина адреси не менше 20 символів")]
        public string adress { get; set; }

        [Display(Name = "Введіть телефон")]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина телефону не менше 5 символів")]
        public string phone { get; set; }

        [Display(Name = "Введіть емеіл")]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина емейлу не менше 10 символів")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [BindNever]
        public DateTime orderTime { get; set; }
        [BindNever]
        public List<OrderDetail> orderDetails { get; set; }
    }
}
