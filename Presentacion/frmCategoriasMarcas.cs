using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmCategoriasMarcas : Form
    {
        private bool marcas;
        private Marca marcaSeleccionada;
        private Categoria categoriaSeleccionada;
        public frmCategoriasMarcas(bool marcas = false)//Inicia lista de categorias si es false, Marcas si es true
        {
            InitializeComponent();
            this.marcas = marcas;
        }
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private void CategoriasMarcas_Load(object sender, EventArgs e)
        {
            if (marcas)
            {
                cargarListaMarcas();
                btnAgregar.Text = "Agregar Marca";
                
            }
            else
            {
                cargarListaCategorias();
                btnAgregar.Text = "Agregar Categoria";
                
            }
        }
        private void cargarListaMarcas()
        {
            dgvCategoriasMarcas.DataSource = marcaNegocio.listar();
            dgvCategoriasMarcas.Columns[0].Visible = false;
        }
        private void cargarListaCategorias()
        {
            dgvCategoriasMarcas.DataSource = categoriaNegocio.listar();
            dgvCategoriasMarcas.Columns[0].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCategoriaMarca ventana = new frmAgregarCategoriaMarca(marcas);
            if (marcas)
                ventana.Text += " Marca";
            else
                ventana.Text += " Categoria";
            ventana.ShowDialog();
            if (marcas)
                cargarListaMarcas();
            else
                cargarListaCategorias();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (marcas)
            {
                Marca seleccionado = new Marca();
                seleccionado = (Marca)dgvCategoriasMarcas.CurrentRow.DataBoundItem;
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Eliminar?, si existe algun articulo relacionado a " + dgvCategoriasMarcas.CurrentRow.DataBoundItem.ToString() + " se eliminará.", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        marcaNegocio.eliminarMarca(seleccionado);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cargarListaMarcas();
            }
            else
            {
                Categoria seleccionado = new Categoria();
                seleccionado = (Categoria)dgvCategoriasMarcas.CurrentRow.DataBoundItem;
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Eliminar?, si existe algun articulo relacionado a " + dgvCategoriasMarcas.CurrentRow.DataBoundItem.ToString() + " se eliminará.", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        categoriaNegocio.eliminarCategoria(seleccionado);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cargarListaCategorias();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (marcas)
            {
                marcaSeleccionada = (Marca)dgvCategoriasMarcas.CurrentRow.DataBoundItem;
                frmAgregarCategoriaMarca ventana = new frmAgregarCategoriaMarca(marcaSeleccionada, marcas);
                
                ventana.ShowDialog();
                cargarListaMarcas();
            }
            else
            {
                categoriaSeleccionada = (Categoria)dgvCategoriasMarcas.CurrentRow.DataBoundItem;
                frmAgregarCategoriaMarca ventana = new frmAgregarCategoriaMarca(categoriaSeleccionada, marcas);
                ventana.ShowDialog();
                cargarListaCategorias();
            }
        }
    }
}
