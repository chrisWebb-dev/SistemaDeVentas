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
    public partial class Categoria : Form
    {
        public Categoria()
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

            if (txt_desc.Text == "")
            {
                errorProvider1.SetError(txt_desc, "Debe ingresar la descripción ");
                txt_desc.Focus();
                return;
            }
        }
    }
}
