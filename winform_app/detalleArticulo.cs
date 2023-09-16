using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;

namespace winform_app
{
    public partial class detalleArticulo : Form
    {
        private Articulos seleccionado;
        public detalleArticulo()
        {
            InitializeComponent();
        }
        public detalleArticulo(Articulos seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            Text = "Detalle del Artículo";
        }

        private void detalleArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                cargarImagen(seleccionado.ImagenUrl);
                txtCodigoDetalle.Text = seleccionado.Codigo;
                txtNombreDetalle.Text = seleccionado.Nombre;
                txtDescripcionDetalle.Text = seleccionado.Descripcion;
                txtMarcaDetalle.Text = seleccionado.Marca.ToString();
                txtCategoriaDetalle.Text = seleccionado.Categoria.ToString();
                txtPrecioDetalle.Text = seleccionado.Precio.ToString();
                txtImagenUrlDetalle.Text = seleccionado.ImagenUrl.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        private void btdDetalle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
