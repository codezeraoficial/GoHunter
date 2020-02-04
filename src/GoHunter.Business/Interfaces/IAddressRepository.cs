﻿using GoHunter.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GoHunter.Business.Interfaces
{
    public interface IAddressRepository: IRepository<Address>
    {
        Task<Address> GetAddressByEmployee(Guid employeeId);
        Task<Address> GetAddressByCompany(Guid companyId);
    }
}
