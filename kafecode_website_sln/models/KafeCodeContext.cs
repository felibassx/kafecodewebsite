using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace models
{
    /// <summary>
    /// En esta clase se definen todas las entidades a crear a partir del modelo de datos codificado
    /// </summary>
    public class KafeCodeContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        
    }
}
