using System.Web;
using System.Web.Optimization;

namespace KrosfyPay
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //bundles.add(new scriptbundle("~/bundles/jquery").include(
            //            "~/scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //"~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/css/style.css",
                      "~/Content/assets/css/bootsnav.css",
                      "~/Content/assets/lib/owlcarousel/assets/owl.carousel.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Content/assets/js/animations.js",
                        "~/Content/assets/js/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/assets/js/jquery-3.4.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Content/assets/js/bootstrap.bundle.min.js.map"));

            bundles.Add(new ScriptBundle("~/bundles/jsLibrary").Include(
                        "~/Content/assets/lib/easing/easing.min.js",
                        "~/Content/assets/lib/waypoints/waypoints.min.js",
                        "~/Content/assets/lib/counterup/jquery.counterup.js",
                        "~/Content/assets/lib/counterup/jquery.counterup.min.js",
                        "~/Content/assets/lib/owlcarousel/owl.carousel.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/mail").Include(
                        "~/Content/assets/mail/jqBootstrapValidation.min.js",
                        "~/Content/assets/mail/contact.js"));



        }
    }
}
