using SistemaControle.Classes;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SistemaControle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.ControleContext, Migrations.Configuration>());
            this.CheckRoles();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        private void CheckRoles()
        {
            Utilidades.CheckRole("Admin");
            Utilidades.CheckRole("Professor");
            Utilidades.CheckRole("Estudante");


        }
    }
}
