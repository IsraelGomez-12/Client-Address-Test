using System;

namespace  FrontOrion.DTO
{
    public class AddressModel
    {
        public Guid Id { get; set; } = Guid.Empty;

        public Guid ClientId { get; set; } = Guid.Empty;

        public string Street { get; set; } = string.Empty;

        public string Province { get; set; } = string.Empty;

        public string PostCode { get; set; } = string.Empty;

        public string Reference { get; set; } = string.Empty;
    }
}
    
