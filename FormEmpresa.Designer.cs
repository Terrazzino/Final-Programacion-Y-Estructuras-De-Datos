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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnModificarTerminado = new Button();
            btnBajaTerminado = new Button();
            btnAltaTerminado = new Button();
            nudStockTerminado = new NumericUpDown();
            cmbDescripciónTerminado = new ComboBox();
            cmbModeloTerminado = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvPiezasEmpresa = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            btnModificarPiezas = new Button();
            btnBajaPiezas = new Button();
            btnAltaPiezas = new Button();
            nudStockPiezas = new NumericUpDown();
            cmbDescripciónPieza = new ComboBox();
            cmbNumeroPieza = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvComposicionEmpresa = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
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
            dgvTerminadosEmpresa.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvTerminadosEmpresa.Location = new Point(320, 64);
            dgvTerminadosEmpresa.Name = "dgvTerminadosEmpresa";
            dgvTerminadosEmpresa.RowHeadersWidth = 51;
            dgvTerminadosEmpresa.RowTemplate.Height = 29;
            dgvTerminadosEmpresa.Size = new Size(428, 160);
            dgvTerminadosEmpresa.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Modelo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Concesionaria";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // btnModificarTerminado
            // 
            btnModificarTerminado.Location = new Point(208, 195);
            btnModificarTerminado.Name = "btnModificarTerminado";
            btnModificarTerminado.Size = new Size(94, 29);
            btnModificarTerminado.TabIndex = 18;
            btnModificarTerminado.Text = "Modificar";
            btnModificarTerminado.UseVisualStyleBackColor = true;
            // 
            // btnBajaTerminado
            // 
            btnBajaTerminado.Location = new Point(208, 141);
            btnBajaTerminado.Name = "btnBajaTerminado";
            btnBajaTerminado.Size = new Size(94, 29);
            btnBajaTerminado.TabIndex = 17;
            btnBajaTerminado.Text = "Baja";
            btnBajaTerminado.UseVisualStyleBackColor = true;
            // 
            // btnAltaTerminado
            // 
            btnAltaTerminado.Location = new Point(208, 87);
            btnAltaTerminado.Name = "btnAltaTerminado";
            btnAltaTerminado.Size = new Size(94, 29);
            btnAltaTerminado.TabIndex = 16;
            btnAltaTerminado.Text = "Alta";
            btnAltaTerminado.UseVisualStyleBackColor = true;
            // 
            // nudStockTerminado
            // 
            nudStockTerminado.Location = new Point(12, 195);
            nudStockTerminado.Name = "nudStockTerminado";
            nudStockTerminado.Size = new Size(181, 27);
            nudStockTerminado.TabIndex = 15;
            // 
            // cmbDescripciónTerminado
            // 
            cmbDescripciónTerminado.FormattingEnabled = true;
            cmbDescripciónTerminado.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
            cmbDescripciónTerminado.Location = new Point(12, 141);
            cmbDescripciónTerminado.Name = "cmbDescripciónTerminado";
            cmbDescripciónTerminado.Size = new Size(181, 28);
            cmbDescripciónTerminado.TabIndex = 14;
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
            dgvPiezasEmpresa.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvPiezasEmpresa.Location = new Point(320, 303);
            dgvPiezasEmpresa.Name = "dgvPiezasEmpresa";
            dgvPiezasEmpresa.RowHeadersWidth = 51;
            dgvPiezasEmpresa.RowTemplate.Height = 29;
            dgvPiezasEmpresa.Size = new Size(428, 160);
            dgvPiezasEmpresa.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Modelo";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Concesionaria";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
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
            // cmbDescripciónPieza
            // 
            cmbDescripciónPieza.FormattingEnabled = true;
            cmbDescripciónPieza.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
            cmbDescripciónPieza.Location = new Point(12, 380);
            cmbDescripciónPieza.Name = "cmbDescripciónPieza";
            cmbDescripciónPieza.Size = new Size(181, 28);
            cmbDescripciónPieza.TabIndex = 24;
            // 
            // cmbNumeroPieza
            // 
            cmbNumeroPieza.FormattingEnabled = true;
            cmbNumeroPieza.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
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
            dgvComposicionEmpresa.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvComposicionEmpresa.Location = new Point(327, 553);
            dgvComposicionEmpresa.Name = "dgvComposicionEmpresa";
            dgvComposicionEmpresa.RowHeadersWidth = 51;
            dgvComposicionEmpresa.RowTemplate.Height = 29;
            dgvComposicionEmpresa.Size = new Size(428, 160);
            dgvComposicionEmpresa.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Concesionaria";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
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
            cmbNumPiezasComposición.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
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
            label12.Click += label12_Click;
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
            // FormConcecionaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 745);
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
            Controls.Add(cmbDescripciónPieza);
            Controls.Add(cmbNumeroPieza);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dgvTerminadosEmpresa);
            Controls.Add(btnModificarTerminado);
            Controls.Add(btnBajaTerminado);
            Controls.Add(btnAltaTerminado);
            Controls.Add(nudStockTerminado);
            Controls.Add(cmbDescripciónTerminado);
            Controls.Add(cmbModeloTerminado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConcecionaria";
            Text = "FormConcecionaria";
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnModificarTerminado;
        private Button btnBajaTerminado;
        private Button btnAltaTerminado;
        private NumericUpDown nudStockTerminado;
        private ComboBox cmbDescripciónTerminado;
        private ComboBox cmbModeloTerminado;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvPiezasEmpresa;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button btnModificarPiezas;
        private Button btnBajaPiezas;
        private Button btnAltaPiezas;
        private NumericUpDown nudStockPiezas;
        private ComboBox cmbDescripciónPieza;
        private ComboBox cmbNumeroPieza;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvComposicionEmpresa;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
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
    }
}