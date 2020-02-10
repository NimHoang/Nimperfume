using System.Web;
using System.Web.Optimization;

namespace Perfume
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
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery-ui.min.js",
                        "~/Scripts/jquery.countdown.min.js",
                        "~/Scripts/jquery.nice-select.min.js",
                        "~/Scripts/jquery.zoom.min.js",
                        "~/Scripts/jquery.dd.min.js",
                        "~/Scripts/jquery.slicknav.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/main.js",
                        "~/Scripts/jquery.dd.min.js"
                        ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/elegant-icon.css",
                       "~/Content/owl.carousel.min.css",
                        "~/Content/themify-icons.css",
                         "~/Content/nice-select.css",
                          "~/Content/jquery-ui.min.css",
                           "~/Content/slicknav.min.css",
                           "~/Content/font-awesome.min.css",
                            "~/Content/style.css"));
        }
    }
}
