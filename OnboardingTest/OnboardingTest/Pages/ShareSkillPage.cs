using OpenQA.Selenium;
using OnboardingTest.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingTest.Pages
{
    public class ShareSkillPage
    {
        public void ClickShareSkillButton(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//a[@class=\"ui basic green button\"]", 5);
            // Identify the Share Skill button and click on it
            IWebElement shareSkillButton = driver.FindElement(By.XPath("//a[@class=\"ui basic green button\"]"));
            shareSkillButton.Click();
        }

        public void ShareSkillAction(IWebDriver driver, string title, string description, string tag, string skillexchange)
        {
            // Identify the Title textbox and enter vaild title
            IWebElement titleTextBox = driver.FindElement(By.Name("title"));
            titleTextBox.SendKeys(title);

            // Identify the Description textarea and enter description
            IWebElement descriptionTextArea = driver.FindElement(By.Name("description"));
            descriptionTextArea.SendKeys(description);

            // Identify the Category dropdown list and select Music & Audio
            IWebElement categoryDropDown = driver.FindElement(By.Name("categoryId"));
            categoryDropDown.Click();

            IWebElement mOOption = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select/option[6]"));
            mOOption.Click();

            // Identify the Category dropdown list and select the Subcategory
            IWebElement subcategoryDropDown = driver.FindElement(By.Name("subcategoryId"));
            subcategoryDropDown.Click();
            // Select the Voice over option
            IWebElement vOOption = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]"));
            vOOption.Click();

            // Identify the Tgas input a tag
            IWebElement tagTextbox = driver.FindElement(By.XPath("//input[@class=\"ReactTags__tagInputField\"]"));
            tagTextbox.SendKeys(tag);
            tagTextbox.SendKeys(Keys.Enter);

            // Identify the Skill-Exchange and input a tag
            IWebElement skillExchangeTag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            skillExchangeTag.SendKeys(skillexchange);
            skillExchangeTag.SendKeys(Keys.Enter);

            // Identify the Save button and click on it
            IWebElement saveButton = driver.FindElement(By.XPath("//input[@class=\"ui teal button\"]"));
            saveButton.Click();
        }
    }
}
