using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnboardingTest.CommonDriver;
using OpenQA.Selenium;

namespace OnboardingTest.Pages
{
    public class SignInPage
    {
        public void SignInActions(IWebDriver driver)
        {
            // Navigate the web page
            driver.Navigate().GoToUrl("http://localhost:5000/");

            // Maxmize the window
            driver.Manage().Window.Maximize();

            // Identify the Sign In button and click on it
            IWebElement signInButton = driver.FindElement(By.XPath("//a[@class=\"item\"]"));
            signInButton.Click();

            // Identify the Email address textbox and enter vaild email address
            IWebElement emailTextbox = driver.FindElement(By.XPath("//input[@name=\"email\"]"));
            emailTextbox.SendKeys("hlhedison@gamil.com");

            // Identify the Password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("//input[@name=\"password\"]"));
            passwordTextbox.SendKeys("Eddie960510");

            // Identify the Login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//button[@class=\"fluid ui teal button\"]"));
            loginButton.Click();
        }
    }
}
