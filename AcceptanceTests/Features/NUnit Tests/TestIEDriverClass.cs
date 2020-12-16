using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//add Selenium files
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using AcceptanceTests.Common.Library;
using OpenQA.Selenium.IE;

namespace AcceptanceTests.Features.NUnit_Tests
{
    class TestIEDriverClass
    {
        [Test]
        public void TestIEDriver()
        {

            //Download from web page
            //http://selenium-release.storage.googleapis.com/index.html?path=3.9/

            //***************************************************************************************
            // .Net 4.6 and NUnit 3.11.0 changed the way the project path is returned
            // projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // You now have to use 
            //TestContext.CurrentContext.TestDirectory;
            //***************************************************************************************
            //var parent = TestContext.CurrentContext.TestDirectory;
            //string projectDir = parent.Substring(0,parent.Length - 10);
            //var driverDir = projectDir + @"\packages\";

            //Add framework packages dir to app.config
            //var driverDir = @"C:\Test\Selenium3.141 Framework(Net)\packages\";
            //var driverDir = @"C:\Test\Selenium3.141-Framework(Net)\packages\";

            var runDir = Libary.GetProjectDir();
            var driverDir = runDir + @"\packages\";

            InternetExplorerOptions ieOptions = new InternetExplorerOptions();
            ieOptions.BrowserAttachTimeout = System.TimeSpan.FromSeconds(60);
            ieOptions.RequireWindowFocus = true;
            ieOptions.EnablePersistentHover = true;
            ieOptions.IgnoreZoomLevel = true;
            //ieOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;

            IWebDriver browser = new InternetExplorerDriver(driverDir, ieOptions, System.TimeSpan.FromSeconds(60));

            //browser.Url = "http://www.google.com";
            browser.Navigate().GoToUrl("http://www.google.com");

            //Find the Search text box UI Element
            IWebElement element = browser.FindElement(By.Name("q"));

            //Search
            element.SendKeys("books");

            // this sends an Enter to the element
            element.SendKeys(Keys.Enter);

            //Wait for page to load
            System.Threading.Thread.Sleep(5 * 1000); //Wait 5-sec


            browser.Close();

        }
    }

}
