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
    public partial class FrmAltaProducto : Form
    {

        
        List<Producto> listaProd;

        public FrmAltaProducto()
        {
            InitializeComponent();
            listaProd = new List<Producto>();

        }

      
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            dgvListado.RowHeadersVisible = false;
            cmbCategoria.DataSource = Enum.GetValues(typeof(ECategoria)); // Carga el comboBox con los Enumerados
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Existe(tbxCodigo.Text))
            {
                errorCodigo.SetError(tbxCodigo, "Codigo ya Existente");
                tbxCodigo.Focus();
                return;
            }
            else
                errorCodigo.Clear();

            Producto NuevoProd = new Producto();
           
            NuevoProd.Categoria = (ECategoria)cmbCategoria.SelectedItem;
            NuevoProd.Codigo = tbxCodigo.Text;
            NuevoProd.Marca = tbxMarca.Text;
            NuevoProd.Descripcion = tbxDescripcion.Text;
            NuevoProd.Precio = float.Parse(tbxPrecio.Text);
            NuevoProd.Cantidad = int.Parse(txbCantidad.Text);
            listaProd.Add(NuevoProd);
            dgvListado.DataSource = null;
            dgvListado.DataSource = listaProd;

            //cmbCategoria
            tbxMarca.Clear();
            tbxDescripcion.Clear();
            tbxPrecio.Clear();
            txbCantidad.Clear();
            tbxCodigo.Clear();

            MessageBox.Show("Los Datos se han guardado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public bool Existe(string cod)
        {
            foreach (Producto mercaderia in listaProd)
            {
                if (mercaderia.Codigo == cod)
                {
                    return true;

                }                
            }
            return false;
        }

        #region Validacion Campos 

        

        private void tbxMarca_Validated(object sender, EventArgs e)
        {
            if (tbxMarca.Text == "")
            {
                errorCamposVacios.SetError(tbxMarca, "Ingrese una Marca");
                tbxMarca.Focus();
            }
            else
                errorCamposVacios.Clear();
        }

        private void tbxDescripcion_Validated(object sender, EventArgs e)
        {
            if (tbxDescripcion.Text == "")
            {
                errorCamposVacios.SetError(tbxDescripcion, "Ingrese una Descripcion");
                tbxDescripcion.Focus();
            }
            else
                errorCamposVacios.Clear();

        }

       

        private void tbxPrecio_Validated(object sender, EventArgs e)
        {
            if (tbxPrecio.Text == "")
            {
                errorCamposVacios.SetError(tbxPrecio, "Ingrese un Precio");
                tbxPrecio.Focus();
            }
            else
                errorCamposVacios.Clear();

        }


        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form inicio = new FrmPrincipal();
            inicio.Show();
            this.Hide();
        }
    }
}
