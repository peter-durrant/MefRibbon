using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using MefRibbon.Common;

namespace MefRibbon.Controls
{
   public class MefRibbon : Ribbon
   {
      [ImportMany] private IEnumerable<Lazy<IRibbonItem, IRibbonLocationAttribute>> _ribbonItems;

      [ImportMany] private IEnumerable<IRibbonMenuItem> _ribbonMenuItems;

      [ImportMany] private IEnumerable<IRibbonQuickItem> _ribbonQuickItems;

      public MefRibbon()
      {
         MefHelper.Instance.Container.ComposeParts(this);
         Loaded += MefRibbon_Loaded;
      }

      private void MefRibbon_Loaded(object sender, RoutedEventArgs e)
      {
         _ribbonMenuItems.ToList().ForEach(x => ApplicationMenu.Items.Add(x));
         _ribbonQuickItems.ToList().ForEach(x => QuickAccessToolBar.Items.Add(x));

         _ribbonItems.ToList().ForEach(item =>
         {
            var oTab = FetchOrCreateTab(item.Metadata.TabName);
            var oGroup = FetchOrCreateGroup(oTab, item.Metadata.GroupName);
            oGroup.Items.Add(item.Value);
         });
      }

      private static RibbonGroup FetchOrCreateGroup(ItemsControl oTab, string name)
      {
         var oGroups = oTab.Items.Cast<RibbonGroup>().Where(group => group.Header.ToString() == name);

         var ribbonGroups = oGroups as IList<RibbonGroup> ?? oGroups.ToList();
         if (ribbonGroups.Any())
         {
            return ribbonGroups.First();
         }

         // We need a new group
         var oGroup = new RibbonGroup {Header = name};

         oTab.Items.Add(oGroup);
         return oGroup;
      }

      private RibbonTab FetchOrCreateTab(string name)
      {
         // Fetch the RibbonTab object with the correct header
         var oTabs = Items.Cast<RibbonTab>().Where(tab => tab.Header.ToString() == name);

         var ribbonTabs = oTabs as IList<RibbonTab> ?? oTabs.ToList();
         if (ribbonTabs.Any())
         {
            return ribbonTabs.First();
         }

         // We need a new tab.
         var oTab = new RibbonTab {Header = name};
         Items.Add(oTab);

         return oTab;
      }
   }
}