using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        private string email;
        private int id;


        #region Constructores

        
        /// <summary>
        /// Inicializa los atributos de Cliente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="direccion"></param>
        /// <param name="id"></param>
        /// <param name="email"></param>

        public Cliente(string nombre, string apellido, int dni, string direccion,int id,string email):base(nombre,apellido,dni,direccion)
        {
            this.id = id;
            this.email = email;
        }


        #endregion

        #region Propiedades

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Muestra los datos de Cliente
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Email: " + this.email);
            sb.AppendLine("Id: " + this.id);
            return sb.ToString();
        }

        /// <summary>
        /// Compara si dos Clientes son iguales 
        /// si el Dni y el Id son iguales
        /// </summary>
        /// <param name="clienteUno"></param>
        /// <param name="clienteDos"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente clienteUno, Cliente clienteDos)
        {
            if (clienteUno.id == clienteDos.id && clienteUno.DNI == clienteDos.DNI)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// sobrecarga del Operador ==
        /// </summary>
        /// <param name="clienteUno"></param>
        /// <param name="clienteDos"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente clienteUno, Cliente clienteDos)
        {
            return !(clienteUno == clienteDos);
        }

        public static implicit operator string(Cliente auxCliente)
        {

            return auxCliente.Nombre;
        }

        #endregion
    }
}
