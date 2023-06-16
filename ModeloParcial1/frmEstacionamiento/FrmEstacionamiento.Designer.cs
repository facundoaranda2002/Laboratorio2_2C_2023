namespace frmEstacionamiento
{
    partial class FrmEstacionamiento
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
            lblTipoVehiculo = new Label();
            lblTipo = new Label();
            lblPatente = new Label();
            btnAgregar = new Button();
            cmbTipoVehiculo = new ComboBox();
            cmbTipoMoto = new ComboBox();
            lstVehiculos = new ListBox();
            txtPatente = new TextBox();
            txtNombreEstacionamiento = new TextBox();
            txtMarca = new TextBox();
            SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(49, 70);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(81, 15);
            lblTipoVehiculo.TabIndex = 0;
            lblTipoVehiculo.Text = "Tipo Vehiculo:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(49, 174);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(68, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo Moto: ";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(49, 118);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(50, 15);
            lblPatente.TabIndex = 1;
            lblPatente.Text = "Patente:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(49, 257);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Vehiculo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(154, 67);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 4;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(154, 174);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(121, 23);
            cmbTipoMoto.TabIndex = 5;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(450, 93);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(285, 199);
            lstVehiculos.TabIndex = 6;
            lstVehiculos.MouseDoubleClick += lstVehiculos_MouseDoubleClick;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(154, 116);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(121, 23);
            txtPatente.TabIndex = 7;
            // 
            // txtNombreEstacionamiento
            // 
            txtNombreEstacionamiento.Location = new Point(450, 62);
            txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            txtNombreEstacionamiento.Size = new Size(285, 23);
            txtNombreEstacionamiento.TabIndex = 8;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(297, 174);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(121, 23);
            txtMarca.TabIndex = 9;
            // 
            // FrmEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMarca);
            Controls.Add(txtNombreEstacionamiento);
            Controls.Add(txtPatente);
            Controls.Add(lstVehiculos);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(btnAgregar);
            Controls.Add(lblTipo);
            Controls.Add(lblPatente);
            Controls.Add(lblTipoVehiculo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstacionamiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estacionamiento";
            Load += FrmEstacionamiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoVehiculo;
        private Label lblTipo;
        private Label lblPatente;
        private Button btnAgregar;
        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbTipoMoto;
        private ListBox lstVehiculos;
        private TextBox txtPatente;
        private TextBox txtNombreEstacionamiento;
        private TextBox txtMarca;
    }
}