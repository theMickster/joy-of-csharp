using System;
using System.Collections.Generic;

namespace Demo.Pubs.Core.Entities
{
    public class Publisher : BaseEntity
    {
        public Publisher()
        {
        }

        public int PublisherNumber { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
