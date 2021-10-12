
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Add Selenium Files
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
//Add Page object Support

using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;


namespace AcceptanceTests.PageObjects
{
    public partial class PageFactoryModel
    {
        //
        //What is Page Factory
        //Page Factory, an extension to Page Objects, is primarily used for initialization of the web elements
        //defined in the page classes(or page objects). Web elements used with Page Objects have to be initialized
        //before they can be used further and Page Factory simplifies the initialization with the initElements method.
        //


        //constructor 
        public PageFactoryModel()
        {

        }

        //constructor 
        //PageFactory.InitElements() is used to [FindsBy] annotation to work.
        public PageFactoryModel(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void InitPageObject(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        // Page Factory [FindsBy] annotation finds the web elements on the homepage.
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement searchText;


        //Define Page Objects
        public void SearchText(string text)
        {
            //Search for the text
            searchText.SendKeys(text);

            // this sends an Enter to the element
            searchText.SendKeys(Keys.Enter);
        }


    }


}

