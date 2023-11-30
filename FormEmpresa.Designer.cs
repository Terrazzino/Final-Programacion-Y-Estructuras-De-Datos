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
            dgvTerminadosEmpresa.Location = new Point(280, 48);
            dgvTerminadosEmpresa.Margin = new Padding(3, 2, 3, 2);
            dgvTerminadosEmpresa.Name = "dgvTerminadosEmpresa";
            dgvTerminadosEmpresa.RowHeadersWidth = 51;
            dgvTerminadosEmpresa.RowTemplate.Height = 29;
            dgvTerminadosEmpresa.Size = new Size(374, 120);
            dgvTerminadosEmpresa.TabIndex = 19;
            dgvTerminadosEmpresa.CellClick += dgvTerminadosEmpresa_CellClick;
            // 
            // btnModificarTerminado
            // 
            btnModificarTerminado.Location = new Point(182, 146);
            btnModificarTerminado.Margin = new Padding(3, 2, 3, 2);
            btnModificarTerminado.Name = "btnModificarTerminado";
            btnModificarTerminado.Size = new Size(82, 22);
            btnModificarTerminado.TabIndex = 18;
            btnModificarTerminado.Text = "Modificar";
            btnModificarTerminado.UseVisualStyleBackColor = true;
            btnModificarTerminado.Click += btnModificarTerminado_Click;
            // 
            // btnBajaTerminado
            // 
            btnBajaTerminado.Location = new Point(182, 106);
            btnBajaTerminado.Margin = new Padding(3, 2, 3, 2);
            btnBajaTerminado.Name = "btnBajaTerminado";
            btnBajaTerminado.Size = new Size(82, 22);
            btnBajaTerminado.TabIndex = 17;
            btnBajaTerminado.Text = "Baja";
            btnBajaTerminado.UseVisualStyleBackColor = true;
            btnBajaTerminado.Click += btnBajaTerminado_Click;
            // 
            // btnAltaTerminado
            // 
            btnAltaTerminado.Location = new Point(182, 65);
            btnAltaTerminado.Margin = new Padding(3, 2, 3, 2);
            btnAltaTerminado.Name = "btnAltaTerminado";
            btnAltaTerminado.Size = new Size(82, 22);
            btnAltaTerminado.TabIndex = 16;
            btnAltaTerminado.Text = "Alta";
            btnAltaTerminado.UseVisualStyleBackColor = true;
            btnAltaTerminado.Click += btnAltaTerminado_Click;
            // 
            // nudStockTerminado
            // 
            nudStockTerminado.Location = new Point(10, 146);
            nudStockTerminado.Margin = new Padding(3, 2, 3, 2);
            nudStockTerminado.Name = "nudStockTerminado";
            nudStockTerminado.Size = new Size(158, 23);
            nudStockTerminado.TabIndex = 15;
            // 
            // cmbModeloTerminado
            // 
            cmbModeloTerminado.FormattingEnabled = true;
            cmbModeloTerminado.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbModeloTerminado.Location = new Point(10, 65);
            cmbModeloTerminado.Margin = new Padding(3, 2, 3, 2);
            cmbModeloTerminado.Name = "cmbModeloTerminado";
            cmbModeloTerminado.Size = new Size(159, 23);
            cmbModeloTerminado.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 129);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 48);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 11;
            label2.Text = "Numero de Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 88);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 10;
            label1.Text = "Descripción";
            // 
            // dgvPiezasEmpresa
            // 
            dgvPiezasEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPiezasEmpresa.Location = new Point(280, 227);
            dgvPiezasEmpresa.Margin = new Padding(3, 2, 3, 2);
            dgvPiezasEmpresa.Name = "dgvPiezasEmpresa";
            dgvPiezasEmpresa.RowHeadersWidth = 51;
            dgvPiezasEmpresa.RowTemplate.Height = 29;
            dgvPiezasEmpresa.Size = new Size(374, 120);
            dgvPiezasEmpresa.TabIndex = 29;
            dgvPiezasEmpresa.CellClick += dgvPiezasEmpresa_CellContentClick;
            dgvPiezasEmpresa.CellContentClick += dgvPiezasEmpresa_CellContentClick;
            // 
            // btnModificarPiezas
            // 
            btnModificarPiezas.Location = new Point(182, 326);
            btnModificarPiezas.Margin = new Padding(3, 2, 3, 2);
            btnModificarPiezas.Name = "btnModificarPiezas";
            btnModificarPiezas.Size = new Size(82, 22);
            btnModificarPiezas.TabIndex = 28;
            btnModificarPiezas.Text = "Modificar";
            btnModificarPiezas.UseVisualStyleBackColor = true;
            btnModificarPiezas.Click += btnModificarPiezas_Click;
            // 
            // btnBajaPiezas
            // 
            btnBajaPiezas.Location = new Point(182, 285);
            btnBajaPiezas.Margin = new Padding(3, 2, 3, 2);
            btnBajaPiezas.Name = "btnBajaPiezas";
            btnBajaPiezas.Size = new Size(82, 22);
            btnBajaPiezas.TabIndex = 27;
            btnBajaPiezas.Text = "Baja";
            btnBajaPiezas.UseVisualStyleBackColor = true;
            btnBajaPiezas.Click += btnBajaPiezas_Click;
            // 
            // btnAltaPiezas
            // 
            btnAltaPiezas.Location = new Point(182, 244);
            btnAltaPiezas.Margin = new Padding(3, 2, 3, 2);
            btnAltaPiezas.Name = "btnAltaPiezas";
            btnAltaPiezas.Size = new Size(82, 22);
            btnAltaPiezas.TabIndex = 26;
            btnAltaPiezas.Text = "Alta";
            btnAltaPiezas.UseVisualStyleBackColor = true;
            btnAltaPiezas.Click += btnAltaPiezas_Click;
            // 
            // nudStockPiezas
            // 
            nudStockPiezas.Location = new Point(10, 326);
            nudStockPiezas.Margin = new Padding(3, 2, 3, 2);
            nudStockPiezas.Name = "nudStockPiezas";
            nudStockPiezas.Size = new Size(158, 23);
            nudStockPiezas.TabIndex = 25;
            // 
            // cmbNumeroPieza
            // 
            cmbNumeroPieza.FormattingEnabled = true;
            cmbNumeroPieza.Items.AddRange(new object[] { "1 - Carroceria (1)", "2 - Motor (1)", "3 - Caja de Cambios (1)", "4 - Puertas (2 o 4)", "5 - Ruedas (4)" });
            cmbNumeroPieza.Location = new Point(10, 244);
            cmbNumeroPieza.Margin = new Padding(3, 2, 3, 2);
            cmbNumeroPieza.Name = "cmbNumeroPieza";
            cmbNumeroPieza.Size = new Size(159, 23);
            cmbNumeroPieza.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 332);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 22;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 227);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 21;
            label5.Text = "Numero de Pieza";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 268);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 20;
            label6.Text = "Descripción";
            // 
            // dgvComposicionEmpresa
            // 
            dgvComposicionEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComposicionEmpresa.Location = new Point(286, 415);
            dgvComposicionEmpresa.Margin = new Padding(3, 2, 3, 2);
            dgvComposicionEmpresa.Name = "dgvComposicionEmpresa";
            dgvComposicionEmpresa.RowHeadersWidth = 51;
            dgvComposicionEmpresa.RowTemplate.Height = 29;
            dgvComposicionEmpresa.Size = new Size(374, 120);
            dgvComposicionEmpresa.TabIndex = 39;
            dgvComposicionEmpresa.CellClick += dgvComposicionEmpresa_CellContentClick;
            dgvComposicionEmpresa.CellContentClick += dgvComposicionEmpresa_CellContentClick;
            // 
            // btnModificarComposicion
            // 
            btnModificarComposicion.Location = new Point(188, 513);
            btnModificarComposicion.Margin = new Padding(3, 2, 3, 2);
            btnModificarComposicion.Name = "btnModificarComposicion";
            btnModificarComposicion.Size = new Size(82, 22);
            btnModificarComposicion.TabIndex = 38;
            btnModificarComposicion.Text = "Modificar";
            btnModificarComposicion.UseVisualStyleBackColor = true;
            btnModificarComposicion.Click += btnModificarComposicion_Click;
            // 
            // btnBajaComposicion
            // 
            btnBajaComposicion.Location = new Point(188, 472);
            btnBajaComposicion.Margin = new Padding(3, 2, 3, 2);
            btnBajaComposicion.Name = "btnBajaComposicion";
            btnBajaComposicion.Size = new Size(82, 22);
            btnBajaComposicion.TabIndex = 37;
            btnBajaComposicion.Text = "Baja";
            btnBajaComposicion.UseVisualStyleBackColor = true;
            btnBajaComposicion.Click += btnBajaComposicion_Click;
            // 
            // btnAltaComposicion
            // 
            btnAltaComposicion.Location = new Point(188, 432);
            btnAltaComposicion.Margin = new Padding(3, 2, 3, 2);
            btnAltaComposicion.Name = "btnAltaComposicion";
            btnAltaComposicion.Size = new Size(82, 22);
            btnAltaComposicion.TabIndex = 36;
            btnAltaComposicion.Text = "Alta";
            btnAltaComposicion.UseVisualStyleBackColor = true;
            btnAltaComposicion.Click += btnAltaComposicion_Click;
            // 
            // nudCantidadComposicion
            // 
            nudCantidadComposicion.Location = new Point(17, 513);
            nudCantidadComposicion.Margin = new Padding(3, 2, 3, 2);
            nudCantidadComposicion.Name = "nudCantidadComposicion";
            nudCantidadComposicion.Size = new Size(158, 23);
            nudCantidadComposicion.TabIndex = 35;
            // 
            // cmbNumPiezasComposición
            // 
            cmbNumPiezasComposición.FormattingEnabled = true;
            cmbNumPiezasComposición.Items.AddRange(new object[] { "1 - Carroceria (1)", "2 - Motor (1)", "3 - Caja de Cambios (1)", "4 - Puertas (2 o 4)", "5 - Ruedas (4)" });
            cmbNumPiezasComposición.Location = new Point(17, 472);
            cmbNumPiezasComposición.Margin = new Padding(3, 2, 3, 2);
            cmbNumPiezasComposición.Name = "cmbNumPiezasComposición";
            cmbNumPiezasComposición.Size = new Size(159, 23);
            cmbNumPiezasComposición.TabIndex = 34;
            // 
            // cmbModeloComposicion
            // 
            cmbModeloComposicion.FormattingEnabled = true;
            cmbModeloComposicion.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbModeloComposicion.Location = new Point(17, 432);
            cmbModeloComposicion.Margin = new Padding(3, 2, 3, 2);
            cmbModeloComposicion.Name = "cmbModeloComposicion";
            cmbModeloComposicion.Size = new Size(159, 23);
            cmbModeloComposicion.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 496);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 32;
            label7.Text = "Cantidad a Usar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 415);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 31;
            label8.Text = "Numero de Modelo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 455);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 30;
            label9.Text = "Numero de Piezas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(10, 18);
            label10.Name = "label10";
            label10.Size = new Size(138, 21);
            label10.TabIndex = 40;
            label10.Text = "Stock Terminado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(10, 196);
            label11.Name = "label11";
            label11.Size = new Size(104, 21);
            label11.TabIndex = 41;
            label11.Text = "Stock Piezas";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(10, 386);
            label12.Name = "label12";
            label12.Size = new Size(211, 21);
            label12.TabIndex = 42;
            label12.Text = "Composición de Vehículos";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 308);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 43;
            label13.Text = "Stock";
            // 
            // txtDescripcionTerminado
            // 
            txtDescripcionTerminado.Location = new Point(10, 106);
            txtDescripcionTerminado.Margin = new Padding(3, 2, 3, 2);
            txtDescripcionTerminado.Name = "txtDescripcionTerminado";
            txtDescripcionTerminado.Size = new Size(159, 23);
            txtDescripcionTerminado.TabIndex = 44;
            // 
            // txtDescripcionPieza
            // 
            txtDescripcionPieza.Location = new Point(10, 285);
            txtDescripcionPieza.Margin = new Padding(3, 2, 3, 2);
            txtDescripcionPieza.Name = "txtDescripcionPieza";
            txtDescripcionPieza.Size = new Size(159, 23);
            txtDescripcionPieza.TabIndex = 45;
            // 
            // FormConcecionaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 559);
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
            Margin = new Padding(3, 2, 3, 2);
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