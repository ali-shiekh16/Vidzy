﻿using System.Web;
using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/DataTables/media/js/jquery.dataTables.js",
                        "~/Scripts/DataTables/media/js/dataTables.bootstrap4.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/toastr.js",
                        "~/Scripts/typeahead.bundle.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/lumen.css",
                      "~/Content/DataTables/media/css/dataTables.bootstrap4.css",
                      "~/Content/site.css",
                      "~/Content/toastr.css",
                      "~/Content/typeahead.css"
                      ));
        }
    }
}
