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
    public partial class FrmCliente : Form
    {
        List<Cliente> miCliente;
        Cliente clienteNuevo = new Cliente("Elena","Alregría",147528963,"Los milagros 247",41,"alegria@fox.com");
        
        public FrmCliente()
        {
            InitializeComponent();
            miCliente = new List<Cliente>();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form inicio = new FrmPrincipal();
            inicio.Show();
            this.Hide();
        }


        private void GuardarDatos()
        {
            clienteNuevo.Nombre = TxbNombre.Text;
            clienteNuevo.Apellido = txbApellido.Text;
            clienteNuevo.DNI = int.Parse(TxbDni.Text);
            clienteNuevo.Direccion = txbDireccion.Text;
            clienteNuevo.Email = txbEmail.Text;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarDatos();
            MessageBox.Show("los datos se han guardao correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.None);
               
        }


        private void TxbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
           Validaciones.ValidarEntero(e);
            
        }

        private void TxbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarLetras(e);
        }

        private void txbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarLetras(e);
        }

        private void TbxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarEntero(e);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxbNombre.Clear();
            txbApellido.Clear();
            TxbDni.Clear();
            txbDireccion.Clear();
            txbEmail.Clear();
        }

       
    }
}

