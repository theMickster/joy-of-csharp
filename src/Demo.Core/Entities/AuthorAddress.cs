using System;

namespace Demo.Pubs.Core.Entities
{
    public class AuthorAddress : BaseEntity
    {
        public AuthorAddress()
        {
        }

        public string AddressLine01 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public Author Author { get; set; }

    }
}
