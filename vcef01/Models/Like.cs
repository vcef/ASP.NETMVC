using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vcef01.Models
{
    public class Like
    {
        public int Id { get; set; }

        [Display(Name = "ShopId")]
        public byte ShopId { get; set; }

        [StringLength(255)]
        [Display(Name = "UserId")]
        public string UserId { get; set; }
    }
}