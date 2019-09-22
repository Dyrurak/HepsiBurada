using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HepsiBurada.Page
{
    public class HepsiBuradaMainPage:Base
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='myAccount']")]
        public IWebElement hoverLogin { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement btnSignIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='productSearch']")]
        public IWebElement txtSearchProduct { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='buttonProductSearch']")]
        public IWebElement btnSearchProduct { get; set; }

        public HepsiBuradaMainPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void HoverLogin()
        {
            Hover(hoverLogin);
        }

        public void ClickSigninButton()
        {
            Click(btnSignIn);
        }

        public void SearchProduct(string product)
        {
            SetText(txtSearchProduct, product);
            Click(btnSearchProduct);
        }
    }
}
