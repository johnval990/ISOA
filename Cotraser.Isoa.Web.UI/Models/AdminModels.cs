using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace Cotraser.Isoa.Web.UI.Models
{
    public class UserDetailModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Identificación")]
        public string Identification { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string userMail { get; set; }

        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string userState { get; set; }

        [Required]
        [Display(Name = "Perfiles")]
        public string userProfiles { get; set; }

        [Required]
        [Display(Name = "Areas")]
        public string userAreas { get; set; }
    }
}