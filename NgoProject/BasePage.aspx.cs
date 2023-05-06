using Autofac;
using Autofac.Integration.Web;
using System;
using System.Web;
using System.Web.UI;

namespace NgoProject
{
    public partial class BasePage : Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            var cpa = (IContainerProviderAccessor)HttpContext.Current.ApplicationInstance;
            var cp = cpa.ContainerProvider;
            cp.RequestLifetime.InjectProperties(this);
        }
    }
}