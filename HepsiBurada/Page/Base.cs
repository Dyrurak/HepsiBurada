using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace HepsiBurada.Page
{
    public class Base
    {
        private IWebDriver _driver;

        public Base(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public IWebElement Find(By by)
        {
            return _driver.FindElement(by);
        }

        public void Click(IWebElement btn)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));            
            btn.Click();
        }

        public void Hover(IWebElement btn)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(btn).Build().Perform();
        }

        public void SetText(IWebElement txt, string text)
        {
            txt.SendKeys(text);
        }

        public void SelectOptionByText(IWebElement slct, string text)
        {
            SelectElement selectElement = new SelectElement(slct);
            selectElement.SelectByText(text);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        public IJavaScriptExecutor GetScriptExecutor()
        {
            return (IJavaScriptExecutor)_driver;
        }

        public string GetTextOfElement(IWebElement lbl)
        {            
            return lbl.GetAttribute("text");
        }

    }
}
