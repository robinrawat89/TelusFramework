using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TelusFramework.Base;
using TelusFramework.Config;

namespace TelusTests.Hooks
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {

        public HookInitialize() : base(BrowserType.Chrome)
        {
            InitializeSettings();
            //Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);
        }


        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

        [AfterScenario]
        public void TestStop()
        {
            if (DriverContext.Driver != null)
            {
                DriverContext.Driver.Close();
                DriverContext.Driver.Quit();
                DriverContext.Driver.Dispose();
            }
            else
            {
                DriverContext.Driver.Close();
                DriverContext.Driver.Quit();
                DriverContext.Driver.Dispose();
            }

        }
    }
}
