using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using MefRibbon.Common;

namespace MefRibbon.RibbonItems.QuickLaunch
{
    /// <summary>
    /// Interaction logic for Undo.xaml
    /// </summary>
    public partial class Undo : RibbonButton, IRibbonQuickItem
    {
        public Undo()
        {
            InitializeComponent();
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nothing was undone!");
        }
    }
}
