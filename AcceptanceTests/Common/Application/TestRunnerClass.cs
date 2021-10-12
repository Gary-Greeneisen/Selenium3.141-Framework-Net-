using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcceptanceTests.Config;
// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
//
using AcceptanceTests.PageObjects;

namespace AcceptanceTests.Common.Application
{
    public class TestRunnerClass
    {
        //Step-1
        //Define a unique UIMap/Page Object var = xxx that references each unique UI Map class
        //
        //Step-2 Initialize any vars
        //
        //Step-3
        //Create a reference to the UIMap(s)/Page Object(s)
        //
        //Step-4 - Use the UI Map/Page Object reference(s) to call the methods
        //launch the browser and login

        //Step-1
        //Define a unique UIMap/Page Object var = xxx that references each unique UI Map class

        //************************
        // Test Context Section
        //************************   
        public RunTestContext testContext = null;


        //************************
        // Page Objects Section
        //************************   
        public AdminPrograms adminPrograms = null;
        public CreditHoursTab creditHoursTab = null;
        public HeaderPage headerPage = null;
        public LoginPage loginPage = null;
        public PageFactoryModel pageFactoryModel = null;
        public ParentStudentTab parentStudentTab = null;
        public ProviderSearchPage providerSearchPage = null;
        public SafePage safePage = null;
        public StaffTab staffTab = null;
        public StudentFinanceSearchPage studentFinanceSearchPage = null;
        public StudentSearchPage studentSearchPage = null;
        public TestPage1 testPage1 = null;
        public TestPage2 testPage2 = null;
        public VerifyPageTabs verifyPageTabs = null;

        //Constructor
        public TestRunnerClass()
        {
            //Step-2 Initialize the Run-Time vars from the Config File
            RunTimeVars.ReadAppConfig();


            //Step-3 Create a reference to the UIMap(s)/Page Object(s)
   
            //**************************
            // Test Context Section
            //************************   
            testContext = new RunTestContext();

            //************************
            // Page Objects Section
            //************************
            adminPrograms = new AdminPrograms();
            creditHoursTab = new CreditHoursTab();
            headerPage = new HeaderPage();
            loginPage = new LoginPage();
            pageFactoryModel = new PageFactoryModel();
            parentStudentTab = new ParentStudentTab();
            providerSearchPage = new ProviderSearchPage();
            safePage = new SafePage();
            staffTab = new StaffTab();
            studentFinanceSearchPage = new StudentFinanceSearchPage();
            studentSearchPage = new StudentSearchPage();
            testPage1 = new TestPage1();
            testPage2 = new TestPage2();
            verifyPageTabs = new VerifyPageTabs();

        } //end Constructor

        //************************************************************************
        // Define Test Methods
        //************************************************************************

        //Step-4 - Use the UI Map/Page Object reference(s) to call the methods
        //populate any class member vars
        //launch the browser and login


    } //end public class TestRunnerClass

} //end namespace AcceptanceTests.Common.Application
