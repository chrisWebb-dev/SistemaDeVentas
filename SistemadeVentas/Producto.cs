using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeVentas
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Validar que no queden espacios en blanco

            if (txt_codigo.Text == "")
            {
                errorProvider1.SetError(txt_codigo, "Debe ingresar el código");
                txt_codigo.Focus();
                return;
            }
            errorProvider1.SetError(txt_codigo, "");

            if (txt_nom.Text == "")
            {
                errorProvider1.SetError(txt_nom, "Debe ingresar el nombre");
                txt_nom.Focus();
                return;
            }
            errorProvider1.SetError(txt_nom, "");

            if (txt_desc.Text == "")
            {
                errorProvider1.SetError(txt_desc, "Debe ingresar la descripción");
                txt_desc.Focus();
                return;
            }
            errorProvider1.SetError(txt_desc, "");

            //validar que no permita texto
            decimal id;
            if (!decimal.TryParse(txt_codigo.Text, out id))
            {
                errorProvider1.SetError(txt_codigo, "Debe ingresar un número");
                txt_codigo.Focus();
                return;
            }
            errorProvider1.SetError(txt_codigo, "");

        }
    }
}
