﻿using System;
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
    public partial class frmAgregarModificar : Form
    {
        private Articulo articulo = null;
        bool prueba = false;
        public frmAgregarModificar()//Ventana Nuevo articulo
        {
            InitializeComponent();
        }
        public frmAgregarModificar(Articulo articulo)//Ventana Modificar Articulo
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private void frmAgregarModificar_Load(object sender, EventArgs e)
        {
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";               
                if (articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.Replace(",", ".");
                    cboCategoria.SelectedValue = articulo.Tipo.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()) ;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = new Marca();
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Tipo = new Categoria();
                articulo.Tipo = (Categoria)cboCategoria.SelectedItem;
                articulo.ImagenUrl = txtImagen.Text;

                articulo.Precio = txtPrecio.Text;
                if (txtNombre.Text != "")
                {
                    if (articulo.Id == 0)
                    {
                        articuloNegocio.agregarArticulo(articulo);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    else
                    {
                        articuloNegocio.modificarArticulo(articulo);
                        MessageBox.Show("Modificado Exitosamente");
                    }
                    Close();
                }
                else
                    MessageBox.Show("Debe ingresar obligatoriamente un Nombre para el articulo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()) ;
            }
        }
        private void cargarImagen(string urlImagen)
        {
            try
            {
                pbxAgregarModificar.Load(urlImagen);
            }
            catch (Exception)
            {

                pbxAgregarModificar.Load("https://cdn-icons-png.flaticon.com/512/85/85488.png");
            }
        }
        private void btnLimpiarCampo_Click(object sender, EventArgs e)
        {
            txtImagen.Clear();
        }
        private void txtImagen_Enter(object sender, EventArgs e)
        {
            if (!prueba)
            {               
                MessageBox.Show("Ingrese una Url de internet o cargue una imagen local.");
                prueba = true;
            }
        }
        private void btnProbarImagen_Click(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrecio.Text.Contains("."))
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Ingrese solo un punto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }
            else
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(e.KeyChar == 46)))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }          
        }
    }
}
