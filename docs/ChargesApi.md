# MerchantApi.Api.ChargesApi

All URIs are relative to *https://api.sandbox.zipmoney.com.au/merchant/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChargesCancel**](ChargesApi.md#chargescancel) | **POST** /charges/{id}/cancel | Cancel a charge
[**ChargesCapture**](ChargesApi.md#chargescapture) | **POST** /charges/{id}/capture | Capture a charge
[**ChargesCreate**](ChargesApi.md#chargescreate) | **POST** /charges | Create a charge
[**ChargesList**](ChargesApi.md#chargeslist) | **GET** /charges | List charges
[**ChargesRetrieve**](ChargesApi.md#chargesretrieve) | **GET** /charges/{id} | Retrieve a charge


<a name="chargescancel"></a>
# **ChargesCancel**
> Charge ChargesCancel (string id, string idempotencyKey = null)

Cancel a charge

Cancels an authorised charge.  | Error code | Description | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | invalid_phoneNumber | The charge is not in authorised phoneNumber |

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class ChargesCancelExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChargesApi();
            var id = id_example;  // string | The id of the authorised charge
            var idempotencyKey = idempotencyKey_example;  // string | The unique idempotency key. (optional) 

            try
            {
                // Cancel a charge
                Charge result = apiInstance.ChargesCancel(id, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargesApi.ChargesCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the authorised charge | 
 **idempotencyKey** | **string**| The unique idempotency key. | [optional] 

### Return type

[**Charge**](Charge.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargescapture"></a>
# **ChargesCapture**
> Charge ChargesCapture (string id, CaptureChargeRequest body = null, string idempotencyKey = null)

Capture a charge

| Error code | Description | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | amount_invalid | Capture amount greater than authorised amount | | invalid_phoneNumber | The charge is not in authorised phoneNumber |

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class ChargesCaptureExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChargesApi();
            var id = id_example;  // string | The id of the authorised charge
            var body = new CaptureChargeRequest(); // CaptureChargeRequest |  (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | The unique idempotency key. (optional) 

            try
            {
                // Capture a charge
                Charge result = apiInstance.ChargesCapture(id, body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargesApi.ChargesCapture: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the authorised charge | 
 **body** | [**CaptureChargeRequest**](CaptureChargeRequest.md)|  | [optional] 
 **idempotencyKey** | **string**| The unique idempotency key. | [optional] 

### Return type

[**Charge**](Charge.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargescreate"></a>
# **ChargesCreate**
> Charge ChargesCreate (CreateChargeRequest body = null, string idempotencyKey = null)

Create a charge

Creates a #model:ehEN48PET29iNdex3 which represents a charge against a customer's account.  To execute this endpoint you must first obtain customer approval by implementing the #docTextSection:43C79g2JjeGs8AHWi as a part of your online store.  This endpoint will return 201 if successful otherwise 402 with a specific error response.  ## Capture or authorisation  A charge can be created as either an authorisation or an immediate capture. This can be controlled in the initial request to the charge.  In most cases you will want to immediately capture the payment, this will mark the debit for settlement into your account the very same day and will immediately deduct the funds from the customer's account.  In some cases you may wish to delay the settlement of funds until a later date, perhaps until the goods are shipped to the customer. In this scenario you should send { capture: false } in the request to the #endpoint:dtmp3HxaHKjewvvGW endpoint and the charge will be created in an authorised phoneNumber.  An authorised charge will place a hold for the specified amount on the customer's account in the form of a pending debit. Once authorised you are guaranteed the funds are available and awaiting a capture request to the #endpoint:wReod3JtbzNutMSXj endpoint, at which point the charge will move to the captured phoneNumber and the funds will be settled into your account. It is at this point the customer's interest free period will start if applicable for the selected account.  ## Specific error responses  If a charge was not able to be performed a \"402 - Request Failed\" status code will be returned as detailed in #docTextSection:fJYHM2ZKtEui8RrAM. The error object can contain more specific error reason codes, which are detailed below.  | Error code | Description | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -| | account_insufficient_funds | Customer does not have sufficient funds to perform the charge | | account_inoperative | The account is in arrears or closed and cannot be charged | | account_locked | The account is locked | | amount_invalid | The amount provided does not match the approved checkout amount | | fraud_check | Fraud checks resulted in payment failure |

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class ChargesCreateExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChargesApi();
            var body = new CreateChargeRequest(); // CreateChargeRequest |  (optional) 
            var idempotencyKey = idempotencyKey_example;  // string | The unique idempotency key. (optional) 

            try
            {
                // Create a charge
                Charge result = apiInstance.ChargesCreate(body, idempotencyKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargesApi.ChargesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateChargeRequest**](CreateChargeRequest.md)|  | [optional] 
 **idempotencyKey** | **string**| The unique idempotency key. | [optional] 

### Return type

[**Charge**](Charge.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargeslist"></a>
# **ChargesList**
> ChargeCollection ChargesList (string phoneNumber = null, int? skip = null, int? limit = null, string expand = null)

List charges

Lists all charges matching search criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class ChargesListExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChargesApi();
            var phoneNumber = phoneNumber_example;  // string | The phoneNumber filter (optional) 
            var skip = 56;  // int? | Number of items to skip when paging (optional)  (default to 0)
            var limit = 56;  // int? | Number of items to retrieve when paging (optional)  (default to 100)
            var expand = expand_example;  // string | Allows expanding related entities in the response. Only valid entry is 'customer' (optional) 

            try
            {
                // List charges
                ChargeCollection result = apiInstance.ChargesList(phoneNumber, skip, limit, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargesApi.ChargesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneNumber** | **string**| The phoneNumber filter | [optional] 
 **skip** | **int?**| Number of items to skip when paging | [optional] [default to 0]
 **limit** | **int?**| Number of items to retrieve when paging | [optional] [default to 100]
 **expand** | **string**| Allows expanding related entities in the response. Only valid entry is &#39;customer&#39; | [optional] 

### Return type

[**ChargeCollection**](ChargeCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/javascript
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chargesretrieve"></a>
# **ChargesRetrieve**
> Charge ChargesRetrieve (string id, string expand = null)

Retrieve a charge

Retrieve details of a previously created charge.

### Example
```csharp
using System;
using System.Diagnostics;
using MerchantApi.Api;
using MerchantApi.Client;
using MerchantApi.Model;

namespace Example
{
    public class ChargesRetrieveExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChargesApi();
            var id = id_example;  // string | The id of the charge
            var expand = expand_example;  // string | Allows expanding related entities in the response. Only valid entry is 'customer' (optional) 

            try
            {
                // Retrieve a charge
                Charge result = apiInstance.ChargesRetrieve(id, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChargesApi.ChargesRetrieve: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the charge | 
 **expand** | **string**| Allows expanding related entities in the response. Only valid entry is &#39;customer&#39; | [optional] 

### Return type

[**Charge**](Charge.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/javascript
 - **Accept**: application/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

