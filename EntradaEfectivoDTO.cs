
namespace POS_CHITOS
{
    public class EntradaEfectivoDTO
    {
        public int idEntrada { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public float Monto { get; set; }
        public string NombreUsuario { get; set; }
        public string Estado { get; set; }
    }
}