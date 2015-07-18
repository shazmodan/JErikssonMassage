using Nancy;

namespace JErikssonMassage
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ =>
            {
                return View["Content/index.html", null].WithContentType("text/html;charset=utf8");
            };
        }
    }
}
