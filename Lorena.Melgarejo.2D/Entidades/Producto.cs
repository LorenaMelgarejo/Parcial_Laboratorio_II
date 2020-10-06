using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string marca;
        private string descripcion;
        private string codigo;
        private float precio;
        private int cantidad;
        private ECategoria categoria;


        #region Propiedades 

        public string Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }

        public ECategoria Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public string Marca
        {
            set { this.marca = value; }
            get { return this.marca; }
        }


        public string Descripcion
        {
            set { this.descripcion = value; }
            get { return this.descripcion; }
        }

        public float Precio
        {
            set { this.precio= value; }
            get { return this.precio; }
        }

        public int Cantidad
        {
            set { this.cantidad = value; }
            get { return this.cantidad; }
        }

        #endregion

        #region Constructores

        public Producto()
        { }

        /// <summary>
        /// Inicializa los atributos de Producto
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="categoria"></param>
        /// <param name="marca"></param>
        /// <param name="descripcion"></param>
        
        public Producto(string codigo,ECategoria categoria,string marca, string descripcion)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.descripcion = descripcion;
            this.categoria = categoria;
            //this.precio = precio;
            //this.cantidad = cantidad;

        }

        /// <summary>
        /// Sobrecarga del contructor Producto
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="categoria"></param>
        /// <param name="marca"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        
        public Producto(string codigo, ECategoria categoria, string marca, string descripcion, float precio, int cantidad) : this(codigo, categoria, marca, descripcion)
        {
            this.precio = precio;
            this.cantidad = cantidad;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Compara si dos productos son iguales,
        /// si coinciden Marca y Código
        /// </summary>
        /// <param name="prodUno"></param>
        /// <param name="prodDos"></param>
        /// <returns></returns>

        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            if (prodUno.codigo == prodDos.codigo && prodUno.marca == prodDos.marca)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="prodUno"></param>
        /// <param name="prodDos"></param>
        /// <returns></returns>
        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno==prodDos);
        }

        /// <summary>
        /// Muestra los Datos de Producto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo: " + this.codigo);
            sb.AppendLine("Categoria: " + this.categoria);
            sb.AppendLine("Marca: " + this.marca);
            sb.AppendLine("Descripcion: " + this.descripcion);
            sb.AppendLine("Precio: " + this.precio);
            sb.AppendLine("Marca: " + this.marca);
            sb.AppendLine("Cantidad: " + this.Cantidad);
            return sb.ToString();

        }

        #endregion

    }
}
