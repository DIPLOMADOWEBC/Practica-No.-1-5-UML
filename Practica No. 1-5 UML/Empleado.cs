using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_No._1_5_UML
{
    public class Empleado:Persona
    {
        public decimal Sueldo { get; set; }
        public DateTime Horario { get; set; }
        public string Puesto { get; set; }
        public string Seguro { get; set; }
    }
}
