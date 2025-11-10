using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Usuarios;

namespace POS_CHITOS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1) Login
            var login = new V_LogIn();
            if (login.ShowDialog() != DialogResult.OK) return;

            Usuario usuario = login.UsuarioAutenticado;
            if (usuario == null) return;

            // 2) Servicios necesarios para checar/aperturar caja
            using var ctx = new POSContext(new DbContextOptions<POSContext>());
            var cortes = new CortesService(ctx);

            // 3) Verificar si ya hay monto inicial hoy
            bool montoInicialOk = cortes.ExisteMontoInicialHoy(usuario.Id);

            // 4) Si no, abrir el diálogo de Monto Inicial
            if (!montoInicialOk)
            {
                using var dlg = new V_MontoInicial(usuario.Id, cortes);
                montoInicialOk = (dlg.ShowDialog() == DialogResult.OK);
            }

            // 5) Pasar el flag al menú principal
            Application.Run(new menuPrincipal(usuario, montoInicialOk));
        }
    }
}
