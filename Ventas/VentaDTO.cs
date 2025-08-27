namespace POS_CHITOS.Ventas
{
    public class VentaDTO
    {
        public int FolioVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public float TotalVenta { get; set; }

        public float PagoRecibido { get; set; }  // Nuevo campo para el pago recibido
        public float Cambio { get; set; }        // Nuevo campo para el cambio
        public string NombreUsuario { get; set; }
        public string Estado { get; set; }
        public List<DetalleVentaDTO> DetallesVenta { get; set; }  // Asegúrate de incluir esta propiedad
        public string Usuario { get; internal set; }

        public string EstadoCorte { get; set; } // Nueva propiedad para el estado del corte
    }

}