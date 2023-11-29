namespace tpFinal
{
    partial class FormConcesionaria
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbModeloPedidos = new ComboBox();
            cmbConcesionariaPedidos = new ComboBox();
            nudCantidadPedidos = new NumericUpDown();
            btnAltaPedidos = new Button();
            btnBajaPedidos = new Button();
            btnModificarPeddidos = new Button();
            dgvConcesionariaPedidos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudCantidadPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConcesionariaPedidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 68);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de Concesionaria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 27);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero de Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 108);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // cmbModeloPedidos
            // 
            cmbModeloPedidos.FormattingEnabled = true;
            cmbModeloPedidos.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbModeloPedidos.Location = new Point(21, 44);
            cmbModeloPedidos.Margin = new Padding(3, 2, 3, 2);
            cmbModeloPedidos.Name = "cmbModeloPedidos";
            cmbModeloPedidos.Size = new Size(159, 23);
            cmbModeloPedidos.TabIndex = 3;
            // 
            // cmbConcesionariaPedidos
            // 
            cmbConcesionariaPedidos.FormattingEnabled = true;
            cmbConcesionariaPedidos.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
            cmbConcesionariaPedidos.Location = new Point(21, 85);
            cmbConcesionariaPedidos.Margin = new Padding(3, 2, 3, 2);
            cmbConcesionariaPedidos.Name = "cmbConcesionariaPedidos";
            cmbConcesionariaPedidos.Size = new Size(159, 23);
            cmbConcesionariaPedidos.TabIndex = 4;
            // 
            // nudCantidadPedidos
            // 
            nudCantidadPedidos.Location = new Point(21, 125);
            nudCantidadPedidos.Margin = new Padding(3, 2, 3, 2);
            nudCantidadPedidos.Name = "nudCantidadPedidos";
            nudCantidadPedidos.Size = new Size(158, 23);
            nudCantidadPedidos.TabIndex = 5;
            // 
            // btnAltaPedidos
            // 
            btnAltaPedidos.Location = new Point(192, 44);
            btnAltaPedidos.Margin = new Padding(3, 2, 3, 2);
            btnAltaPedidos.Name = "btnAltaPedidos";
            btnAltaPedidos.Size = new Size(82, 22);
            btnAltaPedidos.TabIndex = 6;
            btnAltaPedidos.Text = "Alta";
            btnAltaPedidos.UseVisualStyleBackColor = true;
            btnAltaPedidos.Click += btnAltaPedidos_Click;
            // 
            // btnBajaPedidos
            // 
            btnBajaPedidos.Location = new Point(192, 85);
            btnBajaPedidos.Margin = new Padding(3, 2, 3, 2);
            btnBajaPedidos.Name = "btnBajaPedidos";
            btnBajaPedidos.Size = new Size(82, 22);
            btnBajaPedidos.TabIndex = 7;
            btnBajaPedidos.Text = "Baja";
            btnBajaPedidos.UseVisualStyleBackColor = true;
            btnBajaPedidos.Click += btnBajaPedidos_Click_1;
            // 
            // btnModificarPeddidos
            // 
            btnModificarPeddidos.Location = new Point(192, 125);
            btnModificarPeddidos.Margin = new Padding(3, 2, 3, 2);
            btnModificarPeddidos.Name = "btnModificarPeddidos";
            btnModificarPeddidos.Size = new Size(82, 22);
            btnModificarPeddidos.TabIndex = 8;
            btnModificarPeddidos.Text = "Modificar";
            btnModificarPeddidos.UseVisualStyleBackColor = true;
            // 
            // dgvConcesionariaPedidos
            // 
            dgvConcesionariaPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConcesionariaPedidos.Location = new Point(290, 27);
            dgvConcesionariaPedidos.Margin = new Padding(3, 2, 3, 2);
            dgvConcesionariaPedidos.Name = "dgvConcesionariaPedidos";
            dgvConcesionariaPedidos.RowHeadersWidth = 51;
            dgvConcesionariaPedidos.RowTemplate.Height = 29;
            dgvConcesionariaPedidos.Size = new Size(374, 120);
            dgvConcesionariaPedidos.TabIndex = 9;
            dgvConcesionariaPedidos.CellClick += dgvConcesionariaPedidos_CellContentClick_1;
            dgvConcesionariaPedidos.CellContentClick += dgvConcesionariaPedidos_CellContentClick_1;
            // 
            // FormConcesionaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 171);
            Controls.Add(dgvConcesionariaPedidos);
            Controls.Add(btnModificarPeddidos);
            Controls.Add(btnBajaPedidos);
            Controls.Add(btnAltaPedidos);
            Controls.Add(nudCantidadPedidos);
            Controls.Add(cmbConcesionariaPedidos);
            Controls.Add(cmbModeloPedidos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormConcesionaria";
            Text = "Form Concesionaria";
            ((System.ComponentModel.ISupportInitialize)nudCantidadPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConcesionariaPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbModeloPedidos;
        private ComboBox cmbConcesionariaPedidos;
        private NumericUpDown nudCantidadPedidos;
        private Button btnAltaPedidos;
        private Button btnBajaPedidos;
        private Button btnModificarPeddidos;
        private DataGridView dgvConcesionariaPedidos;
    }
}