using System;
using System.Collections.Generic;

namespace GSB_JacquesB.Models
{
    public partial class Specialite
    {
        public Specialite()
        {
            Medecins = new HashSet<Medecin>();
        }

        public int IdSpecialite { get; set; }
        public string NomSpecialite { get; set; } = null!;

        public virtual ICollection<Medecin> Medecins { get; set; }
    }
}
