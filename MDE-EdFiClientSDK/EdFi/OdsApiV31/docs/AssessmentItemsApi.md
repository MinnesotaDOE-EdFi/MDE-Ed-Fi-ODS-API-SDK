# EdFi.OdsApi.Sdk.Apis.All.AssessmentItemsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAssessmentItemById**](AssessmentItemsApi.md#deleteassessmentitembyid) | **DELETE** /ed-fi/assessmentItems/{id} | Deletes an existing resource using the resource identifier.
[**GetAssessmentItems**](AssessmentItemsApi.md#getassessmentitems) | **GET** /ed-fi/assessmentItems | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetAssessmentItemsById**](AssessmentItemsApi.md#getassessmentitemsbyid) | **GET** /ed-fi/assessmentItems/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostAssessmentItem**](AssessmentItemsApi.md#postassessmentitem) | **POST** /ed-fi/assessmentItems | Creates or updates resources based on the natural key values of the supplied resource.
[**PutAssessmentItem**](AssessmentItemsApi.md#putassessmentitem) | **PUT** /ed-fi/assessmentItems/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteassessmentitembyid"></a>
# **DeleteAssessmentItemById**
> void DeleteAssessmentItemById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class DeleteAssessmentItemByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentItemsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteAssessmentItemById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentItemsApi.DeleteAssessmentItemById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **ifMatch** | **string**| The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentitems"></a>
# **GetAssessmentItems**
> List<EdFiAssessmentItem> GetAssessmentItems (int? offset = null, int? limit = null, bool? totalCount = null, string identificationCode = null, string assessmentIdentifier = null, string _namespace = null, string assessmentItemCategoryDescriptor = null, string assessmentItemURI = null, string correctResponse = null, string expectedTimeAssessed = null, string id = null, int? maxRawScore = null, string nomenclature = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class GetAssessmentItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentItemsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var identificationCode = identificationCode_example;  // string | A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity. (optional) 
            var assessmentIdentifier = assessmentIdentifier_example;  // string | A unique number or alphanumeric code assigned to an assessment. (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the Assessment. (optional) 
            var assessmentItemCategoryDescriptor = assessmentItemCategoryDescriptor_example;  // string | Category or type of the AssessmentItem. For example:          Multiple choice          Analytic          Prose          ... (optional) 
            var assessmentItemURI = assessmentItemURI_example;  // string | The URI (typical a URL) pointing to the entry in an assessment item bank, which describes this content item. (optional) 
            var correctResponse = correctResponse_example;  // string | The correct response for the AssessmentItem. (optional) 
            var expectedTimeAssessed = expectedTimeAssessed_example;  // string | The duration of time allotted for the AssessmentItem. (optional) 
            var id = id_example;  // string |  (optional) 
            var maxRawScore = 56;  // int? | The maximum raw score achievable across all assessment items that are correct and scored at the maximum. (optional) 
            var nomenclature = nomenclature_example;  // string | Reflects the specific nomenclature used for AssessmentItem. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiAssessmentItem&gt; result = apiInstance.GetAssessmentItems(offset, limit, totalCount, identificationCode, assessmentIdentifier, _namespace, assessmentItemCategoryDescriptor, assessmentItemURI, correctResponse, expectedTimeAssessed, id, maxRawScore, nomenclature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentItemsApi.GetAssessmentItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Indicates how many items should be skipped before returning results. | [optional] [default to 0]
 **limit** | **int?**| Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25]
 **totalCount** | **bool?**| Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false]
 **identificationCode** | **string**| A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity. | [optional] 
 **assessmentIdentifier** | **string**| A unique number or alphanumeric code assigned to an assessment. | [optional] 
 **_namespace** | **string**| Namespace for the Assessment. | [optional] 
 **assessmentItemCategoryDescriptor** | **string**| Category or type of the AssessmentItem. For example:          Multiple choice          Analytic          Prose          ... | [optional] 
 **assessmentItemURI** | **string**| The URI (typical a URL) pointing to the entry in an assessment item bank, which describes this content item. | [optional] 
 **correctResponse** | **string**| The correct response for the AssessmentItem. | [optional] 
 **expectedTimeAssessed** | **string**| The duration of time allotted for the AssessmentItem. | [optional] 
 **id** | **string**|  | [optional] 
 **maxRawScore** | **int?**| The maximum raw score achievable across all assessment items that are correct and scored at the maximum. | [optional] 
 **nomenclature** | **string**| Reflects the specific nomenclature used for AssessmentItem. | [optional] 

### Return type

[**List<EdFiAssessmentItem>**](EdFiAssessmentItem.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentitemsbyid"></a>
# **GetAssessmentItemsById**
> EdFiAssessmentItem GetAssessmentItemsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class GetAssessmentItemsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentItemsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiAssessmentItem result = apiInstance.GetAssessmentItemsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentItemsApi.GetAssessmentItemsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **ifNoneMatch** | **string**| The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. | [optional] 

### Return type

[**EdFiAssessmentItem**](EdFiAssessmentItem.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postassessmentitem"></a>
# **PostAssessmentItem**
> void PostAssessmentItem (EdFiAssessmentItem assessmentItem)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class PostAssessmentItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentItemsApi();
            var assessmentItem = new EdFiAssessmentItem(); // EdFiAssessmentItem | The JSON representation of the \"assessmentItem\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostAssessmentItem(assessmentItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentItemsApi.PostAssessmentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessmentItem** | [**EdFiAssessmentItem**](EdFiAssessmentItem.md)| The JSON representation of the \&quot;assessmentItem\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putassessmentitem"></a>
# **PutAssessmentItem**
> void PutAssessmentItem (string id, EdFiAssessmentItem assessmentItem, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class PutAssessmentItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentItemsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var assessmentItem = new EdFiAssessmentItem(); // EdFiAssessmentItem | The JSON representation of the \"assessmentItem\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutAssessmentItem(id, assessmentItem, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentItemsApi.PutAssessmentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **assessmentItem** | [**EdFiAssessmentItem**](EdFiAssessmentItem.md)| The JSON representation of the \&quot;assessmentItem\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

