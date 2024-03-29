﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ProyectoPAV.Clases
{
    class CargadorCombos
    {

        GestorTransaccionesSQL gestor = new GestorTransaccionesSQL();

        static GestorTransaccionesSQL gestorStatic = new GestorTransaccionesSQL();

        public static ComboBox CargarComboGenerico(ComboBox comboBox, string nombreTabla, string valueMember, string displayMember)
        {
            DataTable tabla = new DataTable();

            string sql = "select * from " + nombreTabla;

            comboBox.DataSource = gestorStatic.consultarTabla(sql);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1;

            return comboBox;
        }

        public static ComboBox CargarComboCategoria(ComboBox comboBox)
        {
            return CargarComboGenerico(comboBox, "Categoria", "IdCategoria", "Nombre");
        }

        public static ComboBox CargarComboDocumento(ComboBox comboBox)
        {
            return CargarComboGenerico(comboBox, "TipoDocumento", "IdTipoDocumento", "Nombre");
        }

        public static ComboBox CargarComboMarca(ComboBox comboBox)
        {
            return CargarComboGenerico(comboBox, "Marca", "IdMarca", "Nombre");
        }

        public static ComboBox CargarComboLocalidad(ComboBox comboBox)
        {
            return CargarComboGenerico(comboBox, "Localidad", "IdLocalidad", "Nombre");
        }

        public static ComboBox CargarComboSexo(ComboBox comboBox)
        {
            return CargarComboGenerico(comboBox, "Sexo", "IdSexo", "Nombre");
        }

        public static ComboBox CargarComboEmpleado(ComboBox comboBox)
        {
            return CargarComboGenerico(comboBox, "Empleado", "IdEmpleado", "Apellido");
        }


        public static ComboBox CargarComboCargo(ComboBox comboBox)
        {
            return CargarComboGenerico(comboBox, "Cargo", "IdCargo", "Nombre");
        }

        public static ComboBox CargarComboProveedor(ComboBox comboBox)
        {
            return CargarComboGenerico(comboBox, "Proveedor", "IdProveedor", "RazonSocial");
        }
        //////////////////////////////////////////////////////////////////////////////////////

        public DataTable CargarComboCargos()
        {
            string sql = "SELECT * FROM Cargo";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if(resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }
                        
            return tabla;
        }

        public DataTable CargarComboTiposDocumentos()
        {
            string sql = "SELECT * FROM TipoDocumento";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }

        public DataTable CargarComboSexos()
        {
            string sql = "SELECT * FROM Sexo";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }

        public DataTable CargarComboLocalidades()
        {
            string sql = "SELECT * FROM Localidad";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }
            return tabla;
        }
        
        public DataTable CargarComboCategorias()
        {
            string sql = "SELECT * FROM Categoria";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }

        public DataTable CargarComboMarcas()
        {
            string sql = "SELECT * FROM Marca";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }
        public DataTable CargarComboEmpleados()
        {
            string sql = "SELECT * FROM Empleado";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }
            return tabla;
        }
        public DataTable CargarComboProveedores()
        {
            string sql = "SELECT * FROM Proveedor";
            DataTable tabla = new DataTable();
            string resultadoTransaccion;
            resultadoTransaccion = gestor.EjecutarConsulta(sql).ToString();
            if (resultadoTransaccion == "correcto")
            {
                tabla = gestor.TablaResultado;
            }

            return tabla;

        }
    }
}
