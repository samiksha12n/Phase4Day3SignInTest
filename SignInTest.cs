
using SignInLib;

namespace TestProjectOne
   
{
    [TestClass]
    public class SignInTest
    {
        [TestMethod]
        public void SuccessMethod()
        {
            string expResult = "valid user";
            Assert.AreEqual(expResult, SignIn.Authenticate("sam", "sam@1234"));
        }
        [TestMethod]
        public void FailMethod()
        {
            string expResult = "invalid user credential";
            Assert.AreEqual(expResult, SignIn.Authenticate("ravi", "ravi@1234"));
        }
        [TestMethod]
        public void AnonymousMethod()
        {
            string expResult = "You must provide username and password";
            Assert.AreEqual(expResult, SignIn.Authenticate(null, null));
        }

    }
}