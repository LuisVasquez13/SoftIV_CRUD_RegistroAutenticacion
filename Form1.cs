using Microsoft.VisualBasic;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SoftIV_CRUD_RegistroAutenticacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox(
                "Ingrese clave de administrador", "Acceso", "");

            if (codigo != "admin123")
            {
                MessageBox.Show("Acceso Denegado");
                this.Close();
            }

            CargarAlumnos();
        }

        // ==========================
        //  CARGAR LISTA
        // ==========================
        private void CargarAlumnos()
        {
            listBoxAlumnos.Items.Clear();

            DataTable dt = AlumnosCRUD.ObtenerTodos();

            foreach (DataRow row in dt.Rows)
            {
                listBoxAlumnos.Items.Add(
                    $"{row["Id"]} — {row["Nombre"]} — {row["Carrera"]} — {row["Jornada"]}");
            }
        }

        // ==========================
        //  GUARDAR
        // ==========================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            Alumno a = ObtenerAlumnoFormulario();

            AlumnosCRUD.Insertar(a);

            MessageBox.Show("Alumno registrado exitosamente");
            CargarAlumnos();
        }

        // ==========================
        //  EDITAR
        // ==========================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Seleccione un alumno");
                return;
            }

            Alumno a = ObtenerAlumnoFormulario();
            a.Id = int.Parse(txtId.Text);

            AlumnosCRUD.Actualizar(a);

            MessageBox.Show("Alumno actualizado");
            CargarAlumnos();
        }

        // ==========================
        //  ELIMINAR
        // ==========================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Seleccione un alumno");
                return;
            }

            if (MessageBox.Show("¿Eliminar alumno?", "Confirmación",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            AlumnosCRUD.Eliminar(int.Parse(txtId.Text));
            MessageBox.Show("Alumno eliminado");

            CargarAlumnos();
        }

        // ==========================
        //  NUEVO
        // ==========================
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
            }
            cbCarrera.Text = "";
            cbSemestre.Text = "";
            rbMatutina.Checked = true;
            chkNotificaciones.Checked = false;
        }

        // ==========================
        //  Método auxiliar
        // ==========================
        private Alumno ObtenerAlumnoFormulario()
        {
            return new Alumno
            {
                Nombre = txtNombre.Text,
                Cedula = txtCedula.Text,
                Carrera = cbCarrera.Text,
                Semestre = cbSemestre.Text,
                Jornada = rbMatutina.Checked ? "Matutina" : "Vespertina",
                Usuario = txtUsuario.Text,
                Contrasena = txtContrasena.Text,
                RecibirNotificaciones = chkNotificaciones.Checked
            };
        }

        // ==========================
        //  SELECCIONAR ANTES DE EDITAR
        // ==========================
        private void listBoxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlumnos.SelectedIndex == -1) return;

            string linea = listBoxAlumnos.SelectedItem.ToString();
            int id = int.Parse(linea.Split('—')[0].Trim());

            DataTable dt = AlumnosCRUD.ObtenerTodos();

            foreach (DataRow r in dt.Rows)
            {
                if ((int)r["Id"] == id)
                {
                    txtId.Text = r["Id"].ToString();
                    txtNombre.Text = r["Nombre"].ToString();
                    txtCedula.Text = r["Cedula"].ToString();
                    cbCarrera.Text = r["Carrera"].ToString();
                    cbSemestre.Text = r["Semestre"].ToString();
                    txtUsuario.Text = r["Usuario"].ToString();
                    txtContrasena.Text = r["Contrasena"].ToString();
                    chkNotificaciones.Checked = (bool)r["RecibirNotificaciones"];

                    if (r["Jornada"].ToString() == "Matutina")
                        rbMatutina.Checked = true;
                    else
                        rbVespertina.Checked = true;
                }
            }
        }

        // ==========================
        //  VALIDAR
        // ==========================
        private bool ValidarFormulario()
        {
            if (Utilidades.CampoVacio(txtNombre)) { MessageBox.Show("Nombre obligatorio"); return false; }
            if (Utilidades.CampoVacio(txtCedula)) { MessageBox.Show("Cédula obligatoria"); return false; }
            if (cbCarrera.Text == "") { MessageBox.Show("Seleccione una carrera"); return false; }

            return true;
        }

        // ==========================
        //  KEYPRESS
        // ==========================
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utilidades.SoloLetras(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utilidades.SoloNumeros(e);
        }

        // ==========================
        //  ATAJOS DE TECLADO
        // ==========================
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) btnGuardar.PerformClick();
            if (e.Control && e.KeyCode == Keys.E) btnEditar.PerformClick();
            if (e.Control && e.KeyCode == Keys.D) btnEliminar.PerformClick();
            if (e.Control && e.KeyCode == Keys.R) reportesToolStripMenuItem.PerformClick();
            if (e.KeyCode == Keys.Escape) btnNuevo.PerformClick();
        }

        // ==========================
        //  REPORTES
        // ==========================
        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte f = new FormReporte("rptGeneral");
            f.ShowDialog();
        }

        private void reportePorCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportParameter[] p = { new ReportParameter("Carrera", cbCarrera.Text) };
            FormReporte f = new FormReporte("rptPorCarrera", p);
            f.ShowDialog();
        }

        private void reportePorJornadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string j = rbMatutina.Checked ? "Matutina" : "Vespertina";
            ReportParameter[] p = { new ReportParameter("Jornada", j) };
            FormReporte f = new FormReporte("rptPorJornada", p);
            f.ShowDialog();
        }

        private void reporteRangoFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportParameter[] p =
            {
                new ReportParameter("Desde", dtpDesde.Value.ToString("yyyy-MM-dd")),
                new ReportParameter("Hasta", dtpHasta.Value.ToString("yyyy-MM-dd"))
            };

            FormReporte f = new FormReporte("rptRangoFechas", p);
            f.ShowDialog();
        }

        private void reportePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Seleccione un alumno");
                return;
            }

            ReportParameter[] p =
            {
                new ReportParameter("Id", txtId.Text)
            };

            FormReporte f = new FormReporte("rptPerfilAlumno", p);
            f.ShowDialog();
        }
    }
}
