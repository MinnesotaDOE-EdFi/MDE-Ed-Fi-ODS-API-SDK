# EdFi.OdsApi.Sdk.Apis.All.GradingPeriodsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteGradingPeriodById**](GradingPeriodsApi.md#deletegradingperiodbyid) | **DELETE** /ed-fi/gradingPeriods/{id} | Deletes an existing resource using the resource identifier.
[**GetGradingPeriods**](GradingPeriodsApi.md#getgradingperiods) | **GET** /ed-fi/gradingPeriods | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetGradingPeriodsById**](GradingPeriodsApi.md#getgradingperiodsbyid) | **GET** /ed-fi/gradingPeriods/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostGradingPeriod**](GradingPeriodsApi.md#postgradingperiod) | **POST** /ed-fi/gradingPeriods | Creates or updates resources based on the natural key values of the supplied resource.
[**PutGradingPeriod**](GradingPeriodsApi.md#putgradingperiod) | **PUT** /ed-fi/gradingPeriods/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletegradingperiodbyid"></a>
# **DeleteGradingPeriodById**
> void DeleteGradingPeriodById (string id, string ifMatch = null)

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
    public class DeleteGradingPeriodByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradingPeriodsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteGradingPeriodById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradingPeriodsApi.DeleteGradingPeriodById: " + e.Message );
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

<a name="getgradingperiods"></a>
# **GetGradingPeriods**
> List<EdFiGradingPeriod> GetGradingPeriods (int? offset = null, int? limit = null, bool? totalCount = null, string gradingPeriodDescriptor = null, int? periodSequence = null, int? schoolId = null, int? schoolYear = null, DateTime? beginDate = null, DateTime? endDate = null, string id = null, int? totalInstructionalDays = null)

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
    public class GetGradingPeriodsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradingPeriodsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var gradingPeriodDescriptor = gradingPeriodDescriptor_example;  // string | The name of the period for which grades are reported. (optional) 
            var periodSequence = 56;  // int? | The sequential order of this period relative to other periods. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the grading period school year. (optional) 
            var beginDate = 2013-10-20;  // DateTime? | Month, day, and year of the first day of the GradingPeriod. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Month, day, and year of the last day of the GradingPeriod. (optional) 
            var id = id_example;  // string |  (optional) 
            var totalInstructionalDays = 56;  // int? | Total days available for educational instruction during the GradingPeriod. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiGradingPeriod&gt; result = apiInstance.GetGradingPeriods(offset, limit, totalCount, gradingPeriodDescriptor, periodSequence, schoolId, schoolYear, beginDate, endDate, id, totalInstructionalDays);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradingPeriodsApi.GetGradingPeriods: " + e.Message );
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
 **gradingPeriodDescriptor** | **string**| The name of the period for which grades are reported. | [optional] 
 **periodSequence** | **int?**| The sequential order of this period relative to other periods. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **schoolYear** | **int?**| The identifier for the grading period school year. | [optional] 
 **beginDate** | **DateTime?**| Month, day, and year of the first day of the GradingPeriod. | [optional] 
 **endDate** | **DateTime?**| Month, day, and year of the last day of the GradingPeriod. | [optional] 
 **id** | **string**|  | [optional] 
 **totalInstructionalDays** | **int?**| Total days available for educational instruction during the GradingPeriod. | [optional] 

### Return type

[**List<EdFiGradingPeriod>**](EdFiGradingPeriod.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgradingperiodsbyid"></a>
# **GetGradingPeriodsById**
> EdFiGradingPeriod GetGradingPeriodsById (string id, string ifNoneMatch = null)

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
    public class GetGradingPeriodsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradingPeriodsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiGradingPeriod result = apiInstance.GetGradingPeriodsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradingPeriodsApi.GetGradingPeriodsById: " + e.Message );
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

[**EdFiGradingPeriod**](EdFiGradingPeriod.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgradingperiod"></a>
# **PostGradingPeriod**
> void PostGradingPeriod (EdFiGradingPeriod gradingPeriod)

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
    public class PostGradingPeriodExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradingPeriodsApi();
            var gradingPeriod = new EdFiGradingPeriod(); // EdFiGradingPeriod | The JSON representation of the \"gradingPeriod\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostGradingPeriod(gradingPeriod);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradingPeriodsApi.PostGradingPeriod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gradingPeriod** | [**EdFiGradingPeriod**](EdFiGradingPeriod.md)| The JSON representation of the \&quot;gradingPeriod\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgradingperiod"></a>
# **PutGradingPeriod**
> void PutGradingPeriod (string id, EdFiGradingPeriod gradingPeriod, string ifMatch = null)

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
    public class PutGradingPeriodExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradingPeriodsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var gradingPeriod = new EdFiGradingPeriod(); // EdFiGradingPeriod | The JSON representation of the \"gradingPeriod\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutGradingPeriod(id, gradingPeriod, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradingPeriodsApi.PutGradingPeriod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **gradingPeriod** | [**EdFiGradingPeriod**](EdFiGradingPeriod.md)| The JSON representation of the \&quot;gradingPeriod\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

