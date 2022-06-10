using ApiOrion.DTO;
using ApiOrion.Models;
using ApiOrion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.Interfaces
{
    public interface IAddressRepository
    {
        Task<AddressViewModel> SaveAddress(Address address);
        Task<List<AddressViewModel>> GetAllAddres(Guid clientId);
        Task<AddressViewModel> GetAddressById(Guid addressId);
        Task<AddressViewModel> UpdateAddress(Address address);
        Task<AddressViewModel> DeleteAddress(Guid addressId);
    }
}
