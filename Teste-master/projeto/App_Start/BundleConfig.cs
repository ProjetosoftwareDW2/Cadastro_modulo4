using System.Web;
using System.Web.Optimization;

namespace projeto
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/admin-lte/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/admin-lte/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/admin-lte/bower_components/Ionicons/css/ionicons.min.css",
                      "~/admin-lte/css/AdminLTE.min.css",
                      "~/admin-lte/css/skins/_all-skins.min.css"));

            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
                        "~/admin-lte/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/admin-lte/bower_components/fastclick/lib/fastclick.js",
                        "~/admin-lte/js/adminlte.min.js",
                        "~/admin-lte/js/demo.js"));
        }
    }
}
