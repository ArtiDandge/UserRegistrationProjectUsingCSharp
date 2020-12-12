using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Given Valid Name should return true
        /// </summary>
        [TestMethod]
        public void GivenValidFirstName_ShouldReturnTrue()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateFirstName("Arti");
            Assert.AreEqual(expectedResult,result);
        }

        /// <summary>
        /// Given first name  which does not start from upper should return false
        /// </summary>
        [TestMethod]
        public void GivenInvalidFirstName_WhenNameNotStartingWithUpper_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateFirstName("arti");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given Valid Last Name should return true
        /// </summary>
        [TestMethod]
        public void GivenValidLastName_ShouldReturnTrue()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateFirstName("Dandge");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given last name which does not start from upper should return false
        /// </summary>
        [TestMethod]
        public void GivenInvalidLastName_WhenNameNotStartingWithUpper_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateFirstName("dandge");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given first name and last name  whose length is less that 3 character should return false
        /// </summary>
        [TestMethod]
        public void GivenName_WhenShort_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateFirstName("ar");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// given valid email, should return true
        /// </summary>
        [TestMethod]
        public void GivenValidEmail_ShouldReturnTrue()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateEmail("abc.xyz@gmail.com");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// given valid email, should return true
        /// </summary>
        [TestMethod]
        public void GivenValidEmail2_ShouldReturnTrue()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateEmail("abc.100@yahoo.com");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// given invalid email, should return false
        /// </summary>
        [TestMethod]
        public void GivenInvalidEmail_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateEmail("abc");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        ///  given invalid email, should return false
        /// </summary>
        [TestMethod]
        public void GivenInvalidEmail2_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateEmail("abc@.com.my");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given valid mobile number should return true
        /// </summary>
        [TestMethod]
        public void GivenValidMobileNumber_ShouldReturnTrue()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateMobileNo("91 9876543210");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given valid mobile number should return true
        /// </summary>
        [TestMethod]
        public void GivenValidMobileNumber2_ShouldReturnTrue()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateMobileNo("9876543210");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given invalid mobile number should return true
        /// </summary>
        [TestMethod]
        public void GivenInvalidMobileNumber_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateMobileNo("13224345564");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given invalid mobile number should return true
        /// </summary>
        [TestMethod]
        public void GivenInvalidMobileNumber2_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateMobileNo("243444");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// validate Password should return retrun
        /// </summary>
        [TestMethod]
        public void GivenValidPassword_ShouldReturnTrue()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validatePassword("Arti@12345");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// given invalid password should return false when its does not contain minimum 8 characters
        /// </summary>
        [TestMethod]
        public void GivenInvalidPassword_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validatePassword("Arti@12");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// retrun false when password doen not contain atleast one Upper letter
        /// </summary>
        [TestMethod]
        public void GivenInvalidPassword2_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validatePassword("arti@12");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// retrun false when password doen not contain atleast one numeric
        /// </summary>
        [TestMethod]
        public void GivenInvalidPassword3_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validatePassword("Aarti@we");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        ///  retrun false when password doen not contain atleast one special character
        /// </summary>
        [TestMethod]
        public void GivenInvalidPassword4_ShouldReturnFalse()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validatePassword("AartiS234we");
            Assert.AreEqual(expectedResult, result);
        }
    }
}
