using System.Windows;
using System.Windows.Controls.Ribbon;
using MefRibbon.Common;

namespace MefRibbon.RibbonItems.Buttons
{
   [RibbonLocation("Main", "Text Manipulation")]
   public partial class Copy : RibbonButton, IRibbonItem
   {
      public Copy()
      {
         InitializeComponent();
      }

      private void Copy_Click(object sender, RoutedEventArgs e)
      {
         MessageBox.Show("Nothing was actually copied!");
      }
   }
}