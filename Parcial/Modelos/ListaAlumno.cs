using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Modelos
{
    public class ListaAlumno
    {
        public List<Alumno> listaAlumno = new List<Alumno>();

        public void agregarAlumno(Alumno nuevoAlumno)
        {
            listaAlumno.Add(nuevoAlumno);
            return;
        }
        public List<Alumno> ObtenerLista()
        {
            return listaAlumno;
        }
        public Alumno BuscarAlumno(int nroLegajo)
        {
            Alumno encontrado = listaAlumno.Find(a => a.NroLegajo == nroLegajo);
            return encontrado;
        }

        public void DarBeca(int nroLegajo)
        {
            Alumno encontrado = listaAlumno.Find(a => a.NroLegajo == nroLegajo);
            encontrado.Becado = true;
        }
    }
}
