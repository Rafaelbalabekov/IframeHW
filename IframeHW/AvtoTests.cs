using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IframeHW
{
    class AvtoTests
    {
        Resualts Resualts;
        IWebDriver driver;

        public AvtoTests()
        {
            Resualts = new Resualts();
        }

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://someurl.com/");
        }
        [Test]

        public void Test1()
        {
            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@id='master-1']"));
            driver.SwitchTo().Frame(frame1);

            driver.FindElement(By.XPath("//*[@id='adBlock']/div[2]/div[1]/a")).Click();

            IWebElement frame2 = driver.FindElement(By.XPath("//iframe[@id='master-1']"));
            driver.SwitchTo().Frame(frame2);

            driver.FindElement(By.XPath("//*[@id='adBlock']/div[2]/div[2]/a")).Click();

            Assert.IsTrue(Resualts.Resualt1());
          
        }

        [Test]

        public void Test2()
        {
            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@id='master-1']"));
            driver.SwitchTo().Frame(frame1);

            driver.FindElement(By.XPath("//*[@id='adBlock']/div[2]/div[2]/a")).Click();

            IWebElement frame2 = driver.FindElement(By.XPath("//iframe[@id='master-1']"));
            driver.SwitchTo().Frame(frame2);

            driver.FindElement(By.XPath("//*[@id='e2']/div[4]/div/div/a")).Click();

            Assert.IsTrue(Resualts.Resualt2());
        }

       [TearDown]
      
       public void TearDown()
       {
           driver.Quit();
       }
    }
}
