using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }



        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            if (TbxUsuario.Text == "Apu" || TbxUsuario.Text == "Sanjay")
            {
                Form inicio = new FrmPrincipal();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TbxUsuario_TextChanged(object sender, EventArgs e)
        {
            TbxContraseña.Text = TbxUsuario.Text;
            if (TbxUsuario.Text == "Sanjay")
            {
                PbxLogin.ImageLocation = "C:/Users/lola_/OneDrive/Escritorio/Git_PP_LaboII/Parcial_Laboratorio_II/Imagenes/sanjay_foto.jpg";
               
            }
            else if (TbxUsuario.Text == "Apu")
            {
                PbxLogin.ImageLocation = "C:/Users/lola_/OneDrive/Escritorio/Git_PP_LaboII/Parcial_Laboratorio_II/Imagenes/apu.png";
               
            }


        }
    }
}
