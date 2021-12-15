using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codeFirstApproachRelationshipApp.Models
{
    public class NovelCategory
    {
        public Novel Novel { get; set; }
        public int NovelId { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
