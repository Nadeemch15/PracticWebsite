using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.PageObject
{
        public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(ObjecRepository.Driver, this);

        }
        #region WebElement
        [FindsBy(How = How.ClassName, Using = "login")]
        private IWebElement SignIn;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//p[@class='submit']//span[1]")]
        private IWebElement SignInBtn;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Hello test101!')]")]
        private IWebElement Confirmation;
        #endregion

        #region TakeScreenshot
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Our stores')]")]
        IWebElement OurStoresLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='dismissButton']")]
        IWebElement GoogleDismissButton { get; set; }
        #endregion

        #region Methods
        public void SignInLink()
        {
            SignIn.Click();
        }
        public void EnterUserDetials(string username, string password)
        {
            Email.SendKeys(username);
            Password.SendKeys(password);
        }
        public void SignInButton()
        {
            SignInBtn.Click();
        }

        public void OurStoreLink()
        {
            OurStoresLink.Click();
            GoogleDismissButton.Click();
        }

            //public void ConfirmUserLoggedIn()
            //{
            //    Assert.AreEqual("Hello test101!", Confirmation.Text);

            //}
            #endregion

        }
    }
