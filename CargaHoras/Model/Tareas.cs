using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CargaHoras.Model
{
    public class Tareas
    {
        public string Usuario { get; set; }= "";
        public int id { get; set; }
        public DateTime fecha { get; set; }

       
        public int? clienteId { get; set; }
        public int? areaFuncionalId { get; set; }

        [Required(ErrorMessage = "Debe ingresar una tarea")]
        public string tarea { get; set; } = "";

        public int? patenteId { get; set; }

        [Required(ErrorMessage = "La seleccionar un producto")]
        public int? productoId { get; set; }

        [Required(ErrorMessage = "La Hora es obligatorio")]
        [Range(0, 24, ErrorMessage = "Las horas deben estar entre 0 y 24")]
        public int horas { get; set; }

        [Required(ErrorMessage = "Minutos es obligatorio")]
        [Range(0, 59, ErrorMessage = "Los minutos deben estar entre 0 y 59 ")]
        public int minutos { get; set; } = 0;


        public DateTime horaRegistrada 
        {
            get 
            {
                return DateTime.Parse($"{horas}:{minutos}:00");
            }
        }
        
        public int NumeroSemana
        {
            get 
            {
                DateTime fecha = this.fecha;
                CultureInfo cultura = CultureInfo.InvariantCulture;
                System.Globalization.Calendar calendario = cultura.Calendar;
                CalendarWeekRule reglaSemana = CalendarWeekRule.FirstFourDayWeek;
                System.DayOfWeek primerDiaSemana = System.DayOfWeek.Monday;

                return calendario.GetWeekOfYear(fecha, reglaSemana, primerDiaSemana);
            }
        }

        public DateTime PrimerDiaSemana
        {
            get
            {
                DateTime hoy = this.fecha;

                // Hacemos que lunes sea siempre el primer día de la semana
                int diferencia = (7 + ((int)hoy.DayOfWeek - (int)DayOfWeek.Monday)) % 7;

                DateTime primerDiaSemana = hoy.AddDays(-diferencia);

                // Ahora _dia es el lunes de esta semana
                return primerDiaSemana;
            }
        }

        public dimClientes Cliente { get; set; }
        public dimAreaFuncional AreaFuncional { get; set; }
        public dimPatentes Patente { get; set; }
        public dimProductos Producto { get; set; }

    }
}
