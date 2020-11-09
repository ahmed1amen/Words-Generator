
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace PermutationCs {
   static class Extensions {

      [DebuggerStepThrough()]
      public static void Swap(this IList Subj, int I1, int I2) {
         var Tmp = Subj[I1];
         Subj[I1] = Subj[I2];
         Subj[I2] = Tmp;
      }


      private static int counter = 0;
      public static void OutputLine(int[] ints) {
         Debug.WriteLine("{0,4}: {1}", counter++, string.Concat(ints));
      }

      [DebuggerStepThrough()]
      public static void OutputAll(this IEnumerable<int[]> operation) {
         counter = 1;
         foreach (var result in operation) {
            OutputLine(result);
         }
         Debug.WriteLine("");
      }

   }
}