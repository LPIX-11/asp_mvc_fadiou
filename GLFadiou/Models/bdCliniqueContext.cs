using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GLFadiou.Models
{
    public class bdCliniqueContext:DbContext
    {
        public bdCliniqueContext() : base("fadhiouConnexion")
        {

        }

       



        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Infirmier> Infirmiers { get; set; }
        public DbSet<Lit> Lits { get; set; }
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
    }
}