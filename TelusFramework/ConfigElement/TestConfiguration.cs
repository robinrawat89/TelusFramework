using System.Configuration;

namespace TelusFramework.ConfigElement
{
    public class TestConfiguration: ConfigurationSection
    {
        private static TestConfiguration _testConfig = (TestConfiguration)ConfigurationManager.GetSection("TestConfiguration");

        public static TestConfiguration Settings { get { return _testConfig; } }

        [ConfigurationProperty("testSettings")]
        public FrameworkElementCollection TestSettings { get { return (FrameworkElementCollection)base["testSettings"]; } }

    }
}
