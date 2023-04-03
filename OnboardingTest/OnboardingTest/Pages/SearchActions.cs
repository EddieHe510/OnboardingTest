using NUnit.Framework;
using OnboardingTest.Utilites;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.Cast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingTest.Pages
{
    public class SearchActions
    {
        public void SearchAction(IWebDriver driver, string skill)
        {
            // Identify the Search Bar at the Home page and click on it
            IWebElement searchBar = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[4]/div/input"));
            searchBar.SendKeys(skill);

            IWebElement searchButton = driver.FindElement(By.XPath("//button[@class=\" big ui teal icon button\"]"));
            searchButton.Click();
        }
        public void VerificationSeller(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[contains(text(),\"Eddie He\")]", 5);
            // Identify the seller name if correct then click on it
            IWebElement sellerName = driver.FindElement(By.XPath("//*[contains(text(),\"Eddie He\")]"));
            if (sellerName.Text == "Eddie He")
            {
                IWebElement clickOnIt = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[3]/div/section/div/div[2]/div/div[2]/div/div/div[1]/a/img"));
                clickOnIt.Click();
            }
            else
            {
                Assert.Fail("Actual seller name and expected seller name do not match!");
            }
        }
        public string VerifiSellerPage(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"service-detail-section\"]/div[3]/div/div[2]/div[2]/div[1]/div/div[1]/a/h3", 5);
            // Check if user access to the right seller page
            IWebElement sellerName = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[3]/div/div[2]/div[2]/div[1]/div/div[1]/a/h3"));
            return sellerName.Text;
        }
    }
}
