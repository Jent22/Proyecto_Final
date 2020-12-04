
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entidades
{
    public class Usuario: IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
