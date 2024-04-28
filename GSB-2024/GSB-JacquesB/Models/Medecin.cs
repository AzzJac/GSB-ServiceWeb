using System;
using System.Collections.Generic;

namespace GSB_JacquesB.Models
{
    public partial class Medecin
    {
        public int IdMedecin { get; set; }
        public string NomMedecin { get; set; } = null!;
        public string PrenomMedecin { get; set; } = null!;
        public string AdresseMedecin { get; set; } = null!;
        public string NumTel { get; set; } = null!;
        public int IdSpecialite { get; set; }
        public string IdDepartement { get; set; } = null!;

        public virtual Departement? IdDepartementNavigation { get; set; } = null!;
        public virtual Specialite? IdSpecialiteNavigation { get; set; } = null!;
    }
}
