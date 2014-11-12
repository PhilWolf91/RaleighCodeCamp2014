using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;


namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"F:\PhilWolf91ReTry\newProject\WpfApplication1\CodedUITestProject1\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            this.UIMap.enterStringAndTwoIntsParams.UIEnterFullNameEditText = TestContext.DataRow["FullName"].ToString();
            this.UIMap.enterStringAndTwoIntsParams.UIEnterNum1EditText = TestContext.DataRow["Num1"].ToString();
            this.UIMap.enterStringAndTwoIntsParams.UIEnterNum2EditText = TestContext.DataRow["Num2"].ToString();
            this.UIMap.UIMainWindowWindow.UIPhillipWolfText.SearchProperties[WpfText.PropertyNames.Name] = TestContext.DataRow["FullName"].ToString();
            this.UIMap.UIMainWindowWindow.UIItem25Text.SearchProperties[WpfText.PropertyNames.Name] = TestContext.DataRow["MagicNumber"].ToString();
            this.UIMap.UIMainWindowWindow.UIItem20Text.SearchProperties[WpfText.PropertyNames.Name] = TestContext.DataRow["Added"].ToString();
            this.UIMap.UIMainWindowWindow.UIItem100Text.SearchProperties[WpfText.PropertyNames.Name] = TestContext.DataRow["Multiplied"].ToString();
            this.UIMap.AssertResultsExpectedValues.UIPhillipWolfTextDisplayText = TestContext.DataRow["FullName"].ToString();
            this.UIMap.AssertResultsExpectedValues.UIItem25TextDisplayText = TestContext.DataRow["MagicNumber"].ToString();
            this.UIMap.AssertResultsExpectedValues.UIItem20TextDisplayText = TestContext.DataRow["Added"].ToString();
            this.UIMap.AssertResultsExpectedValues.UIItem100TextDisplayText = TestContext.DataRow["Multiplied"].ToString();
            this.UIMap.openApplication();
            this.UIMap.enterStringAndTwoInts();
            this.UIMap.AssertResults();
            this.UIMap.closeApplication();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
