Feature: HepsiBurada
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@HepsiBuradaShoppingWithLogin
Scenario: HepsiBuradaShoppingWithLogin
	* HepsiBurada sitesi acilir
	* Acilan sayfada Giris Yap butonuna tiklanir
	* Email alanina 'hepsiburadatest@gmail.com', password alanina 'Hepsiburada@123' yazilarak giris yap butonuna tiklanir
	* Arama alanina 'gözlük' yazilarak ara butonuna tiklanir
	* Ilk cikan urune tiklanir
	* Sepete ekle butonuna tiklanir
	* Arama alanina 'gözlük' yazilarak ara butonuna tiklanir
	* Ikinci cikan urune tiklanir
	* Secilen ilk iki urunun magaza isimleri karsilastirilir ve birbirinden farkliysa ikinci urun de sepete eklenir
	* Ilk iki urunun magaza isimleri aynıysa arama alanina 'gözlük' yazilarak ara butonuna tiklanir
	* Ucuncu cikan urune tiklanir
	* Secilen ilk ve ucuncu urunun magaza isimleri karsilastirilir ve birbirinden farkliysa ucuncu urun de sepete eklenir


@HepsiBuradaShoppingWithoutLogin
Scenario: HepsiBuradaShoppingWithoutLogin
	* HepsiBurada sitesi acilir
	* Kategorilere tiklanir
	* Kullanıcı, Kitap, Müzik, Film, Hobi kategorisine tiklanir
	* Hobi Oyuna tiklanir
	* Uzaktan kumandali araclara tiklanir
	* Drone yedek parca urunune tiklanir
	* Sepete ekle butonuna tiklanir


