using System;
using System.Collections.Generic;

#nullable disable

namespace Cudo.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Contrasena { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
