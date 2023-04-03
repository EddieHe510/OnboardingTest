using NUnit.Framework;
using OnboardingTest.Pages;
using OnboardingTest.Utilites;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace OnboardingTest.FeatureStepDefinition
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        JoinPage joinObj = new JoinPage();
        SignInPage signInObj = new SignInPage();
        UserPage userObj = new UserPage();
        ShareSkillPage shareSkillObj = new ShareSkillPage();
        SearchActions searchActionsObj = new SearchActions();

        [Given(@"I navigated to the Mars website successfully")]
        public void GivenINavigatedToTheMarsWebsiteSuccessfully()
        {
            driver = new ChromeDriver();
            joinObj.GoToMars(driver);
        }

        [Given(@"I clicked the Join button")]
        public void GivenIClickedTheJoinButton()
        {
            joinObj.ClickJoinButton(driver);
        }

        [Given(@"I enter valid '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void GivenIEnterValid(string firstname, string lastname, string emailaddress, string password, string comfirmpassword)
        {
            joinObj.JoinActions(driver, firstname, lastname, emailaddress, password, comfirmpassword);
        }

        [Then(@"The account should be created successfully")]
        public void ThenTheAccountShouldBeCreatedSuccessfully()
        {
            string successMessage = joinObj.AccountHasBeenCreated(driver);
            Assert.That(successMessage == "Registration successful", "Actual message and expected message do not match!");
        }

        [Given(@"I clicked the signin button")]
        public void GivenIClickedTheSigninButton()
        {
            signInObj.ClickSignInButton(driver);
        }

        [Given(@"I enter valid '([^']*)', '([^']*)'")]
        public void GivenIEnterValid(string emailaddress, string password)
        {
            signInObj.SignInActions(driver, emailaddress, password);
        }

        [Then(@"Should be in the user page '([^']*)'")]
        public void ThenShouldBeInTheUserPage(string fullname)
        {
            string actualAccountNam = signInObj.GetAccountName(driver);
            Assert.That(actualAccountNam == fullname, "Actual name and expected name do not match!");
        }

        [Then(@"I write user description")]
        public void ThenIWriteUserDescription()
        {
            userObj.AddDescription(driver);
        }

        [Then(@"I add new langauge '([^']*)'")]
        public void ThenIAddNewLangauge(string language)
        {
            userObj.AddLanguage(driver, language);
        }

        [Then(@"I add new skills '([^']*)'")]
        public void ThenIAddNewSkills(string skill)
        {
            userObj.AddSkills(driver, skill);
        }

        [Then(@"I add new education '([^']*)' '([^']*)'")]
        public void ThenIAddNewEducation(string collegename, string degree)
        {
            userObj.AddEducation(driver, collegename, degree);
        }

        [Then(@"I add new certifications '([^']*)', '([^']*)'")]
        public void ThenIAddNewCertifications(string certificate, string certifiedFrom)
        {
            userObj.AddCertifications(driver, certificate, certifiedFrom);
        }

        [Then(@"I click the Share skill button")]
        public void ThenIClickTheShareSkillButton()
        {
            shareSkillObj.ClickShareSkillButton(driver);
        }

        [Then(@"I completed the Share skill form '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenICompletedTheShareSkillForm(string title, string description, string tags, string skillexchange)
        {
            shareSkillObj.ShareSkillAction(driver, title, description, tags, skillexchange);
        }

        [Then(@"My form should be searchable")]
        public void ThenMyFormShouldBeSearchable()
        {
            userObj.SearchMyProfile(driver);
        }

        [Given(@"I use search bar to search skill '([^']*)'")]
        public void GivenIUseSearchBarToSearchSkill(string skill)
        {
            searchActionsObj.SearchAction(driver, skill);
        }

        [Given(@"I should be able to see the seller I want and click the seller name")]
        public void GivenIShouldBeAbleToSeeTheSellerIWantAndClickTheSellerName()
        {
            searchActionsObj.VerificationSeller(driver);
        }

        [Then(@"I should be in the seller profile page")]
        public void ThenIShouldBeInTheSellerProfilePage()
        {
            string varifSellerName = searchActionsObj.VerifiSellerPage(driver);
            Assert.That(varifSellerName == "Eddie", "Actual seller name and expected seller name do not match.");
        }
    }
}

