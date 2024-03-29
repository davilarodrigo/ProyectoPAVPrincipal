﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Clases;

namespace ProyectoPAV.Formularios.Auxiliares
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            AuxiliaresABM categorias = new AuxiliaresABM();
            DataTable tabla = new DataTable();
            tabla = categorias.ConsultarAuxiliares("Categoria");
            categorias.CargarGrillaAuxiliares(tabla, dataGridCategorias);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNuevaCategoria.Text == "")
            {
                MessageBox.Show("No cargó datos"
                    , "Importante!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNuevaCategoria.Focus();
                return;
            }
            if (this.textBoxNuevaCategoria.Text != "")
            {
                AuxiliaresABM categoria = new AuxiliaresABM();
                categoria.InsertarAuxiliares(this.textBoxNuevaCategoria.Text, "Categoria");

                consulta();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCategorias.CurrentRow != null)
            {
                if (MessageBox.Show("Seguro que desea eliminarlo?", "Importante!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    AuxiliaresABM categoria = new AuxiliaresABM();
                    string Nombre = dataGridCategorias.CurrentRow.Cells[1].Value.ToString();
                    categoria.EliminarAuxiliares(Nombre, "Categoria");
                    consulta();
                }
            }
            else
            {
                MessageBox.Show("Para eliminar primero seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
            }
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
