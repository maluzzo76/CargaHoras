using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CargaHoras.Model
{
    public class Tareas
    {
        public string Usuario { get; set; }= "";
        public int id { get; set; }
        public DateTime fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage ="Debe seleccionar un cliente")]
        public int? clienteId { get; set; }
        public int? areaFuncionalId { get; set; }

        [Required(ErrorMessage = "Debe ingresar una tarea")]
        public string tarea { get; set; } = "";

        public int? patenteId { get; set; }

        [Required(ErrorMessage = "La seleccionar un producto")]
        public int? productoId { get; set; }
        [Required(ErrorMessage = "La Hora es obligatorio")]
        [Range(1, 24, ErrorMessage = "Las horas deben estar entre 1 y 24")]
        public int horas { get; set; }
        public int minutos { get; set; } = 0;

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
