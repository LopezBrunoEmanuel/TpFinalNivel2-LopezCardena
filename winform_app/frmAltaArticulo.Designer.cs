namespace winform_app
{
    partial class frmAltaArticulo
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
            lblCodigo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblCategoria = new Label();
            lblMarca = new Label();
            cboCategoria = new ComboBox();
            cboMarca = new ComboBox();
            lblImagenUrl = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            txtImagenUrl = new TextBox();
            pbxArticulos = new PictureBox();
            btnAgregarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxArticulos).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(52, 42);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(47, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(52, 100);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(46, 15);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio: ";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.Location = new Point(104, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(122, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.Location = new Point(104, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(122, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.WhiteSmoke;
            txtPrecio.Location = new Point(104, 92);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(122, 23);
            txtPrecio.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.WhiteSmoke;
            btnAceptar.FlatAppearance.BorderSize = 3;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Location = new Point(79, 258);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(71, 25);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.FlatAppearance.BorderSize = 3;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(174, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 26);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(38, 187);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(47, 214);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 9;
            lblMarca.Text = "Marca";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(105, 179);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 6;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(105, 206);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(120, 23);
            cboMarca.TabIndex = 7;
            // 
            // lblImagenUrl
            // 
            lblImagenUrl.AutoSize = true;
            lblImagenUrl.Location = new Point(36, 152);
            lblImagenUrl.Name = "lblImagenUrl";
            lblImagenUrl.Size = new Size(68, 15);
            lblImagenUrl.TabIndex = 13;
            lblImagenUrl.Text = "ImagenUrl: ";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(29, 127);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 15);
            lblDescripcion.TabIndex = 15;
            lblDescripcion.Text = "Descripcion: ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.Location = new Point(105, 119);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(122, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // txtImagenUrl
            // 
            txtImagenUrl.BackColor = Color.WhiteSmoke;
            txtImagenUrl.Location = new Point(104, 150);
            txtImagenUrl.Name = "txtImagenUrl";
            txtImagenUrl.Size = new Size(122, 23);
            txtImagenUrl.TabIndex = 4;
            txtImagenUrl.Leave += txtImagenUrl_Leave;
            // 
            // pbxArticulos
            // 
            pbxArticulos.Location = new Point(325, 34);
            pbxArticulos.Name = "pbxArticulos";
            pbxArticulos.Size = new Size(162, 195);
            pbxArticulos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxArticulos.TabIndex = 18;
            pbxArticulos.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.BackColor = Color.WhiteSmoke;
            btnAgregarImagen.FlatStyle = FlatStyle.Popup;
            btnAgregarImagen.Location = new Point(256, 126);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(41, 41);
            btnAgregarImagen.TabIndex = 5;
            btnAgregarImagen.Text = "+";
            btnAgregarImagen.UseVisualStyleBackColor = false;
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // frmAltaArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(526, 304);
            Controls.Add(btnAgregarImagen);
            Controls.Add(pbxArticulos);
            Controls.Add(txtImagenUrl);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblImagenUrl);
            Controls.Add(cboMarca);
            Controls.Add(cboCategoria);
            Controls.Add(lblMarca);
            Controls.Add(lblCategoria);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            MaximumSize = new Size(542, 343);
            MinimumSize = new Size(542, 343);
            Name = "frmAltaArticulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Articulo";
            Load += frmAltaArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)pbxArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblPrecio;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblCategoria;
        private Label lblMarca;
        private ComboBox cboCategoria;
        private ComboBox cboMarca;
        private Label lblImagenUrl;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private TextBox txtImagenUrl;
        private PictureBox pbxArticulos;
        private Button btnAgregarImagen;
    }
}