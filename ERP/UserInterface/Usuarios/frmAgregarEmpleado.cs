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
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
          
            InitializeComponent();
         
        }

        private void lblTituloAgregarProducto_Click(object sender, EventArgs e)
        {

        }


        private void gbAgregarProducto_Enter(object sender, EventArgs e)
        {

        }

        private void lblLinea_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           

          

            }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarTelefonos_Click(object sender, EventArgs e)
        {
            frmTelefonos nuevofrm= new frmTelefonos();
            nuevofrm.ShowDialog();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
          
        }

        private void chkNo_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chkNo_Click(object sender, EventArgs e)
        {
            chkSi.Checked = false;
            chkNo.Checked = true;
            btnGuardar.Text = "Guardar";
        }

        private void chkSi_Click(object sender, EventArgs e)
        {
            chkNo.Checked = false;
            chkSi.Checked = true;
            btnGuardar.Text = "Siguiente";
            
         }

        private void chkhablitado_Click(object sender, EventArgs e)
        {
            chkhablitado.Checked = true;
            chkdesabilitado.Checked = false;
        }

        private void chkdesabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkhablitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkdesabilitado_Click(object sender, EventArgs e)
        {
            chkhablitado.Checked = false;
            chkdesabilitado.Checked = true;
        }

        private void txtidentidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            mskIdentidad.Focus();
            chkhablitado.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (chkSi.Checked)
            {
                this.Hide();
                frmAgregarUsuario Nuevofrm = new frmAgregarUsuario();
                Nuevofrm.ShowDialog();

            }
            else
            {
                this.Close();
            }
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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
       

    }
}
