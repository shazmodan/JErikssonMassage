using SquishIt.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace JErikssonMassage
{
    public class Bundles
    {
        private const string StylesPath = "~/Styles/";
        private const string ScriptsPath = "~/Scripts/";

        public const string CombinedCssName = "combined.css";
        public const string CombinedJavaScriptName = "combined.js";
        public const string CombinedDirectoryPath = "~/Content/";

        public static void BuildBundles()
        {
            Bundle.Css()
                .AddDirectory(StylesPath)
                .ForceRelease()
                .Render(CombinedDirectoryPath + CombinedCssName);

            Bundle.JavaScript()
                .AddDirectory(ScriptsPath)
                .ForceRelease()
                .Render(CombinedDirectoryPath + CombinedJavaScriptName);
        }
    }
}