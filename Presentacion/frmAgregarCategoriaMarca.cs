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
        private Categoria categoria;
        private Marca marca;
        private bool marcaActiva;
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        public frmAgregarCategoriaMarca(bool marca = false)
        {
            InitializeComponent();
            this.marcaActiva = marca;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevo = txtAgregar.Text;
            if(marcaActiva)
            {
                marcaNegocio.agregarMarca(nuevo);
                MessageBox.Show("Agregado Exitosamente");
            }
            else
            {
                categoriaNegocio.agregarCategoria(nuevo);
                MessageBox.Show("Agregado Exitosamente");
            }
            Close();
        }

        private void frmAgregarCategoriaMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
