using Nancy;
using System;
using System.IO;

namespace JErikssonMassage
{
    public class IndexModule : NancyModule
    {
        private static readonly string AppPath;

        static IndexModule()
        {
            AppPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", "").Replace(@"\bin\Release", "");
        }

        public IndexModule()
        {
            Get["/"] = _ =>
            {
                return View["Content/index.html", null].WithContentType("text/html;charset=utf8");
            };

            Get["/sitemap.xml"] = _ =>
            {
                var sitemapFile = Path.Combine(AppPath, "Content\\sitemap.xml");
                var sitemap = File.ReadAllText(sitemapFile);
                return Response.AsText(sitemap).WithContentType("text/xml;charset=utf8");
            };
        }
    }
}
