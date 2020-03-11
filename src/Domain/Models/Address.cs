﻿using System;

namespace Domain.Models
{
    public class Address:Entity
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Cep { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public Employee Employee { get; set; }
        public Company Company { get; set; }

    }
}
