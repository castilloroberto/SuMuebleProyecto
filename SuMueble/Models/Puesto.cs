using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("Puestos")]
    public class Puesto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public List<Colaborador> Colaboradores { get; set; }
        public override string ToString() => Nombre;
        public Puesto()
        {
            Colaboradores = new List<Colaborador>();
        }

    }
}
