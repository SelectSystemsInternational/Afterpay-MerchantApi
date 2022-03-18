/* 
 * Merchant API
 *
 * Afterpay Merchant API Initial build
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MerchantApi.Client;
using MerchantApi.Model;
using RestSharp;

namespace MerchantApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizationApi : IApiAccessor
    {

        /// <summary>
        /// Create a checkout
        /// </summary>
        /// <remarks>
        /// Creates a Afterpay checkout
        /// </remarks>
        /// <exception cref="MerchantApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiIdentifier">apiIdentifier</param>
        /// <returns>Checkout</returns>
        Task<Authentication> AuthorizationCreateTokenAsync();

        /// <summary>
        /// Retrieve a checkout
        /// </summary>
        /// <remarks>
        /// Retrieves a previously created checkout by id.
        /// </remarks>
        /// <exception cref="MerchantApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Checkout</returns>
        String AuthorizationGetToken(string id);

        /// <summary>
        /// Create a checkout
        /// </summary>
        /// <remarks>
        /// Creates a Afterpay checkout.  During the checkout process a customer can apply for credit decisioning in real-time. This means the checkout needs to represent a good picture of known customer details along with order information and the checkout entity represents this as a resource.  For more information on how to checkout with Afterpay see the #model:Z2QcrzRGHACY8wM6G guide.
        /// </remarks>
        /// <exception cref="MerchantApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Checkout</returns>
        Task<Authentication> AuthorizationCreateAsync(AuthorityRequest body = null);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthorizationApi : IAuthorizationApi
    {

        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorizationApi(String basePath, String userAgent)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
            this.Configuration.UserAgent = userAgent;

            ExceptionFactory = MerchantApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthorizationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = MerchantApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return "https://api-sandbox.afterpay.com/v2/";
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create a checkout Creates a Afterpay checkout.  During the checkout process a customer can apply for credit decisioning in real-time. This means the checkout needs to represent a good picture of known customer details along with order information and the checkout entity represents this as a resource.  For more information on how to checkout with Afterpay see the #model:Z2QcrzRGHACY8wM6G guide.
        /// </summary>
        /// <exception cref="MerchantApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Checkout</returns>
        public async Task<Authentication> AuthorizationCreateTokenAsync()
        {
            //var options = new RestClientOptions(GetBasePath())
            //{
            //    ThrowOnAnyError = true,
            //    Timeout = 15000 //15 Seconds
            //};

            //var client = new RestClient(options);

            var authorization = Convert.ToBase64String(Encoding.Default.GetBytes(this.Configuration.MerchantId + ":" + this.Configuration.MerchantSecretKey));

            this.Configuration.AccessToken = authorization;

            Configuration.AddApiKey("Authorization", this.Configuration.AccessToken);
            Configuration.AddApiKeyPrefix("Authorization", "Basic");

            Configuration.AddApiKey("User-Agent", this.Configuration.UserAgent);
            Configuration.AddApiKeyPrefix("User-Agent", "User-Agent");        

            var authorityRequest = new AuthorityRequest(AuthorityRequest.TypeEnum.ClientCredentials, 
                this.Configuration.MerchantId, this.Configuration.MerchantSecretKey);

            ApiResponse<Authentication> localVarResponse = await AuthorizationCreateWithHttpInfoAsync();
            if ((System.Net.HttpStatusCode)localVarResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return localVarResponse.Data;
            }

            return null;
        }

        /// <summary>
        /// Retrieve a checkout Retrieves a previously created checkout by id.
        /// </summary>
        /// <exception cref="MerchantApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Checkout</returns>
        public String AuthorizationGetToken(string id)
        {
            return Configuration.AccessToken;
        }

        /// <summary>
        /// Create a checkout Creates a Afterpay checkout.  During the checkout process a customer can apply for credit decisioning in real-time. This means the checkout needs to represent a good picture of known customer details along with order information and the checkout entity represents this as a resource.  For more information on how to checkout with Afterpay see the #model:Z2QcrzRGHACY8wM6G guide.
        /// </summary>
        /// <exception cref="MerchantApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Checkout</returns>
        public async Task<ApiResponse<Authentication>> AuthorizationCreateWithHttpInfoAsync(AuthorityRequest body = null)
        {

            var localVarPath = GetBasePath() + "configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = await Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthorizationCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Authentication>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Authentication)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Authentication)));
            
        }

        /// <summary>
        /// Create a checkout Creates a Afterpay checkout.  During the checkout process a customer can apply for credit decisioning in real-time. This means the checkout needs to represent a good picture of known customer details along with order information and the checkout entity represents this as a resource.  For more information on how to checkout with Afterpay see the #model:Z2QcrzRGHACY8wM6G guide.
        /// </summary>
        /// <exception cref="MerchantApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Checkout</returns>
        public async Task<Authentication> AuthorizationCreateAsync(AuthorityRequest body = null)
        {
             ApiResponse<Authentication> localVarResponse = await AuthorizationCreateAsyncWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a checkout Creates a Afterpay checkout.  During the checkout process a customer can apply for credit decisioning in real-time. This means the checkout needs to represent a good picture of known customer details along with order information and the checkout entity represents this as a resource.  For more information on how to checkout with Afterpay see the #model:Z2QcrzRGHACY8wM6G guide.
        /// </summary>
        /// <exception cref="MerchantApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Checkout)</returns>
        public async Task<ApiResponse<Authentication>> AuthorizationCreateAsyncWithHttpInfo(AuthorityRequest body = null)
        {

            var localVarPath = "configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthorizationCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Authentication>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Authentication) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Authentication)));
            
        }

    }
}
