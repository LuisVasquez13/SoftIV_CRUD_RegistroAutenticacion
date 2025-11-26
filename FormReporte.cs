using Microsoft.Reporting.WinForms;
using System.Data;
using System.Windows.Forms;

namespace SoftIV_CRUD_RegistroAutenticacion
{
    public partial class FormReporte : Form
    {
        public FormReporte(string nombreReporte, ReportParameter[] parametros = null)
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportPath =
                $"Reportes/{nombreReporte}.rdlc";

            DataTable dt = AlumnosCRUD.ObtenerTodos();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetAlumnos", dt));

            if (parametros != null)
                reportViewer1.LocalReport.SetParameters(parametros);

            reportViewer1.RefreshReport();
        }
    }
}
