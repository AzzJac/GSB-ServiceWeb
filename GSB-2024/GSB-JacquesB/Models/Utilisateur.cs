using System;
using System.Collections.Generic;

namespace GSB_JacquesB.Models
{
    public partial class Utilisateur
    {
        public int IdUtilisateur { get; set; }
        public string LoginUtilisateur { get; set; } = null!;
        public string MotDePasseUtilisateur { get; set; } = null!;
    }
}
