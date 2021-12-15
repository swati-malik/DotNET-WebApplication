using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codeFirstApproachRelationshipApp.Models
{
    public class AuthorBiography
    {
        public int AuthorBiographyId{get;set;}
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
