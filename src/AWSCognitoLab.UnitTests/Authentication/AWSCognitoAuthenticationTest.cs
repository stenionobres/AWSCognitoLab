using NUnit.Framework;
using AWSCognitoLab.Authentication;

namespace AWSCognitoLab.UnitTests.Authentication
{
    [TestFixture]
    public class AWSCognitoAuthenticationTest
    {
        [Test]
        public void ShouldAuthenticateAnUser()
        {
            var authenticationFunction = new AuthenticationFunction();

            authenticationFunction.FunctionHandler(string.Empty, null);
        }
    }
}
