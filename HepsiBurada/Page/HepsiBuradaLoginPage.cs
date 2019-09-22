using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace HepsiBurada.Page
{
    class HepsiBuradaLoginPage:Base
    {
        public HepsiBuradaLoginPage(IWebDriver _driver) : base(_driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-login']")]
        public IWebElement rbLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='email']")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Giriş']")]
        public IWebElement btnLogin { get; set; }

        public void ClickLoginRadioButton()
        {
            Click(rbLogin);
        }

        public void SetLoginInformation(string email, string password)
        {
            SetText(txtEmail, email);
            SetText(txtPassword, password);
        }

        public void ClickLoginButton()
        {
            Click(btnLogin);
        }
    }
}
