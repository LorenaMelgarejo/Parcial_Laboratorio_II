using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
       private string nombre;
       private string apellido;
       private int dni;
       private string direccion;


        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre =value;
            }
        }


        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {

                this.apellido = value;
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {

                this.apellido = direccion;
            }
        }


        #endregion

        #region Constructores

        /// <summary>
        /// Inicializa los atributos de Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="direccion"></param>

        public Persona(string nombre, string apellido,int dni,string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los Datos de Persona
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre : " + this.apellido);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("DNI: " + this.dni);
            sb.AppendLine("Direccion: " + this.direccion);
            return sb.ToString();
        }

        #endregion

    }
}
