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
    public class SubMenu
    {
        [Key]
        public int subMenuId { get; set; }

        public int mainMenuId { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre para el SubMenu")]
        [DisplayName("Nombre del sub-menú")]
        [StringLength(80)]
        public string subMenuName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del controlador")]
        [DisplayName("Nombre del controlador")]
        [StringLength(100)]
        public string controllerName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre de la acción")]
        [DisplayName("Nombre de la accion del controlador")]
        [StringLength(100)]
        public string actionName { get; set; }

        //public int? RoleId { get; set; }
        //public string RoleName { get; set; }

        //propiedad de navegación, sirve para definir la relación entre dos entidades
        public virtual MainMenu mainMenu { get; set; }
    }
}
