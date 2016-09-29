using System.Web.Optimization;

namespace SampleMVCSPAApplications
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                    "~/Scripts/jquery-1.9.1.min.js",
                    "~/Scripts/bootstrap.min.js",
                    "~/Scripts/angular.min.js",
                    "~/Scripts/i18n/angular-locale_ru.js",
                    "~/Scripts/i18n/angular-locale_ru-ru.js",
                    "~/Scripts/angular-route.js",
                    "~/Scripts/angular-messages.min.js",
                    "~/Scripts/angular-local-storage.min.js",
                    "~/Scripts/bootstrap-filestyle.min.js"
                    ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-theme.min.css",
                "~/Content/bootstrap-select.min.css",
                "~/Content/Site.css"
                ));
        }
    }
}