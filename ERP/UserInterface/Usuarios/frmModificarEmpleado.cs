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
    public partial class frmModificarEmpleado : Form
    {
        public frmModificarEmpleado()
        {
            InitializeComponent();
        }

        private void gbDatosEmpleado1_Enter(object sender, EventArgs e)
        {

        }

        private void chkSi_Click(object sender, EventArgs e)
        {
            chkNo.Checked = false;
            chkSi.Checked = true;
            btnGuardar.Text = "Siguiente";
        }

        private void chkNo_Click(object sender, EventArgs e)
        {
            chkSi.Checked = false;
            chkNo.Checked = true;
            btnGuardar.Text = "Guardar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (chkSi.Checked)
            {
                this.Hide();
                frmModificarUsuario Nuevofrm = new frmModificarUsuario();
                Nuevofrm.ShowDialog();

            }
            else
            {
            }
        }

        private void chkSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarTelefonos_Click(object sender, EventArgs e)
        {
            frmModificarTelefono Nuevofrm =new frmModificarTelefono();
            Nuevofrm.ShowDialog();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' != char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' != char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
