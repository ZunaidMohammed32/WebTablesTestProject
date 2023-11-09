using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using TestProject1.POM;


namespace TestProject1
{
    public class Tests
    {
        IWebDriver Driver;
        private static int inputCounter = 1;
        private string readmeFilePath = "C:\\Users\\zunaz\\source\\repos\\TestProject1\\Results.txt";
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            IWebDriver driver = Driver; 
        }

        [Test]
        public void userListTableTest1()
        {
            PageObjectModel POM = new PageObjectModel(Driver);

            Driver.Navigate().GoToUrl("https://www.way2automation.com/angularjs-protractor/webtables/");
            IWebElement userListTable = Driver.FindElement(By.TagName("table"));
            Assert.IsTrue(userListTable.Displayed, "User list table is displayed.");

            POM.ClickAddUser();
            POM.InputFirstName(inputCounter);
            POM.InputLastName(inputCounter);
            POM.InputUserName(inputCounter);
            POM.InputPassword(inputCounter);
            POM.ClickCustomerCompanyRadioButton(inputCounter);
            POM.SelectRoleDropDown(inputCounter);
            POM.InputUserEmail(inputCounter);
            POM.InputUserCellNo(inputCounter);
            POM.ClickSaveButton();
            POM.SearchForUser(inputCounter);

            RecordTestResult("userListTableTest1", true);
            inputCounter++;
            

        }
        [Test]
        public void userListTableTest2()
        {
            PageObjectModel POM = new PageObjectModel(Driver);

            Driver.Navigate().GoToUrl("https://www.way2automation.com/angularjs-protractor/webtables/");
            IWebElement userListTable = Driver.FindElement(By.TagName("table"));
            Assert.IsTrue(userListTable.Displayed, "User list table is displayed.");

            POM.ClickAddUser();
            POM.InputFirstName(inputCounter);
            POM.InputLastName(inputCounter);
            POM.InputUserName(inputCounter);
            POM.InputPassword(inputCounter);
            POM.ClickCustomerCompanyRadioButton(inputCounter);
            POM.SelectRoleDropDown(inputCounter);
            POM.InputUserEmail(inputCounter);
            POM.InputUserCellNo(inputCounter);           
            POM.ClickSaveButton();
            POM.SearchForUser(inputCounter);

            RecordTestResult("userListTableTest2", true);
            inputCounter++;

        }
        

        [TearDown]
        
        public void TearDown()
        {
            Driver.Quit();
        }
        private void RecordTestResult(string testName, bool success)
        {
            string result = success ? "Passed" : "Failed";
            string testResult = $"**Test Name**: {testName}\n**Result**: {result}\n\n";

            File.AppendAllText(readmeFilePath, testResult);
        }
    }
    }
