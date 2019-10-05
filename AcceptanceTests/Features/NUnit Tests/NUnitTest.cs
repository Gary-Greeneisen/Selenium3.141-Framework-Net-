using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add Selenium files
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using AcceptanceTests.Features.NUnit_Tests;
using AcceptanceTests.Interface;
using AcceptanceTests.Common.Library;


namespace AcceptanceTests.Features.NUnit_Tests
{
    class NUnitTest
    {

        [SetUp]
        public void Initialize()
        {

        }

        [Test]
        public void TestDrivers()
        {
            TestChromeDriverClass TestChrome = new TestChromeDriverClass();
            TestChrome.TestChromeDriver();

            TestFireFoxDriverClass TestFireFox = new TestFireFoxDriverClass();
            TestFireFox.TestFireFoxDriver();

            //TestEdgeDriverClass TestEdge = new TestEdgeDriverClass();
            //TestEdge.TestEdgeDriver();

            //TestIEDriverClass TestIE = new TestIEDriverClass();
            //TestIE.TestIEDriver();

        }

        [Test]
        public void TestGooglePageObjects()
        {
            //To test Google Page Objects need to do the following
            //Create an instance of Google
            //Call the the method public GooglePageObjectModel(IWebDriver driver) to initialize the [FindsBy] annotation to work.
            //Call the method public void SearchText(string text) with text to search

            //*****************************************************************
            //The loginPage Page Object uses the app.config file
            // to set which browser to use (Chrome,Firefox,Edge,IE)
            //
            //Create an instance of Google
            TestRunnerInterface.Map.loginPage.LaunchBrowser("https://www.google.com/");

            //initialize the [FindsBy] annotation to work.
            IWebDriver browser = TestRunnerInterface.Map.loginPage.browser;
            TestRunnerInterface.Map.googlePageObject.InitPageObject(browser);


            //text to search
            TestRunnerInterface.Map.googlePageObject.SearchText("Books");

            //wait for page to load
            Libary.WaitForPageLoad(30);
                
            browser.Close();
        }


        [TearDown]
        public void EndTest()
        {
     
        }

    }


}
