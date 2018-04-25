﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResterauntReview.dl.Models
{
   public  class Resteraunt
    {

        [Key]
    
        public int ResterauntId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }


        public virtual ICollection<Review> Reviews { get; set; }

        public virtual Review  reviews{ get; set; }
    }
}

