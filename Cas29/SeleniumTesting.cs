using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using OpenQA.Selenium.Chrome;

namespace Cas29
{
    class SeleniumTesting
    {
        IWebDriver driver;
        WebDriverWait wait;

        
        [Test]
        public void Registration()
        {
            Navigate("http://test.qa.rs/");

            IWebElement kreirajKorisnika = wait.Until(EC.ElementIsVisible(By.LinkText("Kreiraj novog korisnika")));
             if (kreirajKorisnika.Displayed && kreirajKorisnika.Enabled)
            {

                kreirajKorisnika.Click();
               
            }

            IWebElement inputName = wait.Until(EC.ElementIsVisible(By.Name("ime")));

            if (inputName.Displayed && inputName.Enabled)
            {

                inputName.SendKeys("Mitar");
               
            }

            IWebElement inputSurname = driver.FindElement(By.Name("prezime"));

            if (inputSurname.Displayed && inputSurname.Enabled)
            {

                inputSurname.SendKeys("Mitrovic");

            }

            IWebElement inputUserName = driver.FindElement(By.Name("korisnicko"));

            if (inputUserName.Displayed && inputUserName.Enabled)
            {

                inputUserName.SendKeys("MMitrovic");

            }

            IWebElement inputEmail = driver.FindElement(By.Name("email"));

            if (inputEmail.Displayed && inputEmail.Enabled)
            {

                inputEmail.SendKeys("MMitrovic@htlo.com");

            }

            IWebElement inputPhone = driver.FindElement(By.Name("telefon"));

            if (inputPhone.Displayed && inputPhone.Enabled)
            {

                inputPhone.SendKeys("021/589-487");

            }
            IWebElement selectCountry = driver.FindElement(By.Name("zemlja"));

            if (selectCountry.Displayed && selectCountry.Enabled)
            {

                SelectElement country = new SelectElement(selectCountry);
                country.SelectByText("Austria");

            }

            IWebElement selectCity = wait.Until(EC.ElementIsVisible(By.Name("grad")));

            if (selectCity.Displayed && selectCity.Enabled)
            {


                SelectElement city = new SelectElement(selectCity);
                city.SelectByText("Linz");

            }

            IWebElement inputStreet = driver.FindElement(By.XPath("//div[@id='address']//input"));

            if (inputStreet.Displayed && inputStreet.Enabled)
            {

                inputStreet.SendKeys("Njegoseva 5");

            }

            IWebElement inputGender = driver.FindElement(By.Id("pol_m"));

            if (inputGender.Displayed && inputGender.Enabled)
            {

                inputGender.Click();

            }

            IWebElement register = driver.FindElement(By.Name("register"));

            if (register.Displayed && register.Enabled)
            {

                register.Click();

            }


            /*
             * 
             * *********** prvi nacin********************
             
            IWebElement verify = driver.FindElement(By.XPath("//td[text()='sadf@jjk.mnn']"));
            
            if (verify.Displayed && verify.Enabled)
            {

                Assert.Pass();

            }

            **************drugi nacin******************

           IWebElement verify = driver.FindElement(By.XPath("//td[text()='ssandra']"));

           if (verify.Displayed && verify.Enabled)
           {

               Assert.Pass();

           }*/

            
           //********** treci nacin********

            IWebElement verify = driver.FindElement(By.XPath("//div[@class='alert alert-success']"));

            if (verify.Displayed && verify.Enabled)
            {

                Assert.Pass();

            }


        }
        private void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }



        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();

            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            driver.Manage().Window.Maximize();
            
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }


    }
}
