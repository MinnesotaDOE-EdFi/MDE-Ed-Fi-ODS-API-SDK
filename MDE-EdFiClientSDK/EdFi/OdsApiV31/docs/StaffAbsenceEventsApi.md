# EdFi.OdsApi.Sdk.Apis.All.StaffAbsenceEventsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStaffAbsenceEventById**](StaffAbsenceEventsApi.md#deletestaffabsenceeventbyid) | **DELETE** /ed-fi/staffAbsenceEvents/{id} | Deletes an existing resource using the resource identifier.
[**GetStaffAbsenceEvents**](StaffAbsenceEventsApi.md#getstaffabsenceevents) | **GET** /ed-fi/staffAbsenceEvents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStaffAbsenceEventsById**](StaffAbsenceEventsApi.md#getstaffabsenceeventsbyid) | **GET** /ed-fi/staffAbsenceEvents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStaffAbsenceEvent**](StaffAbsenceEventsApi.md#poststaffabsenceevent) | **POST** /ed-fi/staffAbsenceEvents | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStaffAbsenceEvent**](StaffAbsenceEventsApi.md#putstaffabsenceevent) | **PUT** /ed-fi/staffAbsenceEvents/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestaffabsenceeventbyid"></a>
# **DeleteStaffAbsenceEventById**
> void DeleteStaffAbsenceEventById (string id, string ifMatch = null)

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
    public class DeleteStaffAbsenceEventByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffAbsenceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStaffAbsenceEventById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffAbsenceEventsApi.DeleteStaffAbsenceEventById: " + e.Message );
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

<a name="getstaffabsenceevents"></a>
# **GetStaffAbsenceEvents**
> List<EdFiStaffAbsenceEvent> GetStaffAbsenceEvents (int? offset = null, int? limit = null, bool? totalCount = null, string absenceEventCategoryDescriptor = null, DateTime? eventDate = null, string staffUniqueId = null, string absenceEventReason = null, double? hoursAbsent = null, string id = null)

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
    public class GetStaffAbsenceEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffAbsenceEventsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var absenceEventCategoryDescriptor = absenceEventCategoryDescriptor_example;  // string | The code describing the type of absence. (optional) 
            var eventDate = 2013-10-20;  // DateTime? | Date for this leave event. (optional) 
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var absenceEventReason = absenceEventReason_example;  // string | Expanded reason for the staff absence. (optional) 
            var hoursAbsent = 1.2;  // double? | The hours the staff was absent, if not the entire working day. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStaffAbsenceEvent&gt; result = apiInstance.GetStaffAbsenceEvents(offset, limit, totalCount, absenceEventCategoryDescriptor, eventDate, staffUniqueId, absenceEventReason, hoursAbsent, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffAbsenceEventsApi.GetStaffAbsenceEvents: " + e.Message );
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
 **absenceEventCategoryDescriptor** | **string**| The code describing the type of absence. | [optional] 
 **eventDate** | **DateTime?**| Date for this leave event. | [optional] 
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **absenceEventReason** | **string**| Expanded reason for the staff absence. | [optional] 
 **hoursAbsent** | **double?**| The hours the staff was absent, if not the entire working day. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiStaffAbsenceEvent>**](EdFiStaffAbsenceEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffabsenceeventsbyid"></a>
# **GetStaffAbsenceEventsById**
> EdFiStaffAbsenceEvent GetStaffAbsenceEventsById (string id, string ifNoneMatch = null)

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
    public class GetStaffAbsenceEventsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffAbsenceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStaffAbsenceEvent result = apiInstance.GetStaffAbsenceEventsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffAbsenceEventsApi.GetStaffAbsenceEventsById: " + e.Message );
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

[**EdFiStaffAbsenceEvent**](EdFiStaffAbsenceEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststaffabsenceevent"></a>
# **PostStaffAbsenceEvent**
> void PostStaffAbsenceEvent (EdFiStaffAbsenceEvent staffAbsenceEvent)

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
    public class PostStaffAbsenceEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffAbsenceEventsApi();
            var staffAbsenceEvent = new EdFiStaffAbsenceEvent(); // EdFiStaffAbsenceEvent | The JSON representation of the \"staffAbsenceEvent\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStaffAbsenceEvent(staffAbsenceEvent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffAbsenceEventsApi.PostStaffAbsenceEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffAbsenceEvent** | [**EdFiStaffAbsenceEvent**](EdFiStaffAbsenceEvent.md)| The JSON representation of the \&quot;staffAbsenceEvent\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstaffabsenceevent"></a>
# **PutStaffAbsenceEvent**
> void PutStaffAbsenceEvent (string id, EdFiStaffAbsenceEvent staffAbsenceEvent, string ifMatch = null)

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
    public class PutStaffAbsenceEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffAbsenceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var staffAbsenceEvent = new EdFiStaffAbsenceEvent(); // EdFiStaffAbsenceEvent | The JSON representation of the \"staffAbsenceEvent\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStaffAbsenceEvent(id, staffAbsenceEvent, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffAbsenceEventsApi.PutStaffAbsenceEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **staffAbsenceEvent** | [**EdFiStaffAbsenceEvent**](EdFiStaffAbsenceEvent.md)| The JSON representation of the \&quot;staffAbsenceEvent\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

