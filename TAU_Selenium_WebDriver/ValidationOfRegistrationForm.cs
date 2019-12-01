﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TAU_Selenium_WebDriver
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidationOfRegistrationForm recording.
    /// </summary>
    [TestModule("a40b003f-9988-4fa0-8862-ea267246bd25", ModuleType.Recording, 1)]
    public partial class ValidationOfRegistrationForm : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TAU_Selenium_WebDriverRepository repository.
        /// </summary>
        public static TAU_Selenium_WebDriverRepository repo = TAU_Selenium_WebDriverRepository.Instance;

        static ValidationOfRegistrationForm instance = new ValidationOfRegistrationForm();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidationOfRegistrationForm()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidationOfRegistrationForm Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://automationpractice.com/index.php?controller=authentication&back=my-account' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://automationpractice.com/index.php?controller=authentication&back=my-account", "Chrome", "", false, false, false, true, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMyStore.EmailCreate' at 56;19.", repo.LoginMyStore.EmailCreateInfo, new RecordItemIndex(2));
            repo.LoginMyStore.EmailCreate.Click("56;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '123' with focus on 'LoginMyStore.EmailCreate'.", repo.LoginMyStore.EmailCreateInfo, new RecordItemIndex(3));
            repo.LoginMyStore.EmailCreate.PressKeys("123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}@{LShiftKey up}123.pl' with focus on 'LoginMyStore.EmailCreate'.", repo.LoginMyStore.EmailCreateInfo, new RecordItemIndex(4));
            repo.LoginMyStore.EmailCreate.PressKeys("{LShiftKey down}@{LShiftKey up}123.pl");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMyStore.FormGroup' at 323;43.", repo.LoginMyStore.FormGroupInfo, new RecordItemIndex(5));
            repo.LoginMyStore.FormGroup.Click("323;43");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='is_required validate account_input form-control') on item 'LoginMyStore.EmailCreate'.", repo.LoginMyStore.EmailCreateInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.LoginMyStore.EmailCreateInfo, "Class", "is_required validate account_input form-control");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='email_create') on item 'LoginMyStore.EmailCreate'.", repo.LoginMyStore.EmailCreateInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.LoginMyStore.EmailCreateInfo, "Id", "email_create");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (SafeClass='account_input form-control is_required validate') on item 'LoginMyStore.EmailCreate'.", repo.LoginMyStore.EmailCreateInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.LoginMyStore.EmailCreateInfo, "SafeClass", "account_input form-control is_required validate");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'LoginMyStore.EmailCreate'.", repo.LoginMyStore.EmailCreateInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.LoginMyStore.EmailCreateInfo, "TagName", "input");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='123@123.pl') on item 'LoginMyStore.EmailCreate'.", repo.LoginMyStore.EmailCreateInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.LoginMyStore.EmailCreateInfo, "TagValue", "123@123.pl");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Value>'@') on item 'LoginMyStore.EmailCreate'.", repo.LoginMyStore.EmailCreateInfo, new RecordItemIndex(11));
            Validate.AttributeContains(repo.LoginMyStore.EmailCreateInfo, "Value", "@");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
