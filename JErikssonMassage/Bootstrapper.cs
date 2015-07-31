using Nancy;
using Nancy.Conventions;

namespace JErikssonMassage
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddFile("/robots.txt", "robots.txt"));
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddFile("/sitemap.xml", "sitemap.xml"));
            base.ConfigureConventions(nancyConventions);
        }

        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            StaticConfiguration.DisableErrorTraces = false;

            Bundles.CleanOldBundles();
            Bundles.BuildBundles();
        }
    }
}
