using System.Web;
using System.Web.Optimization;

namespace GLFadiou
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/asset/bower_components/jquery/dist/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/asset/bower_components/bootstrap/dist/js/bootstrap.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                      "~/asset/dist/js/adminlte.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/asset/bower_components/bootstrap/dist/css/bootstrap.css",
                      "~/asset/bower_components/font-awesome/css/font-awesome.css",
                      "~/asset/bower_components/Ionicons/css/ionicons.css",
                      "~/asset/dist/css/AdminLTE.css",
                      "~/asset/dist/css/skins/skin-blue.css"));
        }
    }
}
