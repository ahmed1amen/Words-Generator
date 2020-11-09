using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PermutationCs {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
         WireUpEvents();
         cmbMode.DataSource = _Modes;
         UpdateWordCount();
      }
#if false
   Private Sub AnythingHappend(sender As Object, e As EventArgs) Handles btCountWords.Click, btApply2Words.Click, btApplyNumeric.Click, cmbMode.SelectedIndexChanged, ckRespectOrder.CheckedChanged, ckWithRepetitions.CheckedChanged, btPermutateWords.Click
      Select Case True
         Case sender Is btPermutateWords : PermutateWords()

         Case sender Is btCountWords : UpdateWordCount()

         Case sender Is btApply2Words : Apply2Words(CInt(numChooseK.Value), CInt(numFromN.Value), _Modes(cmbMode.SelectedIndex))

         Case sender Is btApplyNumeric : ApplyNumeric(CInt(numChooseK.Value), CInt(numFromN.Value), _Modes(cmbMode.SelectedIndex))

         Case sender Is ckRespectOrder, sender Is ckWithRepetitions 'synchronisize CombinatoricMode with Checkboxes
            Dim i = Convert.ToInt32(ckRespectOrder.Checked) * 2 + Convert.ToInt32(ckWithRepetitions.Checked)
            cmbMode.SelectedIndex = i

         Case sender Is cmbMode 'synchronisize CombinatoricMode with Checkboxes
            Dim mode = _Modes(cmbMode.SelectedIndex)
            ckRespectOrder.Checked = (mode And CombinatoricMode.Variation_NoRepetition) = CombinatoricMode.Variation_NoRepetition
            ckWithRepetitions.Checked = (mode And CombinatoricMode.Combination_WithRepetitions) = CombinatoricMode.Combination_WithRepetitions
      End Select
   End Sub
#endif
      private void WireUpEvents() {
         btPermutateWords.Click += (s, e) => PermutateWords();
         btCountWords.Click += (s, e) => UpdateWordCount();
         btApply2Words.Click += (s, e) => Apply2Words(Convert.ToInt32(numChooseK.Value), Convert.ToInt32(numFromN.Value), _Modes[cmbMode.SelectedIndex]);
         btApplyNumeric.Click += (s, e) => ApplyNumeric(Convert.ToInt32(numChooseK.Value), Convert.ToInt32(numFromN.Value), _Modes[cmbMode.SelectedIndex]);
         EventHandler dlg = (s, e) => { cmbMode.SelectedIndex = Convert.ToInt32(ckRespectOrder.Checked) * 2 + Convert.ToInt32(ckWithRepetitions.Checked); };
         ckRespectOrder.CheckedChanged += dlg;
         ckWithRepetitions.CheckedChanged += dlg;
         cmbMode.SelectedIndexChanged += (s, e) => {
            var mode = _Modes[cmbMode.SelectedIndex];
            ckRespectOrder.Checked = (mode & CombinatoricMode.Variation_NoRepetition) == CombinatoricMode.Variation_NoRepetition;
            ckWithRepetitions.Checked = (mode & CombinatoricMode.Combination_WithRepetitions) == CombinatoricMode.Combination_WithRepetitions;
         };
      }
      private CombinatoricMode[] _Modes = { CombinatoricMode.Combination_NoRepetition, CombinatoricMode.Combination_WithRepetitions, CombinatoricMode.Variation_NoRepetition, CombinatoricMode.Variation_WithRepetitions };

      private Regex _rgxWords = new Regex("\\s+");
      private void UpdateWordCount() {
         var wrdCount = _rgxWords.Split(txtInput.Text.Trim()).Length;
         numFromN.Value = wrdCount;
         lbWordCount.Text = wrdCount.ToString();
      }
      private void PermutateWords() {
         var words = _rgxWords.Split(txtInput.Text.Trim());
         var fromN = words.Length;
         if (fromN > 7) {
            txtOutput.Text = "Many permutations requested - may take some time...";
            txtOutput.Refresh();
         }
         if (fromN > 9) {
            MessageBox.Show("avoid to input more than 9 Word - Richtextbox has Trouble to display millions of results ( eg 10! = 3.628.800 )");
            return;
         }
         var wordCounts = words.GroupBy(w => w, w => 2, (g, w) => w.Count());
         var indexCounter = 0;
         var indicees = wordCounts.SelectMany(cnt => Enumerable.Repeat(indexCounter++, cnt));
         var distinctWords = words.Distinct().ToArray();
         var sb = new StringBuilder();
         var counter = 0;
         foreach (var result in Combinatorics.Permutation(indicees)) {
            sb.AppendLine(string.Join(" ", result.Select(i => distinctWords[i])));
            counter += 1;
         }
         txtOutput.Text = string.Concat("Permutating the given set of word yields: ", counter, " results\n\n", sb.ToString());
      }

      private void Apply2Words(int chooseK, int fromN, CombinatoricMode mode) {
         //demo, how to transform the int-results to any other DataType: Just take them as Indicees of an Source-Element-Array (of any type).
         var sb = new StringBuilder();
         var words = _rgxWords.Split(txtInput.Text.Trim());
         if (words.Length != fromN) {
            MessageBox.Show("number of words must equal the fromN-Parameter");
            return;
         }
         var counter = 0;
         foreach (var result in Combinatorics.ChooseKfromN(chooseK, fromN, mode)) {
            sb.AppendLine(string.Join(" ", result.Select(i => words[i]).ToArray()));
            counter += 1;
         }
         txtOutput.Text = string.Concat(Preambel(chooseK, fromN, mode), counter, " results\n\n", sb.ToString());
      }

      private void ApplyNumeric(int chooseK, int fromN, CombinatoricMode mode) {
         var sb = new StringBuilder();
         var counter = 0;
         foreach (var result in Combinatorics.ChooseKfromN(chooseK, fromN, mode)) {
            sb.Append(string.Concat(result)).Append(" ");
            counter += 1;
         }
         txtOutput.Text = string.Concat(Preambel(chooseK, fromN, mode), counter, " results\n\n", sb.ToString());
      }

      private string Preambel(int chooseK, int fromN, CombinatoricMode mode) {
         var sElementSet = string.Concat(Enumerable.Range(0, fromN));
         return string.Format("CombinatoricMode.{0}\nchoose {1} from {2} {{{3}}}\n", mode, chooseK, fromN, sElementSet);
      }

   }
}
