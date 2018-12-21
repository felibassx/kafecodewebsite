using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using models.Utils;
using System.ComponentModel.DataAnnotations.Schema;

namespace models
{
    public class Categoria
    {
        [Key]
        public int categoriaID { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [DisplayName("Nombre de la categoría")]
        [StringLength(100)]
        public string nombre { get; set; }

        //Propiedad de navegacion que hace referencia los productos pertenecientes a la categoria
        public virtual ICollection<Producto> productos { get; set; }
    }
}