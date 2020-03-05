﻿using GoHunter.Business.Interfaces;
using GoHunter.Business.Models;
using GoHunter.Business.Models.Validations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GoHunter.Business.Services
{
    public class EmployeeService : BaseService, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IAddressRepository _addressRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, IAddressRepository addressRepository, INotifier notifier): base(notifier)
        {
            _addressRepository = addressRepository;
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Add(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employee.AddressId = Guid.NewGuid();
            employee.Address.Id = employee.AddressId.Value;

            if (!ExecuteValidation(new EmployeeValidation(), employee)
                || !ExecuteValidation(new AddressValidation(), employee.Address)) return null;

            if (_employeeRepository.Get(e=> e.Document == employee.Document).Result.Any())
            {
                Notify("There is already a employee with the document informed.");

                return null;
            }

            await _employeeRepository.Add(employee);
            return employee;

        }

        public async Task<Employee> Update(Employee employee)
        {
            if (!ExecuteValidation(new EmployeeValidation(), employee)) return null;

            if (_employeeRepository.Get(e=>e.Document == employee.Document && e.Id != employee.Id).Result.Any())
            {
                Notify("Employee does not exists.");

                return null;
            }

            await _employeeRepository.Update(employee);
            return employee;
        }

        public async Task UpdateAddress(Address address)
        {
            if (!ExecuteValidation(new AddressValidation(), address)) return;

            await _addressRepository.Update(address);
        }

        public async Task<bool> Delete(Guid id)
        {  
            if (id == null)
            {
                Notify("Employee does not exists.");
                return false;
            }

            var address = await _addressRepository.GetAddressByEmployee(id);

            await _employeeRepository.Delete(id);

            if (address != null)
            {
                await _addressRepository.Delete(address.Id);
            }

            return true;
        }

        public void Dispose()
        {
            _addressRepository?.Dispose();
            _employeeRepository?.Dispose();
        }

    }
}
