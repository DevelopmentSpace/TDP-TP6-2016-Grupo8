namespace EJ2
{
    partial class FormEstadoYMovimientos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcreditar = new System.Windows.Forms.Button();
            this.btnDebitar = new System.Windows.Forms.Button();
            this.txtCantMov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnObtUltMov = new System.Windows.Forms.Button();
            this.tablaMovimientos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDebitar);
            this.groupBox2.Controls.Add(this.btnAcreditar);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(304, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tablaMovimientos);
            this.groupBox3.Controls.Add(this.btnObtUltMov);
            this.groupBox3.Controls.Add(this.txtCantMov);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 253);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimientos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Enabled = false;
            this.txtIdCuenta.Location = new System.Drawing.Point(38, 10);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdCuenta.TabIndex = 3;
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(73, 26);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Balance:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(68, 42);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto:";
            // 
            // btnAcreditar
            // 
            this.btnAcreditar.Location = new System.Drawing.Point(196, 19);
            this.btnAcreditar.Name = "btnAcreditar";
            this.btnAcreditar.Size = new System.Drawing.Size(146, 23);
            this.btnAcreditar.TabIndex = 8;
            this.btnAcreditar.Text = "Acreditar";
            this.btnAcreditar.UseVisualStyleBackColor = true;
            // 
            // btnDebitar
            // 
            this.btnDebitar.Location = new System.Drawing.Point(196, 62);
            this.btnDebitar.Name = "btnDebitar";
            this.btnDebitar.Size = new System.Drawing.Size(146, 23);
            this.btnDebitar.TabIndex = 9;
            this.btnDebitar.Text = "Debitar";
            this.btnDebitar.UseVisualStyleBackColor = true;
            // 
            // txtCantMov
            // 
            this.txtCantMov.Location = new System.Drawing.Point(77, 19);
            this.txtCantMov.Name = "txtCantMov";
            this.txtCantMov.Size = new System.Drawing.Size(100, 20);
            this.txtCantMov.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad:";
            // 
            // btnObtUltMov
            // 
            this.btnObtUltMov.Location = new System.Drawing.Point(195, 17);
            this.btnObtUltMov.Name = "btnObtUltMov";
            this.btnObtUltMov.Size = new System.Drawing.Size(189, 23);
            this.btnObtUltMov.TabIndex = 10;
            this.btnObtUltMov.Text = "Obtener ultimos movimientos";
            this.btnObtUltMov.UseVisualStyleBackColor = true;
            this.btnObtUltMov.Click += new System.EventHandler(this.btnObtUltMov_Click);
            // 
            // tablaMovimientos
            // 
            this.tablaMovimientos.AllowUserToAddRows = false;
            this.tablaMovimientos.AllowUserToDeleteRows = false;
            this.tablaMovimientos.AllowUserToResizeColumns = false;
            this.tablaMovimientos.AllowUserToResizeRows = false;
            this.tablaMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMovimientos.Location = new System.Drawing.Point(6, 46);
            this.tablaMovimientos.MultiSelect = false;
            this.tablaMovimientos.Name = "tablaMovimientos";
            this.tablaMovimientos.ReadOnly = true;
            this.tablaMovimientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaMovimientos.Size = new System.Drawing.Size(644, 201);
            this.tablaMovimientos.TabIndex = 17;
            // 
            // FormEstadoYMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.txtIdCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEstadoYMovimientos";
            this.Text = "Estado de cuenta y movimientos";
            this.Load += new System.EventHandler(this.FormEstadoYMovimientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDebitar;
        private System.Windows.Forms.Button btnAcreditar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnObtUltMov;
        private System.Windows.Forms.TextBox txtCantMov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.DataGridView tablaMovimientos;
    }
}