using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
   public class dllTest
   {
      public virtual int fn_Add(int a, int b)
      {
         return a + b;
      }
   }

   public class Print
   {
      public void Showmsg()
      {
         MessageBox.Show("Hello World");
      }
   }

   public static class sPrint
   {
      public static void Showmsg()
      {
         MessageBox.Show("Hello World");
      }
   }

}
