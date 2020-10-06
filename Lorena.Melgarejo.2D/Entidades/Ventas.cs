using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas:Producto
    {
        private List<Producto> productos;
        private DateTime fecha_factura;
        //private int cantidad;

        #region Constructores

        /// <summary>
        /// Inicializa la Lista de producto
        /// </summary>
        private Ventas()
        {
            this.productos = new List<Producto>();

        }

        /// <summary>
        /// Inicializa el atributo de Ventas
        /// </summary>
        /// <param name="productos"></param>

        public Ventas(List<Producto> productos):this()
        {
            this.productos = productos;
        }

        public Ventas(List<Producto> productos, DateTime fecha) : this(productos)
        {
            this.fecha_factura = fecha;
        }

        #endregion

        #region Propiedades

        public DateTime Fecha_factura
        {
            get
            {
                return fecha_factura;
            }
            set
            {
                fecha_factura = value;
            }
        }

        public List<Producto> Productos
        {
            get
            {
                return productos;
            }
            set
            {
                productos = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra las Ventas segun la categoria
        /// </summary>
        /// <param name="vta"></param>
        /// <param name="categ"></param>
        /// <returns></returns>

        public static string Mostrar(Ventas vta, ECategoria categ)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto prod in vta.productos)
            {
                switch (categ)
                {
                    case ECategoria.Almacen:
                        if (prod is Producto)
                        {
                            sb.AppendLine(prod.ToString());
                        }
                        break;
                    case ECategoria.Bebidas:
                        if (prod is Producto)
                        {
                            sb.AppendLine(prod.ToString());
                        }
                        break;
                    case ECategoria.Congelados:
                        if (prod is Producto)
                        {
                            sb.AppendLine(prod.ToString());
                        }
                        break;
                    case ECategoria.Frescos:
                        if (prod is Producto)
                        {
                            sb.AppendLine(prod.ToString());
                        }
                        break;
                    case ECategoria.Limpieza:
                        if (prod is Producto)
                        {
                            sb.AppendLine(prod.ToString());
                        }
                        break;
                    case ECategoria.Perfumeria:
                        if (prod is Producto)
                        {
                            sb.AppendLine(prod.ToString());
                        }
                        break;
                    default:
                        sb.AppendLine(prod.ToString());
                        break;
                }
            }

            return sb.ToString();
        }

        #endregion

    }
}
