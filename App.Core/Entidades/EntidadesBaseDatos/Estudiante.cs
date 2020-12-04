using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entidades.EntidadesBaseDatos
{
    public class Estudiante : EntidadBase
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public int CantAsignaturaCursada { get; set; }
        public int Cuatrimestres { get; set; }
    }
}
