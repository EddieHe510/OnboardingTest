using OpenQA.Selenium;
using OnboardingTest.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace OnboardingTest.Pages
{
    public class UserPage
    {
        public void AddDescription(IWebDriver driver)
        {
            // Identify the Description write icon and click it
            IWebElement descriptionIcon = driver.FindElement(By.XPath("//i[@class=\"outline write icon\"]"));
            descriptionIcon.Click();

            // Identify the Description textarea and input description
            IWebElement descriptionTextarea = driver.FindElement(By.XPath("//textarea[@name=\"value\"]"));
            descriptionTextarea.Click();
            descriptionTextarea.Clear();
            descriptionTextarea.SendKeys("I am Eddie, I am a Jazz music true lover!!!");

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();

        }                
        public void AddLanguage(IWebDriver driver, string language)
        {
            // Identify the Languages Add New button and add language
            IWebElement languageAddNewButton = driver.FindElement(By.XPath("//div[@class=\"ui teal button \"]"));
            languageAddNewButton.Click();

            IWebElement addLanguageTextBox = driver.FindElement(By.XPath("//input[@name=\"name\"]"));
            addLanguageTextBox.SendKeys(language);

            IWebElement languageDropDown = driver.FindElement(By.XPath("//select[@name=\"level\"]"));
            languageDropDown.Click();

            IWebElement fluentOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            fluentOption.Click();

            IWebElement languageAddButton = driver.FindElement(By.XPath("//input[@class=\"ui teal button\"]"));
            languageAddButton.Click();
        }
        public void AddSkills(IWebDriver driver, string skill)
        {
            // Identify the Skills tag and click on it 
            IWebElement skillsTag = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTag.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//div[@class=\"ui teal button\"]", 5);
            // Identify the Skill add new button and add skill
            IWebElement skillAddNewButton = driver.FindElement(By.XPath("//div[@class=\"ui teal button\"]"));
            skillAddNewButton.Click();

            IWebElement addSkillTextBox = driver.FindElement(By.XPath("//input[@name=\"name\"]"));
            addSkillTextBox.SendKeys(skill);

            IWebElement skillDropDown = driver.FindElement(By.XPath("//select[@name=\"level\"]"));
            skillDropDown.Click();

            IWebElement expertOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            expertOption.Click();

            IWebElement skillSaveButton = driver.FindElement(By.XPath("//input[@class=\"ui teal button \"]"));
            skillSaveButton.Click();
        }
        public void AddEducation(IWebDriver driver, string collegename, string degree)
        {
            // Identify the Education tag and click on it
            IWebElement educationTag = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTag.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 5);
            // Identify the Education add new button and add education
            IWebElement educationAddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            educationAddNewButton.Click();

            // college textbox
            IWebElement collegeTextBox = driver.FindElement(By.XPath("//input[@name=\"instituteName\"]"));
            collegeTextBox.SendKeys(collegename);

            // Country dropdown list
            IWebElement countryOfCollege = driver.FindElement(By.XPath("//select[@name=\"country\"]"));
            countryOfCollege.Click();

            IWebElement australiaOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[11]"));
            australiaOption.Click();

            // Title dropdown list
            IWebElement titleDropDown = driver.FindElement(By.XPath("//select[@name=\"title\"]"));
            titleDropDown.Click();

            IWebElement bAOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[3]"));
            bAOption.Click();

            // degree textbox
            IWebElement degreeTextbox = driver.FindElement(By.XPath("//input[@name=\"degree\"]"));
            degreeTextbox.SendKeys(degree);

            // Year of graduat
            IWebElement yearOfGraduat = driver.FindElement(By.XPath("//select[@name=\"yearOfGraduation\"]"));
            yearOfGraduat.Click();

            IWebElement secondOptiton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[3]"));
            secondOptiton.Click();

            // Click the add button
            IWebElement educationAddButton = driver.FindElement(By.XPath("//input[@class=\"ui teal button \"]"));
            educationAddButton.Click();
        }
        public void AddCertifications(IWebDriver driver, string certificate, string certifiedfrom)
        {
            // Identify the Certifications tag and click on it
            IWebElement certificationsTag = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationsTag.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 5);
            // Identify the certification add new button click on it and add certificate
            IWebElement certificationAddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            certificationAddNewButton.Click();

            IWebElement certificationTextBox = driver.FindElement(By.XPath("//input[@name=\"certificationName\"]"));
            certificationTextBox.SendKeys(certificate);

            IWebElement certifiedFromTextBox = driver.FindElement(By.XPath("//input[@name=\"certificationFrom\"]"));
            certifiedFromTextBox.SendKeys(certifiedfrom);

            IWebElement yearDropDown = driver.FindElement(By.XPath("//select[@class=\"ui fluid dropdown\"]"));
            yearDropDown.Click();

            IWebElement theFirstOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
            theFirstOption.Click();

            // Click the add button
            IWebElement certificationAddButton = driver.FindElement(By.XPath("//input[@class=\"ui teal button \"]"));
            certificationAddButton.Click();
        }  
        
        public void SearchMyProfile(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[1]/div[1]/input", 5);
            // Identify the Search skills searchbar and input skill name
            IWebElement searchSkillsSearchbar = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[1]/div[1]/input"));
            searchSkillsSearchbar.SendKeys("Jazz");

            IWebElement searchLinkIcon = driver.FindElement(By.XPath("//i[@class=\"search link icon\"]"));
            searchLinkIcon.Click();

            Wait.WaitToBeVisible(driver, "XPath", "//a[@class=\"seller-info\"]", 5);
            // Identify the seller name if correct then click on it
            IWebElement sellerName = driver.FindElement(By.XPath("//a[@class=\"seller-info\"]"));
            if (sellerName.Text == "Eddie He")
            {
                IWebElement clickOnIt = driver.FindElement(By.XPath("//a[@class=\"seller-info\"]"));
                clickOnIt.Click();
            }
            else
            {
                Assert.Fail("Actual seller name and expected seller name do not match!");
            }
        }
    }  
}
