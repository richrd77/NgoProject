using Autofac;
using Autofac.Integration.Web;
using System;
using System.Web;
using System.Web.UI;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace NgoProject
{
    public partial class BasePage : Page
    {
        public bool IsModelValid<T>(T item)
        {
            var errors = new List<ValidationResult>();
            return Validator.TryValidateObject(item, new ValidationContext(item), errors, true);
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            var cpa = (IContainerProviderAccessor)HttpContext.Current.ApplicationInstance;
            var cp = cpa.ContainerProvider;
            cp.RequestLifetime.InjectProperties(this);
        }
    }
}