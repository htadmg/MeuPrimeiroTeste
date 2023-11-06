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

            fromCall = fp.FileExists(@"C:\Users\Desktop\Smartbility\bin\Debug\net5.0\Smartbility.exe");

            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        public void FileNameNullOrEmpty_ThorwsArgumentNullException()
        {

            Assert.Inconclusive();
        }
    }
}
