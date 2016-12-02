namespace MefRibbon.Common
{
   /// <summary>
   ///    Defines the information necessary to determine the location in which an IRibbonItem should be
   ///    placed within the Ribbon tree.
   /// </summary>
   public interface IRibbonLocationAttribute
   {
      /// <summary>
      ///    Gets the name of the tab the IRibbonItem should be placed within.
      /// </summary>
      string TabName { get; }

      /// <summary>
      ///    Gets the name of the group the IRibbonItem should be placed within.
      /// </summary>
      string GroupName { get; }
   }
}