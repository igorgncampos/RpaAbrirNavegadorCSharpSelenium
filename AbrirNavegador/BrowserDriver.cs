using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbrirNavegador
{

    public class BrowserDriver
    {
        public IWebDriver driver;
        public BrowserDriver() 
        {
            ChromeOptions opt = new ChromeOptions();

      opt.AddExcludedArgument("enable-automation");
      //opt.AddAdditionalOption("useAutomationExtension", false);
      opt.AcceptInsecureCertificates = true;
            opt.AddArgument("--start-maximized");
            opt.AddArgument("--aways-authorize-plugins");
            opt.AddArgument("--disable-notifications");
            opt.AddArgument("--no-sandbox");
            opt.AddArgument("--ignore-certificate-errors");
            opt.AddArgument("--ignore-ssl-errors");
            

            //opt.AddArgument("--headless");

            ChromeDriverService chromeDriverService =
            ChromeDriverService.CreateDefaultService($@"C:\Program Files\Google\Chrome\Application");

            driver = new ChromeDriver(chromeDriverService, opt);
        }

        public void TarefaNavegador()
        { 
        driver.Navigate().GoToUrl("https://www.google.com/");
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).Clear();

      driver.FindElement(By.Name("q")).SendKeys("pokemon"); 
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter); 
            Thread.Sleep(1000);
        driver.Close();
        }
    }


}
