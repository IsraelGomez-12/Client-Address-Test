using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.ViewModel
{
    public class AddressViewModel
    {
        public Guid AddressId { get; set; } = Guid.Empty;
        public Guid ClientId { get; set; } = Guid.Empty;
        public string Street { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;
    }
}
