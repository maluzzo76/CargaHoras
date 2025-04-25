namespace CargaHoras.Model
{
    public class Configuracion
    {
        public int id { get; set; }
        public string Usuario { get; set; } = string.Empty;

        public int ClienteId { get; set; }

        public int AreaFuncionalId { get; set; }
    
        public int ProductoId { get; set; }

    }
}
