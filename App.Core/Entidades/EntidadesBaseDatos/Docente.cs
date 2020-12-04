using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entidades.EntidadesBaseDatos
{
    public class Docente : EntidadBase
    {
        public string Nombre { get; set; }
        public int Salario { get; set; }
        public int IdAsignaturaAsignada { get; set; }
        public string Aula { get; set; }
    }
}
