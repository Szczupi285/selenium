using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Sel.BaseClass;
using OpenQA.Selenium.Support.UI;

namespace Sel
{
    [TestFixture]
    public class Tests : BaseTest   
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Category("Smoke testing")]
        public void Test1()
        {
          
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement ele = new SelectElement(monthDropdownList);
            ele.SelectByIndex(1);
            ele.SelectByText("Apr");
            ele.SelectByValue("12");
        }
        [Test, Category("Regression Testing")]
        public void Test2()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Category("Smoke testing")]
        public void Test3()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(1000);

        }


    }
}