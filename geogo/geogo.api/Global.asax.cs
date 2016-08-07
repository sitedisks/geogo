namespace geogo.api
{
    using System.Web.Http;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var config = GlobalConfiguration.Configuration;
           
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoBootstrapper.Run();
        }
    }
}
