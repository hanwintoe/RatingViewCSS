using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RatingViewCSS.Models
{
    public class RatingData
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }

        public int OneStarCount { get; set; }
        public int OneStarTotal { get; set; }

        public int TwoStarCount { get; set; }
        public int TwoStarTotal { get; set; }

        public int ThreeStarCount { get; set; }
        public int ThreeStarTotal { get; set; }

        public int FourStarCount { get; set; }
        public int FourStarTotal { get; set; }

        public int FiveStarCount { get; set; }
        public int FiveStarTotal { get; set; }
    }
}
