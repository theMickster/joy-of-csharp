using System;
using System.Collections.Generic;

namespace Demo.Pubs.Core.Entities
{
    public class Author : BaseEntity
    {
        public Author()
        {
        }

        public int AuthorNumber { get; set; }

        public string Code { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public AuthorAddress Address { get; set; }

    }
}
