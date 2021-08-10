using System;
using System.Collections.Generic;

#nullable disable

namespace Cudo.Models
{
    public partial class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public int? Telefono { get; set; }
        public string Correo { get; set; }
        public int? UsuarioIdUsuario { get; set; }

        public virtual Usuario UsuarioIdUsuarioNavigation { get; set; }
    }
}
