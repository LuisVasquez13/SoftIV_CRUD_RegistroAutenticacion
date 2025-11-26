using System.Windows.Forms;

namespace SoftIV_CRUD_RegistroAutenticacion
{
    public static class Utilidades
    {
        public static bool SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ' ')
                return true;

            return false;
        }

        public static bool SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
                return true;

            return false;
        }

        public static bool CampoVacio(TextBox t)
        {
            return string.IsNullOrWhiteSpace(t.Text);
        }
    }
}
