using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExists()
        {
            FileProcess fp = new FileProcess();

            bool fromCall;

            fromCall = fp.FileExists(@"C:\Users\Agata Farias\Desktop\Smartbility\bin\Debug\net5.0\Smartbility.exe");

            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        public void FileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();

            bool fromCall;

            fromCall = fp.FileExists(@"C:\Smartbility.exe");

            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_throwsArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }
        [TestMethod]
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
