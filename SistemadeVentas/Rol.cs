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
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }
    }
}
