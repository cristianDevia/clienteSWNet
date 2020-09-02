using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteProyectoSWNet.model
{
    class ServicioUniversidad
    {
        //--------------------------------Singleton-------------------------------------------------------

        private static ServicioProyectoUniversidadSW.ServicioUniversidadSWClient servicio;

        private ServicioUniversidad()
        {
            
        }

        public static ServicioProyectoUniversidadSW.ServicioUniversidadSWClient getServicio()
        {
            if (servicio == null)
            {
                return new ServicioProyectoUniversidadSW.ServicioUniversidadSWClient();
            }
            else
            {
                return servicio;
            }
        }

        //---------------------------------Servicio Estudiante---------------------------------------------

        public static void agregarEstudiante(ServicioProyectoUniversidadSW.estudiante estu)
        {
            getServicio().anadirEstudiante(estu);
            
        }

        public static ServicioProyectoUniversidadSW.estudiante buscarEstudiante( String codigo )
        {
            return getServicio().buscarEstudiantePorCodigo(codigo);
        }

        public static void actualizarEstudiante(String nombre, int cedula, String codigo, String correo, int celular, DateTime fechaNacimiento, String genero)
        {
             getServicio().actualizarEstudiantePorCodigo(nombre, cedula, codigo, correo, celular, fechaNacimiento, genero);
        }

        public static void eliminarEstudiante(string codigo)
        {
            getServicio().eliminarPorCodigoEstudiante(codigo);
        }

        public static ServicioProyectoUniversidadSW.estudiante[] listarEstudiantes()
        {
            return getServicio().getEstudiantes();
        }

        //---------------------------------Servicio Matricula---------------------------------------------------------


        public static void agregarMatricula(ServicioProyectoUniversidadSW.matricula mat)
        {
            getServicio().anadirMatricula(mat);
        }

        public static ServicioProyectoUniversidadSW.matricula buscarMatricula(String codigo)
        {
            return getServicio().buscarMatricula(codigo);
        }

        public static void actualizarMatricula(int numMat, int numCre, DateTime fechaMat, double valor, double ppa)
        {
            getServicio().actualizarMatricula(numMat,numCre,fechaMat,valor,ppa);
        }

        public static void eliminarMatricula(string numMat)
        {
            getServicio().eliminarPorNumeroMatricula(numMat);
        }

        public static ServicioProyectoUniversidadSW.matricula[] listarMatriculas()
        {
            return getServicio().getMatriculas();
        }

        public static ServicioProyectoUniversidadSW.programaAcademico[] listarProgramas()
        {
            return getServicio().getProgramas();
        }


    }
}
