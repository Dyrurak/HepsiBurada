using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using NUnit.Framework;
using HepsiBurada.Page;


namespace HepsiBurada.Test
{    
    [TestFixture]    
    [Binding]
    public class HepsiBuradaTest
    {
        public IWebDriver webDriver { get; set; }
        private HepsiBuradaLoginPage hepsiBuradaLoginPage;
        private HepsiBuradaMainPage hepsiBuradaMainPage;
        private HepsiBuradaShoppingPage hepsiBuradaShoppingPage;


        [StepDefinition(@"HepsiBurada sitesi acilir")]
        public void OpenHepsiBurada()
        {
            webDriver = new ChromeDriver(@"C:\Diyar\SetupDosyaları\chromeDriver");
            webDriver.Navigate().GoToUrl("https://www.hepsiburada.com");
        }

        [StepDefinition(@"Acilan sayfada Giris Yap butonuna tiklanir")]
        public void ClickLoginButton()
        {
            hepsiBuradaMainPage.HoverLogin();
            hepsiBuradaMainPage.ClickSigninButton();
        }

        [StepDefinition(@"Email alanina (.*), password alanina (.*) yazilarak giris yap butonuna tiklanir")]
        public void SetLoginInformation(string email, string password)
        {
            hepsiBuradaLoginPage.ClickLoginRadioButton();
            hepsiBuradaLoginPage.SetLoginInformation(email, password);
            hepsiBuradaLoginPage.ClickLoginButton();
        }

        [StepDefinition(@"Arama alanina '(.*)' yazilarak ara butonuna tiklanir")]
        public void SearchProduct(string product)
        {
            hepsiBuradaMainPage.SearchProduct(product);
        }

        [StepDefinition(@"Ilk cikan urune tiklanir")]
        public void ClickFirstProduct()
        {
            hepsiBuradaShoppingPage.ClickFirstProduct();
            hepsiBuradaShoppingPage.GetShopNameOfFirstProduct();
        }

        [StepDefinition(@"Sepete ekle butonuna tiklanir")]
        public void ClickButtonAddShoppingCart()
        {
            hepsiBuradaShoppingPage.ClickButtonAddCart();
        }

        [StepDefinition(@"Ikinci cikan urune tiklanir")]
        public void ClickSecondProduct()
        {
            hepsiBuradaShoppingPage.ClickSecondProduct();
            hepsiBuradaShoppingPage.GetShopNameOfSecondProduct();
        }

        [StepDefinition(@"Secilen ilk iki urunun magaza isimleri karsilastirilir ve birbirinden farkliysa ikinci urun de sepete eklenir")]
        public void CompareShopNamesOfFirstAndSecondProducts()
        {
            hepsiBuradaShoppingPage.CompareShopNamesOfFirstAndSecondProducts();
        }

        [StepDefinition(@"Ilk iki urunun magaza isimleri aynıysa arama alanina '(.*)' yazilarak ara butonuna tiklanir")]
        public void SearchForProduct(string product)
        {
            hepsiBuradaMainPage.SearchProduct(product);
        }

        [StepDefinition(@"Ucuncu cikan urune tiklanir")]
        public void ClickThirdProduct()
        {
            hepsiBuradaShoppingPage.ClickThirdProduct();
        }

        [Given(@"Secilen ilk ve ucuncu urunun magaza isimleri karsilastirilir ve birbirinden farkliysa ucuncu urun de sepete eklenir")]
        public void CompareShopNamesOfFirstAndThirdProducts()
        {
            hepsiBuradaShoppingPage.CompareShopNameOfFirstAndThirdProducts();
        }

        [StepDefinition(@"Kategorilere tiklanir")]
        public void ClickCategories()
        {
            hepsiBuradaShoppingPage.ClickCategories();
        }

        [StepDefinition(@"Kullanıcı, Kitap, Müzik, Film, Hobi kategorisine tiklanir")]
        public void ClickUserBookMusicFilmHobbyCategory()
        {
            hepsiBuradaShoppingPage.ClickUserBookMusicFilmHobbyCategory();
        }

        [StepDefinition(@"Hobi Oyuna tiklanir")]
        public void ClickHobbyGame()
        {
            hepsiBuradaShoppingPage.ClickHobbyGame();
        }

        [StepDefinition(@"Uzaktan kumandali araclara tiklanir")]
        public void ClickRemoteControlledVehicles()
        {
            hepsiBuradaShoppingPage.ClickRemoteControlledVehicles();
        }

        [StepDefinition(@"Drone yedek parca urunune tiklanir")]
        public void ClickSparePartOfDrone()
        {
            hepsiBuradaShoppingPage.ClickSparePartOfDrone();
        }
    }
}

