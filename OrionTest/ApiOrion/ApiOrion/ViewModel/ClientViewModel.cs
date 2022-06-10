using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.ViewModel
{
    public class ClientViewModel
    {
        public Guid ClientId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;

        public ICollection<AddressViewModel> Addresses { get; set; } = new List<AddressViewModel>();
    }
}
