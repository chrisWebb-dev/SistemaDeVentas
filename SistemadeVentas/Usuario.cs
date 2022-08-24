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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Validar que no queden espacios en blanco

            if (txt_nom.Text == "")
            {
                errorProvider1.SetError(txt_nom, "Debe ingresar el nombre");
                txt_nom.Focus();
                return;
            }
            errorProvider1.SetError(txt_nom, "");

            if (txt_apel.Text == "")
            {
                errorProvider1.SetError(txt_apel, "Debe ingresar el apellido");
                txt_apel.Focus();
                return;
            }
            errorProvider1.SetError(txt_apel, "");

            if (txt_usuario.Text == "")
            {
                errorProvider1.SetError(txt_usuario, "Debe ingresar el Usuario");
                txt_usuario.Focus();
                return;
            }
            errorProvider1.SetError(txt_usuario, "");

            if (txt_contra.Text == "")
            {
                errorProvider1.SetError(txt_contra, "Debe ingresar la Contraseña");
                txt_contra.Focus();
                return;
            }
            errorProvider1.SetError(txt_contra, "");
        }
    }
}
