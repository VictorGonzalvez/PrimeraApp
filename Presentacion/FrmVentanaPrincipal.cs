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
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
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
            cargarCombos();
            dgvVentanaPrincipal.AutoResizeColumns();
            ocultarColumnas();
        }
        public void cargarImagen(string urlImagen)
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
        public void cargarCombos()
        {
            cboCategorias.DataSource = categoriaNegocio.cargarCbo();
            cboMarcas.DataSource = marcaNegocio.cargarCbo();
            List<string> aux = new List<string>();
            aux.Add("Nombre A-Z");
            aux.Add("Nombre Z-A");
            aux.Add("Precio Menor a Mayor");
            aux.Add("Precio Mayor a Menor");
            cboOrden.DataSource = aux;
        }
        private void dgvVentanaPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvVentanaPrincipal.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);           
            richTextBoxDescripcion.Text = seleccionado.Descripcion;           
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgvVentanaPrincipal.DataSource = negocio.listarAvanzado(cboCategorias.SelectedItem.ToString(), cboMarcas.SelectedItem.ToString(), cboOrden.SelectedItem.ToString());
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarModificar ventana = new frmAgregarModificar();
            ventana.Text = "Nuevo Artículo";
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
            dgvVentanaPrincipal.DataSource = negocio.listarOrdenado(cboOrden.SelectedItem.ToString());
            cargarCombos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo articuloModificar ;
            articuloModificar =    (Articulo)dgvVentanaPrincipal.CurrentRow.DataBoundItem;
            frmAgregarModificar ventanaModificar = new frmAgregarModificar(articuloModificar);
            ventanaModificar.Text = articuloModificar.Nombre;
            ventanaModificar.ShowDialog();            
            cargar();            
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if(filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvVentanaPrincipal.DataSource = null;
            dgvVentanaPrincipal.DataSource = listaFiltrada;
            ocultarColumnas();
            dgvVentanaPrincipal.AutoResizeColumns();
        }
        private void ocultarColumna(string columna)
        {
            dgvVentanaPrincipal.Columns[columna].Visible = false;
        }
        private void ocultarColumnas()
        {
            ocultarColumna("ImagenUrl");
            ocultarColumna("Descripcion");
            ocultarColumna("Id");
        }
        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmCategoriasMarcas ventana = new frmCategoriasMarcas(true);
            ventana.Text = "Lista de Marcas";
            ventana.ShowDialog();           
            cargar();
            
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoriasMarcas ventana = new frmCategoriasMarcas();
            ventana.Text = "Lista de Categorias";
            ventana.ShowDialog();           
            cargar();
            
        }
        private void cboOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar();
        }
    }
}