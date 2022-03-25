using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Ratep;

namespace TC_SP
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void SearchTestMaterialTrue()
        {
            bool IsTrue = Test.SearchTestMaterial("т");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void SearchTestOKEITrue()
        {
            bool IsTrue = Test.SearchTestOKEI("м");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void SearchTestMaterialFalse()
        {
            bool IsFalse = Test.SearchTestMaterial("1");
            Assert.AreEqual(false, IsFalse);
        }
        [TestMethod]
        public void SearchTestOKEIFalse()
        {
            bool IsFalse = Test.SearchTestOKEI("2");
            Assert.AreEqual(false, IsFalse);
        }

        [TestMethod]
        public void CipherTestTrue()
        {
            // Исходные данные
            string password = "12ав1";
            bool experted = true;

            // Тестирование метода
            string encrypt = Cipher.Encrypt(password);
            bool actual = password != encrypt && password == Cipher.Encrypt(encrypt);

            // Сравнение ожидаемого результата с полученным
            Assert.AreEqual(experted, actual);
        }
        [TestMethod]
        
        public void AutorizatingTestTrue()
        {
            bool IsTrue = Test.AutorizatingTest("ingener", "12345");
            Assert.AreNotEqual(true, IsTrue);
        }
        [TestMethod]
        public void AutorizatingTestFalse()
        {
            bool IsFalse = Test.AutorizatingTest("ingener", "12355");
            Assert.AreEqual(false, IsFalse);
        }
        [TestMethod]
    
        public void CipherTestFalse()
        {
            // Исходные данные
            string password = "";
            bool experted = true;

            // Тестирование метода
            string encrypt = Cipher.Encrypt(password);
            bool actual = password != encrypt && password == Cipher.Encrypt(encrypt);

            // Сравнение ожидаемого результата с полученным
            Assert.AreNotEqual(experted, actual);
        }

        [TestMethod]
        public void SearchTestNomenclotureTrue()
        {
            bool IsTrue = Test.SearchTestMaterial("р");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void SearchTestNomenclotureFalse()
        {
            bool IsFalse = Test.SearchTestOKEI("3");
            Assert.AreEqual(false, IsFalse);
        }
    }
}
