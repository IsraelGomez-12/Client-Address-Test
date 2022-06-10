using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.DTO
{
    public class AddressDTO
    {
        public Guid AddressId { get; set; } = Guid.Empty;
        public Guid ClientId { get; set; } = Guid.Empty;
        public string Street { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;

        public ApiOrion.Models.Address mapToPersistence()
        {
            Guid localId = AddressId.Equals(Guid.Empty) ? Guid.NewGuid() : AddressId;

            return new ApiOrion.Models.Address { 
                AddressId= localId,
                ClientId = ClientId,
                Street =Street,
                Province = Province,
                PostCode = PostCode,
                Reference = Reference
            };
        }
    }
}
