using TelusFramework.Config;

namespace TelusFramework.Base
{
    public abstract class BaseStep : Base
    {

        public virtual void NavigateSite()
        {
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Browser.GoToUrl(Settings.AUT);
            //LogHelpers.Write("Opened the browser !!!");
        }
    }
}
