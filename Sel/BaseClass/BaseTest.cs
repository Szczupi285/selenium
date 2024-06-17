using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.BaseClass
{
    public class BaseTest
    {

        public IWebDriver driver;

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://web.archive.org/web/20151227004932/https://www.facebook.com/";
        }
        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
