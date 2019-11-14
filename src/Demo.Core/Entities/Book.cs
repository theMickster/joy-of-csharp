using System;
using System.Collections.Generic;

namespace Demo.Pubs.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book()
        {
        }

        public int TitleNumber { get; set; }

        public string TitleCode { get; set; }

        public string Title { get; set; }

        public string TitleType { get; set; }

        public string PublisherCode { get; set; }

        public decimal Price { get; set; }

        public string PublishYear { get; set; }

        public DateTime PublishedDate { get; set; }

        public Publisher Publisher { get; set; }

        public ICollection<Author> Authors { get; set; }

    }
}
