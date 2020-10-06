using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Market
    {
        List<Empleado> miEmpleado;
        List<Cliente>  miCliente;
        List<Producto> miProducto;

        private int stock;

        #region Propiedades

        public List<Empleado> Empleados
        {
            get
            {
                return miEmpleado;
            }

            set
            {
                miEmpleado = value;
            }
        }

        public List<Cliente> MiCliente
        {
            get
            {
                return miCliente;
            }
            set
            {
                miCliente = value;
            }
        }

        public List<Producto> MiProducto
        {
            get
            {
                return miProducto;
            }
            set
            {
                miProducto = value;
            }
        }

       
        #endregion

        #region Constructores

        private Market()
        {
            this.miEmpleado = new List<Empleado>();
            this.miCliente  = new List<Cliente>();
            this.miProducto = new List<Producto>();
        }

        public Market(int stock):this()
        {
            this.stock = stock;
        }


        #endregion

        #region Metodos

        
        #endregion
    }
}
