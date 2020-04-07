using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestDLL
{
   public class dllTest
   {
      public int fn_Add(int a, int b)
      {
         Console.WriteLine(a+"_"+ b);
         return a+b;
      }
   }

   public class Print
   {
      public void Showmsg()
      {
         MessageBox.Show("Hello C#");
      }
   }
}
