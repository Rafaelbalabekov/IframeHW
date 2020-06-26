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
    class Resualts
    {
        IWebDriver driver;

        public bool Resualt1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://designstreet.az/?gclid=EAIaIQobChMIgom5jpmf6gIVS7DtCh37kgQDEAEYASAAEgIMm_D_BwE");

            if (driver.FindElements(By.XPath("//*[text()='XİDMƏTLƏR']")).Count != 1)
            {
                driver.Quit();
                return false;

            }
            else
            {
                driver.Quit();
                return true;
            }
        }
            public bool Resualt2()
            {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.alibabacloud.com/campaign/free-trial?utm_content=se_1005982031&gclid=EAIaIQobChMIpIb-7aWf6gIVBBUYCh3ugQIQEAEYASAAEgLX0PD_BwE");

                if (driver.FindElements(By.XPath("//*[text()='Alibaba Cloud Free Trial']")).Count != 1)
                {
                    driver.Quit();
                    return false;

                }
                else
                {
                    driver.Quit();
                    return true;
                }

            }
      } } 
