using Bogus;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TestProject1.POM
{
    public class PageObjectModel
    {
        private readonly IWebDriver Driver;
        public PageObjectModel(IWebDriver driver)
        {
            Driver = driver;

        }
        public void MinimizePopUp()
        {
            try
            {
                Driver.FindElement(By.CssSelector("button[aria-label='Minimize widget']")).Click();

            }
            catch (NoSuchElementException)
            {

            }
        }
        public void ClickAddUser()
        {
            Driver.FindElement(By.TagName("i")).Click();
        }
        public void InputFirstName(int inputCounter)
        {
            Driver.FindElement(By.Name("FirstName")).SendKeys("FName" + inputCounter);
        }
        public void InputLastName(int inputCounter)
        {
            Driver.FindElement(By.Name("LastName")).SendKeys("LName" + inputCounter);
        }
        public void InputUserName(int inputCounter)
        {
            var faker = new Faker();
            string fakeUserName = faker.Name.FullName();
            string uniqueUserName = fakeUserName + inputCounter;
            Driver.FindElement(By.Name("UserName")).SendKeys(uniqueUserName);
;
        }
        public void InputPassword(int inputCounter)
        {
            Driver.FindElement(By.Name("Password")).SendKeys("Pass" + inputCounter);
        }
        public void ClickCustomerCompanyRadioButton(int inputCounter)
        {
            if (inputCounter % 2 == 0)
            {
                IWebElement customerCompanyBBBradioButton = Driver.FindElement(By.CssSelector("input[type='radio'][value='16']"));
                customerCompanyBBBradioButton.Click();

            }
            else
            {
                IWebElement customerCompanyAAAradioButton = Driver.FindElement(By.CssSelector("input[type='radio'][value='15']"));
                customerCompanyAAAradioButton.Click();

            }

        }
        public void SelectRoleDropDown(int inputCounter)
        {
            if (inputCounter % 2 == 0)
            {
                IWebElement selectElement = Driver.FindElement(By.Name("RoleId"));
                SelectElement select = new SelectElement(selectElement);
                select.SelectByText("Customer");

            }
            else
            {
                IWebElement selectElement = Driver.FindElement(By.Name("RoleId"));
                SelectElement select = new SelectElement(selectElement);
                select.SelectByText("Admin");

            }

        }
        public void InputUserEmail(int inputCounter)
        {
            if (inputCounter % 2 == 0)
            {
                Driver.FindElement(By.Name("Email")).SendKeys("customer@mail.com");

            }
            else
            {
                Driver.FindElement(By.Name("Email")).SendKeys("admin@mail.com");

            }
        }
        public void InputUserCellNo(int inputCounter)
        {
            if (inputCounter % 2 == 0)
            {

                Random random = new Random();
                string randomNumbers = "";
                for (int i = 0; i < 4; i++)
                {
                    randomNumbers += random.Next(0, 10).ToString();

                }

                Driver.FindElement(By.Name("Mobilephone")).SendKeys("082444" + randomNumbers);

            }
            else
            {

                Random random = new Random();
                string randomNumbers = "";
                for (int i = 0; i < 4; i++)
                {
                    randomNumbers += random.Next(0, 10).ToString();

                }

                Driver.FindElement(By.Name("Mobilephone")).SendKeys("082555" + randomNumbers);
            }

        }
        public void ClickSaveButton()
        {
            Driver.FindElement(By.XPath("//button[text()='Save']")).Click();
        }
        public void SearchForUser(int inputCounter)
        {
            Driver.FindElement(By.CssSelector("input[ng-model='searchValue']")).SendKeys("FName" + inputCounter);
        }
    
    }
}
