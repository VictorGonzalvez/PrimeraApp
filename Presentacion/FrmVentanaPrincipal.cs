using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class FrmVentanaPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public FrmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            Text = "Catalogo";
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvVentanaPrincipal.DataSource = listaArticulos;
            cargarImagen(listaArticulos[0].ImagenUrl);
            ocultarColumna("ImagenUrl");
            
            
        }

        private void ocultarColumna(string columna)
        {
            dgvVentanaPrincipal.Columns[columna].Visible = false;
        }
        private void cargarImagen(string urlImagen)
        {
            try
            {
                pbxVentanaPrincipal.Load(urlImagen);
            }
            catch (Exception)
            {

                pbxVentanaPrincipal.Load("https://cdn-icons-png.flaticon.com/512/85/85488.png");
            }
        }

        private void dgvVentanaPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvVentanaPrincipal.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }
    }
}
