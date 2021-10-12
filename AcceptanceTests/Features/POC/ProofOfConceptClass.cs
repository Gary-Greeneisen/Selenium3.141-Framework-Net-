using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//
//add Selenium files
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using AcceptanceTests.Interface;
using AcceptanceTests.Common.Application;
using AcceptanceTests.Common.Library;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using System.Xml;
using AcceptanceTests.Config;
using OpenQA.Selenium.Support.UI;


/// <summary>
/// Class with driver method(s) to debug code
/// </summary>
namespace AcceptanceTests.Features.POC
{
    public class ProofOfConceptClass
    {
        [Test]
        public void TestMethod1()
        {
            var loginPage = new AcceptanceTests.PageObjects.LoginPage();

            //lauch a valid web page
            IWebDriver browser = loginPage.LaunchBrowser("http://www.google.com");
            //IWebDriver browser = loginPage.LaunchBrowser("http://www.xyz.com");


            //test Google search textfield
            //Is Page Element Displayed with NO Timeout Parameter
            //var isFound1 = Libary.IsPageElementDisplayed(browser, RunTimeVars.ELEMENTSEARCH.NAME, "q");
            //var isFound1 = Libary.ImplicitWaitIsPageElementDisplayed(browser, RunTimeVars.ELEMENTSEARCH.NAME, "q", 10);
            //var element = Libary.ExplicitWaitGetPageElement(browser, RunTimeVars.ELEMENTSEARCH.NAME, "q", 5);
            var element = Libary.ImplicitWaitGetPageElement(browser, RunTimeVars.ELEMENTSEARCH.NAME, "q", 5);

            //test Google search textfield
            //Is Page Element Displayed with a Timeout Parameter
            //var isFound2 = Libary.ExplicitWaitIsPageElementDisplayed(browser, RunTimeVars.ELEMENTSEARCH.NAME, "q", 5);

            //test Google search textfield
            /// Wait until the page element is displayed
            /// Resutn the selected page element
            //var isFound3 = Libary.FluenttWaitIsPageElementDisplayed(browser, RunTimeVars.ELEMENTSEARCH.NAME, "q", 5);


            browser.Close();
        }


        [Test]
        public void TestMethod2()
        {

        }


        [Test]
        public void TestMethod3()
        {


        }


    }






}
