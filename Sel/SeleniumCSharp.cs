using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel
{
    [TestFixture]
    public class SeleniumCSharp
    {
        [Test]
        [Author("Bartosz ", "example@mail.com")]
        [Description("Facebook Login Verify")]
        [TestCaseSource(nameof(DataDrivenTesting))]
        public void Test1(string urlName)
        {
            IWebDriver driver  = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot Tscreen = driver as ITakesScreenshot;
                Screenshot sc = Tscreen.GetScreenshot();
                sc.SaveAsFile("Example path");
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null)
                    driver.Quit();
            }
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://web.archive.org/web/20151227004932/https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");

            return list;
        }
    }
}
