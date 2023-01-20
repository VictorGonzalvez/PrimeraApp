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
    public partial class frmAgregarCategoriaMarca : Form
    {
        private Categoria categoria = null;
        private Marca marca = null;
        private bool marcaActiva;
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        public frmAgregarCategoriaMarca(bool marca = false)
        {
            InitializeComponent();
            marcaActiva = marca;
        }
        public frmAgregarCategoriaMarca(Categoria categoria,bool marca = false)
        {
            InitializeComponent();
            marcaActiva = marca;
            this.categoria = categoria;
            btnAgregar.Text = "Modificar categoria.";
            Text = categoria.Descripcion;
        }
        public frmAgregarCategoriaMarca(Marca marca, bool marcas = false)
        {
            InitializeComponent();
            marcaActiva = marcas;
            this.marca = marca;
            btnAgregar.Text = "Modificar Marca";
            Text = marca.Descripcion;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevo = txtAgregar.Text;
            if (txtAgregar.Text != "")
            {
                if (marcaActiva)
                {
                    if (marca != null)
                    {
                        marcaNegocio.modificarMarca(marca, txtAgregar.Text);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        marcaNegocio.agregarMarca(nuevo);
                        MessageBox.Show("Agregado Exitosamente");

                    }
                }
                else
                {
                    if (categoria != null)
                    {
                        categoriaNegocio.modificarCategoria(categoria, txtAgregar.Text);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        categoriaNegocio.agregarCategoria(nuevo);
                        MessageBox.Show("Agregado Exitosamente");

                    }
                }
                Close();
            }
            else
                MessageBox.Show("Por favor ingrese un valor en el campo de texto.");
        }

        private void frmAgregarCategoriaMarca_Load(object sender, EventArgs e)
        {
            if (marcaActiva)//si es marca y se pasa por parametro se carga en el txtbox
            {
                if (marca != null)
                    txtAgregar.Text = marca.Descripcion;
            }
            else
            {
                if (categoria != null)
                    txtAgregar.Text = categoria.Descripcion;
            }
            

        }
    }
}
