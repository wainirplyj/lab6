using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication1.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
            "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
            "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/mdb/css").Include(
            "~/Content/mdb.min.css", new CssRewriteUrlTransform()));
               bundles.Add(new StyleBundle("~/bundles/style/css").Include(
               "~/Content/stylea.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
            "~/Scripts/jquery-3.4.1.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/popper/js").Include(
            "~/Scripts/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
            "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/mdb/js").Include(
            "~/Scripts/mdb.min.js"));
        }
    }
}