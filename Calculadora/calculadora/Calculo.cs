using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
   class Calculo
   {
      public float Add(float n1, float n2)
      {
         return n1 + n2;
      }
      public float Decrease(float n1, float n2)
      {
         return n1 - n2;
      }
      public float Share(float n1, float n2)
      {
         return n1 / n2;
      }
      public float Multiply(float n1, float n2)
      {
         return n1 * n2;
      }
   }
}
