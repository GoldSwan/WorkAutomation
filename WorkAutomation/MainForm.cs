using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WorkAutomation.Service;

namespace WorkAutomation
{
    public partial class MainForm : Form
    {
        private IWebDriver driver;
        private IAutomationService cLoginService;

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        public MainForm(IWebDriver driver)
        {
            InitializeComponent();
            this.driver = driver;
            cLoginService = LoginService.GetInstance(this);
            SetDefaultValue();
        }
        private void SetDefaultValue()
        {          
            this.TxtServerUrl.Text = "https://login.ecount.com/Login/KR/";
            this.TxtCode.Text = "";
            this.TxtId.Text = "";
            this.TxtPassword.Text = "";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DoService(cLoginService);
        }

        private void DoService(IAutomationService cAutoMationService)
        {
            cAutoMationService.AutoService();
        }
    }
}
