using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Sel.BaseClass;

namespace Sel
{
    [TestFixture]
    public class Tests : BaseTest   
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
          
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test]
        public void Test2()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test]
        public void Test3()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(1000);
        }


    }
}