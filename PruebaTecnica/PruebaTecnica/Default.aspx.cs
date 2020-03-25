using Datos;
using DatosAcceso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaTecnica
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPais();
                CargarEstado();
                CargarCiudad();
            }
        }

        private void CargarPais()
        {
            ListItem i;
            i = new ListItem("Colombia", "1");
            CmbPais.Items.Add(i);
        }

        private void CargarEstado()
        {
            ListItem i;
            i = new ListItem("ACTIVO", "true");
            CmbEstado.Items.Add(i);
            i = new ListItem("INACTIVO", "false");
            CmbEstado.Items.Add(i);
        }

        private void CargarCiudad()
        {
            ListItem i;
            i = new ListItem("BOGOTÁ", "1");
            CmbEstado.Items.Add(i);
            i = new ListItem("MEDELLIN", "2");
            CmbEstado.Items.Add(i);
            i = new ListItem("CALI", "3");
            CmbEstado.Items.Add(i);
            i = new ListItem("BUCARAMANGA", "4");
            CmbEstado.Items.Add(i);
            i = new ListItem("BARRAQUILLA", "5");
            CmbEstado.Items.Add(i);
            i = new ListItem("MANIZALES", "6");
            CmbEstado.Items.Add(i);
        }

        private void Guardar()
        {
            Alumno cliente = new Alumno();
            ClienteData Manager = new ClienteData();

            if (!string.IsNullOrEmpty(txtId.Text)) cliente.Id = Convert.ToInt32(txtId.Text.Replace("'", " ").Trim());
            if (!string.IsNullOrEmpty(txtNombre.Text)) cliente.Nombre = txtNombre.Text.Replace("'", " ").Trim();
            if (!string.IsNullOrEmpty(txtApellido.Text)) cliente.Apellido = txtApellido.Text.Replace("'", " ").Trim();
            if (!string.IsNullOrEmpty(CmbEstado.SelectedValue)) cliente.Estado = Convert.ToBoolean(CmbEstado.SelectedValue);
            if (!string.IsNullOrEmpty(txtIdentificacion.Text)) cliente.Identificacion = txtIdentificacion.Text.Replace("'", " ").Trim();





            Manager.InsertCliente(cliente);

        }

        private void Editar()
        {
            Alumno cliente = new Alumno();
            ClienteData Manager = new ClienteData();

            if (!string.IsNullOrEmpty(txtId.Text)) cliente.Id = Convert.ToInt32(txtId.Text.Replace("'", " ").Trim());
            if (!string.IsNullOrEmpty(txtNombre.Text)) cliente.Nombre = txtNombre.Text.Replace("'", " ").Trim();
            if (!string.IsNullOrEmpty(txtApellido.Text)) cliente.Apellido = txtApellido.Text.Replace("'", " ").Trim();
            if (!string.IsNullOrEmpty(CmbEstado.SelectedValue)) cliente.Estado = Convert.ToBoolean(CmbEstado.SelectedValue);
            if (!string.IsNullOrEmpty(txtIdentificacion.Text)) cliente.Identificacion = txtIdentificacion.Text.Replace("'", " ").Trim();





            Manager.UpdateCliente(cliente);

        }

        private void Buscar()
        {
            Alumno cliente = new Alumno();
            ClienteData Manager = new ClienteData();

            if (!string.IsNullOrEmpty(txtId.Text)) cliente.Id = Convert.ToInt32(txtId.Text.Replace("'", " ").Trim());
            if (!string.IsNullOrEmpty(txtNombre.Text)) cliente.Nombre = txtNombre.Text.Replace("'", " ").Trim();
            if (!string.IsNullOrEmpty(txtApellido.Text)) cliente.Apellido = txtApellido.Text.Replace("'", " ").Trim();
            if (!string.IsNullOrEmpty(CmbEstado.SelectedValue)) cliente.Estado = Convert.ToBoolean(CmbEstado.SelectedValue);
            if (!string.IsNullOrEmpty(txtIdentificacion.Text)) cliente.Identificacion = txtIdentificacion.Text.Replace("'", " ").Trim();


            var datatable = Manager.GetCliente(cliente);

            if (datatable.Rows.Count > 0)
            {
                if (datatable.Rows.Count == 1)
                {

                }
                else
                {

                }
            }

        }
    }
}