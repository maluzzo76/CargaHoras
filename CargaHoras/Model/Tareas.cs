using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;

namespace CargaHoras.Model
{
    public class Tareas
    {
        public string Usuario { get; set; }= "";
        public int id { get; set; }
        public DateTime fecha { get; set; } = DateTime.Now;
        public int? clienteId { get; set; }
        public int? areaFuncionalId { get; set; }

        public string estado { get; set; } = "Nuevo";

        public int? patenteId { get; set; }
        public int? productoId { get; set; }
        public int horas { get; set; }
        public int minutos { get; set; }

        public DateTime horaRegistrada 
        {
            get 
            {
                return DateTime.Parse($"{horas}:{minutos}:00");
            }
        }
        
        public dimClientes Cliente { get; set; }
        public dimAreaFuncional AreaFuncional { get; set; }
        public dimPatentes Patente { get; set; }
        public dimProductos Producto { get; set; }

    }
}
