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
            bool result = UserRegistration.UserRegistration.validateName("Arti");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given first name  which does not start from upper should return false
        /// </summary>
        [TestMethod]
        public void GivenInvalidFirstName_WhenNameNotStartingWithUpper_ShouldReturnFalse()
        {
            try
            {
                bool result = UserRegistration.UserRegistration.validateName("arti");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("Invalid User Name. Please make sure Name should follow all predefined rules of a valid name", e.Message);
            }
        }

        /// <summary>
        /// Given Valid Last Name should return true
        /// </summary>
        [TestMethod]
        public void GivenValidLastName_ShouldReturnTrue()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateName("Dandge");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// given invalid email,  should throw custom exception for invalid email
        /// </summary>
        [TestMethod]
        public void GivenInvalidLastName_WhenNameNotStartingWithUpper_ShouldReturnFalse()
        {
            try
            {
                bool result = UserRegistration.UserRegistration.validateName("dandge");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("Invalid User Name. Please make sure Name should follow all predefined rules of a valid name", e.Message);
            }
        }

        /// <summary>
        /// given invalid email,  should throw custom exception for invalid email
        /// </summary>
        [TestMethod]
        public void GivenName_WhenShort_ShouldReturnFalse()
        {
            try
            {
                bool result = UserRegistration.UserRegistration.validateName("ar");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("Invalid User Name. Please make sure Name should follow all predefined rules of a valid name", e.Message);
            }
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
        /// given invalid email, should throw custom exception for invalid email
        /// </summary>
        [TestMethod]
        public void GivenInvalidEmail_ShouldReturnFalse()
        {
            try
            {
                UserRegistration.UserRegistration.validateEmail("abc");
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("Invalid Email address.Please make sure email should follow all predefined rules of a valid email", e.Message);
            }
        }

        /// <summary>
        ///  given invalid email, should throw custom exception for invalid email
        /// </summary>
        [TestMethod]
        public void GivenInvalidEmail2_ShouldReturnFalse()
        {
            try
            {
                UserRegistration.UserRegistration.validateEmail("abc@.com.my");
            }
            catch(UserRegistrationExceptions e)
            {
                Assert.AreEqual("Invalid Email address.Please make sure email should follow all predefined rules of a valid email", e.Message);
            }
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
        /// Given invalid mobile number should throw custom exception for invalid mobile number
        /// </summary>
        [DataTestMethod]
        [DataRow("13224345564")]
        [DataRow("21 22343424234")]
        [DataRow("675565")]
        [DataRow("2343")]
        public void GivenInvalidMobileNumber_ShouldReturnFalse(string mobileNo)
        {
            try
            {
                UserRegistration.UserRegistration.validateMobileNo(mobileNo);
            }
            catch (UserRegistrationExceptions e)
            {
                Assert.AreEqual("Invalid Mobile Number.Please make sure Mobile Number should follow all predefined rules of a valid Mobile Number", e.Message);
            }
        }

        /// <summary>
        /// validate Password should return true
        /// </summary>
        [TestMethod]
        public void GivenValidPassword_ShouldReturnTrue()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validatePassword("Arti@12345");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        ///  throw custom exception for invalid password
        /// </summary>
        [DataTestMethod]
        [DataRow("AartiS234we")]
        [DataRow("Aarti@we")]
        [DataRow("arti@1342")]
        [DataRow("Arti@12")]
        public void GivenInvalidPassword_ShouldReturnFalse(string password)
        {
            try
            {
                UserRegistration.UserRegistration.validatePassword(password);
            }
            catch(UserRegistrationExceptions e)
            {
                Assert.AreEqual("Invalid Password.Please make sure Password should follow all predefined rules of a valid Password", e.Message);
            }            
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Given Valid Name to the lambda function should return true and test case should pass  
        /// </summary>
        [TestMethod]
        public void GivenValidName_WhenTrue_ShouldReturnTrueUsingLambdaExpression()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateUserName("Arti");
            Assert.AreEqual(expectedResult, result);
        }
        /// <summary>
        /// Given Invalid Name to the lambda function should return false and test case should pass  
        /// </summary>
        [TestMethod]
        public void GivenInvalidName_WhenFalse_ShouldReturnTrueUsingLambdaExpression()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateUserName("arti");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given Valid email to the lambda function should return true and test case should pass  
        /// </summary>
        [TestMethod]
        public void GivenValidEmail_WhenTrue_ShouldReturnTrueUsingLambdaExpression()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateUserEmail("abc.xyz@gmail.com");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given Invalid email to the lambda function should return false and test case should pass  
        /// </summary>
        [TestMethod]
        public void GivenInvalidEmail_WhenFalse_ShouldReturnTrueUsingLambdaExpression()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateUserEmail("abc@%*gmail.com");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        ///  Given Valid mobile number to the lambda function should return true and test case should pass  
        /// </summary>
        [TestMethod]
        public void GivenValidMobileNo_WhenTrue_ShouldReturnTrueUsingLambdaExpression()
        {
            bool expectedResult = true;
            bool result = UserRegistration.UserRegistration.validateUserMobileNo("91 9876543210");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        ///  Given Invalid mobile number to the lambda function should return false and test case should pass  
        /// </summary>
        [TestMethod]
        public void GivenInvalidMobileNo_WhenFalse_ShouldReturnTrueUsingLambdaExpression()
        {
            bool expectedResult = false;
            bool result = UserRegistration.UserRegistration.validateUserMobileNo("76543210");
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Given Valid Password to the lambda function should return true and test case should pass 
        /// </summary>
        [TestMethod]

        public void GivenValidPassword_WhenTrue_ShouldReturnTrueUsingLambdaExpression()
        {
            bool expectedResult = true;
            var result = UserRegistration.UserRegistration.validateUserPassword("Arti@12333");
            Assert.AreEqual(expectedResult, result);

        }

        /// <summary>
        /// Given Invalid Password to the lambda function should return false and test case should pass 
        /// </summary>
        [TestMethod]

        public void GivenInvalidPassword_WhenFalse_ShouldReturnTrueUsingLambdaExpression()
        {
            bool expectedResult = false;
            var result = UserRegistration.UserRegistration.validateUserPassword("arti2333");
            Assert.AreEqual(expectedResult, result);

        }
    }
}
