using System.ComponentModel.Composition;

namespace MefRibbon.Common
{
   /// <summary>
   ///    A marker interface for RibbonButton and RibbonMenuButton objects to be placed in the Quick
   ///    Access toolbar.
   /// </summary>
   [InheritedExport(typeof(IRibbonQuickItem))]
   public interface IRibbonQuickItem
   {
   }
}