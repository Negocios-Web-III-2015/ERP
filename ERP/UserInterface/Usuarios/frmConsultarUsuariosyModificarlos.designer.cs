namespace ERP
{
    partial class frmConsultarUsuariosyModificarlos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMostrarUsuarios = new System.Windows.Forms.Label();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gvDatosUsuario = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.mskIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.gbDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMostrarUsuarios
            // 
            this.lblMostrarUsuarios.AutoSize = true;
            this.lblMostrarUsuarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblMostrarUsuarios.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMostrarUsuarios.Location = new System.Drawing.Point(370, 9);
            this.lblMostrarUsuarios.Name = "lblMostrarUsuarios";
            this.lblMostrarUsuarios.Size = new System.Drawing.Size(158, 18);
            this.lblMostrarUsuarios.TabIndex = 37;
            this.lblMostrarUsuarios.Text = "Mostrar Usuarios";
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.mskIdentidad);
            this.gbDatosUsuario.Controls.Add(this.lblIdentidad);
            this.gbDatosUsuario.Controls.Add(this.btnCerrar);
            this.gbDatosUsuario.Controls.Add(this.btnBuscar);
            this.gbDatosUsuario.Controls.Add(this.gvDatosUsuario);
            this.gbDatosUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDatosUsuario.Location = new System.Drawing.Point(12, 59);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Size = new System.Drawing.Size(857, 421);
            this.gbDatosUsuario.TabIndex = 36;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "DATOS DEL USUARIO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(456, 366);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Location = new System.Drawing.Point(311, 366);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 37);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gvDatosUsuario
            // 
            this.gvDatosUsuario.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvDatosUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gvDatosUsuario.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvDatosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDatosUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gvDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.IdEmpleado,
            this.IdRol,
            this.Alias,
            this.Estado});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDatosUsuario.DefaultCellStyle = dataGridViewCellStyle18;
            this.gvDatosUsuario.Location = new System.Drawing.Point(28, 65);
            this.gvDatosUsuario.Name = "gvDatosUsuario";
            this.gvDatosUsuario.RowHeadersVisible = false;
            this.gvDatosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDatosUsuario.Size = new System.Drawing.Size(802, 295);
            this.gvDatosUsuario.TabIndex = 2;
            this.gvDatosUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDatosUsuario_CellDoubleClick);
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Id Usuario";
            this.IdUsuario.Name = "IdUsuario";
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "Id Empleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Width = 200;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "Id Rol";
            this.IdRol.Name = "IdRol";
            this.IdRol.Width = 200;
            // 
            // Alias
            // 
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            this.Alias.Width = 300;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-53, 41);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(1028, 15);
            this.lblLinea.TabIndex = 35;
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidad.Location = new System.Drawing.Point(31, 30);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(94, 18);
            this.lblIdentidad.TabIndex = 27;
            this.lblIdentidad.Text = "Identidad:";
            // 
            // mskIdentidad
            // 
            this.mskIdentidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskIdentidad.ForeColor = System.Drawing.Color.SteelBlue;
            this.mskIdentidad.Location = new System.Drawing.Point(144, 27);
            this.mskIdentidad.Mask = "0000-0000-00000";
            this.mskIdentidad.Name = "mskIdentidad";
            this.mskIdentidad.Size = new System.Drawing.Size(203, 27);
            this.mskIdentidad.TabIndex = 26;
            this.mskIdentidad.Tag = "0";
            this.mskIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmConsultarUsuariosyModificarlos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 483);
            this.Controls.Add(this.lblMostrarUsuarios);
            this.Controls.Add(this.gbDatosUsuario);
            this.Controls.Add(this.lblLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarUsuariosyModificarlos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarUsuariosyModificarlos";
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostrarUsuarios;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gvDatosUsuario;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label lblIdentidad;
        private System.Windows.Forms.MaskedTextBox mskIdentidad;
    }
}