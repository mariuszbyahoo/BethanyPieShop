using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Model
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        [Required(ErrorMessage ="Enter ur name")]
        [Display(Name ="First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Enter ur Last name")]
        [Display(Name ="Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Enter ur adress")]
        [StringLength(100)]
        [Display(Name ="Adress Line 1")]
        public string AdressLine1 { get; set; }
        [Display(Name ="Adress Line 2")]
        public string AdressLine2 { get; set; }
        [Required(ErrorMessage ="Enter ZipCode")]
        [StringLength(10)]
        [Display(Name ="Zip Code")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage ="Enter City")]
        [StringLength(50)]
        [Display(Name ="City")]
        public string City { get; set; }
        public string State { get; set; }
        [Required(ErrorMessage = "Enter ur Country")]
        [StringLength(50)]
        [Display(Name ="Country")]
        public string Country { get; set; }

        [Required(ErrorMessage ="Enter ur phone")]
        [StringLength(12)]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Enter ur email")]
        [StringLength(40)]
        [Display(Name ="Email")]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
