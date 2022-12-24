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
        private ArticuloNegocio negocio = new ArticuloNegocio();
        public FrmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            Text = "Catalogo";
            listaArticulos = negocio.listar();
            dgvVentanaPrincipal.DataSource = listaArticulos;
            cargarImagen(listaArticulos[0].ImagenUrl);
            ocultarColumna("ImagenUrl");
            ocultarColumna("Descripcion");
            
            
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
            txtDescripción.Text = seleccionado.Descripcion;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void txtDescripción_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                txtDescripción.Text = "Sin descripción";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarModificar ventana = new frmAgregarModificar();
            ventana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            seleccionado = (Articulo)dgvVentanaPrincipal.CurrentRow.DataBoundItem;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Eliminar?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    negocio.eliminarArticulo(seleccionado.Id);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()) ;
            }
            cargar();
        }
        private void cargar()
        {
            dgvVentanaPrincipal.DataSource = negocio.listar();
        }
    }
}
