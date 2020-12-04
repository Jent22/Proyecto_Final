using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entidades.EntidadesBaseDatos
{ 
    public class Asignatura : EntidadBase
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int CosteCredito { get; set; }
        public string PreRequisitos { get; set; }
    }
}
