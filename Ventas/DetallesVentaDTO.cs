namespace POS_CHITOS.Ventas
{
    public class DetallesVentaDTO
    {
        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public float Total { get; set; }
    }
}