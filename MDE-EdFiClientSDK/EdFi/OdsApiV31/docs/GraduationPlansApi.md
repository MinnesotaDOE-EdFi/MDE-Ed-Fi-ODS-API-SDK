# EdFi.OdsApi.Sdk.Apis.All.GraduationPlansApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteGraduationPlanById**](GraduationPlansApi.md#deletegraduationplanbyid) | **DELETE** /ed-fi/graduationPlans/{id} | Deletes an existing resource using the resource identifier.
[**GetGraduationPlans**](GraduationPlansApi.md#getgraduationplans) | **GET** /ed-fi/graduationPlans | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetGraduationPlansById**](GraduationPlansApi.md#getgraduationplansbyid) | **GET** /ed-fi/graduationPlans/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostGraduationPlan**](GraduationPlansApi.md#postgraduationplan) | **POST** /ed-fi/graduationPlans | Creates or updates resources based on the natural key values of the supplied resource.
[**PutGraduationPlan**](GraduationPlansApi.md#putgraduationplan) | **PUT** /ed-fi/graduationPlans/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletegraduationplanbyid"></a>
# **DeleteGraduationPlanById**
> void DeleteGraduationPlanById (string id, string ifMatch = null)

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
    public class DeleteGraduationPlanByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GraduationPlansApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteGraduationPlanById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GraduationPlansApi.DeleteGraduationPlanById: " + e.Message );
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

<a name="getgraduationplans"></a>
# **GetGraduationPlans**
> List<EdFiGraduationPlan> GetGraduationPlans (int? offset = null, int? limit = null, bool? totalCount = null, string graduationPlanTypeDescriptor = null, int? educationOrganizationId = null, int? graduationSchoolYear = null, string totalRequiredCreditTypeDescriptor = null, string id = null, bool? individualPlan = null, double? totalRequiredCreditConversion = null, double? totalRequiredCredits = null)

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
    public class GetGraduationPlansExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GraduationPlansApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var graduationPlanTypeDescriptor = graduationPlanTypeDescriptor_example;  // string | The type of academic plan the student is following for graduation: for example, Minimum, Recommended, Distinguished, or Standard. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var graduationSchoolYear = 56;  // int? | The school year the student is expected to graduate. (optional) 
            var totalRequiredCreditTypeDescriptor = totalRequiredCreditTypeDescriptor_example;  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var id = id_example;  // string |  (optional) 
            var individualPlan = true;  // bool? | An indicator of whether the GraduationPlan is tailored for an individual. (optional) 
            var totalRequiredCreditConversion = 1.2;  // double? | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var totalRequiredCredits = 1.2;  // double? | The value of credits or units of value awarded for the completion of a course. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiGraduationPlan&gt; result = apiInstance.GetGraduationPlans(offset, limit, totalCount, graduationPlanTypeDescriptor, educationOrganizationId, graduationSchoolYear, totalRequiredCreditTypeDescriptor, id, individualPlan, totalRequiredCreditConversion, totalRequiredCredits);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GraduationPlansApi.GetGraduationPlans: " + e.Message );
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
 **graduationPlanTypeDescriptor** | **string**| The type of academic plan the student is following for graduation: for example, Minimum, Recommended, Distinguished, or Standard. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **graduationSchoolYear** | **int?**| The school year the student is expected to graduate. | [optional] 
 **totalRequiredCreditTypeDescriptor** | **string**| The type of credits or units of value awarded for the completion of a course. | [optional] 
 **id** | **string**|  | [optional] 
 **individualPlan** | **bool?**| An indicator of whether the GraduationPlan is tailored for an individual. | [optional] 
 **totalRequiredCreditConversion** | **double?**| Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
 **totalRequiredCredits** | **double?**| The value of credits or units of value awarded for the completion of a course. | [optional] 

### Return type

[**List<EdFiGraduationPlan>**](EdFiGraduationPlan.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgraduationplansbyid"></a>
# **GetGraduationPlansById**
> EdFiGraduationPlan GetGraduationPlansById (string id, string ifNoneMatch = null)

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
    public class GetGraduationPlansByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GraduationPlansApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiGraduationPlan result = apiInstance.GetGraduationPlansById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GraduationPlansApi.GetGraduationPlansById: " + e.Message );
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

[**EdFiGraduationPlan**](EdFiGraduationPlan.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgraduationplan"></a>
# **PostGraduationPlan**
> void PostGraduationPlan (EdFiGraduationPlan graduationPlan)

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
    public class PostGraduationPlanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GraduationPlansApi();
            var graduationPlan = new EdFiGraduationPlan(); // EdFiGraduationPlan | The JSON representation of the \"graduationPlan\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostGraduationPlan(graduationPlan);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GraduationPlansApi.PostGraduationPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **graduationPlan** | [**EdFiGraduationPlan**](EdFiGraduationPlan.md)| The JSON representation of the \&quot;graduationPlan\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgraduationplan"></a>
# **PutGraduationPlan**
> void PutGraduationPlan (string id, EdFiGraduationPlan graduationPlan, string ifMatch = null)

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
    public class PutGraduationPlanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GraduationPlansApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var graduationPlan = new EdFiGraduationPlan(); // EdFiGraduationPlan | The JSON representation of the \"graduationPlan\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutGraduationPlan(id, graduationPlan, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GraduationPlansApi.PutGraduationPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **graduationPlan** | [**EdFiGraduationPlan**](EdFiGraduationPlan.md)| The JSON representation of the \&quot;graduationPlan\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

