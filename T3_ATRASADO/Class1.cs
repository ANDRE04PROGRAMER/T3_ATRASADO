using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_ATRASADO
{
    public class Estudiante
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string universidad { get; set; }
        public override string? ToString()
        {
            return $"Codigo {codigo}, Nombre {nombre}, Universidad {universidad}";
        }
    }
    public class Cita
    {
        public int numero { get; set; }
        public Estudiante estudiante { get; set; }
        public string enfermedad { get; set; }
        public double precio { get; set; }
        public override string? ToString()
        {
            return $"Cita N°: {numero}\nEstudiante: {estudiante.nombre}\nEnfermedad :{enfermedad}\nPrecio :{precio}";
        }
    }
}