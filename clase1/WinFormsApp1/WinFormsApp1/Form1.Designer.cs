namespace WinFormsApp1
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
            btnInstancia1 = new Button();
            btnInstancia2 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnInstancia1
            // 
            btnInstancia1.Location = new Point(191, 157);
            btnInstancia1.Name = "btnInstancia1";
            btnInstancia1.Size = new Size(75, 23);
            btnInstancia1.TabIndex = 0;
            btnInstancia1.Text = "Instancia 1";
            btnInstancia1.UseVisualStyleBackColor = true;
            btnInstancia1.Click += btnInstancia1_Click;
            // 
            // btnInstancia2
            // 
            btnInstancia2.Location = new Point(191, 213);
            btnInstancia2.Name = "btnInstancia2";
            btnInstancia2.Size = new Size(75, 23);
            btnInstancia2.TabIndex = 1;
            btnInstancia2.Text = "Instancia 2";
            btnInstancia2.UseVisualStyleBackColor = true;
            btnInstancia2.Click += btnInstancia2_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Red;
            lblResultado.Location = new Point(212, 311);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(40, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "label1";
            lblResultado.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnInstancia2);
            Controls.Add(btnInstancia1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInstancia1;
        private Button btnInstancia2;
        private Label lblResultado;
    }
}