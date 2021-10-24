using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace WorkAutomation.Service
{
    //로그인 서비스 - 싱글턴
    public class LoginService : IAutomationService
    {
        MainForm mainForm { get; set; }
        private static LoginService instance = null;
        private LoginService(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        public static LoginService GetInstance(MainForm mainForm)
        {
            if(instance == null)
            {
                instance = new LoginService(mainForm);
            }
            return instance;
        }
        public void AutoService()
        {
            mainForm.Driver.Navigate().GoToUrl(mainForm.TxtServerUrl.Text);
            mainForm.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);
            mainForm.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10000);
            mainForm.Driver.Manage().Window.Maximize();

            mainForm.Driver.FindElement(By.XPath("//INPUT[@id='com_code']")).Click();
            mainForm.Driver.FindElement(By.XPath("//INPUT[@id='com_code']")).Clear();
            mainForm.Driver.FindElement(By.XPath("//INPUT[@id='com_code']")).SendKeys(mainForm.TxtCode.Text);

            mainForm.Driver.FindElement(By.XPath("//INPUT[@id='id']")).Click();
            mainForm.Driver.FindElement(By.XPath("//INPUT[@id='id']")).Clear();
            mainForm.Driver.FindElement(By.XPath("//INPUT[@id='id']")).SendKeys(mainForm.TxtId.Text);

            mainForm.Driver.FindElement(By.XPath("//INPUT[@id='passwd']")).Click();
            mainForm.Driver.FindElement(By.XPath("//INPUT[@id='passwd']")).Clear();
            mainForm.Driver.FindElement(By.XPath("//INPUT[@id='passwd']")).SendKeys(mainForm.TxtPassword.Text);


            mainForm.Driver.FindElement(By.XPath("//BUTTON[@id='save']")).Click();

            mainForm.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);
            mainForm.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10000);
        }
    }
}
