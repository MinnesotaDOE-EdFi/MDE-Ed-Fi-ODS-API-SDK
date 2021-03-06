# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile.ExamReimbursementRequestsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb20_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteexamReimbursementRequestById**](ExamReimbursementRequestsApi.md#deleteexamreimbursementrequestbyid) | **DELETE** /MN/examReimbursementRequests/{id} | Deletes an existing resource using the resource identifier.
[**GetExamReimbursementRequests**](ExamReimbursementRequestsApi.md#getexamreimbursementrequests) | **GET** /MN/examReimbursementRequests | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetExamReimbursementRequestsById**](ExamReimbursementRequestsApi.md#getexamreimbursementrequestsbyid) | **GET** /MN/examReimbursementRequests/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostexamReimbursementRequest**](ExamReimbursementRequestsApi.md#postexamreimbursementrequest) | **POST** /MN/examReimbursementRequests | Creates or updates resources based on the natural key values of the supplied resource.
[**PutexamReimbursementRequest**](ExamReimbursementRequestsApi.md#putexamreimbursementrequest) | **PUT** /MN/examReimbursementRequests/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteexamreimbursementrequestbyid"></a>
# **DeleteexamReimbursementRequestById**
> void DeleteexamReimbursementRequestById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class DeleteexamReimbursementRequestByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExamReimbursementRequestsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteexamReimbursementRequestById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExamReimbursementRequestsApi.DeleteexamReimbursementRequestById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.examreimbursementrequest.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexamreimbursementrequests"></a>
# **GetExamReimbursementRequests**
> List<MnExamReimbursementRequestReadable> GetExamReimbursementRequests (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? testedDate = null, int? educationOrganizationId = null, string studentUniqueId = null, string assessmentCategoryDescriptor = null, string id = null, bool? reimbursementRequested = null, bool? unableToPay = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class GetExamReimbursementRequestsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExamReimbursementRequestsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var testedDate = 2013-10-20;  // DateTime? | Date student took the test. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var assessmentCategoryDescriptor = assessmentCategoryDescriptor_example;  // string | Test that requires reimbursement. E.g., ACT, ACT plus Writing, SAT, SAT with Essay. (optional) 
            var id = id_example;  // string |  (optional) 
            var reimbursementRequested = true;  // bool? | Reimbursement was requested. (optional) 
            var unableToPay = true;  // bool? | Reimbursement for a student determined by the district as 'unable to pay'. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnExamReimbursementRequestReadable&gt; result = apiInstance.GetExamReimbursementRequests(offset, limit, totalCount, testedDate, educationOrganizationId, studentUniqueId, assessmentCategoryDescriptor, id, reimbursementRequested, unableToPay);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExamReimbursementRequestsApi.GetExamReimbursementRequests: " + e.Message );
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
 **testedDate** | **DateTime?**| Date student took the test. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **assessmentCategoryDescriptor** | **string**| Test that requires reimbursement. E.g., ACT, ACT plus Writing, SAT, SAT with Essay. | [optional] 
 **id** | **string**|  | [optional] 
 **reimbursementRequested** | **bool?**| Reimbursement was requested. | [optional] 
 **unableToPay** | **bool?**| Reimbursement for a student determined by the district as &#39;unable to pay&#39;. | [optional] 

### Return type

[**List<MnExamReimbursementRequestReadable>**](MnExamReimbursementRequestReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.examreimbursementrequest.minnesota-twentytwentytwopreview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexamreimbursementrequestsbyid"></a>
# **GetExamReimbursementRequestsById**
> MnExamReimbursementRequestReadable GetExamReimbursementRequestsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class GetExamReimbursementRequestsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExamReimbursementRequestsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnExamReimbursementRequestReadable result = apiInstance.GetExamReimbursementRequestsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExamReimbursementRequestsApi.GetExamReimbursementRequestsById: " + e.Message );
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

[**MnExamReimbursementRequestReadable**](MnExamReimbursementRequestReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.examreimbursementrequest.minnesota-twentytwentytwopreview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexamreimbursementrequest"></a>
# **PostexamReimbursementRequest**
> void PostexamReimbursementRequest (MnExamReimbursementRequestWritable examReimbursementRequest)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class PostexamReimbursementRequestExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExamReimbursementRequestsApi();
            var examReimbursementRequest = new MnExamReimbursementRequestWritable(); // MnExamReimbursementRequestWritable | The JSON representation of the \"examReimbursementRequest\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostexamReimbursementRequest(examReimbursementRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExamReimbursementRequestsApi.PostexamReimbursementRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **examReimbursementRequest** | [**MnExamReimbursementRequestWritable**](MnExamReimbursementRequestWritable.md)| The JSON representation of the \&quot;examReimbursementRequest\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.examreimbursementrequest.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putexamreimbursementrequest"></a>
# **PutexamReimbursementRequest**
> void PutexamReimbursementRequest (string id, MnExamReimbursementRequestWritable examReimbursementRequest, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class PutexamReimbursementRequestExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExamReimbursementRequestsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var examReimbursementRequest = new MnExamReimbursementRequestWritable(); // MnExamReimbursementRequestWritable | The JSON representation of the \"examReimbursementRequest\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutexamReimbursementRequest(id, examReimbursementRequest, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExamReimbursementRequestsApi.PutexamReimbursementRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **examReimbursementRequest** | [**MnExamReimbursementRequestWritable**](MnExamReimbursementRequestWritable.md)| The JSON representation of the \&quot;examReimbursementRequest\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.examreimbursementrequest.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

