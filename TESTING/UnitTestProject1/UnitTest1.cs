using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver myD;
            myD = new ChromeDriver("C:\\selenium jars");
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\selenium jars", "geckodriver.exe");
            //service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            //myD = new FirefoxDriver(service);
            myD.Url = " http://www.youcandealwithit.com/";

            //Thread.Sleep(2000);

            myD.Manage().Window.Maximize();
            // myD.Manage().Timeouts().ImplicitWait = Timespan.FormSeconds(30);


            myD.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
            Actions act=new Actions(myD);
            
            act.MoveToElement(myD.FindElement(By.LinkText("BORROWERS"))).Build().Perform();
            
           // Thread.Sleep(2000);
            myD.FindElement(By.LinkText("Calculators & Resources")).Click();
            validation(myD.Title, "Calculators & Resources");
            //Thread.Sleep(2000);
            myD.FindElement(By.LinkText("Calculators")).Click();
            validation(myD.Title, "Calculators");

           // Thread.Sleep(2000);
            myD.FindElement(By.LinkText("Budget Calculator")).Click();
            validation(myD.Title, "Budget Calculator");

            //Thread.Sleep(2000);
            myD.FindElement(By.Id("food")).SendKeys("1000");
            myD.FindElement(By.Id("food")).SendKeys(Keys.Tab);
            myD.FindElement(By.Id("clothing")).SendKeys("1000");
            myD.FindElement(By.Id("clothing")).SendKeys(Keys.Tab);
            myD.FindElement(By.Id("shelter")).SendKeys("1000");
            myD.FindElement(By.Id("shelter")).SendKeys(Keys.Tab);
            myD.FindElement(By.Id("household")).SendKeys("1000");
            myD.FindElement(By.Id("household")).SendKeys(Keys.Tab); 
            myD.FindElement(By.Id("transportation")).SendKeys("1000");
            myD.FindElement(By.Id("transportation")).SendKeys(Keys.Tab);
            string MonthlyPay = "1000";
            myD.FindElement(By.Id("monthlyPay")).SendKeys(MonthlyPay);
            myD.FindElement(By.Id("monthlyPay")).SendKeys(Keys.Tab);

            myD.FindElement(By.Id("monthlyOther")).SendKeys("1000");

            //Thread.Sleep(4000);
            string x = myD.FindElement(By.Id("underOverBudget")).GetAttribute("value");
            System.Console.WriteLine("Budget is: " + x);
                
            if (double.Parse(x)>=double.Parse(MonthlyPay))
            {
                System.Console.WriteLine("You are Warren Buffet.");

            }
            else
            {
                System.Console.WriteLine("You are Shashank.");

            }
            myD.Close();

        }

        public void validation(string s1,string s2)
        {
            if (s1.Contains(s2))
            {

                System.Console.WriteLine("Pass for "+s2);
            }
            else
            {
                System.Console.WriteLine("Fail for "+ s2);
            }
            

        }
    }
}
