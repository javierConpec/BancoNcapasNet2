﻿using Banco.Entidades;
using Banco.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.AppWin
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void CargarFormulario(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void cargarDatos()
        {
            dgvDatos.Rows.Clear();
            var listados = ClienteBL.Listar();
            foreach(var cliente in listados) 
            { 
                dgvDatos.Rows.Add(cliente.ID, cliente.RazonSocial, cliente.Telefono, cliente.Email);
            }

        }

        private void NuevoRegistro(object sender, EventArgs e)
        {
            var frm = new ClienteEdit();
            var nuevoCliente = new Cliente();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var resultado = ClienteBL.Insertar(nuevoCliente);
            }
            

        }
    }
}
