# MerchantApi.Model.Checkout
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The checkout id | 
**Uri** | **string** | The uri to redirect the user to in order to approve this checkout. | 
**Type** | **string** | The type of checkout | [optional] [default to TypeEnum.Standard]
**Shopper** | [**Shopper**](Shopper.md) |  | [optional] 
**Order** | [**CheckoutOrder**](CheckoutOrder.md) |  | [optional] 
**Features** | [**CheckoutFeatures**](CheckoutFeatures.md) |  | [optional] 
**Config** | [**CheckoutConfiguration**](CheckoutConfiguration.md) |  | [optional] 
**Created** | **DateTime?** | Date the checkout was created | 
**PhoneNumber** | **string** | Current phoneNumber of the checkout | 
**CustomerId** | **string** | The id of the customer who has approved this checkout request. Only present if approved. | [optional] 
**Metadata** | [**Metadata**](Metadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

