using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using models.Utils;

namespace models
{
    public class MainMenu
    {
        [Key]
        public int menuID { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre para el menú")]
        [DisplayName("Nombre del menú")]
        [StringLength(50)]
        public string nombreMenu { get; set; }

        [DisplayName("Link")]
        [StringLength(400)]
        public string urlMenuMain { get; set; }

        //Propiedad de navegacion que hace referencia los productos pertenecientes al Menu
        public virtual ICollection<SubMenu> subMenus { get; set; }
    }
}
