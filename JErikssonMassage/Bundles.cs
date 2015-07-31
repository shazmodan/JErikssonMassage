using SquishIt.Framework;
using System;
using System.IO;
using System.Linq;

namespace JErikssonMassage
{
    public class Bundles
    {
        private const string StylesPath = "~/Styles/";
        private const string ScriptsPath = "~/Scripts/";
        private static string CombinedCssName = string.Format("combined-{0}.css", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
        private static string CombinedJavaScriptName = string.Format("combined-{0}.js", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
        private const string CombinedDirectoryRelativePath = "~/Content/";
        private const string CombinedDirectoryPath = "Content/";

        public static string CombinedCssPath { get { return CombinedDirectoryPath + CombinedCssName; } }
        public static string CombinedJsPath { get { return CombinedDirectoryPath + CombinedJavaScriptName; } }

        public static readonly string AppPath;

        static Bundles()
        {
            AppPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", "").Replace(@"\bin\Release", "");
        }

        public static void CleanOldBundles()
        {
            var bundleFiles = Directory.GetFiles(Path.Combine(AppPath + "Content\\"), "combined*");
            var filesToRemove = bundleFiles.Where(f => f.EndsWith(".css") || f.EndsWith(".js"));
            filesToRemove.ToList().ForEach(f => File.Delete(f));
        }

        public static void BuildBundles()
        {
            Bundle.Css()
                .AddDirectory(StylesPath)
                .ForceRelease()
                .Render(CombinedDirectoryRelativePath + CombinedCssName);

            Bundle.JavaScript()
                .AddDirectory(ScriptsPath)
                .ForceRelease()
                .Render(CombinedDirectoryRelativePath + CombinedJavaScriptName);
        }
    }
}