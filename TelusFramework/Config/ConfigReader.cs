using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using TelusFramework.ConfigElement;
using TelusFramework.Base;

namespace TelusFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            Settings.AUT = TestConfiguration.Settings.TestSettings["testing"].AUT;
            //Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = TestConfiguration.Settings.TestSettings["testing"].TestType;
            //Settings.IsLog = TestConfiguration.Settings.TestSettings["staging"].IsLog;
            //Settings.IsReporting = isreport.Value.ToString();
            //Settings.LogPath = TestConfiguration.Settings.TestSettings["staging"].LogPath;
            //Settings.AppConnectionString = TestConfiguration.Settings.TestSettings["staging"].AUTDBConnectionstring;
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), TestConfiguration.Settings.TestSettings["testing"].Browser);






            // XPathItem aut;
            // XPathItem testtype;
            // //XPathItem islog;
            // //XPathItem isreport;
            // //XPathItem buildname;
            // //XPathItem logPath;

            // string strFilename = "C:\\Users\\Dell\\Downloads\\TelusProject\\TelusFramework\\TelusFramework\\Config\\GlobalConfig.xml";
            // FileStream stream = new FileStream(strFilename, FileMode.Open);
            // XPathDocument document = new XPathDocument(stream);
            // XPathNavigator navigator = document.CreateNavigator();

            // //Get XML Details and pass it in XPathItem type variables
            // aut = navigator.SelectSingleNode("TelusFramework/RunSettings/AUT");
            // //buildname = navigator.SelectSingleNode("EAAutoFramework/RunSettings/BuildName");
            // testtype = navigator.SelectSingleNode("TelusFramework/RunSettings/TestType");
            // //islog = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsLog");
            //// isreport = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsReport");
            // //logPath = navigator.SelectSingleNode("EAAutoFramework/RunSettings/LogPath");

            // //Set XML Details in the property to be used accross framework
            // Settings.AUT = aut.Value.ToString();
            // //Settings.BuildName = buildname.Value.ToString();
            // Settings.TestType = testtype.Value.ToString();
            // //Settings.IsLog = islog.Value.ToString();
            // //Settings.IsReporting = isreport.Value.ToString();
            // //Settings.LogPath = logPath.Value.ToString();
        }

    }
}
