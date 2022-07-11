using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingViewCSS.Models
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int TotalCount { get; set; }
        public int VoteTotal { get; set; }

   
        public int OneCount { get; set; }
        public int OneTotal { get; set; }

        public int TwoCount { get; set; }
        public int TwoTotal { get; set; }

        public int ThrCount { get; set; }
        public int ThrTotal { get; set; }

        public int FouCount { get; set; }
        public int FouTotal { get; set; }

        public int FivCount { get; set; }
        public int FivTotal { get; set; }
    }
}
