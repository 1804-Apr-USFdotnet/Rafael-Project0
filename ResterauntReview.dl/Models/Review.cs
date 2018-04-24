using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResterauntReview.dl.Models
{
   public class Review
    {
        public int ReviewId { get; set; }
        [EmailAddress]
        public string EmailOfReviewer{ get; set; }
        public double   Rating { get; set; }
        public string  ReviewComment  { get; set; }
        [ForeignKey("ResterauntId")]
        Resteraunt  Resteraunt { get; set; }
        public int ResterauntId { get; set; }
        public DateTime DateOfReview { get; set; }
    }
}
