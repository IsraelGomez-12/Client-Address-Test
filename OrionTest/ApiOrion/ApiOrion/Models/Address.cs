using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.Models
{
    public class Address
    {
        public Guid AddressId { get; set; } = Guid.Empty;
        public Guid ClientId { get; set; } = Guid.Empty;
        public string Street { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;

        public ApiOrion.ViewModel.AddressViewModel mapToView()
        {
            return new ApiOrion.ViewModel.AddressViewModel
            {
                AddressId = AddressId,
                ClientId = ClientId,
                Street = Street,
                Province = Province,
                PostCode = PostCode,
                Reference = Reference
            };
        }
    }
}
