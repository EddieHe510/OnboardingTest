using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingTest.Pages
{
    public class JoinPage
    {
        public void JoinActions(IWebDriver driver)
        {
            // Navigate the web page
            driver.Navigate().GoToUrl("http://localhost:5000/");

            // Maxmize the window
            driver.Manage().Window.Maximize();

            // Identify the Join button and click on it
            IWebElement joinButton = driver.FindElement(By.XPath("//button[@class=\"ui green basic button\"]"));
            joinButton.Click();

            // Identify the First name textbox and enter valid first name
            IWebElement firstNameTextbox = driver.FindElement(By.XPath("//input[@name=\"firstName\"]"));
            firstNameTextbox.SendKeys("Eddie");

            // Identify the Last name textbox and enter valid last name
            IWebElement lastNameTextbox = driver.FindElement(By.XPath("//input[@name=\"lastName\"]"));
            lastNameTextbox.SendKeys("He");

            // Identify the Email address textbox and enter valid email address
            IWebElement emailTextbox = driver.FindElement(By.XPath("//input[@name=\"email\"]"));
            emailTextbox.SendKeys("hlhedison@gmail.com");

            // Identify the Password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("//input[@name=\"password\"]"));
            passwordTextbox.SendKeys("Eddie960510");

            // Identify the Confirm Password textbox and enter same password as first one
            IWebElement comfirmPassword = driver.FindElement(By.XPath("//input[@name=\"confirmPassword\"]"));
            comfirmPassword.SendKeys("Eddie960510");

            // Identify the Agreement checkbox and click on it
            IWebElement agreementCheckbox = driver.FindElement(By.XPath("//input[@name=\"terms\"]"));
            agreementCheckbox.Click();

            // Idenfity the Join button and click on it
            IWebElement submitButton = driver.FindElement(By.Id("submit-btn"));
            submitButton.Click();
        }
    }
}

