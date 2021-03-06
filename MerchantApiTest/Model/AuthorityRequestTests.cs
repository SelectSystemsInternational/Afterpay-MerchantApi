/* 
 * Merchant API
 *
 * Afterpay Merchant API Initial build
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using MerchantApi.Model;

namespace MerchantApi.Test
{
    /// <summary>
    ///  Class for testing Authority
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AuthorityRequestTests
    {
        // TODO uncomment below to declare an instance variable for Authority
        private AuthorityRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {

        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Authority
        /// </summary>
        [Test]
        public void AuthorityInstanceTest()
        {
            instance = new AuthorityRequest(AuthorityRequest.TypeEnum.ClientCredentials, "MerchantId", "MerchantSecretKey");
            Assert.IsInstanceOf<AuthorityRequest> (instance, "variable 'instance' is a Authority");
        }
    }

}
