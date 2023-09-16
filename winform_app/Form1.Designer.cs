namespace winform_app
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
            lblFiltro = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminarFisico = new Button();
            btnVerDetalle = new Button();
            pbxArticulos = new PictureBox();
            dgvArticulos = new DataGridView();
            txtFiltro = new TextBox();
            btnFiltro = new Button();
            lblCampo = new Label();
            lblCriterio = new Label();
            lblFiltroAvanzado = new Label();
            cboCampo = new ComboBox();
            cboCriterio = new ComboBox();
            txtFiltroAvanzado = new TextBox();
            lblListaArticulos = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxArticulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(595, 338);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(77, 15);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Filtro Rápido:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.WhiteSmoke;
            btnAgregar.FlatAppearance.BorderSize = 3;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(25, 330);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 30);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.WhiteSmoke;
            btnModificar.FlatAppearance.BorderSize = 3;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.Location = new Point(160, 330);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 30);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.BackColor = Color.WhiteSmoke;
            btnEliminarFisico.FlatAppearance.BorderSize = 3;
            btnEliminarFisico.FlatStyle = FlatStyle.Popup;
            btnEliminarFisico.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminarFisico.Location = new Point(308, 330);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(96, 30);
            btnEliminarFisico.TabIndex = 3;
            btnEliminarFisico.Text = "Eliminar";
            btnEliminarFisico.UseVisualStyleBackColor = false;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.WhiteSmoke;
            btnVerDetalle.FlatAppearance.BorderSize = 3;
            btnVerDetalle.FlatStyle = FlatStyle.Popup;
            btnVerDetalle.ForeColor = SystemColors.ActiveCaptionText;
            btnVerDetalle.Location = new Point(440, 330);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(96, 30);
            btnVerDetalle.TabIndex = 4;
            btnVerDetalle.Text = "Ver Detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // pbxArticulos
            // 
            pbxArticulos.Location = new Point(585, 57);
            pbxArticulos.Name = "pbxArticulos";
            pbxArticulos.Size = new Size(189, 267);
            pbxArticulos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxArticulos.TabIndex = 5;
            pbxArticulos.TabStop = false;
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvArticulos.Location = new Point(12, 57);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.RowTemplate.Height = 25;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.Size = new Size(543, 267);
            dgvArticulos.TabIndex = 6;
            dgvArticulos.SelectionChanged += dgvArticulos_SelectionChanged;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.WhiteSmoke;
            txtFiltro.Location = new Point(676, 335);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(100, 23);
            txtFiltro.TabIndex = 7;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnFiltro
            // 
            btnFiltro.BackColor = Color.WhiteSmoke;
            btnFiltro.FlatStyle = FlatStyle.Popup;
            btnFiltro.Location = new Point(651, 387);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(82, 24);
            btnFiltro.TabIndex = 8;
            btnFiltro.Text = "Buscar";
            btnFiltro.UseVisualStyleBackColor = false;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Location = new Point(12, 391);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(52, 15);
            lblCampo.TabIndex = 9;
            lblCampo.Text = "Campo :";
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Location = new Point(198, 391);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new Size(55, 15);
            lblCriterio.TabIndex = 10;
            lblCriterio.Text = "Criterio : ";
            // 
            // lblFiltroAvanzado
            // 
            lblFiltroAvanzado.AutoSize = true;
            lblFiltroAvanzado.Location = new Point(411, 391);
            lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            lblFiltroAvanzado.Size = new Size(40, 15);
            lblFiltroAvanzado.TabIndex = 11;
            lblFiltroAvanzado.Text = "Filtro :";
            // 
            // cboCampo
            // 
            cboCampo.BackColor = Color.WhiteSmoke;
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(79, 387);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(100, 23);
            cboCampo.TabIndex = 12;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // cboCriterio
            // 
            cboCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new Point(251, 388);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new Size(121, 23);
            cboCriterio.TabIndex = 13;
            // 
            // txtFiltroAvanzado
            // 
            txtFiltroAvanzado.BackColor = Color.WhiteSmoke;
            txtFiltroAvanzado.Location = new Point(455, 387);
            txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            txtFiltroAvanzado.Size = new Size(100, 23);
            txtFiltroAvanzado.TabIndex = 14;
            // 
            // lblListaArticulos
            // 
            lblListaArticulos.AutoSize = true;
            lblListaArticulos.BackColor = Color.Transparent;
            lblListaArticulos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaArticulos.ForeColor = Color.Black;
            lblListaArticulos.Location = new Point(207, 14);
            lblListaArticulos.Name = "lblListaArticulos";
            lblListaArticulos.Size = new Size(180, 28);
            lblListaArticulos.TabIndex = 15;
            lblListaArticulos.Text = "Lista De Articulos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(804, 438);
            Controls.Add(lblListaArticulos);
            Controls.Add(txtFiltroAvanzado);
            Controls.Add(cboCriterio);
            Controls.Add(cboCampo);
            Controls.Add(lblFiltroAvanzado);
            Controls.Add(lblCriterio);
            Controls.Add(lblCampo);
            Controls.Add(btnFiltro);
            Controls.Add(txtFiltro);
            Controls.Add(dgvArticulos);
            Controls.Add(pbxArticulos);
            Controls.Add(btnVerDetalle);
            Controls.Add(btnEliminarFisico);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblFiltro);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MaximumSize = new Size(820, 477);
            MinimumSize = new Size(820, 477);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = SystemColors.ActiveBorder;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbxArticulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFiltro;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminarFisico;
        private Button btnVerDetalle;
        private PictureBox pbxArticulos;
        private DataGridView dgvArticulos;
        private TextBox txtFiltro;
        private Button btnFiltro;
        private Label lblCampo;
        private Label lblCriterio;
        private Label lblFiltroAvanzado;
        private ComboBox cboCampo;
        private ComboBox cboCriterio;
        private TextBox txtFiltroAvanzado;
        private Label lblListaArticulos;
    }
}