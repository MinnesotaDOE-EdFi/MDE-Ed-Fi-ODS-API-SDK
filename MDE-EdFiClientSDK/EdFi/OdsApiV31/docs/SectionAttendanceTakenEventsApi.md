# EdFi.OdsApi.Sdk.Apis.All.SectionAttendanceTakenEventsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSectionAttendanceTakenEventById**](SectionAttendanceTakenEventsApi.md#deletesectionattendancetakeneventbyid) | **DELETE** /ed-fi/sectionAttendanceTakenEvents/{id} | Deletes an existing resource using the resource identifier.
[**GetSectionAttendanceTakenEvents**](SectionAttendanceTakenEventsApi.md#getsectionattendancetakenevents) | **GET** /ed-fi/sectionAttendanceTakenEvents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetSectionAttendanceTakenEventsById**](SectionAttendanceTakenEventsApi.md#getsectionattendancetakeneventsbyid) | **GET** /ed-fi/sectionAttendanceTakenEvents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostSectionAttendanceTakenEvent**](SectionAttendanceTakenEventsApi.md#postsectionattendancetakenevent) | **POST** /ed-fi/sectionAttendanceTakenEvents | Creates or updates resources based on the natural key values of the supplied resource.
[**PutSectionAttendanceTakenEvent**](SectionAttendanceTakenEventsApi.md#putsectionattendancetakenevent) | **PUT** /ed-fi/sectionAttendanceTakenEvents/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletesectionattendancetakeneventbyid"></a>
# **DeleteSectionAttendanceTakenEventById**
> void DeleteSectionAttendanceTakenEventById (string id, string ifMatch = null)

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
    public class DeleteSectionAttendanceTakenEventByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionAttendanceTakenEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteSectionAttendanceTakenEventById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionAttendanceTakenEventsApi.DeleteSectionAttendanceTakenEventById: " + e.Message );
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

<a name="getsectionattendancetakenevents"></a>
# **GetSectionAttendanceTakenEvents**
> List<EdFiSectionAttendanceTakenEvent> GetSectionAttendanceTakenEvents (int? offset = null, int? limit = null, bool? totalCount = null, string calendarCode = null, DateTime? date = null, int? schoolId = null, int? schoolYear = null, string localCourseCode = null, string sectionIdentifier = null, string sessionName = null, string staffUniqueId = null, DateTime? eventDate = null, string id = null)

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
    public class GetSectionAttendanceTakenEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionAttendanceTakenEventsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var calendarCode = calendarCode_example;  // string | The identifier for the Calendar. (optional) 
            var date = 2013-10-20;  // DateTime? | The month, day, and year of the CalendarEvent. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year. (optional) 
            var localCourseCode = localCourseCode_example;  // string | The local code assigned by the School that identifies the course offering provided for the instruction of students. (optional) 
            var sectionIdentifier = sectionIdentifier_example;  // string | The local identifier assigned to a section. (optional) 
            var sessionName = sessionName_example;  // string | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (optional) 
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var eventDate = 2013-10-20;  // DateTime? | The date the SectionAttendanceTakenEvent was submitted, which could be a different date than the instructional day. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiSectionAttendanceTakenEvent&gt; result = apiInstance.GetSectionAttendanceTakenEvents(offset, limit, totalCount, calendarCode, date, schoolId, schoolYear, localCourseCode, sectionIdentifier, sessionName, staffUniqueId, eventDate, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionAttendanceTakenEventsApi.GetSectionAttendanceTakenEvents: " + e.Message );
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
 **calendarCode** | **string**| The identifier for the Calendar. | [optional] 
 **date** | **DateTime?**| The month, day, and year of the CalendarEvent. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **schoolYear** | **int?**| The identifier for the school year. | [optional] 
 **localCourseCode** | **string**| The local code assigned by the School that identifies the course offering provided for the instruction of students. | [optional] 
 **sectionIdentifier** | **string**| The local identifier assigned to a section. | [optional] 
 **sessionName** | **string**| The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). | [optional] 
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **eventDate** | **DateTime?**| The date the SectionAttendanceTakenEvent was submitted, which could be a different date than the instructional day. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiSectionAttendanceTakenEvent>**](EdFiSectionAttendanceTakenEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsectionattendancetakeneventsbyid"></a>
# **GetSectionAttendanceTakenEventsById**
> EdFiSectionAttendanceTakenEvent GetSectionAttendanceTakenEventsById (string id, string ifNoneMatch = null)

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
    public class GetSectionAttendanceTakenEventsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionAttendanceTakenEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiSectionAttendanceTakenEvent result = apiInstance.GetSectionAttendanceTakenEventsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionAttendanceTakenEventsApi.GetSectionAttendanceTakenEventsById: " + e.Message );
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

[**EdFiSectionAttendanceTakenEvent**](EdFiSectionAttendanceTakenEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsectionattendancetakenevent"></a>
# **PostSectionAttendanceTakenEvent**
> void PostSectionAttendanceTakenEvent (EdFiSectionAttendanceTakenEvent sectionAttendanceTakenEvent)

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
    public class PostSectionAttendanceTakenEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionAttendanceTakenEventsApi();
            var sectionAttendanceTakenEvent = new EdFiSectionAttendanceTakenEvent(); // EdFiSectionAttendanceTakenEvent | The JSON representation of the \"sectionAttendanceTakenEvent\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostSectionAttendanceTakenEvent(sectionAttendanceTakenEvent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionAttendanceTakenEventsApi.PostSectionAttendanceTakenEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sectionAttendanceTakenEvent** | [**EdFiSectionAttendanceTakenEvent**](EdFiSectionAttendanceTakenEvent.md)| The JSON representation of the \&quot;sectionAttendanceTakenEvent\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsectionattendancetakenevent"></a>
# **PutSectionAttendanceTakenEvent**
> void PutSectionAttendanceTakenEvent (string id, EdFiSectionAttendanceTakenEvent sectionAttendanceTakenEvent, string ifMatch = null)

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
    public class PutSectionAttendanceTakenEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionAttendanceTakenEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var sectionAttendanceTakenEvent = new EdFiSectionAttendanceTakenEvent(); // EdFiSectionAttendanceTakenEvent | The JSON representation of the \"sectionAttendanceTakenEvent\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutSectionAttendanceTakenEvent(id, sectionAttendanceTakenEvent, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionAttendanceTakenEventsApi.PutSectionAttendanceTakenEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **sectionAttendanceTakenEvent** | [**EdFiSectionAttendanceTakenEvent**](EdFiSectionAttendanceTakenEvent.md)| The JSON representation of the \&quot;sectionAttendanceTakenEvent\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

