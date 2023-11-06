using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;
using System.Configuration;
using System.IO;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        private const string BAD_FILE_NAME = @"C:\Smartbility.exe";

        private string _GoodFileName;

        public TestContext TestContext { get; set; }

        #region Teste Initialize e Cleanup

        [TestInitialize]
        public void TesteInitialize() 
        {
            if(TestContext.TestName == "FileNameDoesExists")
            {
                SetGoodFileName();
                if(!string.IsNullOrEmpty(_GoodFileName))
                {
                    TestContext.WriteLine($"Creating File: {_GoodFileName}");
                    File.AppendAllText(_GoodFileName, "Some Text");
                }
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName == "FileNameDoesExists")
            {
                if (!string.IsNullOrEmpty(_GoodFileName))
                {
                    TestContext.WriteLine("Deleting File");
                    File.Delete(_GoodFileName);
                }
            }
        }
        #endregion


        [TestMethod]
        [Description("check to see if a file does exist.")]
        [Priority(0)]
        [TestCategory("NoException")]
        public void FileNameDoesExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            TestContext.WriteLine("Testing File");
            fromCall = fp.FileExists(_GoodFileName);
            

            Assert.IsTrue(fromCall);
        }

        public void SetGoodFileName()
        {
            _GoodFileName = ConfigurationManager.AppSettings["GoodFileName"];
            if (_GoodFileName.Contains("[AppPath]"))
            {
                _GoodFileName = _GoodFileName.Replace("[AppPath]",
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
        }
        [TestMethod]
        [Timeout(3100)]
        public void SimulateTimeOut()
        {
            System.Threading.Thread.Sleep(3000);
        }


        [TestMethod]
        [Description("check to see if a file does NOT exist.")]
        [Priority(0)]
        [TestCategory("NoException")]
        public void FileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();

            bool fromCall;

            fromCall = fp.FileExists(BAD_FILE_NAME);

            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [Priority(1)]
        [TestCategory("Exception")]
        public void FileNameNullOrEmpty_throwsArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }
        [TestMethod]
        [Priority(1)]
        [TestCategory("NoException")]
        public void FileNameNullOrEmpty_throwsArgumentNullException_UsingTryCatch()
        {
            FileProcess fp = new FileProcess();
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentNullException)
            {
                return;
            }
            Assert.Fail("Fail expected");
        }
    }
}
