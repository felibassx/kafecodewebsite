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
    public class Producto
    {

        /**
         * en esta clase se implementaran las DataAnnotations, que son metadatos que permiten o sirven para
         * determinar cómo desplegar y/o editar las propiedades del modelo.
         * También pueden ser usadas para validar datos de entrada del usuario hacia el modelo
         * Se pueden utilizar DataAnnotations de validación personalizadas para realizar chequeos más complejos
         * 
         * 
         * Para claves primarias compuestas se deben añadir los siguientes DataAnnotations
         * [Key]    
         * [Column(Order = 1)]
         * ClaveUno
         * 
         * [Key]    
         * [Column(Order = 2)]
         * ClaveDos
         * **/
        [Key]
        public int productoID { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [DisplayName("Nombre del Producto")]
        [StringLength(100)]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Debe agregar una imagen")]
        public byte[] imagen { get; set; }

        public string tipoImagen { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripción para el producto")]
        [DisplayName("Descripción del Producto")]
        [DataType(DataType.MultilineText)]
        [StringLength(500)]
        public string descrpcion { get; set; }

        [Required(ErrorMessage = "Debe ingresar un precio para el producto")]
        [DisplayName("Precio")]
        [Range(0, 10000000)]
        [ValidaValorPositivo]
        public decimal precio { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        [DisplayName("Fecha de creación del producto")]
        public DateTime fechaCreacion { get; set; }

        [DisplayName("Producto está activo?")]
        public bool esActivo { get; set; }


        public int categoriaID { get; set; }

        //propiedad de navegación, sirve para definir la relación entre dos entidades
        public virtual Categoria categoria { get; set; }
    }

    //Creamos un DataAnnotations personalizado que nos validará el precio
}
