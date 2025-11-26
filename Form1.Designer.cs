using System;
using System.Windows.Forms;

namespace SoftIV_CRUD_RegistroAutenticacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePorCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePorJornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteRangoFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVespertina = new System.Windows.Forms.RadioButton();
            this.rbMatutina = new System.Windows.Forms.RadioButton();
            this.chkNotificaciones = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();

            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;

            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGeneralToolStripMenuItem,
            this.reportePorCarreraToolStripMenuItem,
            this.reportePorJornadaToolStripMenuItem,
            this.reporteRangoFechasToolStripMenuItem,
            this.reportePerfilToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";

            // Menú items
            this.reporteGeneralToolStripMenuItem.Text = "Reporte General";
            this.reporteGeneralToolStripMenuItem.Click += new System.EventHandler(this.reporteGeneralToolStripMenuItem_Click);

            this.reportePorCarreraToolStripMenuItem.Text = "Reporte por Carrera";
            this.reportePorCarreraToolStripMenuItem.Click += new System.EventHandler(this.reportePorCarreraToolStripMenuItem_Click);

            this.reportePorJornadaToolStripMenuItem.Text = "Reporte por Jornada";
            this.reportePorJornadaToolStripMenuItem.Click += new System.EventHandler(this.reportePorJornadaToolStripMenuItem_Click);

            this.reporteRangoFechasToolStripMenuItem.Text = "Reporte entre fechas";
            this.reporteRangoFechasToolStripMenuItem.Click += new System.EventHandler(this.reporteRangoFechasToolStripMenuItem_Click);

            this.reportePerfilToolStripMenuItem.Text = "Perfil del Alumno";
            this.reportePerfilToolStripMenuItem.Click += new System.EventHandler(this.reportePerfilToolStripMenuItem_Click);

            // ====== CONTROLES ======

            // ID
            this.label1.Text = "ID:";
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.txtId.Location = new System.Drawing.Point(120, 40);
            this.txtId.ReadOnly = true;

            // Nombre
            this.label2.Text = "Nombre:";
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.txtNombre.Location = new System.Drawing.Point(120, 70);
            this.txtNombre.KeyPress += new KeyPressEventHandler(this.txtNombre_KeyPress);

            // Cedula
            this.label3.Text = "Cédula:";
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.txtCedula.Location = new System.Drawing.Point(120, 100);
            this.txtCedula.KeyPress += new KeyPressEventHandler(this.txtCedula_KeyPress);

            // Carrera
            this.label4.Text = "Carrera:";
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.cbCarrera.Location = new System.Drawing.Point(120, 130);
            this.cbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;

            // Semestre
            this.label5.Text = "Semestre:";
            this.label5.Location = new System.Drawing.Point(20, 160);
            this.cbSemestre.Location = new System.Drawing.Point(120, 160);
            this.cbSemestre.DropDownStyle = ComboBoxStyle.DropDownList;

            // Jornada
            this.groupBox1.Text = "Jornada";
            this.groupBox1.Location = new System.Drawing.Point(20, 190);
            this.groupBox1.Size = new System.Drawing.Size(220, 70);

            this.rbMatutina.Text = "Matutina";
            this.rbMatutina.Location = new System.Drawing.Point(10, 20);
            this.rbMatutina.Checked = true;

            this.rbVespertina.Text = "Vespertina";
            this.rbVespertina.Location = new System.Drawing.Point(110, 20);

            this.groupBox1.Controls.Add(this.rbMatutina);
            this.groupBox1.Controls.Add(this.rbVespertina);

            // Notificaciones
            this.chkNotificaciones.Text = "Recibir notificaciones";
            this.chkNotificaciones.Location = new System.Drawing.Point(20, 270);

            // Usuario
            this.label6.Text = "Usuario:";
            this.label6.Location = new System.Drawing.Point(20, 300);
            this.txtUsuario.Location = new System.Drawing.Point(120, 300);

            // Contraseña
            this.label7.Text = "Contraseña:";
            this.label7.Location = new System.Drawing.Point(20, 330);
            this.txtContrasena.Location = new System.Drawing.Point(120, 330);
            this.txtContrasena.UseSystemPasswordChar = true;

            // ListBox
            this.listBoxAlumnos.Location = new System.Drawing.Point(360, 40);
            this.listBoxAlumnos.Size = new System.Drawing.Size(500, 300);
            this.listBoxAlumnos.SelectedIndexChanged += new EventHandler(this.listBoxAlumnos_SelectedIndexChanged);

            // Botones
            this.btnGuardar.Text = "Guardar (Ctrl+S)";
            this.btnGuardar.Location = new System.Drawing.Point(20, 370);
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);

            this.btnEditar.Text = "Editar (Ctrl+E)";
            this.btnEditar.Location = new System.Drawing.Point(140, 370);
            this.btnEditar.Click += new EventHandler(this.btnEditar_Click);

            this.btnEliminar.Text = "Eliminar (Ctrl+D)";
            this.btnEliminar.Location = new System.Drawing.Point(260, 370);
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);

            this.btnNuevo.Text = "Nuevo (Esc)";
            this.btnNuevo.Location = new System.Drawing.Point(380, 370);
            this.btnNuevo.Click += new EventHandler(this.btnNuevo_Click);

            // Fechas
            this.label8.Text = "Desde:";
            this.label8.Location = new System.Drawing.Point(20, 420);
            this.dtpDesde.Location = new System.Drawing.Point(120, 420);

            this.label9.Text = "Hasta:";
            this.label9.Location = new System.Drawing.Point(20, 450);
            this.dtpHasta.Location = new System.Drawing.Point(120, 450);

            // FORM
            this.ClientSize = new System.Drawing.Size(880, 520);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1); this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2); this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3); this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label4); this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.label5); this.Controls.Add(this.cbSemestre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkNotificaciones);
            this.Controls.Add(this.label6); this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label7); this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.listBoxAlumnos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);

            this.MainMenuStrip = this.menuStrip1;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Registro de Alumnos";

            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePorCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePorJornadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteRangoFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePerfilToolStripMenuItem;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVespertina;
        private System.Windows.Forms.RadioButton rbMatutina;
        private System.Windows.Forms.CheckBox chkNotificaciones;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContrasena;

        private System.Windows.Forms.ListBox listBoxAlumnos;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
