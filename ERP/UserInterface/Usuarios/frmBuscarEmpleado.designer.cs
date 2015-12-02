namespace ERP
{
    partial class frmBuscarEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLinea = new System.Windows.Forms.Label();
            this.gbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarEstado = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gvDatosEmpleado = new System.Windows.Forms.DataGridView();
            this.Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Género = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMostrarEmpleados = new System.Windows.Forms.Label();
            this.gbDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinea
            // 
            this.lblLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLinea.Location = new System.Drawing.Point(-53, 41);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(1028, 15);
            this.lblLinea.TabIndex = 32;
            // 
            // gbDatosEmpleado
            // 
            this.gbDatosEmpleado.Controls.Add(this.btnCerrar);
            this.gbDatosEmpleado.Controls.Add(this.btnActualizarEstado);
            this.gbDatosEmpleado.Controls.Add(this.btnBuscar);
            this.gbDatosEmpleado.Controls.Add(this.gvDatosEmpleado);
            this.gbDatosEmpleado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosEmpleado.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbDatosEmpleado.Location = new System.Drawing.Point(12, 59);
            this.gbDatosEmpleado.Name = "gbDatosEmpleado";
            this.gbDatosEmpleado.Size = new System.Drawing.Size(857, 370);
            this.gbDatosEmpleado.TabIndex = 33;
            this.gbDatosEmpleado.TabStop = false;
            this.gbDatosEmpleado.Text = "DATOS DEL EMPLEADO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Location = new System.Drawing.Point(502, 327);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(114, 37);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizarEstado
            // 
            this.btnActualizarEstado.BackColor = System.Drawing.Color.White;
            this.btnActualizarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEstado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEstado.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarEstado.Location = new System.Drawing.Point(371, 327);
            this.btnActualizarEstado.Name = "btnActualizarEstado";
            this.btnActualizarEstado.Size = new System.Drawing.Size(114, 37);
            this.btnActualizarEstado.TabIndex = 1;
            this.btnActualizarEstado.Text = "&Actualizar";
            this.btnActualizarEstado.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Location = new System.Drawing.Point(240, 327);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 37);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gvDatosEmpleado
            // 
            this.gvDatosEmpleado.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            this.gvDatosEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDatosEmpleado.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.gvDatosEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDatosEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDatosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatosEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identidad,
            this.Nombres,
            this.Apellidos,
            this.Dirección,
            this.Género,
            this.Cargo,
            this.Estado,
            this.Teléfonos});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDatosEmpleado.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDatosEmpleado.Location = new System.Drawing.Point(29, 26);
            this.gvDatosEmpleado.Name = "gvDatosEmpleado";
            this.gvDatosEmpleado.RowHeadersVisible = false;
            this.gvDatosEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDatosEmpleado.Size = new System.Drawing.Size(802, 295);
            this.gvDatosEmpleado.TabIndex = 3;
            this.gvDatosEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDatosEmpleado_CellDoubleClick);
            // 
            // Identidad
            // 
            this.Identidad.HeaderText = "Identidad";
            this.Identidad.Name = "Identidad";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 200;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 200;
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            this.Dirección.Width = 300;
            // 
            // Género
            // 
            this.Género.HeaderText = "Género";
            this.Género.Name = "Género";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado Civil";
            this.Estado.Name = "Estado";
            // 
            // Teléfonos
            // 
            this.Teléfonos.HeaderText = "Teléfonos";
            this.Teléfonos.Name = "Teléfonos";
            // 
            // lblMostrarEmpleados
            // 
            this.lblMostrarEmpleados.AutoSize = true;
            this.lblMostrarEmpleados.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblMostrarEmpleados.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMostrarEmpleados.Location = new System.Drawing.Point(352, 9);
            this.lblMostrarEmpleados.Name = "lblMostrarEmpleados";
            this.lblMostrarEmpleados.Size = new System.Drawing.Size(177, 18);
            this.lblMostrarEmpleados.TabIndex = 34;
            this.lblMostrarEmpleados.Text = "Mostrar Empleados";
            // 
            // frmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 441);
            this.Controls.Add(this.lblMostrarEmpleados);
            this.Controls.Add(this.gbDatosEmpleado);
            this.Controls.Add(this.lblLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarEmpleado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarEmpleado";
            this.gbDatosEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.GroupBox gbDatosEmpleado;
        private System.Windows.Forms.DataGridView gvDatosEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Género;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfonos;
        private System.Windows.Forms.Button btnActualizarEstado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblMostrarEmpleados;

    }
}