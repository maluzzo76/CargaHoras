using Microsoft.AspNetCore.Identity;

namespace CargaHoras.Model
{
    public class Tareas
    {
        public string Usuario { get; set; }= "Pablo Ons";
        public string tarea { get; set; } = string.Empty;

        public DateTime fecha { get; set; } = DateTime.Now;
        public int Hs { get; set; } = 0;
        public int Minutos { get; set; } = 0;

        public string Estado { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
        public string Producto { get; set; } = string.Empty;
        public string Patente { get; set; } = string.Empty;

        public DateTime horaRegistrada 
        {
            get 
            {
                return DateTime.Parse($"{Hs}:{Minutos}:00");
            }
        }


    }
}
