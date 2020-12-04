using System;
using System.ComponentModel.DataAnnotations;

namespace App.Core.Entidades
{
    public class EntidadBase
    {
        [Key]
        public int Id { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime ActualizarFecha { get; set; }
    }
}