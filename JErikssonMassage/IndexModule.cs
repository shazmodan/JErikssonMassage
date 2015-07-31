using Nancy;

namespace JErikssonMassage
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ =>
            {
                return View["index.html", new { Bundles.CombinedCssPath, Bundles.CombinedJsPath }].WithContentType("text/html;charset=utf8");
            };
        }
    }
}
