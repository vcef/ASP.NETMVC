using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vcef01.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "CIN")]
        public string Cin { get; set; }

        [Required]
        [Display(Name = "Sexe")]
        public string Sexe { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "NOM")]
        public string Nom { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "PRENOM")]
        public string Prenom { get; set; }

        [Required]
        [Phone]
        [StringLength(250)]
        [Display(Name = "Telephone")]
        public string Telephone { get; set; }

        [Required]
        [Display(Name = "Date de naissance")]
        public String DateNaissance { get; set; }

        [Required]
        [StringLength(400)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Ville")]
        public string Ville { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public DateTime Date { get; set; }
    }
}