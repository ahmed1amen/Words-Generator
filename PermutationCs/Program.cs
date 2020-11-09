using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermutationCs {
   static class Program {
      [STAThread]
      static void Main() {
         //CompareAlgos(); return;
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Form1());
      }
      static void CompareAlgos() {
#if false
theese Algo-Comparisons are stupid at the moment: they compare the same algo. But you can create an alternative, and check it against the previous version
#endif
         var ints = new int[] {1,2,2,3,4 };
         ComparePermutations(ints);

         CompareChooseKfromN(3, 5, CombinatoricMode.Variation_WithRepetitions); // ( 5^3 = 125 )
         CompareChooseKfromN(3, 5, CombinatoricMode.Variation_NoRepetition); // ( 5! / (5-3)! = 60 )
         CompareChooseKfromN(3, 5, CombinatoricMode.Combination_WithRepetitions); // ( 35 )
         CompareChooseKfromN(3, 5, CombinatoricMode.Combination_NoRepetition); // ( 10 )
         //Combinatorics.Permutation("12334".Select(c => int.Parse(c.ToString())).ToArray()).OutputAll(); // permutation with repetitions in Input-Set
      }
      private static void CompareChooseKfromN(int chooseK, int fromN, CombinatoricMode mode) {
         var tst1 = Combinatorics.ChooseKfromN(chooseK, fromN, mode).ToArray();
         var tst2 = Combinatorics.ChooseKfromN(chooseK, fromN, mode); // enter alternative-call here
         Compare(tst1, tst2);
      }
      private static void ComparePermutations(IEnumerable<int>ints) {// enter alternative-call here
         Compare(Combinatorics.Permutation(ints.ToArray()), Combinatorics.Permutation(ints.ToArray()));
      }

      private static void Compare(IEnumerable<int[]> tst1, IEnumerable<int[]> tst2) {
         if (tst1.SelectMany(rs => rs).SequenceEqual(tst2.SelectMany(rs => rs))) return;
         tst1.OutputAll();
         throw new Exception("algo-difference detected!");
      }
   }
}
