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
using ProyectoPAV.Formularios.Transacciones;

namespace ProyectoPAV.Formularios.Transacciones
{
    public partial class FrmProductosTransacciones : Form
    {
        public string FormularioPadre { get; set; }

        PruebaGestorTransacciones gestor;

        string idVenta;
        public FrmProductosTransacciones(PruebaGestorTransacciones ges, string idVent="1")
        {            
            InitializeComponent();
            gestor = ges;
            idVenta = idVent;
        }

        private void Consulta()
        {
            ProductosABM productos = new ProductosABM();
            string cadenaResultado;
            DataTable tabla = new DataTable();
            cadenaResultado = productos.ConsultarProductos().ToString();
            tabla = productos.tablaProducto;
            if (cadenaResultado == "correcto")
            {
                this.CargarGrilla(tabla);
            }
            else
            {
                MessageBox.Show(productos.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarGrilla(DataTable tabla)
        {
            dataGridProductos.DataSource = tabla;
            dataGridProductos.Columns[0].Visible = false;
            dataGridProductos.Columns[4].Visible = false;
            dataGridProductos.Columns[5].Visible = false;
            dataGridProductos.Columns[1].HeaderText = "Codigo Producto";
            dataGridProductos.Columns[2].HeaderText = "Numero Talle";
            dataGridProductos.Columns[3].HeaderText = "Nombre";
            dataGridProductos.Columns[6].HeaderText = "StockDisponible";
            dataGridProductos.Columns[7].HeaderText = "Marca";
            dataGridProductos.Columns[8].HeaderText = "Categoria";
        }

        private void botonBuscarProducto_Click(object sender, EventArgs e)
        {
            ProductosABM productos = new ProductosABM();
            string cadenaResultado;
            string selectedValue = "";
            DataTable tabla = new DataTable();

            if (comboCategorias.SelectedValue == null)
            {
                selectedValue = "0";
            }
            else
            {
                selectedValue = this.comboCategorias.SelectedValue.ToString();
            }

            if (this.textBoxNombreProducto.Text != "" || this.textBoxMarca.Text != ""
                || selectedValue != "0")
            {

                cadenaResultado = productos.ConsultarProductosFiltros(this.textBoxNombreProducto.Text, this.textBoxMarca.Text,
                selectedValue).ToString();
                if (cadenaResultado == "correcto")
                {
                    tabla = productos.tablaProducto;
                    this.CargarGrilla(tabla);
                }
                else
                {
                    MessageBox.Show(productos.mensajeRetorno, "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Consulta();
            }
        }
        string IdProducto;
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.CurrentRow != null)
            {
                //aca se obtine la id del producto
                IdProducto = dataGridProductos.CurrentRow.Cells[0].Value.ToString();
                //se le reduce en 1 el stock al producto
                gestor.ejecutar_no_select(@"update Producto set StockDisponible -=1 where IdProducto='"+IdProducto+"';");

                string precio = dataGridProductos.CurrentRow.Cells[7].Value.ToString();

                gestor.ejecutar_no_select(@"insert DetalleVenta values ("+idVenta+","+IdProducto+ ",666," + precio + ");");

                //gestor.cerrar_transaccion();
                this.Dispose();
                /*
                if (FormularioPadre == "Ventas")
                {
                    FrmVentasNueva nuevaVenta = Owner as FrmVentasNueva;
                    nuevaVenta.IdProducto = dataGridProductos.CurrentRow.Cells[0].Value.ToString();
                }
                if (FormularioPadre == "Compras")
                {
                    FrmCompraNueva nuevaCompra= Owner as FrmCompraNueva;
                    nuevaCompra.IdProducto = dataGridProductos.CurrentRow.Cells[0].Value.ToString();
                }*/
            }
            else
            {
                MessageBox.Show("Primero seleccione una fila de la grilla"
                    , "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmProductosTransacciones_Load(object sender, EventArgs e)
        {
            dataGridProductos.DataSource = gestor.ejecutar_consulta(@"select p.IdProducto,p.Nombre, p.CodigoProducto, p.NumeroTalle, p.StockDisponible, m.Nombre as Marca,c.Nombre as Categoria,p.PrecioUnitario from Producto p join Marca m on p.IdMarca=m.IdMarca join Categoria c on p.IdCategoria=c.IdCategoria where p.StockDisponible>=1 ;");

            comboCategorias = CargadorCombos.CargarComboCategoria(comboCategorias);
        }

        private void botonNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmProductosNuevo nuevoProducto = new FrmProductosNuevo();
            nuevoProducto.ShowDialog();
        }
    }
}
