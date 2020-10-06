using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Persona
    {
        private int legajo;

        #region Constructores

        /// <summary>
        /// Inicializa los atributos de Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="direccion"></param>
        /// <param name="legajo"></param>

        public Empleado(string nombre, string apellido, int dni, string direccion, int legajo):base(nombre, apellido, dni, direccion)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Muestra los datos de Empleado
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Email: " + this.legajo);
            return sb.ToString();
        }

        /// <summary>
        /// Dos Empleados seran iguales si 
        /// el Legajo y el Dni coinciden
        /// </summary>
        /// <param name="empleadoUno"></param>
        /// <param name="empleadoDos"></param>
        /// <returns></returns>

        public static bool operator ==(Empleado empleadoUno, Empleado empleadoDos)
        {
            if (empleadoUno.legajo == empleadoDos.legajo && empleadoUno.DNI == empleadoDos.DNI)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del Operador ==
        /// </summary>
        /// <param name="empleadoUno"></param>
        /// <param name="empleadoDos"></param>
        /// <returns></returns>

        public static bool operator !=(Empleado empleadoUno, Empleado empleadoDos)
        {
            return !(empleadoUno == empleadoDos);
        }

        #endregion

    }
}
