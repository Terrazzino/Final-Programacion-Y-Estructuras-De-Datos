namespace tpFinal
{
    partial class FormConcecionaria
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
            dgvTerminadosEmpresa = new DataGridView();
            btnModificarTerminado = new Button();
            btnBajaTerminado = new Button();
            btnAltaTerminado = new Button();
            nudStockTerminado = new NumericUpDown();
            cmbModeloTerminado = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvPiezasEmpresa = new DataGridView();
            btnModificarPiezas = new Button();
            btnBajaPiezas = new Button();
            btnAltaPiezas = new Button();
            nudStockPiezas = new NumericUpDown();
            cmbNumeroPieza = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvComposicionEmpresa = new DataGridView();
            btnModificarComposicion = new Button();
            btnBajaComposicion = new Button();
            btnAltaComposicion = new Button();
            nudCantidadComposicion = new NumericUpDown();
            cmbNumPiezasComposición = new ComboBox();
            cmbModeloComposicion = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtDescripcionTerminado = new TextBox();
            txtDescripcionPieza = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTerminadosEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockTerminado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPiezasEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockPiezas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvComposicionEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadComposicion).BeginInit();
            SuspendLayout();
            // 
            // dgvTerminadosEmpresa
            // 
            dgvTerminadosEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerminadosEmpresa.Location = new Point(320, 64);
            dgvTerminadosEmpresa.Name = "dgvTerminadosEmpresa";
            dgvTerminadosEmpresa.RowHeadersWidth = 51;
            dgvTerminadosEmpresa.RowTemplate.Height = 29;
            dgvTerminadosEmpresa.Size = new Size(428, 160);
            dgvTerminadosEmpresa.TabIndex = 19;
            dgvTerminadosEmpresa.CellClick += dgvTerminadosEmpresa_CellClick;
            // 
            // btnModificarTerminado
            // 
            btnModificarTerminado.Location = new Point(208, 195);
            btnModificarTerminado.Name = "btnModificarTerminado";
            btnModificarTerminado.Size = new Size(94, 29);
            btnModificarTerminado.TabIndex = 18;
            btnModificarTerminado.Text = "Modificar";
            btnModificarTerminado.UseVisualStyleBackColor = true;
            btnModificarTerminado.Click += btnModificarTerminado_Click;
            // 
            // btnBajaTerminado
            // 
            btnBajaTerminado.Location = new Point(208, 141);
            btnBajaTerminado.Name = "btnBajaTerminado";
            btnBajaTerminado.Size = new Size(94, 29);
            btnBajaTerminado.TabIndex = 17;
            btnBajaTerminado.Text = "Baja";
            btnBajaTerminado.UseVisualStyleBackColor = true;
            btnBajaTerminado.Click += btnBajaTerminado_Click;
            // 
            // btnAltaTerminado
            // 
            btnAltaTerminado.Location = new Point(208, 87);
            btnAltaTerminado.Name = "btnAltaTerminado";
            btnAltaTerminado.Size = new Size(94, 29);
            btnAltaTerminado.TabIndex = 16;
            btnAltaTerminado.Text = "Alta";
            btnAltaTerminado.UseVisualStyleBackColor = true;
            btnAltaTerminado.Click += btnAltaTerminado_Click;
            // 
            // nudStockTerminado
            // 
            nudStockTerminado.Location = new Point(12, 195);
            nudStockTerminado.Name = "nudStockTerminado";
            nudStockTerminado.Size = new Size(181, 27);
            nudStockTerminado.TabIndex = 15;
            // 
            // cmbModeloTerminado
            // 
            cmbModeloTerminado.FormattingEnabled = true;
            cmbModeloTerminado.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbModeloTerminado.Location = new Point(12, 87);
            cmbModeloTerminado.Name = "cmbModeloTerminado";
            cmbModeloTerminado.Size = new Size(181, 28);
            cmbModeloTerminado.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 12;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 11;
            label2.Text = "Numero de Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 10;
            label1.Text = "Descripción";
            // 
            // dgvPiezasEmpresa
            // 
            dgvPiezasEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPiezasEmpresa.Location = new Point(320, 303);
            dgvPiezasEmpresa.Name = "dgvPiezasEmpresa";
            dgvPiezasEmpresa.RowHeadersWidth = 51;
            dgvPiezasEmpresa.RowTemplate.Height = 29;
            dgvPiezasEmpresa.Size = new Size(428, 160);
            dgvPiezasEmpresa.TabIndex = 29;
            // 
            // btnModificarPiezas
            // 
            btnModificarPiezas.Location = new Point(208, 434);
            btnModificarPiezas.Name = "btnModificarPiezas";
            btnModificarPiezas.Size = new Size(94, 29);
            btnModificarPiezas.TabIndex = 28;
            btnModificarPiezas.Text = "Modificar";
            btnModificarPiezas.UseVisualStyleBackColor = true;
            // 
            // btnBajaPiezas
            // 
            btnBajaPiezas.Location = new Point(208, 380);
            btnBajaPiezas.Name = "btnBajaPiezas";
            btnBajaPiezas.Size = new Size(94, 29);
            btnBajaPiezas.TabIndex = 27;
            btnBajaPiezas.Text = "Baja";
            btnBajaPiezas.UseVisualStyleBackColor = true;
            // 
            // btnAltaPiezas
            // 
            btnAltaPiezas.Location = new Point(208, 326);
            btnAltaPiezas.Name = "btnAltaPiezas";
            btnAltaPiezas.Size = new Size(94, 29);
            btnAltaPiezas.TabIndex = 26;
            btnAltaPiezas.Text = "Alta";
            btnAltaPiezas.UseVisualStyleBackColor = true;
            // 
            // nudStockPiezas
            // 
            nudStockPiezas.Location = new Point(12, 434);
            nudStockPiezas.Name = "nudStockPiezas";
            nudStockPiezas.Size = new Size(181, 27);
            nudStockPiezas.TabIndex = 25;
            // 
            // cmbNumeroPieza
            // 
            cmbNumeroPieza.FormattingEnabled = true;
            cmbNumeroPieza.Items.AddRange(new object[] { "1 - Carroceria (1)", "2 - Motor (1)", "3 - Caja de Cambios (1)", "4 - Puertas (2 o 4)", "5 - Ruedas (4)" });
            cmbNumeroPieza.Location = new Point(12, 326);
            cmbNumeroPieza.Name = "cmbNumeroPieza";
            cmbNumeroPieza.Size = new Size(181, 28);
            cmbNumeroPieza.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 443);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 22;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 303);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 21;
            label5.Text = "Numero de Pieza";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 357);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 20;
            label6.Text = "Descripción";
            // 
            // dgvComposicionEmpresa
            // 
            dgvComposicionEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComposicionEmpresa.Location = new Point(327, 553);
            dgvComposicionEmpresa.Name = "dgvComposicionEmpresa";
            dgvComposicionEmpresa.RowHeadersWidth = 51;
            dgvComposicionEmpresa.RowTemplate.Height = 29;
            dgvComposicionEmpresa.Size = new Size(428, 160);
            dgvComposicionEmpresa.TabIndex = 39;
            // 
            // btnModificarComposicion
            // 
            btnModificarComposicion.Location = new Point(215, 684);
            btnModificarComposicion.Name = "btnModificarComposicion";
            btnModificarComposicion.Size = new Size(94, 29);
            btnModificarComposicion.TabIndex = 38;
            btnModificarComposicion.Text = "Modificar";
            btnModificarComposicion.UseVisualStyleBackColor = true;
            // 
            // btnBajaComposicion
            // 
            btnBajaComposicion.Location = new Point(215, 630);
            btnBajaComposicion.Name = "btnBajaComposicion";
            btnBajaComposicion.Size = new Size(94, 29);
            btnBajaComposicion.TabIndex = 37;
            btnBajaComposicion.Text = "Baja";
            btnBajaComposicion.UseVisualStyleBackColor = true;
            // 
            // btnAltaComposicion
            // 
            btnAltaComposicion.Location = new Point(215, 576);
            btnAltaComposicion.Name = "btnAltaComposicion";
            btnAltaComposicion.Size = new Size(94, 29);
            btnAltaComposicion.TabIndex = 36;
            btnAltaComposicion.Text = "Alta";
            btnAltaComposicion.UseVisualStyleBackColor = true;
            // 
            // nudCantidadComposicion
            // 
            nudCantidadComposicion.Location = new Point(19, 684);
            nudCantidadComposicion.Name = "nudCantidadComposicion";
            nudCantidadComposicion.Size = new Size(181, 27);
            nudCantidadComposicion.TabIndex = 35;
            // 
            // cmbNumPiezasComposición
            // 
            cmbNumPiezasComposición.FormattingEnabled = true;
            cmbNumPiezasComposición.Items.AddRange(new object[] { "1 - Carroceria (1)", "2 - Motor (1)", "3 - Caja de Cambios (1)", "4 - Puertas (2 o 4)", "5 - Ruedas (4)" });
            cmbNumPiezasComposición.Location = new Point(19, 630);
            cmbNumPiezasComposición.Name = "cmbNumPiezasComposición";
            cmbNumPiezasComposición.Size = new Size(181, 28);
            cmbNumPiezasComposición.TabIndex = 34;
            // 
            // cmbModeloComposicion
            // 
            cmbModeloComposicion.FormattingEnabled = true;
            cmbModeloComposicion.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbModeloComposicion.Location = new Point(19, 576);
            cmbModeloComposicion.Name = "cmbModeloComposicion";
            cmbModeloComposicion.Size = new Size(181, 28);
            cmbModeloComposicion.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 661);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 32;
            label7.Text = "Cantidad a Usar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 553);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 31;
            label8.Text = "Numero de Modelo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 607);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
            label9.TabIndex = 30;
            label9.Text = "Numero de Piezas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 24);
            label10.Name = "label10";
            label10.Size = new Size(170, 28);
            label10.TabIndex = 40;
            label10.Text = "Stock Terminado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(12, 261);
            label11.Name = "label11";
            label11.Size = new Size(129, 28);
            label11.TabIndex = 41;
            label11.Text = "Stock Piezas";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 514);
            label12.Name = "label12";
            label12.Size = new Size(258, 28);
            label12.TabIndex = 42;
            label12.Text = "Composición de Vehículos";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 411);
            label13.Name = "label13";
            label13.Size = new Size(45, 20);
            label13.TabIndex = 43;
            label13.Text = "Stock";
            // 
            // txtDescripcionTerminado
            // 
            txtDescripcionTerminado.Location = new Point(12, 141);
            txtDescripcionTerminado.Name = "txtDescripcionTerminado";
            txtDescripcionTerminado.Size = new Size(181, 27);
            txtDescripcionTerminado.TabIndex = 44;
            // 
            // txtDescripcionPieza
            // 
            txtDescripcionPieza.Location = new Point(12, 380);
            txtDescripcionPieza.Name = "txtDescripcionPieza";
            txtDescripcionPieza.Size = new Size(181, 27);
            txtDescripcionPieza.TabIndex = 45;
            // 
            // FormConcecionaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 745);
            Controls.Add(txtDescripcionPieza);
            Controls.Add(txtDescripcionTerminado);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dgvComposicionEmpresa);
            Controls.Add(btnModificarComposicion);
            Controls.Add(btnBajaComposicion);
            Controls.Add(btnAltaComposicion);
            Controls.Add(nudCantidadComposicion);
            Controls.Add(cmbNumPiezasComposición);
            Controls.Add(cmbModeloComposicion);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dgvPiezasEmpresa);
            Controls.Add(btnModificarPiezas);
            Controls.Add(btnBajaPiezas);
            Controls.Add(btnAltaPiezas);
            Controls.Add(nudStockPiezas);
            Controls.Add(cmbNumeroPieza);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dgvTerminadosEmpresa);
            Controls.Add(btnModificarTerminado);
            Controls.Add(btnBajaTerminado);
            Controls.Add(btnAltaTerminado);
            Controls.Add(nudStockTerminado);
            Controls.Add(cmbModeloTerminado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConcecionaria";
            Text = "Form Empresa";
            ((System.ComponentModel.ISupportInitialize)dgvTerminadosEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockTerminado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPiezasEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockPiezas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvComposicionEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadComposicion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTerminadosEmpresa;
        private Button btnModificarTerminado;
        private Button btnBajaTerminado;
        private Button btnAltaTerminado;
        private NumericUpDown nudStockTerminado;
        private ComboBox cmbModeloTerminado;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvPiezasEmpresa;
        private Button btnModificarPiezas;
        private Button btnBajaPiezas;
        private Button btnAltaPiezas;
        private NumericUpDown nudStockPiezas;
        private ComboBox cmbNumeroPieza;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvComposicionEmpresa;
        private Button btnModificarComposicion;
        private Button btnBajaComposicion;
        private Button btnAltaComposicion;
        private NumericUpDown nudCantidadComposicion;
        private ComboBox cmbNumPiezasComposición;
        private ComboBox cmbModeloComposicion;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtDescripcionTerminado;
        private TextBox txtDescripcionPieza;
    }
}