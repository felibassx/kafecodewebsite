using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;

namespace models
{
    /// <summary>
    /// Esta clase inicializará la base de datos en la primera ejecución de la aplicación
    /// </summary>
    public class Initializer : DropCreateDatabaseAlways<KafeCodeContext>
    {
        /// <summary>
        /// a traves del método Seed insertaremos los datos semilla o iniciales para la aplicación
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(KafeCodeContext context)
        {

            //Insertar Categorias
            var categorias = new List<Categoria> {
                new Categoria
                {
                    nombre = "Publicidad"
                },
                new Categoria
                {
                    nombre = "Software Factory"
                }
            };

            //Se insertan las categorías a traves de las siguientes expresiones lambda:
            categorias.ForEach(s => context.Categorias.Add(s));
            context.SaveChanges();


            //Insertar Productos
            var productos = new List<Producto> {
                new Producto{
                    nombre = "Campañas Adsword",
                    descrpcion = "Implementación de campañas Adswords, se crea un plan y se implementa",
                    imagen = Utils.Utils.getFileBytes("\\Images\\logo_adWords.png"),
                    tipoImagen = "png",
                    precio = 100000.0m,
                    fechaCreacion = DateTime.Now,
                    esActivo = true,
                    categoriaID = 1
                },
                new Producto{
                    nombre = "Landing Pages",
                    descrpcion = "Crea tu Landing Page con nosotros, utilizamos la mejor tecnología de desarrollo web.",
                    imagen = Utils.Utils.getFileBytes("\\Images\\landing_page.jpg"),
                    tipoImagen = "jpg",
                    precio = 100000.0m,
                    fechaCreacion = DateTime.Now,
                    esActivo = true,
                    categoriaID = 2
                },
                new Producto{
                    nombre = "Software a la medida",
                    descrpcion = "Tienes un proyecto de software para tu empres?, nosotros lo realizamos, tenemos un equipo informático de primer nivel.",
                    imagen = Utils.Utils.getFileBytes("\\Images\\software_factory.png"),
                    tipoImagen = "png",
                    precio = 100000.0m,
                    fechaCreacion = DateTime.Now,
                    esActivo = true,
                    categoriaID = 2
                }

            };

            //Se insertan los productos a traves de las siguientes expresiones lambda:
            productos.ForEach(s => context.Productos.Add(s));
            context.SaveChanges();


            base.Seed(context);

        }

    }
}
