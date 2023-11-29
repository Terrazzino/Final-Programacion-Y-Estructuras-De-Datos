namespace tpFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConcesionaria = new Button();
            btnEmpresa = new Button();
            SuspendLayout();
            // 
            // btnConcesionaria
            // 
            btnConcesionaria.Location = new Point(46, 55);
            btnConcesionaria.Name = "btnConcesionaria";
            btnConcesionaria.Size = new Size(115, 29);
            btnConcesionaria.TabIndex = 0;
            btnConcesionaria.Text = "Concesionaria";
            btnConcesionaria.UseVisualStyleBackColor = true;
            btnConcesionaria.Click += btnConcesionaria_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Location = new Point(46, 113);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Size = new Size(115, 29);
            btnEmpresa.TabIndex = 1;
            btnEmpresa.Text = "Empresa";
            btnEmpresa.UseVisualStyleBackColor = true;
            btnEmpresa.Click += btnEmpresa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 190);
            Controls.Add(btnEmpresa);
            Controls.Add(btnConcesionaria);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConcesionaria;
        private Button btnEmpresa;
    }
}