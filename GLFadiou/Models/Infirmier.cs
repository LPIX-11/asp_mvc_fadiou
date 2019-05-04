using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GLFadiou.Models
{
    public class Infirmier
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idInf { get; set; }

        [ForeignKey("idInf")]
        public virtual Personne personne { get; set; }

        [MaxLength(80, ErrorMessage = "Taille maximale dépassée"), Required(ErrorMessage = "*")]
        [Display(Name = "Spécialité")]
        public string specialiteInf { get; set; }
    }
}