using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class Validaciones
    {
        /// <summary>
        /// Metodo que valida que solo se introduzcan letras
        /// si se introducen numeros no dejara escribir dichos caracteres
        /// </summary>
        /// <param name="e"> objeto </param>
        public void validarSoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Metodo que valida que solo se introduzcan numeros
        /// si se introducen letras no dejara escribir dichos caracteres
        /// </summary>
        /// <param name="e"> objeto </param>
        public void validarSoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
