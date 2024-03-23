using adsProyecto.Models;
using adsProyecto.Interfaces;
using System.Linq.Expressions;
using System.Linq;

namespace adsProyecto.Repositorios
{
    public class estudianteRepositorio : IEstudiante
    {
        private List<Estudiante> lstEstudiantes = new List<Estudiante>
        {
            new Estudiante { IdEstudiante = 1, 
                NombreEstudiante = "Juan",
                ApellidoEstudiante = "Perez", 
                CodigoEstudiante = "2019100001", 
                CorreoEstudiante = "jp21i04001@usonsonate.edu.sv"}
        };
        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                if(lstEstudiantes.Count > 0)
                {
                    estudiante.IdEstudiante = lstEstudiantes.Last().IdEstudiante + 1;
                }
                lstEstudiantes.Add(estudiante);
                return estudiante.IdEstudiante;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Estudiante> ConsultarEstudiantes()
        {
            try
            {
                return lstEstudiantes;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Estudiante ConsultarEstudiantePorID(int idEstudiante)
        {
            try
            {
                Estudiante estudiante  = lstEstudiantes.FirstOrDefault(temp => temp.IdEstudiante == idEstudiante);
                return estudiante; 
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            try
            {
                int index = lstEstudiantes.FindIndex(temp => temp.IdEstudiante == idEstudiante);
                lstEstudiantes.RemoveAt(index);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int ModificarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try
            {
                int index = lstEstudiantes.FindIndex(temp => temp.IdEstudiante == idEstudiante);
                lstEstudiantes[index] = estudiante;
                return estudiante.IdEstudiante;
            }catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
