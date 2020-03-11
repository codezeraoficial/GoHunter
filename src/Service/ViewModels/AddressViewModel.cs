﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Service.ViewModels
{
    public class AddressViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(200, ErrorMessage = "The field {0} must have between {2} and {1} characteres", MinimumLength = 2)]
        public string Street { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50, ErrorMessage = "The field {0} must have between {2} and {1} characteres", MinimumLength = 1)]
        public string Number { get; set; }

        public string Complement { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(8, ErrorMessage = "The field {0} must have between {2} and {1} characteres", MinimumLength = 8)]
        public string Cep { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} must have between {2} and {1} characteres", MinimumLength = 2)]
        public string Neighborhood { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} must have between {2} and {1} charactres", MinimumLength = 2)]
        public string City { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} must have between {2} and {1} charactres", MinimumLength = 2)]
        public string Country { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50, ErrorMessage = "The field {0} must have between {2} and {1} charactres", MinimumLength = 2)]
        public string State { get; set; }

          
    }
}
