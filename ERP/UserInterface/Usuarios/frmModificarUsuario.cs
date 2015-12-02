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
    public partial class frmModificarUsuario : Form
    {
        public frmModificarUsuario()
        {
            InitializeComponent();
        }


        private void chkMostrarCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarCaracteres.Checked)
            {
                txtAcutal2.Visible = true;
                txtnueva2.Visible = true;
                txtconfirmar2.Visible = true;
            }
            else
            {
                txtAcutal2.Visible = false;
                txtnueva2.Visible = false;
                txtconfirmar2.Visible = false;
            }
        }

        private void txtActual1_TextChanged(object sender, EventArgs e)
        {
            txtAcutal2.Text = txtActual1.Text;
        }

        private void txtNueva_TextChanged(object sender, EventArgs e)
        {
            txtnueva2.Text = txtNueva.Text;
        }

        private void txtconfirmar_TextChanged(object sender, EventArgs e)
        {
            txtconfirmar2.Text = txtconfirmar.Text;
        }

        private void txtnueva2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            frmModificarRol Nuevofrm = new frmModificarRol();
            Nuevofrm.ShowDialog();
        }
    }
}
