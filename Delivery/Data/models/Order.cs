using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введіть ім*я")]
        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "Довжина ім`я не менше ніж 5 символів")]
        public string name { get; set; }


        [Display(Name = "Введіть фамілію")]
        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "Довжина фамілії не менше ніж 2 символів")]
        public string surname { get; set; }


        [Display(Name = "Введіть адресу")]
        [StringLength(75, MinimumLength = 10)]
        [Required(ErrorMessage = "Довжина адреси не менше ніж 7 символів")]
        public string adress { get; set; }

        [Display(Name = "Введіть номер телефону")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина номера не менше ніж 10 символів")]
        public string phone { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime ordertime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
