using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FrmPrincipal : Form
    {

        List<Producto> listaProductos;
        List<Cliente> listaCliente;
        List<Empleado> listaEmpleados;

        public FrmPrincipal()
        {
            InitializeComponent();
            listaProductos = new List<Producto>();
            listaCliente = new List<Cliente>();
            listaEmpleados = new List<Empleado>();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {          
            CargarProd();
        }

        public void CargarProd()
        {
            listaProductos.Add(new Producto("123", ECategoria.Almacen,"Pureza", "Harina 000 1Kg", 47, 50));
            listaProductos.Add(new Producto("124", ECategoria.Almacen,"La Virginia", "Té  25u", 62, 50));
            listaProductos.Add(new Producto("125", ECategoria.Almacen,"Dolca", "Café 170 gr", 200, 50));
            listaProductos.Add(new Producto("126", ECategoria.Almacen,"Natura", "Mayonesa 475 gr", 90, 50));
            listaProductos.Add(new Producto("127", ECategoria.Almacen,"Molinos", "Arroz 1kg", 55, 50));
            listaProductos.Add(new Producto("128", ECategoria.Bebidas,"Coca Cola", "Gaseosa 1Lt", 150, 50));
            listaProductos.Add(new Producto("129", ECategoria.Bebidas,"Sprite", "Gaseosa 1Lt", 109, 50));
            listaProductos.Add(new Producto("130", ECategoria.Bebidas,"Seven UP", "Gaseosa 1Lt", 105, 50));
            listaProductos.Add(new Producto("131", ECategoria.Bebidas,"Fanta", "Gaseosa 1Lt", 150, 50));
            listaProductos.Add(new Producto("132", ECategoria.Bebidas,"Citric", "Jugo Ttb 1Lt", 170, 50));
            listaProductos.Add(new Producto("100", ECategoria.Congelados,"Paty","Hamburguesa 4u",210,20));
            listaProductos.Add(new Producto("101", ECategoria.Congelados,"Swift","Hamburguesa 4u",176,10));
            listaProductos.Add(new Producto("102", ECategoria.Congelados,"Frigor","Helado 150gr",280,10));
            listaProductos.Add(new Producto("103", ECategoria.Congelados,"Frigor","Helado 300gr",600,5));
            listaProductos.Add(new Producto("104", ECategoria.Congelados,"Freddo","Helado 150gr",300,5));
            listaProductos.Add(new Producto("110", ECategoria.Frescos,"Serenisima","Leche Ent. 1Lt",35,6));
            listaProductos.Add(new Producto("111", ECategoria.Frescos,"Sancor","Yogurt descremado 1 Lt",80,20));
            listaProductos.Add(new Producto("112", ECategoria.Frescos,"Armonia","Leche Larga vida 1Lt",45,20));
            listaProductos.Add(new Producto("113", ECategoria.Frescos,"Ilolay","Manteca 200 Gr",125,6));
            listaProductos.Add(new Producto("114", ECategoria.Frescos,"Veronica","Manteca 100 Gr",82,6));
            listaProductos.Add(new Producto("130", ECategoria.Limpieza,"Skip","Jabón Liq. 3L",520,6));
            listaProductos.Add(new Producto("132", ECategoria.Limpieza,"Ala","Jabón Liq. 3L",422,6));
            listaProductos.Add(new Producto("133", ECategoria.Limpieza,"Ayudin","Lavandina 1lt",92,6));
            listaProductos.Add(new Producto("134", ECategoria.Limpieza,"Querubin","Lavandina 1lt",56,6));
            listaProductos.Add(new Producto("135", ECategoria.Limpieza,"Vivere","Suavizante 900 ml",122,6));
            listaProductos.Add(new Producto("140", ECategoria.Perfumeria,"Dove","Shampoo 400 ml",263,6));
            listaProductos.Add(new Producto("141", ECategoria.Perfumeria,"Sedal","Shampoo 400 ml",125,6));
            listaProductos.Add(new Producto("142", ECategoria.Perfumeria,"Axe","Desodorante 150ml",105,6));
            listaProductos.Add(new Producto("143", ECategoria.Perfumeria,"Dove","Shampoo 50 ml",125,6));
            listaProductos.Add(new Producto("144", ECategoria.Perfumeria,"Lux","Jabón 90gr",70,6));


            listaCliente.Add(new Cliente("Marge","Simpson", 11456987,"Av.SiempreViva 742",20,"margesimp@fox.com"));
            listaCliente.Add(new Cliente("Luann ","Van Houten", 11456741,"Av.Springfield 252",25,"luannvh@fox.com"));
            listaCliente.Add(new Cliente("Seymour", "Skinner", 11456876, "Los patos 132", 30, "sskinner@fox.com"));

            listaEmpleados.Add(new Empleado("Apu", "Nahasapeemapetilon",14236745,"la libertad 321",085));
            listaEmpleados.Add(new Empleado("Sanjay", "Nahasapeemapetilon", 14236745, "la libertad 321", 086));


        }

        private void TSMItem_AgregarProducto_Click(object sender, EventArgs e)
        {
            Form formulario2 = new FrmAltaProducto();
            formulario2.Show();
            this.Hide();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario3 = new FrmNuevaVenta(this.listaProductos,this.listaCliente);
            formulario3.Show();
            this.Hide();
        }

        private void AltaCliente_Click(object sender, EventArgs e)
        {
            Form formulario4 = new FrmCliente();
            formulario4.Show();
            this.Hide();
        }

        private void CerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
