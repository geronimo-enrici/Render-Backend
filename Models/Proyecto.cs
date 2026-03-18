namespace Backend.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Estilo { get; set; }
        public decimal Precio { get; set; }
        public int MetrosCuadrados { get; set; }
        public int Habitaciones { get; set; }
        public decimal Banos { get; set; }
        public int Niveles { get; set; }
        public string ImagenUrl { get; set; }
        public bool EsPremium { get; set; }
    }
}