using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assistance_system.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            panelBienvenida.Dock = DockStyle.Fill;

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            //int height = panelPadre.Height;
           // int width = panelPadre.Width;
            panelPadre.Controls.Clear();
            Personal control = new Personal();
            //control.Width = width;
            //control.Height = height;
            control.Dock = DockStyle.Fill;

            panelPadre.Controls.Add(control);
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            CtlUsuarios control = new CtlUsuarios();
            control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(control);
        }
    }
}
