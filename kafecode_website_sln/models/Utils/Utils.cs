using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace models.Utils
{
    /// <summary>
    /// Clase con utilidades reutilizables
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Obtiene los byte de un archivo.
        /// </summary>
        /// <param name="path">Es la ruta del archivo</param>
        /// <returns></returns>
        public static byte[] getFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int) fileOnDisk.Length);
            }

            return fileBytes;
        }
    }
}
