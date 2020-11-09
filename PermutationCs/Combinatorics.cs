using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
namespace PermutationCs {
   public static class Combinatorics {

      public static IEnumerable<int[]> ChooseKfromN(int chooseK, int fromN, CombinatoricMode mode) {
         var ubound = chooseK - 1;
         var nMax = fromN - 1;
         int iPivot = 0;
         switch (mode) {
         case CombinatoricMode.Combination_NoRepetition:            // keeps the resultSet asc-ordered
            var resultSet = Enumerable.Range(0, chooseK).ToArray();      // init resultSet with ascending sequence
            do {
               for (var n = resultSet[ubound]; n <= nMax; n++) {  // 1) output-loop: enumerate last digit and yield results
                  resultSet[ubound] = n;
                  yield return resultSet.ToArray();
               }
               // 2) find incrementable pivot-element: must have a gap to its successor 
               for (iPivot = ubound; iPivot-- > 0; ) if (resultSet[iPivot] < resultSet[iPivot + 1] - 1) break;
               if (iPivot < 0) yield break;               // 4) 
               // 3) "regeneration"
               var diff = resultSet[iPivot] + 1 - iPivot;               // difference between pivotValue and its index
               // fill resultSet after pivot with ascending sequence keeps it ordered without Repetitions
               for (var i = iPivot; i <= ubound; i++) resultSet[i] = i + diff;
            } while (true);

         case CombinatoricMode.Combination_WithRepetitions:            // keeps the resultSet asc-ordered
            resultSet = Enumerable.Repeat(0, chooseK).ToArray();            // init resultSet with 0
            do {
               for (var n = resultSet[ubound]; n <= nMax; n++) {  // 1) output-loop: enumerate last digit and yield results
                  resultSet[ubound] = n;
                  yield return resultSet.ToArray();
               }
               // find incrementable position 
               for (iPivot = ubound; iPivot-- > 0; ) if (resultSet[iPivot] < resultSet[iPivot + 1]) break;
               if (iPivot < 0) yield break;
               var pivotValue = resultSet[iPivot] + 1;
               // fill resultSet after pivot with same pivotValue keeps it ordered with Repetitions
               for (var i = iPivot; i <= ubound; i++) resultSet[i] = pivotValue;
            } while (true);

         case CombinatoricMode.Variation_WithRepetitions:
            resultSet = Enumerable.Repeat(0, chooseK).ToArray();
            do {
               for (var n = resultSet[ubound]; n <= nMax; n++) {  // 1) output-loop: enumerate last digit and yield results
                  resultSet[ubound] = n;
                  yield return resultSet.ToArray();
               }
               for (iPivot = chooseK; iPivot-- > 0; ) {    // find incrementable position, set others to 0
                  if (resultSet[iPivot] < nMax) break;
                  else resultSet[iPivot] = 0;
               }
               if (iPivot < 0) yield break;
               resultSet[iPivot] += 1;
            } while (true);

         case CombinatoricMode.Variation_NoRepetition:
            // this is different, and results are not in lexicographic order
            // to each Combination_NoRepetition-result the Permutation-algo is applied
            // (Variation_WithRepetitions could be implemented analogously, but its actual Algo is faster, and ordered)
            foreach (var result in ChooseKfromN(chooseK, fromN, CombinatoricMode.Combination_NoRepetition)) {
               foreach (var perm in Permutation(result)) yield return perm;
            }
            break;
         }
      }
      public static IEnumerable<int[]> Permutation(IEnumerable<int> sortedElements) {
#if false
lexicographic Permutation-Algo as described by Dijkstra:
works correct (no redundant results), even if sortedElements contains some elements of equal value
1) output perm-clone
2) find pivot-element: the last, which is smaller than its successor
3) find swap-element: the last, which is bigger than pivot
4) swap them - this preserves the descending sort-order after the pivot-position
5) reverse the array after pivot-position: now behind pivot the array is sorted ascending - which is the lexicographic minimum
6) algo terminates, when in 2) no pivot could be found
#endif
         var perm = sortedElements.ToArray();
         var ubound = perm.Length - 1;
         int pivot = 0;
         int iPivot = 0;
         do {
            yield return perm.ToArray();                           //1
            for (iPivot = ubound - 1; iPivot >= 0; iPivot += -1) {
               pivot = perm[iPivot];
               if (pivot < perm[iPivot + 1]) break;                 //2
            }
            if (iPivot < 0) yield break;                                //6
            var iSwap = Array.FindLastIndex(perm, p => p > pivot);  //3
            perm[iPivot] = perm[iSwap];                             //4
            perm[iSwap] = pivot;
            Array.Reverse(perm, iPivot + 1, ubound - iPivot);       //5
         } while (true);
      }
      
   }
   [Flags()]
   public enum CombinatoricMode { Combination_NoRepetition = 0, Combination_WithRepetitions, Variation_NoRepetition, Variation_WithRepetitions }
}