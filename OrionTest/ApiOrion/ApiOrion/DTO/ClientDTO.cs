using ApiOrion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.DTO
{
    public class ClientDTO
    {
        public Guid ClientId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;

        public ICollection<AddressDTO> AddressesDTO { get; set; } = new List<AddressDTO>();

        public ApiOrion.Models.Client mapToPersistence()
        {
            IEnumerable<Address> Addresses = AddressesDTO.Select(address => address.mapToPersistence());

            return new ApiOrion.Models.Client
            {
                ClientId = ClientId,
                Name = Name,
                Addresses = Addresses.ToList()
            };
        }
    }
}
