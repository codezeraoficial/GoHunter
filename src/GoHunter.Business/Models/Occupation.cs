﻿using System;

namespace GoHunter.Business.Models
{
    public class Occupation : Entity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }


        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid JobOfferId { get; set; }
        public JobOffer JobOffer { get; set; }

    }
}