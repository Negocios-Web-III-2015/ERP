namespace ERP
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEmpleadoUsuariosRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevoEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMostrarActualizarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDarBajaEmpleada = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMostrarActualizarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDarBajaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevoRol = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMostrarActualizarRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmpleadoUsuariosRoles});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuEmpleadoUsuariosRoles
            // 
            this.mnuEmpleadoUsuariosRoles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmpleado,
            this.mnuUsuarios,
            this.mnuRoles});
            this.mnuEmpleadoUsuariosRoles.Name = "mnuEmpleadoUsuariosRoles";
            this.mnuEmpleadoUsuariosRoles.Size = new System.Drawing.Size(164, 20);
            this.mnuEmpleadoUsuariosRoles.Text = "Empleados, usuarios y roles";
            // 
            // mnuEmpleado
            // 
            this.mnuEmpleado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevoEmpleado,
            this.mnuMostrarActualizarEmpleado,
            this.mnuDarBajaEmpleada});
            this.mnuEmpleado.Name = "mnuEmpleado";
            this.mnuEmpleado.Size = new System.Drawing.Size(152, 22);
            this.mnuEmpleado.Text = "Empleado";
            // 
            // mnuNuevoEmpleado
            // 
            this.mnuNuevoEmpleado.Name = "mnuNuevoEmpleado";
            this.mnuNuevoEmpleado.Size = new System.Drawing.Size(178, 22);
            this.mnuNuevoEmpleado.Text = "Nuevo";
            this.mnuNuevoEmpleado.Click += new System.EventHandler(this.mnuNuevoEmpleado_Click);
            // 
            // mnuMostrarActualizarEmpleado
            // 
            this.mnuMostrarActualizarEmpleado.Name = "mnuMostrarActualizarEmpleado";
            this.mnuMostrarActualizarEmpleado.Size = new System.Drawing.Size(178, 22);
            this.mnuMostrarActualizarEmpleado.Text = "Mostrar o actualizar";
            this.mnuMostrarActualizarEmpleado.Click += new System.EventHandler(this.mnuMostrarActualizarEmpleado_Click);
            // 
            // mnuDarBajaEmpleada
            // 
            this.mnuDarBajaEmpleada.Name = "mnuDarBajaEmpleada";
            this.mnuDarBajaEmpleada.Size = new System.Drawing.Size(178, 22);
            this.mnuDarBajaEmpleada.Text = "Dar de baja";
            this.mnuDarBajaEmpleada.Click += new System.EventHandler(this.mnuDarBajaEmpleada_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevoUsuarios,
            this.mnuMostrarActualizarUsuarios,
            this.mnuDarBajaUsuarios});
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(152, 22);
            this.mnuUsuarios.Text = "Usuarios";
            // 
            // mnuNuevoUsuarios
            // 
            this.mnuNuevoUsuarios.Name = "mnuNuevoUsuarios";
            this.mnuNuevoUsuarios.Size = new System.Drawing.Size(178, 22);
            this.mnuNuevoUsuarios.Text = "Nuevo";
            this.mnuNuevoUsuarios.Click += new System.EventHandler(this.mnuNuevoUsuarios_Click);
            // 
            // mnuMostrarActualizarUsuarios
            // 
            this.mnuMostrarActualizarUsuarios.Name = "mnuMostrarActualizarUsuarios";
            this.mnuMostrarActualizarUsuarios.Size = new System.Drawing.Size(178, 22);
            this.mnuMostrarActualizarUsuarios.Text = "Mostrar o actualizar";
            this.mnuMostrarActualizarUsuarios.Click += new System.EventHandler(this.mnuMostrarActualizarUsuarios_Click);
            // 
            // mnuDarBajaUsuarios
            // 
            this.mnuDarBajaUsuarios.Name = "mnuDarBajaUsuarios";
            this.mnuDarBajaUsuarios.Size = new System.Drawing.Size(178, 22);
            this.mnuDarBajaUsuarios.Text = "Dar de baja";
            this.mnuDarBajaUsuarios.Click += new System.EventHandler(this.mnuDarBajaUsuarios_Click);
            // 
            // mnuRoles
            // 
            this.mnuRoles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevoRol,
            this.mnuMostrarActualizarRoles});
            this.mnuRoles.Name = "mnuRoles";
            this.mnuRoles.Size = new System.Drawing.Size(152, 22);
            this.mnuRoles.Text = "Roles";
            // 
            // mnuNuevoRol
            // 
            this.mnuNuevoRol.Name = "mnuNuevoRol";
            this.mnuNuevoRol.Size = new System.Drawing.Size(172, 22);
            this.mnuNuevoRol.Text = "Nuevo";
            this.mnuNuevoRol.Click += new System.EventHandler(this.mnuNuevoRol_Click);
            // 
            // mnuMostrarActualizarRoles
            // 
            this.mnuMostrarActualizarRoles.Name = "mnuMostrarActualizarRoles";
            this.mnuMostrarActualizarRoles.Size = new System.Drawing.Size(172, 22);
            this.mnuMostrarActualizarRoles.Text = "Mostrar o actulizar";
            this.mnuMostrarActualizarRoles.Click += new System.EventHandler(this.mnuMostrarActualizarRoles_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 375);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpleadoUsuariosRoles;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpleado;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuMostrarActualizarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRoles;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevoRol;
        private System.Windows.Forms.ToolStripMenuItem mnuMostrarActualizarRoles;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevoEmpleado;
        private System.Windows.Forms.ToolStripMenuItem mnuMostrarActualizarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem mnuDarBajaEmpleada;
        private System.Windows.Forms.ToolStripMenuItem mnuDarBajaUsuarios;
    }
}

