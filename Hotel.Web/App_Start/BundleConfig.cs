using System.Web;
using System.Web.Optimization;

namespace Hotel.Web
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/bundles/bootstrap.min.css").Include(
				"~/Vendor/css/bootstrap.min.css"));
			bundles.Add(new StyleBundle("~/bundles/animate.css").Include(
				"~/Vendor/css/animate.css"));
			bundles.Add(new StyleBundle("~/bundles/owl.carousel.min.css").Include(
				"~/Vendor/css/owl.carousel.min.css"));
			bundles.Add(new StyleBundle("~/bundles/aos.css").Include(
				"~/Vendor/css/aos.css"));
			bundles.Add(new StyleBundle("~/bundles/bootstrap-datepicker.css").Include(
				"~/Vendor/css/bootstrap-datepicker.css"));
			bundles.Add(new StyleBundle("~/bundles/jquery.timepicker.css").Include(
				"~/Vendor/css/jquery.timepicker.css"));
			bundles.Add(new StyleBundle("~/bundles/fancybox.min.css").Include(
				"~/Vendor/css/fancybox.min.css"));
			bundles.Add(new StyleBundle("~/bundles/ionicons.css").Include(
				"~/Vendor/fonts/ionicons/css/ionicons.min.css"));
			bundles.Add(new StyleBundle("~/bundles/font-awesome.css").Include(
				"~/Vendor/fonts/fontawesome/css/font-awesome.min.css"));
			bundles.Add(new StyleBundle("~/bundles/style.css").Include(
				"~/Vendor/css/style.css"));


			bundles.Add(new ScriptBundle("~/bundles/jquery-3.3.1.min").Include(
				"~/Vendor/js/jquery-3.3.1.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery-migrate-3.0.1.min").Include(
				"~/Vendor/js/jquery-migrate-3.0.1.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/popper.min").Include(
				"~/Vendor/js/popper.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap.min").Include(
				"~/Vendor/js/bootstrap.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/owl.carousel.min").Include(
				"~/Vendor/js/owl.carousel.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery.stellar.min").Include(
				"~/Vendor/js/jquery.stellar.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery.fancybox.min").Include(
				"~/Vendor/js/jquery.fancybox.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/aos").Include(
				"~/Vendor/js/aos.js"));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker").Include(
				"~/Vendor/js/bootstrap-datepicker.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery.timepicker.min").Include(
				"~/Vendor/js/jquery.timepicker.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/main").Include(
				"~/Vendor/js/main.js"));
		}
	}
}
