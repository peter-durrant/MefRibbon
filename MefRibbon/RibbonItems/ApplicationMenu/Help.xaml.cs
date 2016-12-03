using System.Windows;
using System.Windows.Controls.Ribbon;
using MefRibbon.Common;

namespace MefRibbon.RibbonItems.ApplicationMenu
{
   /// <summary>
   ///    Interaction logic for HelpApplicationMenuItem.xaml
   /// </summary>
   public partial class HelpApplicationMenuItem : RibbonApplicationMenuItem, IRibbonMenuItem
   {
      public HelpApplicationMenuItem()
      {
         InitializeComponent();
      }

      private void Help_Click(object sender, RoutedEventArgs e)
      {
         MessageBox.Show("You've been helped!");
      }
   }
}