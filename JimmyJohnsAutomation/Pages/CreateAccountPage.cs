﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace JimmyJohnsAutomation.Pages
{
    public class CreateAccountPage
    {

        [FindsBy(How = How.XPath, Using = "//input[@name='FirstName']")]
        [CacheLookup]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='LastName']")]
        [CacheLookup]
        public IWebElement LastNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='phone_0']")]
        [CacheLookup]
        public IWebElement PhoneNumberTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        [CacheLookup]
        public IWebElement EmailTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='emailConfirm']")]
        [CacheLookup]
        public IWebElement ConfirmEmailTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        [CacheLookup]
        public IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='passwordConfirm']")]
        [CacheLookup]
        public IWebElement PasswordConfirmTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='chkTermsAndConditions']")]
        [CacheLookup]
        public IWebElement TermsAndConditionsCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='createAccountBtn']")]
        [CacheLookup]
        public IWebElement CreateAccountButton { get; set; }

        //IWebElement FirstNameTextBox = driver.FindElement(By.XPath("//input[@name='FirstName']"));
        //IWebElement LastNameTextBox = driver.FindElement(By.XPath("//input[@name='LastName']"));
        //IWebElement PhoneNumberTextBox = driver.FindElement(By.XPath("//input[@id='phone_0']"));
        //IWebElement EmailTextBox = driver.FindElement(By.XPath("//input[@id='email']"));
        //IWebElement ConfirmEmailTextBox = driver.FindElement(By.XPath("//input[@id='emailConfirm']"));
        //IWebElement PasswordTextBox = driver.FindElement(By.XPath("//input[@id='password']"));
        //IWebElement PasswordConfirmTextBox = driver.FindElement(By.XPath("//input[@id='passwordConfirm']"));
        //IWebElement TermsAndConditionsCheckBox = driver.FindElement(By.XPath("//a[@id='chkTermsAndConditions']"));
        //IWebElement CreateAccountButton = driver.FindElement(By.XPath("//a[@id='createAccountBtn']"));


        public CreateAccountPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }


        public IWebDriver Driver { get; set; }

        public void CreateAccount()
        {
            FirstNameTextBox.SendKeys("Jimmy7");
            LastNameTextBox.SendKeys("JOBO7");
            PhoneNumberTextBox.SendKeys("3039139999");
            EmailTextBox.SendKeys("ktice@blah7.com");
            ConfirmEmailTextBox.SendKeys("ktice@blah7.com");
            PasswordTextBox.SendKeys("BlahPassword6");
            PasswordConfirmTextBox.SendKeys("BlahPassword6");
            TermsAndConditionsCheckBox.Click();
            CreateAccountButton.Click();
        }
    }
}
