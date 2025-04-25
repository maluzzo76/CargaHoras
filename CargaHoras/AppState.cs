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

        public string UserImageUrl { get; set; } = string.Empty;

        public string DefaultCliente { get; set; } = string.Empty;
        public string DefaultAreaFuncional { get; set; } = string.Empty;
        public string DefaultProducto { get; set; } = string.Empty;
        public int DefaultClienteId { get; set; } 
        public int DefaultAreaFuncionalId { get; set; }
        public int DefaultProductoId { get; set; }

        public int NueroSemana { get; set; }

    }
}
