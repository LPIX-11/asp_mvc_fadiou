using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GLFadiou.Models
{
    public class Chambre
    {
        [Key]
        public int idCh { get; set; }

        [MaxLength(2, ErrorMessage = "Taille maximale dépassée"), Required(ErrorMessage = "*")]
        [Display(Name = "CodeCh")]
        public string codeCh { get; set; }

        [MaxLength(80, ErrorMessage = "Taille maximale dépassée"), Required(ErrorMessage = "*")]
        [Display(Name = "Libelle")]
        public string libelle { get; set; }
    }
}