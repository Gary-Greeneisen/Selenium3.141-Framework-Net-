
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
    public partial class GooglePageObjectModel
    {
        //constructor 
        public GooglePageObjectModel()
        {

        }

        //constructor 
        //PageFactory.InitElements() is used to [FindsBy] annotation to work.
        public GooglePageObjectModel(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void InitPageObject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
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

