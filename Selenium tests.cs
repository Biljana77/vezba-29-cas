using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace vezba_29_cas
{
    class Selenium_tests
    {
        IWebDriver driver;
        WebDriverWait wait;

        public void Navigate(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();

        }
        [Test]
        public void TestRegistracija()
        {
            Navigate("http://test.qa.rs/");
            IWebElement LinkLogIn = wait.Until(EC.ElementIsVisible(By.XPath("//a[@href='/new']")));
            if (LinkLogIn.Displayed && LinkLogIn.Enabled)
            {
                LinkLogIn.Click();
            }
            IWebElement userName = driver.FindElement(By.Name("ime"));
            if (userName.Displayed && userName.Enabled)
            {
                userName.SendKeys("Pera");
            }
            IWebElement lastName = driver.FindElement(By.Name("prezime"));
            if (lastName.Displayed && lastName.Enabled)
            {
                lastName.SendKeys("Peric");
            }
            IWebElement Korisnicko = driver.FindElement(By.Name("korisnicko"));
            if (Korisnicko.Displayed && Korisnicko.Enabled)
            {
                Korisnicko.SendKeys("PPetar");
            }
            IWebElement emailuser = driver.FindElement(By.Name("email"));
            if (emailuser.Displayed && emailuser.Enabled)
            {
                emailuser.SendKeys("p.petar@ggmail.comm");
            }
            IWebElement phoneuser = driver.FindElement(By.Name("telefon"));
            if (phoneuser.Displayed && phoneuser.Enabled)
            {
                phoneuser.SendKeys("021/444444");
            }
            IWebElement inputCountry = driver.FindElement(By.Name("zemlja"));
            if (inputCountry.Displayed && inputCountry.Enabled)
            {
                SelectElement selectCountry = new SelectElement(inputCountry);
                selectCountry.SelectByText("Austria");
            }
            IWebElement inputCity = wait.Until(EC.ElementIsVisible(By.Name("grad")));
            if (inputCity.Displayed && inputCity.Enabled)
            {
                SelectElement selectCity = new SelectElement(inputCity);
                selectCity.SelectByIndex(3); 
            }
            IWebElement Street = driver.FindElement(By.XPath("//div[@id='address']//input"));
            if (Street.Displayed && Street.Enabled)
            {
               Street.SendKeys("Bircanin 28");
            }
            IWebElement inputGender = driver.FindElement(By.Id("pol_m"));
            if (inputGender.Displayed && inputGender.Enabled)
            {
                inputGender.Click();
            }
            IWebElement inputNewsletter = driver.FindElement(By.Id("newsletter"));
            if (inputNewsletter.Displayed && inputNewsletter.Enabled)
            {
                inputNewsletter.Click();
            }
            IWebElement buttonRegister = driver.FindElement(By.Name("register"));
            if (buttonRegister.Displayed && buttonRegister.Enabled)
            {
                buttonRegister.Click();
            }


        }

    }
}
