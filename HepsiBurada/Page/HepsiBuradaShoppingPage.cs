using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.Page
{
    class HepsiBuradaShoppingPage : Base
    {
        private string shopNameOfFirstProduct { get; set; }
        private string shopNameOfSecondProduct { get; set; }
        private string shopNameOfThirdProduct { get; set; }


        public HepsiBuradaShoppingPage(IWebDriver _driver) : base(_driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='seller']//..//a[contains(@href, 'magaza')][1]")]
        public IWebElement lblFirstProduct;

        [FindsBy(How = How.XPath, Using = "//*[@class='seller']//..//a[contains(@href, 'magaza')][2]")]
        public IWebElement lblSecondProduct;

        [FindsBy(How = How.XPath, Using = "//*[@class='seller']//..//a[contains(@href, 'magaza')][3]")]
        public IWebElement lblThirdProduct;

        [FindsBy(How = How.XPath, Using = "//*[@id='addToCart']")]
        public IWebElement btnCart;

        [FindsBy(How = How.XPath, Using = "//*[@class='HeaderButton - n4FS6']//..//span[text()='Kategoriler']")]
        public IWebElement btnCategories;

        [FindsBy(How = How.XPath, Using = "//span[text()='Kitap, Müzik, Film, Hobi']")]
        public IWebElement btnBookMusicFilmHobbyCategory;

        [FindsBy(How = How.XPath, Using = "//*[text()='Hobi & Oyun']")]
        public IWebElement btnHobbyGame;

        [FindsBy(How = How.XPath, Using = "//*[text()='Uzaktan Kumandalı Araçlar']")]
        public IWebElement btnRemoteControlledVehicles;

        [FindsBy(How = How.XPath, Using = "//*[@class='product - list results - container do-flex list']//..//*[contains(text(),'Drone')]")]
        public IWebElement btnSparePartOfDrone;

        public void ClickFirstProduct()
        {
            Click(lblFirstProduct);
        }

        public void ClickButtonAddCart()
        {
            Click(btnCart);
        }

        public void GetShopNameOfFirstProduct()
        {
            shopNameOfFirstProduct = GetTextOfElement(lblFirstProduct);
        }

        public void ClickSecondProduct()
        {
            Click(lblSecondProduct);
        }

        public void GetShopNameOfSecondProduct()
        {
            shopNameOfSecondProduct = GetTextOfElement(lblSecondProduct);
        }

        public void ClickThirdProduct()
        {
            Click(lblThirdProduct);
        }

        public void GetShopNameOfThirdProduct()
        {
            shopNameOfThirdProduct = GetTextOfElement(lblThirdProduct);
        }

        public void CompareShopNamesOfFirstAndSecondProducts()
        {
            if ((lblSecondProduct != null) && (shopNameOfFirstProduct != shopNameOfSecondProduct))
            {
                    Click(btnCart);
            }
        }

        public void CompareShopNameOfFirstAndThirdProducts()
        {
            if (shopNameOfFirstProduct != shopNameOfThirdProduct)
            {
                Click(btnCart);
            }
        }

        public void ClickCategories()
        {
            Click(btnCategories);
        }

        public void ClickUserBookMusicFilmHobbyCategory(){
            Click(btnBookMusicFilmHobbyCategory);
        }

        public void ClickHobbyGame()
        {
            Click(btnHobbyGame);
        }

        public void ClickRemoteControlledVehicles()
        {
            Click(btnRemoteControlledVehicles);
        }

        public void ClickSparePartOfDrone()
        {
            Click(btnSparePartOfDrone);
        }
    }
}
