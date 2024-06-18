using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace Sel
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test,Order(2), Category("OrderSkipAttribute")]
        public void Test1()
        {
            Assert.Ignore("Example Defect");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://web.archive.org/web/20151227004932/https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test, Order(1), Category("OrderSkipAttribute")]
        public void Test2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://web.archive.org/web/20151227004932/https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test, Order(0), Category("OrderSkipAttribute")]
        public void Test3()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://web.archive.org/web/20151227004932/https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
