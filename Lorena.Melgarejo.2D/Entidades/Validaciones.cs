using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public static class Validaciones
    {

        /// <summary>
        /// Valida que en los campos solo se ingrese 
        /// números enteros
        /// </summary>
        /// <param name="pe"></param>
        public static void ValidarEntero(KeyPressEventArgs pe)
        {
            if (char.IsDigit(pe.KeyChar))
            {
                pe.Handled = false;
               
            }
            else if (char.IsControl(pe.KeyChar))
            {
                pe.Handled = false;
                
            }

            else
            {
                pe.Handled = true;
                MessageBox.Show("Ingrese solo Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        /// <summary>
        /// Valida que en los campos
        /// se ingresen letras
        /// </summary>
        /// <param name="pe"></param>
        public static void ValidarLetras(KeyPressEventArgs pe)
        {
            if (char.IsLetter(pe.KeyChar))
            {
                pe.Handled = false;

            }
            else if (char.IsControl(pe.KeyChar))
            {
                pe.Handled = false;
               
            }

            else if (char.IsSeparator(pe.KeyChar))
            {
                pe.Handled = true;
            }

            else
            {
                pe.Handled = true;
                MessageBox.Show("Ingrese solo Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }



    }
}
