using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ProyectoFinal.Model
{
    public class ClaseAlumno
    {
        public int AlumnoId { get; set; }
        public int ClaseId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Clase Clase { get; set; }
    }
}
