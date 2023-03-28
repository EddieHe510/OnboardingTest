using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnboardingTest.Utilites;
using OpenQA.Selenium;

namespace OnboardingTest.Pages
{
    public class SignInPage
    {
     
        public void ClickSignInButton(IWebDriver driver)
        {
            // Identify the Sign In button and click on it
            IWebElement signInButton = driver.FindElement(By.XPath("//a[@class=\"item\"]"));
            signInButton.Click();
        }

        public void SignInActions(IWebDriver driver, string emailaddress, string password)
        {
            // Identify the Email address textbox and enter vaild email address
            IWebElement emailTextbox = driver.FindElement(By.XPath("//input[@name=\"email\"]"));
            emailTextbox.SendKeys(emailaddress);

            // Identify the Password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("//input[@name=\"password\"]"));
            passwordTextbox.SendKeys(password);

            // Identify the Login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//button[@class=\"fluid ui teal button\"]"));
            loginButton.Click();
        }

        public string GetAccountName(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//div[contains(text(), \"Eddie He\")]", 5);
            IWebElement actualAccountName = driver.FindElement(By.XPath("//div[contains(text(), \"Eddie He\")]"));
            return actualAccountName.Text;
        }
    }
}
