using System;
using System.Collections.ObjectModel;

namespace FrontOrion.DTO
{
    public class ClientModel
    {
        public Guid Id { get; set; } = Guid.Empty;

        public string Name { get; set; } = string.Empty;

        public Collection<AddressModel> Addresses { get; set; } = new Collection<AddressModel>();
    }
}

