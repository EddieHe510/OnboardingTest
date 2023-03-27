﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

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
            descriptionTextarea.SendKeys("I am Eddie, I am a Jazz music true lover!!!");

        }
        
            
        public void AddLanguage(IWebDriver driver)
        {
                // Identify the Languages Add New button and add language
                IWebElement languageAddNewButton = driver.FindElement(By.XPath("//div[@class=\"ui teal button \"]"));
                languageAddNewButton.Click();

                IWebElement addLanguageTextBox = driver.FindElement(By.XPath("//input[@name=\"name\"]"));
                addLanguageTextBox.SendKeys("English");

                IWebElement languageDropDown = driver.FindElement(By.XPath("//select[@name=\"level\"]"));
                languageDropDown.Click();

                IWebElement fluentOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
                fluentOption.Click();

                IWebElement languageAddButton = driver.FindElement(By.XPath("//input[@class=\"ui teal button\"]"));
                languageAddButton.Click();
        }

        public void AddSkills(IWebDriver driver)
        {
            // Identify the Skills tag and click on it 
            IWebElement skillsTag = driver.FindElement(By.XPath("//a[@class=\"item active\"]"));
            skillsTag.Click();

            // Identify the Skill add new button and add skill
            IWebElement skillAddNewButton = driver.FindElement(By.XPath("//div[@class=\"ui teal button\"]"));
            skillAddNewButton.Click();

            IWebElement addSkillTextBox = driver.FindElement(By.XPath("//input[@name=\"name\"]"));
            addSkillTextBox.SendKeys("Piano");

            IWebElement skillDropDown = driver.FindElement(By.XPath("//select[@name=\"level\"]"));
            skillDropDown.Click();

            IWebElement expertOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            expertOption.Click();

            IWebElement skillSaveButton = driver.FindElement(By.XPath("//input[@class=\"ui teal button \"]"));
            skillSaveButton.Click();
        }

        public void AddEducation(IWebDriver driver)
        {
            // Identify the Education tag and click on it
            IWebElement educationTag = driver.FindElement(By.XPath("//a[@class=\"item active\"]"));
            educationTag.Click();

            // Identify the Education add new button and add education
            IWebElement educationAddNewButton = driver.FindElement(By.XPath("//div[@class=\"ui teal button \"]"));
            educationAddNewButton.Click();

            // college textbox
            IWebElement collegeTextBox = driver.FindElement(By.XPath("//input[@name=\"instituteName\"]"));
            collegeTextBox.SendKeys("USQ");

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
            degreeTextbox.SendKeys('Master');

            // Year of graduat
            IWebElement yearOfGraduat = driver.FindElement(By.XPath("//select[@name=\"yearOfGraduation\"]"));
            yearOfGraduat.Click();

            IWebElement secondOptiton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[3]"));
            secondOptiton.Click();

            // Click the add button
            IWebElement educationAddButton = driver.FindElement(By.XPath("//input[@class=\"ui teal button \"]"));
            educationAddButton.Click();
        }

        public void AddCertifications(IWebDriver driver)
        {
            // Identify the Certifications tag and click on it
            IWebElement certificationsTag = driver.FindElement(By.XPath("//a[@class=\"item active\"]"));
            certificationsTag.Click();

            IWebElement certificationAddNewButton = driver.FindElement(By.XPath("//div[@class=\"ui teal button \"]"));
            certificationAddNewButton.Click();

            IWebElement certificationTextBox = driver.FindElement(By.XPath("//input[@name=\"certificationName\"]"));
            certificationTextBox.SendKeys("Master of Jazz");

            IWebElement certifiedFromTextBox = driver.FindElement(By.XPath("//input[@name=\"certificationFrom\"]"));
            certifiedFromTextBox.SendKeys("GUESS");

            IWebElement yearDropDown = driver.FindElement(By.XPath("//select[@class=\"ui fluid dropdown\"]"));
            yearDropDown.Click();

            IWebElement theFirstOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
            theFirstOption.Click();
        }

   
    
    }
}
