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
    public partial class FrmVentanaPrincipal : Form
    {
        public FrmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            Text = "Catalogo";
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvVentanaPrincipal.DataSource = negocio.listar();
            
            
        }
    }
}
