using System;
using System.ComponentModel.Composition;

namespace MefRibbon.Common
{
   /// <summary>
   ///    A MetadataAttribute that helps determine the location of a specific IRibbonItem.
   /// </summary>
   [MetadataAttribute]
   [AttributeUsage(AttributeTargets.Class, Inherited = false)]
   public sealed class RibbonLocation : ExportAttribute, IRibbonLocationAttribute
   {
      public RibbonLocation(string tabName, string groupName)
         : base(typeof(IRibbonItem))
      {
         TabName = tabName;
         GroupName = groupName;
      }

      public string TabName { get; }

      public string GroupName { get; }
   }
}