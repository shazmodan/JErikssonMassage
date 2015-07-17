using Nancy;

namespace JErikssonMassage
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ =>
            {
                //Response.Context.Response.ContentType = "text/html; charset=utf8";
                return View["Content/index.html", null].WithContentType("text/html;charset=utf8");
            };
        }
    }
}
