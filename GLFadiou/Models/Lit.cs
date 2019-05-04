using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GLFadiou.Models
{
    public class Lit
    {
        [Key]
        public int idLit { get; set; }

        [MaxLength(2, ErrorMessage = "Taille maximale dépassée"), Required(ErrorMessage = "*")]
        [Display(Name = "CodeLit")]
        public string codeLit { get; set; }


        public int idChambre { get; set; }

        [ForeignKey("idChambre")]
        public virtual Chambre chamre { get; set; }
    }
}