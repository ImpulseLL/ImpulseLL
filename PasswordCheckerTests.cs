using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            string password = "ASqw123$";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void Check_8Symbols_Returnsfalse()
        {
            string password = "Kukusha";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);

        }

        [TestMethod()]
        public void Check_20Symbols_Returnsfalse()
        {
            string password = "Zxcvbnmqwertyuiopasdfg3";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);
            
        }
        [TestMethod()]
        public void Check_Numbers_ReturnsTrue()
        {
            string password = "Stalker_2006";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void Check_Numbers_Returnsfalse()
        {
            string password = "Stalker_denis";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);
            
        }
        [TestMethod()]
        public void Check_SpecialCharacters_ReturnsTrue()
        {
            string password = "VORVZAKONE_228";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void Check_SpecialCharacters_Returnsfalse()
        {
            string password = "DENISKARABCHIK";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);
            
        }
        [TestMethod()]
        public void Check_UppercaseLetters_ReturnsTrue()
        {
            string password = "Bsgbsgbsg_1858";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void Check_UppercaseLetters_Returnsfalse()
        {
            string password = "DENISKARABCHIKOV";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);
            
        }
        [TestMethod()]
        public void Check_LowercaseLetters_ReturnsTrue()
        {
            string password = "Qwerty_1858";
            bool expected = true;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void Check_LowercaseLetters_Returnsfalse()
        {
            string password = "Qwerty1858";
            bool expected = false;
            bool actual = PasswordChecker.ValidatePassword(password);
            Assert.IsFalse(actual);

        }
    }

}
