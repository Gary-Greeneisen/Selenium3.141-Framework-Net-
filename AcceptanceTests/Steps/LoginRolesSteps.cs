﻿using System;
using TechTalk.SpecFlow;
//
using AcceptanceTests.Interface;
using AcceptanceTests.Common.Application;
using OpenQA.Selenium;
using AcceptanceTests.Common.Library;
using AcceptanceTests.Config;
using System.Collections.Generic;
using NUnit.Framework;

namespace AcceptanceTests.Steps
{
    [Binding]
    public class LoginRolesSteps
    {

        string currentRole = null;

        [BeforeScenario()]
        public static void PrepareForTest()
        {

        }

        [AfterScenario]
        public void CleanUpTest()
        {
            //check for any active browsers open
            //Don't close non-active browsers
            try
            {
                if (!TestRunnerInterface.Map.loginPage.browserClosed)
                {
                    TestRunnerInterface.Map.loginPage.BrowserClose();
                }
            }
            catch
            {
                //empty catch
                //the application is already closed
            }
       
        }


        /// <summary>
        /// Use this method to 
        /// Login
        /// Wait for Safe Home page
        /// Click the product link
        /// wait for the product homw page
        /// </summary>
        /// <param name="role"></param>
        [Given(@"my login role ""(.*)""")]
        public void GivenMyLoginRole(string role)
        {
            //Update Test Context
            TestRunnerInterface.Map.testContext.role = role;

            //ScenarioContext.Current.Pending();
            TestRunnerInterface.Map.loginPage.GivenaUserRole(role);

            //Check if(Change Password is displayed)
            if (TestRunnerInterface.Map.loginPage.IsChangePasswordDisplayed(RunTimeVars.REPEAT_TIMES))
            {
                TestRunnerInterface.Map.loginPage.ChangePasswordCancel();             
                //TestRunnerInterface.Map.loginPage.UpdatePassword(role);
            }

            //Wait for Safe Home Page displayed
            TestRunnerInterface.Map.loginPage.WaitForSafeHomePage(RunTimeVars.REPEAT_TIMES);
            TestRunnerInterface.Map.loginPage.ClickLink("Scholarship");

            Libary.WaitForPageLoad(RunTimeVars.REPEAT_TIMES);
            
        }

        
        /// <summary>
        /// Login to an existing browser page
        /// with the target URL already set
        /// </summary>
        /// <param name="role"></param>
        public void LoginToExistingURL(string role)
        {
     
            //TestRunnerInterface.Map.loginPage.GivenaUserRole(role);

            //Login with Username/Pwd
            var result = AppConfig.GetAppSectionValue(role);
            string[] userPwd = result.Split(',');

            TestRunnerInterface.Map.loginPage.Login(userPwd[0], userPwd[1]);

            //Check if(Change Password is displayed)
            if (TestRunnerInterface.Map.loginPage.IsChangePasswordDisplayed(RunTimeVars.REPEAT_TIMES))
            {
                TestRunnerInterface.Map.loginPage.ChangePasswordCancel();             
                //TestRunnerInterface.Map.loginPage.UpdatePassword(role);
            }

            //Wait for Safe Home Page displayed
            TestRunnerInterface.Map.loginPage.WaitForSafeHomePage(RunTimeVars.REPEAT_TIMES);
            TestRunnerInterface.Map.loginPage.ClickLink("Scholarship");

            Libary.WaitForPageLoad(RunTimeVars.REPEAT_TIMES);

        }

    
        [Given(@"I login using ODE Personnel role ""(.*)""")]
        public void GivenILoginUsingODEPersonnelRole(string role)
        {
            //ScenarioContext.Current.Pending();
            this.GivenMyLoginRole(role);
        }

        /// <summary>
        /// Login to SAFE
        /// Wait for SAFE Home Page to be displayed
        /// </summary>
        /// <param name="role"></param>
        [Given(@"I login as role ""(.*)""")]
        public void GivenILoginAsRole(string role)
        {
            //ScenarioContext.Current.Pending();
            TestRunnerInterface.Map.loginPage.GivenaUserRole(role);

            //Check if(Change Password is displayed)
            if (TestRunnerInterface.Map.loginPage.IsChangePasswordDisplayed(RunTimeVars.REPEAT_TIMES))
            {
                TestRunnerInterface.Map.loginPage.ChangePasswordCancel();
                //TestRunnerInterface.Map.loginPage.UpdatePassword(role);
            }

            Libary.WaitForPageLoad(RunTimeVars.REPEAT_TIMES);

        }

        [Given(@"A User Role ""(.*)""")]
        public void GivenAUserRole(string role)
        {
            //ScenarioContext.Current.Pending();
            //Update the call variable with the latest role
            currentRole = role;
            TestRunnerInterface.Map.loginPage.GivenaUserRole(role);
        }

        [When(@"I wait for the SAFE home page")]
        public void WhenIWaitForTheSAFEHomePage()
        {
            //ScenarioContext.Current.Pending();
            TestRunnerInterface.Map.loginPage.WaitForSafeHomePage(RunTimeVars.REPEAT_TIMES);

        }

        [When(@"I Click on link ""(.*)""")]
        public void WhenIClickOnLink(string link)
        {
            TestRunnerInterface.Map.loginPage.ClickLink(link);
        }

        [Given(@"I Click on link ""(.*)""")]
        public void GivenIClickOnLink(string link)
        {
            //ScenarioContext.Current.Pending();
            TestRunnerInterface.Map.loginPage.ClickLink(link);
        }



        [When(@"I change the passsword")]
        public void WhenIChangeThePasssword()
        {
            //ScenarioContext.Current.Pending();
            TestRunnerInterface.Map.loginPage.ChangePassword(currentRole);
        }


        [Given(@"I login as invalid role ""(.*)""")]
        public void GivenILoginAsInvalidRole(string role)
        {
            //ScenarioContext.Current.Pending();
            TestRunnerInterface.Map.loginPage.GivenaUserRole(role);
        }

        [When(@"I wait for the home page")]
        public void WhenIWaitForTheHomePage()
        {
            //ScenarioContext.Current.Pending();
            TestRunnerInterface.Map.loginPage.WaitForSafeHomePage(RunTimeVars.REPEAT_TIMES);
        }

        [Then(@"the home page is displayed ""(.*)""")]
        public void ThenTheHomePageIsDisplayed(string text)
        {
            //ScenarioContext.Current.Pending();

            //TestRunnerInterface.Map.loginPage.WaitProductHomePage(text,RunTimeVars.WEBDRIVERWAIT);
            TestRunnerInterface.Map.loginPage.WaitProductHomePage(text, RunTimeVars.REPEAT_TIMES);

        }

        [Then(@"the login error is displayed ""(.*)""")]
        public void ThenTheLoginErrorIsDisplayed(string error)
        {
            //ScenarioContext.Current.Pending();
            IWebDriver browser = TestRunnerInterface.Map.loginPage.browser;
            var pageText = browser.FindElement(By.XPath("//div[contains(@class,'validation-summary-errors')]")).Text;

            //Compare error msgs Expected Result, Actual Result
            Assert.AreEqual(error, pageText);

            TestRunnerInterface.Map.loginPage.BrowserClose();
        }

        [Given(@"I Logout")]
        public void GivenILogout()
        {
            //ScenarioContext.Current.Pending();
            this.ThenILogout();
        }

        [Then(@"I Logout")]
        public void ThenILogout()
        {
            //ScenarioContext.Current.Pending();
            TestRunnerInterface.Map.loginPage.SignOut();
            TestRunnerInterface.Map.loginPage.BrowserClose();

        }




    }
}
