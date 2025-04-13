using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeamento.Mapping
{
    public static class ArrayExtension
    {
        public static string[] MaptoArray(this string text)
        {
           
         return text.Split(",");
           
        }
    }
}
