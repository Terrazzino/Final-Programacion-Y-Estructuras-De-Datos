namespace tpFinal
{
    partial class Reporte
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
            dgvReporte = new DataGridView();
            dgvReporteVehiculos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVehiculos).BeginInit();
            SuspendLayout();
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(12, 32);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.RowTemplate.Height = 29;
            dgvReporte.Size = new Size(683, 178);
            dgvReporte.TabIndex = 0;
            // 
            // dgvReporteVehiculos
            // 
            dgvReporteVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteVehiculos.Location = new Point(12, 251);
            dgvReporteVehiculos.Name = "dgvReporteVehiculos";
            dgvReporteVehiculos.RowHeadersWidth = 51;
            dgvReporteVehiculos.RowTemplate.Height = 29;
            dgvReporteVehiculos.Size = new Size(683, 178);
            dgvReporteVehiculos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 18);
            label1.TabIndex = 2;
            label1.Text = "PEDIDOS DE CONSECIONARIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 230);
            label2.Name = "label2";
            label2.Size = new Size(368, 18);
            label2.TabIndex = 3;
            label2.Text = "ANALISIS DEL REPORTE DE AUTOMOVILES";
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvReporteVehiculos);
            Controls.Add(dgvReporte);
            Name = "Reporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte";
            Load += Reporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReporte;
        private DataGridView dgvReporteVehiculos;
        private Label label1;
        private Label label2;
    }
}