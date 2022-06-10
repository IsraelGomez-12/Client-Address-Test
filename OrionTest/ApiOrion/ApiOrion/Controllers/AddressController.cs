using ApiOrion.DTO;
using ApiOrion.Interfaces;
using ApiOrion.Models;
using ApiOrion.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Triplex.Validations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiOrion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAddress(Guid addressId)
        {
            List<AddressViewModel> response = await _addressRepository.GetAllAddres(addressId).ConfigureAwait(true);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveAddress(AddressDTO addressDTO)
        {
            Arguments.NotNull(addressDTO, nameof(addressDTO));

            Address addressToPersistence = addressDTO.mapToPersistence();

            AddressViewModel response = await _addressRepository.SaveAddress(addressToPersistence).ConfigureAwait(true);

            return Ok(response);
        }

        [HttpPost("get-by-id")]
        public async Task<IActionResult> GetClientById(Guid addressId)
        {
            AddressViewModel response = await _addressRepository.GetAddressById(addressId).ConfigureAwait(true);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAddress(Guid addressId)
        {
            AddressViewModel response = await _addressRepository.DeleteAddress(addressId).ConfigureAwait(true);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddress(AddressDTO addressDTO)
        {
            Arguments.NotNull(addressDTO, nameof(addressDTO));

            Address addresToPersistence = addressDTO.mapToPersistence();

            AddressViewModel response = await _addressRepository.UpdateAddress(addresToPersistence).ConfigureAwait(true);

            return Ok(response);
        }
    }
}
