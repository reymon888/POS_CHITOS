namespace POS_CHITOS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = new V_LogIn();
            Usuario usuario = null;

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                usuario = loginForm.UsuarioAutenticado; // Obtenemos el usuario autenticado
                Application.Run(new menuPrincipal(usuario)); // Pasamos el usuario al menú principal
            }
        }
    }
    }
