using ApiOrion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.Models
{
    public class Client
    {
        public Guid ClientId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;

        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        public ApiOrion.ViewModel.ClientViewModel mapToView()
        {
            ICollection<AddressViewModel> listAddress = Addresses.Select(address => address.mapToView()).ToList();

            return new ApiOrion.ViewModel.ClientViewModel
            {
                ClientId = ClientId,
                Name = Name,
                Addresses = listAddress
            };
        }
    }
}
