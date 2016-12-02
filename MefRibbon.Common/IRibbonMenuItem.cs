using System.ComponentModel.Composition;

namespace MefRibbon.Common
{
   /// <summary>
   ///    A marker interface for RibbonApplicationMenuItem objects.
   /// </summary>
   [InheritedExport(typeof(IRibbonMenuItem))]
   public interface IRibbonMenuItem
   {
   }
}