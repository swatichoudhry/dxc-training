using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {

        IWebDriver myD;

        public By oSearch = By.Name("q");
        public By oSubmit = By.Name("btnK");
        
        public void SearchText(string a)
        {
            
            myD.FindElement(oSearch).SendKeys(a);

        }
        public void SubmitButton()
        {
            
            myD.FindElement(oSubmit).Click();
        }


    }



    [TestClass]
    public class Test
    {
        public static void Test1()
        {
            UnitTest3 ut = new UnitTest3();
            IWebDriver myD1;
            myD1 = new ChromeDriver("C:\\selenium jars");
            myD1.Url = "https://www.google.com/";
            ut.SearchText("Shashnak");
            ut.SubmitButton();

        }
    }
}