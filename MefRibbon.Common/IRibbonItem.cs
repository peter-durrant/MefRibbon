using System.ComponentModel.Composition;

namespace MefRibbon.Common
{
   /// <summary>
   ///    A marker interface for RibbonButton and RibbonMenuButton objects to be placed in the ribbon
   ///    itself.
   /// </summary>
   [InheritedExport(typeof(IRibbonItem))]
   public interface IRibbonItem
   {
   }
}