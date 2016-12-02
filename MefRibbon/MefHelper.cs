using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MefRibbon
{
   /// <summary>
   ///    Globalizes the MEF catalog and container in an effort to allow WPF objects to compose
   ///    themselves.  While Dependency Injection on WPF controls is possible, it can be messy, and
   ///    this object avoids that.
   /// </summary>
   public class MefHelper
   {
      /// <summary>
      ///    Private property for Instance.
      /// </summary>
      private static MefHelper _instance;

      /// <summary>
      ///    Private field for Catalog.
      /// </summary>
      private readonly AggregateCatalog _catalog = new AggregateCatalog();

      /// <summary>
      ///    Prevent instantiation of this object.
      /// </summary>
      private MefHelper()
      {
         Catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
         Container = new CompositionContainer(Catalog);
      }

      /// <summary>
      ///    Gets the instance of this object.
      /// </summary>
      public static MefHelper Instance => _instance ?? (_instance = new MefHelper());

      /// <summary>
      ///    Gets the AggregateCatalog object used for composition.
      /// </summary>
      public AggregateCatalog Catalog => _catalog;

      /// <summary>
      ///    Gets the CompositionContainer object for composition.
      /// </summary>
      public CompositionContainer Container { get; private set; }
   }
}