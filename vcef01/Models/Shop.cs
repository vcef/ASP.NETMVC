using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vcef01.Models
{
    public class Shop
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "NOM")]
        public string Nom { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Distance")]
        public int Distance { get; set; }
    }
}