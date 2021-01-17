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
    ///  Class for testing Consumer
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConsumerTests
    {
        // TODO uncomment below to declare an instance variable for CheckoutConfiguration
        private Consumer instance;

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
        /// Test an instance of CheckoutConfiguration
        /// </summary>
        [Test]
        public void ConsumerInstanceTest()
        {
            var phoneNumber = "0200000000";
            instance = new Consumer(phoneNumber, "Given Name", "Surname", "youremail@yourwebsite.com");
            Assert.IsInstanceOf<Consumer> (instance, "variable 'instance' is a CheckoutConfiguration");
        }
    }
}