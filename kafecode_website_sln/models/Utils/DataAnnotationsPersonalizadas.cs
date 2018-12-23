using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.Utils
{

    [AttributeUsage(AttributeTargets.Property)]
    public class ValidaValorPositivo : ValidationAttribute
    {
        public decimal Valor { get; set; }

        public ValidaValorPositivo()
        {
            ErrorMessage = "El número ingresado debe ser un valor positivo.";
        }

        public override bool IsValid(object value)
        {
            try
            {
                var aEvaluar = (decimal)value;
                if (aEvaluar >= 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
