using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

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

        public static Image getImageFromByteArray(this byte[] arr, int width, int height)
        {
            var output = new Bitmap(width, height);
            var rect = new Rectangle(0, 0, width, height);
            var bmpData = output.LockBits(rect,
                ImageLockMode.ReadWrite, output.PixelFormat);
            var ptr = bmpData.Scan0;
            Marshal.Copy(arr, 0, ptr, arr.Length);
            output.UnlockBits(bmpData);
            return output;
        }
    }
}
