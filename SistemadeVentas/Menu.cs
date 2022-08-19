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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelSub_mantenedor.Visible = false;
            panelSub_reportes.Visible = false;
            panelSub_ventas.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelSub_mantenedor.Visible == true)
                panelSub_mantenedor.Visible = false;
            if (panelSub_reportes.Visible == true)
                panelSub_reportes.Visible = false;
            if (panelSub_ventas.Visible == true)
                panelSub_ventas.Visible = false;
        }

        private void showSubMenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
            
        }

        private void btn_mantenedor_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSub_mantenedor);
        }

        private void btn_rol_Click(object sender, EventArgs e)
        {
            openPrincipal(new Rol());
            //Codigo de la funcion del sistema arriba
            hideSubMenu();
        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            openPrincipal(new AsignarPermisos());
            //Codigo de la funcion del sistema arriba
            hideSubMenu();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            openPrincipal(new Usuario());
            //Codigo de la funcion del sistema arriba
            hideSubMenu();
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            openPrincipal(new Categoria());
            //Codigo de la funcion del sistema arriba
            hideSubMenu();
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            openPrincipal(new Producto());
            //Codigo de la funcion del sistema arriba
            hideSubMenu();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            openPrincipal(new Venta());
            //Codigo de la funcion del sistema arriba
            hideSubMenu();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            //Codigo de la funcion del sistema arriba
            hideSubMenu();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            //Codigo de la funcion del sistema arriba
            hideSubMenu();
        }

        private void btn_reporte_ventas_Click(object sender, EventArgs e)
        {
            //Codigo de la funcion del sistema arriba
            hideSubMenu();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSub_ventas);
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSub_reportes);
        }

        private Form activeForm = null;
        private void openPrincipal(Form principal)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = principal;
            principal.TopLevel = false;
            principal.FormBorderStyle = FormBorderStyle.None;
            principal.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(principal);
            panelPrincipal.Tag = principal;
            principal.BringToFront();
            principal.Show();
            //codigo para abrir formularios en el panel principal

        }
        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
   
        }
    }
}
