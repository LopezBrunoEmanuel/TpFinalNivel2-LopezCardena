using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocios;
using System.Configuration;

namespace winform_app
{
    public partial class frmAltaArticulo : Form
    {
        private Articulos articulos = null;
        private OpenFileDialog archivo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            Text = " Modificar Articulo";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //Articulos article= new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (validarCarga())
                {
                    return;
                }
                if (articulos == null)
                    articulos = new Articulos();

                articulos.Codigo = txtCodigo.Text;
                articulos.Nombre = txtNombre.Text;
                articulos.Precio = decimal.Parse(txtPrecio.Text);
                articulos.Descripcion = txtDescripcion.Text;
                articulos.ImagenUrl = txtImagenUrl.Text;
                articulos.Categoria = (Categorias)cboCategoria.SelectedItem;
                articulos.Marca = (Marcas)cboMarca.SelectedItem;

                if (articulos.Id != 0)
                {
                    negocio.modificar(articulos);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(articulos);
                    MessageBox.Show("Agregado Exitosamente");
                }


                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["articulo_asset"] + archivo.SafeFileName);

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            try
            {
                cboCategoria.DataSource = categoriasNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcasNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if (articulos != null)
                {
                    txtCodigo.Text = articulos.Codigo;
                    txtNombre.Text = articulos.Nombre;
                    txtPrecio.Text = articulos.Precio.ToString();
                    txtDescripcion.Text = articulos.Descripcion;
                    txtImagenUrl.Text = articulos.ImagenUrl;
                    cargarImagen(articulos.ImagenUrl);
                    cboCategoria.SelectedValue = articulos.Categoria.Id;
                    cboMarca.SelectedValue = articulos.Marca.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulos.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private bool validarCarga()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Complete los campos vacios");
                return true;
            }
            if (!soloNumeros(txtPrecio.Text))
            {
                MessageBox.Show("Complete el campo de precio solo con números");
                return true;
            }
            else if (txtPrecio.Text == "")
            {
                MessageBox.Show("Complete los campos vacíos");
                return true;
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (char.IsLetter(caracter) || caracter == '.')
                    return false;
            }
            return true;
        }

    }
}
