namespace FrmView
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
            lblHora = new Label();
            btnIniciar = new Button();
            btnCancelar = new Button();
            txtIngresar = new TextBox();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Location = new Point(63, 9);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(169, 72);
            lblHora.TabIndex = 0;
            lblHora.Text = "Hora:";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(63, 181);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(139, 84);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(243, 181);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 84);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtIngresar
            // 
            txtIngresar.Location = new Point(63, 117);
            txtIngresar.Name = "txtIngresar";
            txtIngresar.Size = new Size(324, 23);
            txtIngresar.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 315);
            Controls.Add(txtIngresar);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(lblHora);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private Button btnIniciar;
        private Button btnCancelar;
        private TextBox txtIngresar;
    }
}