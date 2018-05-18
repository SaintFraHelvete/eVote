using System.Web;
using System.Web.Optimization;

namespace eVote
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Content/scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Content/scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Content/scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Content/scripts/umd/popper.min.js",
                "~/Content/scripts/bootstrap.js",
                "~/Content/scripts/mdb.min.js",
                "~/Content/scripts/respond.js",
                "~/Content/scripts/toastr.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/styles/font-awesome.min.css",
                "~/Content/styles/bootstrap.min.css",
                "~/Content/styles/mdb.css",
                "~/Content/styles/toastr.min.css",
                "~/Content/styles/site.css"));
        }
    }
}
