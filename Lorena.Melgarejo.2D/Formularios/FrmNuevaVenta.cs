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
    public partial class FrmNuevaVenta : Form
    {
        List<Producto> listaProductos;
        List<Cliente> listaCliente;

        public FrmNuevaVenta()
        {
            InitializeComponent();
            this.listaProductos = new List<Producto>();
            listaCliente = new List<Cliente>();

        }

        public FrmNuevaVenta(List<Producto> listaProductos, List<Cliente> listaCliente) :this()
        {
            this.listaProductos = listaProductos;
            this.listaCliente = listaCliente;
        }

        private void FrmNuevaVenta_Load(object sender, EventArgs e)
        {
            dgvVentas.RowHeadersVisible = false;
            dgvCarrito.RowHeadersVisible = false;
            dgvVentas.DataSource = listaProductos;
            dgvVentas.AllowDrop = true;
            dgvCarrito.AllowDrop = true;
            cbxCliente.DataSource = listaCliente;
            lblHora.Text = DateTime.Now.ToString("G");

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PasarProductos();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
        private void PasarProductos()
        {
            this.dgvCarrito.Rows.Add(new string[] {
                Convert.ToString(dgvVentas[0, dgvVentas.CurrentRow.Index].Value),
                Convert.ToString(dgvVentas[1, dgvVentas.CurrentRow.Index].Value),
                Convert.ToString(dgvVentas[2, dgvVentas.CurrentRow.Index].Value),
                Convert.ToString(dgvVentas[3, dgvVentas.CurrentRow.Index].Value),
                Convert.ToString(dgvVentas[4, dgvVentas.CurrentRow.Index].Value),
                Convert.ToString(dgvVentas[5, dgvVentas.CurrentRow.Index].Value),
            });
        }

        
        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            dgvCarrito.Rows.Remove(dgvCarrito.CurrentRow);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            dgvCarrito.Rows.Clear();
            lblTotal.Text = "";
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            SumarColumna();
        }

        private void SumarColumna()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Precio"].Value);
            }
            lblTotal.Text = total.ToString();

        }

        private void BtnPagPrincipal_Click(object sender, EventArgs e)
        {
            Form inicio = new FrmPrincipal();
            inicio.Show();
            this.Hide();
            MessageBox.Show("Gracias!!! Vuelvas prontosss", "",MessageBoxButtons.OK);
        }

        
    }
}
