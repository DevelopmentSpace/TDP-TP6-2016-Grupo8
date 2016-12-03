namespace EJ2
{
    partial class FormCuentas
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetalleYMov = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaCuentas = new System.Windows.Forms.DataGridView();
            this.btnVerTodas = new System.Windows.Forms.Button();
            this.btnObtSuperanLim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Id:";
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(221, 128);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarId.TabIndex = 21;
            this.btnBuscarId.Text = "Buscar";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(52, 128);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(163, 20);
            this.txtBuscarId.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(594, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDetalleYMov);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLimite);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 101);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnDetalleYMov
            // 
            this.btnDetalleYMov.Location = new System.Drawing.Point(746, 13);
            this.btnDetalleYMov.Name = "btnDetalleYMov";
            this.btnDetalleYMov.Size = new System.Drawing.Size(85, 80);
            this.btnDetalleYMov.TabIndex = 21;
            this.btnDetalleYMov.Text = "Detalle y movimientos";
            this.btnDetalleYMov.UseVisualStyleBackColor = true;
            this.btnDetalleYMov.Click += new System.EventHandler(this.btnDetalleYMov_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(65, 70);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(163, 20);
            this.txtCliente.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cliente:";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(299, 43);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(163, 20);
            this.txtLimite.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Limite:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(594, 40);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(65, 43);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(163, 20);
            this.txtIdCliente.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(594, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(65, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(163, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(299, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // tablaCuentas
            // 
            this.tablaCuentas.AllowUserToAddRows = false;
            this.tablaCuentas.AllowUserToDeleteRows = false;
            this.tablaCuentas.AllowUserToResizeColumns = false;
            this.tablaCuentas.AllowUserToResizeRows = false;
            this.tablaCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCuentas.Location = new System.Drawing.Point(6, 53);
            this.tablaCuentas.MultiSelect = false;
            this.tablaCuentas.Name = "tablaCuentas";
            this.tablaCuentas.ReadOnly = true;
            this.tablaCuentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCuentas.Size = new System.Drawing.Size(876, 218);
            this.tablaCuentas.TabIndex = 16;
            this.tablaCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCuentas_CellClick);
            // 
            // btnVerTodas
            // 
            this.btnVerTodas.Location = new System.Drawing.Point(13, 19);
            this.btnVerTodas.Name = "btnVerTodas";
            this.btnVerTodas.Size = new System.Drawing.Size(104, 23);
            this.btnVerTodas.TabIndex = 24;
            this.btnVerTodas.Text = "Ver todas";
            this.btnVerTodas.UseVisualStyleBackColor = true;
            this.btnVerTodas.Click += new System.EventHandler(this.btnVerTodas_Click);
            // 
            // btnObtSuperanLim
            // 
            this.btnObtSuperanLim.Location = new System.Drawing.Point(123, 19);
            this.btnObtSuperanLim.Name = "btnObtSuperanLim";
            this.btnObtSuperanLim.Size = new System.Drawing.Size(147, 23);
            this.btnObtSuperanLim.TabIndex = 25;
            this.btnObtSuperanLim.Text = "Ver superan limite";
            this.btnObtSuperanLim.UseVisualStyleBackColor = true;
            this.btnObtSuperanLim.Click += new System.EventHandler(this.btnObtSuperanLim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tablaCuentas);
            this.groupBox2.Controls.Add(this.btnObtSuperanLim);
            this.groupBox2.Controls.Add(this.btnVerTodas);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 280);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCuentas";
            this.Text = "Cuentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCuentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablaCuentas;
        private System.Windows.Forms.Button btnVerTodas;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnObtSuperanLim;
        private System.Windows.Forms.Button btnDetalleYMov;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}