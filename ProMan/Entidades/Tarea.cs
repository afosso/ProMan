using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan.Entidades
{
    public class Tarea
    {
        public int IdTarea { get; set; }
        public int IdColaborador { get; set; }
        public int IdProyecto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
