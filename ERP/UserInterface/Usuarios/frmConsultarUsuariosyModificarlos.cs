using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmConsultarUsuariosyModificarlos : Form
    {
        public frmConsultarUsuariosyModificarlos()
        {
            InitializeComponent();
        }

        private void gvDatosUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmModificarUsuario Nuevofrm = new frmModificarUsuario();
            Nuevofrm.ShowDialog();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
