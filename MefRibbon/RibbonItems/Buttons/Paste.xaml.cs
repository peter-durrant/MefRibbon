using System.Windows;
using System.Windows.Controls.Ribbon;
using MefRibbon.Common;

namespace MefRibbon.RibbonItems.Buttons
{
   [RibbonLocation("Main", "Text Manipulation")]
   public partial class Paste : RibbonButton, IRibbonItem
   {
      public Paste()
      {
         InitializeComponent();
      }

      private void Paste_Click(object sender, RoutedEventArgs e)
      {
         MessageBox.Show("Nothing was actually pasted!");
      }
   }
}