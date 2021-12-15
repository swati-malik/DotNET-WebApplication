using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codeFirstApproachRelationshipApp.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title{ get; set; }
        public double Price { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
