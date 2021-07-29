using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models.Contacts
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string BarberName { get; set; }
        [Required]
        public string BarberShopName { get; set; }

        [RegularExpression(@"^(\s*)?(\+)?([- _():=+]?\d[- _():=+]?){10,14}(\s*)?$")]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string TimeWork { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
