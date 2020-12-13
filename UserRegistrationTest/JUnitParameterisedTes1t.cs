using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using UserRegistration;
namespace UserRegistrationTest
{
    [TestClass]
    public class JUnitParameterisedTes1t
    {
        /// <summary>
        /// Test case will pass for all valid emails
        /// </summary>
        /// <param name="emailAddress"></param>
        [DataTestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenValidEmailList_WhenReturnsTrue_ShouldPassTheTest(string emailAddress)
        {
            bool expectedResult = true;
            var result = UserRegistration.UserRegistration.validateEmail(emailAddress);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given Invalid Email List, should match with expected result and test case should pass
        /// </summary>
        /// <param name="emailAddress"></param>
        [DataTestMethod]
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        public void GivenInvalidEmailList_WhenReturnsFalse_ShouldPassTheTest(string emailAddress) 
        {
            bool expectedResult = false;
            var result = UserRegistration.UserRegistration.validateEmail(emailAddress);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
