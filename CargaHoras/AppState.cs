using CargaHoras.Model;
using Microsoft.EntityFrameworkCore;
using CargaHoras.Data;

namespace CargaHoras
{
    
    public class AppState
    {
        
        public string UserName { get; set; } = "";

        public List<dimClientes> lClientes { get; set; }
        public List<dimAreaFuncional> lAreaFuncional { get; set; }

        public List<dimPatentes> lPatentes { get; set; }

        public List<dimProductos> lProductos{ get; set; }
       
    }
}
