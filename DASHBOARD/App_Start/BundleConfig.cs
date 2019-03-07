using System.Web;
using System.Web.Optimization;

namespace DASHBOARD
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //CSS HIBA CRM
            bundles.Add(new StyleBundle("~/Content/LoginCss").Include(
                      "~/Content/res/assets/node_modules/bootstrap/css/bootstrap.min.css",
                      "~/Content/res/css/pages/login-register-lock.css",
                      "~/Content/res/css/style.css",
                      "~/Content/res/css/colors/default.css",
                      "~/Content/res/css/gsport-style.css"));

            bundles.Add(new StyleBundle("~/Content/IndexCss").Include(
                      "~/Content/res/assets/node_modules/bootstrap/css/bootstrap.min.css",
                      "~/Content/res/assets/node_modules/perfect-scrollbar/css/perfect-scrollbar.css",
                      "~/Content/res/assets/node_modules/morrisjs/morris.css",
                      "~/Content/res/assets/node_modules/c3-master/c3.min.css",
                      "~/Content/res/assets/node_modules/toast-master/css/jquery.toast.css",
                      "~/Content/res/assets/node_modules/bootstrap-material-datetimepicker/css/bootstrap-material-datetimepicker.css",
                      "~/Content/res/assets/node_modules/timepicker/bootstrap-timepicker.min.css",
                      "~/Content/res/assets/node_modules/clockpicker/dist/jquery-clockpicker.min.css",
                      "~/Content/res/css/Common.css",
                      "~/Content/res/css/Loading.css",
                      "~/Content/res/css/TreeMenuStyle.css",
                      "~/Content/res/css/style.css",
                      "~/Content/res/css/pages/dashboard1.css",
                      "~/Content/res/css/colors/default.css",
                      "~/Content/res/css/gsport-style.css",
                      "~/Content/res/css/pages/file-upload.css"));

            //JS HIBA CRM
            bundles.Add(new ScriptBundle("~/Content/LoginJs").Include(
                      "~/Content/res/assets/node_modules/jquery/jquery.min.js",
                      "~/Content/res/assets/node_modules/bootstrap/js/popper.min.js",
                      "~/Content/res/assets/node_modules/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/Content/IndexJs").Include(
                      "~/Content/res/assets/node_modules/jquery/jquery.min.js",
                      "~/Content/res/assets/node_modules/bootstrap/js/popper.min.js",
                      "~/Content/res/assets/node_modules/bootstrap/js/bootstrap.min.js",
                      "~/Content/res/assets/node_modules/ps/perfect-scrollbar.jquery.min.js",
                      "~/Content/res/assets/node_modules/raphael/raphael-min.js",
                      "~/Content/res/assets/node_modules/morrisjs/morris.min.js",
                      "~/Content/res/assets/node_modules/d3/d3.min.js",
                      "~/Content/res/assets/node_modules/c3-master/c3.min.js",
                      "~/Content/res/assets/node_modules/toast-master/js/jquery.toast.js",
                      "~/Content/res/assets/node_modules/styleswitcher/jQuery.style.switcher.js",
                      "~/Content/res/assets/node_modules/datatables/jquery.dataTables.min.js",
                      "~/Content/res/assets/node_modules/moment/moment.js",
                      "~/Content/res/assets/node_modules/bootstrap-material-datetimepicker/js/bootstrap-material-datetimepicker.js",

                      "~/Content/res/js/waves.js",
                      "~/Content/res/js/sidebarmenu.js",
                      "~/Content/res/js/custom.min.js",
                      "~/Content/res/js/DatatablesGrid.js",
                      "~/Content/res/js/dashboard1.js",
                      "~/Content/res/js/dataTables.buttons.min.js",
                      "~/Content/res/js/buttons.flash.min.js"));

            bundles.Add(new ScriptBundle("~/Content/DataTableJS").Include(
                      "~/Content/res/vendors/datatables.net/js/jquery.dataTables.min.js",
                      "~/Content/res/vendors/datatables.net-bs/js/dataTables.bootstrap.min.js",
                      "~/Content/res/vendors/datatables.net-buttons/js/dataTables.buttons.min.js",
                      "~/Content/res/vendors/datatables.net-buttons-bs/js/buttons.bootstrap.min.js",
                      "~/Content/res/vendors/datatables.net-buttons/js/buttons.flash.min.js",
                      "~/Content/res/vendors/datatables.net-buttons/js/buttons.html5.min.js",
                      "~/Content/res/vendors/datatables.net-buttons/js/buttons.print.min.js",
                      "~/Content/res/vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js",
                      "~/Content/res/vendors/datatables.net-keytable/js/dataTables.keyTable.min.js",
                      "~/Content/res/vendors/datatables.net-responsive/js/dataTables.responsive.min.js",
                      "~/Content/res/vendors/datatables.net-responsive-bs/js/responsive.bootstrap.js",
                      "~/Content/res/vendors/datatables.net-scroller/js/dataTables.scroller.min.js"));

        }
    }
}
