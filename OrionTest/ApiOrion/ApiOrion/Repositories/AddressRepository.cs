using ApiOrion.DTO;
using ApiOrion.Interfaces;
using ApiOrion.Models;
using ApiOrion.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly Context _context;
        public AddressRepository(Context context)
        {
            _context = context;
        }

        async Task<AddressViewModel> IAddressRepository.GetAddressById(Guid addressId)
        {
            Address address = await _context.Addresses.FirstOrDefaultAsync(address => address.AddressId == addressId).ConfigureAwait(true);

            return address.mapToView();
        }

        async Task<AddressViewModel> IAddressRepository.DeleteAddress(Guid addressId)
        {
            Address addressToDelete = await _context.Addresses.FirstOrDefaultAsync(address => address.AddressId == addressId).ConfigureAwait(true);
            _context.Addresses.Remove(addressToDelete);
            await _context.SaveChangesAsync().ConfigureAwait(true);

            return addressToDelete.mapToView();
        }

        async Task<List<AddressViewModel>> IAddressRepository.GetAllAddres(Guid clientId)
        {
            List<Address> addresses = await _context.Addresses.Where(address => address.ClientId == clientId).ToListAsync().ConfigureAwait(true);

            return addresses.Select(address => address.mapToView()).ToList();
        }

        async Task<AddressViewModel> IAddressRepository.SaveAddress(Address address)
        {
            await _context.Addresses.AddAsync(address).ConfigureAwait(true);
            await _context.SaveChangesAsync().ConfigureAwait(true);

            return address.mapToView();
        }

        async Task<AddressViewModel> IAddressRepository.UpdateAddress(Address address)
        {
            Address addressToUpdate = await _context.Addresses.FirstOrDefaultAsync(address => address.AddressId == address.AddressId).ConfigureAwait(true);

            addressToUpdate.ClientId = address.ClientId;
            addressToUpdate.Street = address.Street;
            addressToUpdate.Province = address.Province;
            addressToUpdate.PostCode = address.PostCode;
            addressToUpdate.Reference = address.Reference;

            _context.Addresses.Update(addressToUpdate);
            await _context.SaveChangesAsync().ConfigureAwait(true);

            return addressToUpdate.mapToView();
        }
    }
}
