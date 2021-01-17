# MerchantApi.Api.RefundsApi

All URIs are relative to *https://api.sandbox.zipmoney.com.au/merchant/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RefundsCreate**](RefundsApi.md#refundscreate) | **POST** /refunds | Create a refund
[**RefundsList**](RefundsApi.md#refundslist) | **GET** /refunds | List refunds
[**RefundsRetrieve**](RefundsApi.md#refundsretrieve) | **GET** /refunds/{id} | Retrieve a refund


<a name="refundscreate"></a>
# **RefundsCreate**
> Refund RefundsCreate (CreateRefundRequest body = null, string idempotencyKey = null)

Create a refund

Creates a refund for a previously authorised or captured charge. See #model:xWJer4QQyRumRi9LD for more information.  This endpoint will return 201 or otherwise 402 if unable to perform the refund.   | Error code | Description | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | account_inoperative | The account is in arrears or closed and cannot be charged | | amount_invalid | The refund amount is greater than the remaining captured total | | invalid_phoneNumber | 1. The charge is already fully refunded |

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class RefundsCreateExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RefundsApi();
            var body = new CreateRefundRequest(); // CreateRefundRequest |  (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | The unique idempotency key. (optional) 

            try
            {
                // Create a refund
                Refund result = apiInstance.RefundsCreate(body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundsApi.RefundsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRefundRequest**](CreateRefundRequest.md)|  | [optional] 
 **idempotencyKey** | **string**| The unique idempotency key. | [optional] 

### Return type

[**Refund**](Refund.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundslist"></a>
# **RefundsList**
> List<InlineResponse200> RefundsList (string chargeId = null, int? skip = null, int? limit = null)

List refunds

List all refunds

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class RefundsListExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RefundsApi();
            var chargeId = chargeId_example;  // string |  (optional) 
            var skip = 56;  // int? | Number of items to skip when paging (optional)  (default to 0)
            var limit = 56;  // int? | Number of items to retrieve when paging (optional)  (default to 100)

            try
            {
                // List refunds
                List&lt;InlineResponse200&gt; result = apiInstance.RefundsList(chargeId, skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundsApi.RefundsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chargeId** | **string**|  | [optional] 
 **skip** | **int?**| Number of items to skip when paging | [optional] [default to 0]
 **limit** | **int?**| Number of items to retrieve when paging | [optional] [default to 100]

### Return type

[**List<InlineResponse200>**](InlineResponse200.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/javascript
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refundsretrieve"></a>
# **RefundsRetrieve**
> Refund RefundsRetrieve (string id)

Retrieve a refund

Retrieves details of a specific refund

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class RefundsRetrieveExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RefundsApi();
            var id = id_example;  // string | The id of the refund

            try
            {
                // Retrieve a refund
                Refund result = apiInstance.RefundsRetrieve(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RefundsApi.RefundsRetrieve: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the refund | 

### Return type

[**Refund**](Refund.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/javascript
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

