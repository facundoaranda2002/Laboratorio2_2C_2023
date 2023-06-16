namespace FrmTorneo
{
    partial class FrmTorneo
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
            cmbEquipoUno = new ComboBox();
            cmbEquipoDos = new ComboBox();
            btnDesafiar = new Button();
            rchtDatosTorneo = new RichTextBox();
            dgvResultados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // cmbEquipoUno
            // 
            cmbEquipoUno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipoUno.FormattingEnabled = true;
            cmbEquipoUno.Location = new Point(83, 35);
            cmbEquipoUno.Name = "cmbEquipoUno";
            cmbEquipoUno.Size = new Size(284, 23);
            cmbEquipoUno.TabIndex = 0;
            cmbEquipoUno.SelectedIndexChanged += cmbEquipoUno_SelectedIndexChanged;
            // 
            // cmbEquipoDos
            // 
            cmbEquipoDos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipoDos.FormattingEnabled = true;
            cmbEquipoDos.Location = new Point(411, 35);
            cmbEquipoDos.Name = "cmbEquipoDos";
            cmbEquipoDos.Size = new Size(294, 23);
            cmbEquipoDos.TabIndex = 1;
            // 
            // btnDesafiar
            // 
            btnDesafiar.Location = new Point(323, 64);
            btnDesafiar.Name = "btnDesafiar";
            btnDesafiar.Size = new Size(125, 23);
            btnDesafiar.TabIndex = 2;
            btnDesafiar.Text = "Jugar Partido";
            btnDesafiar.UseVisualStyleBackColor = true;
            btnDesafiar.Click += btnDesafiar_Click;
            // 
            // rchtDatosTorneo
            // 
            rchtDatosTorneo.Location = new Point(83, 270);
            rchtDatosTorneo.Name = "rchtDatosTorneo";
            rchtDatosTorneo.Size = new Size(622, 102);
            rchtDatosTorneo.TabIndex = 3;
            rchtDatosTorneo.Text = "";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(83, 93);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowTemplate.Height = 25;
            dgvResultados.Size = new Size(622, 171);
            dgvResultados.TabIndex = 4;
            // 
            // FrmTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResultados);
            Controls.Add(rchtDatosTorneo);
            Controls.Add(btnDesafiar);
            Controls.Add(cmbEquipoDos);
            Controls.Add(cmbEquipoUno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmTorneo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Competencias";
            Load += FrmTorneo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbEquipoUno;
        private ComboBox cmbEquipoDos;
        private Button btnDesafiar;
        private RichTextBox rchtDatosTorneo;
        private DataGridView dgvResultados;
    }
}