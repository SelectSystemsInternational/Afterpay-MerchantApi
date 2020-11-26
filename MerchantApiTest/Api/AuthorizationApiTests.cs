/* 
 * Merchant API
 *
 * ZipMoney Merchant API Initial build
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using MerchantApi.Api;
using MerchantApi.Model;

namespace MerchantApi.Test
{
    /// <summary>
    ///  Class for testing AuthorizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuthorizationApiTests
    {
        private AuthorizationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthorizationApi("https://merchant-auth-nz.sandbox.zip.co");
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthorizationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthorizationApi
            Assert.IsInstanceOf(typeof(AuthorizationApi), instance, "instance is a AuthorizationApi");
        }
                
        /// <summary>
        /// Test CheckoutsCreate
        /// </summary>
        [Test]
        public void AuthorizationCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value

            //var client = new RestClient("https://merchant-auth-nz.sandbox.zip.com/oauth/token");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", "{\r\n  \"client_id\": \"{Client Id}\",\r\n  \"client_secret\": \"{Client Secret}",\r\n  \"audience\": \"https://auth-dev.partpay.co.nz\",\r\n  \"grant_type\": \"client_credentials\"\r\n}", ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            instance.Configuration.ClientId = "VxBHMqt9aI4cPHjRBBmLt1Orw6xkk63n";
            instance.Configuration.ClientSecret = "o7fNo_1vfSDYUyMA_ZD2sVqxAiO-oeEkYo2FDQhiyUdeJ-8-rx91wRrUkUEJmgEe";

            var response = instance.AuthorizationCreateToken("https://auth-dev.partpay.co.nz");

            Assert.IsInstanceOf<AccessToken> (response, "response is AccessToken");
        }
        
        /// <summary>
        /// Test CheckoutsGet
        /// </summary>
        [Test]
        public void AuthorizationGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string id = null;
            AuthorizationCreateTest();
            var response = instance.AuthorizationGet(id);
            Assert.IsInstanceOf<AccessToken> (response, "response is AccessToken");
        }
        
    }

}
