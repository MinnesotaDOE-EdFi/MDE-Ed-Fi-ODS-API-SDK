# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile.CourseCourseAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb21_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletecourseCourseAssociationById**](CourseCourseAssociationsApi.md#deletecoursecourseassociationbyid) | **DELETE** /MN/courseCourseAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetCourseCourseAssociations**](CourseCourseAssociationsApi.md#getcoursecourseassociations) | **GET** /MN/courseCourseAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetCourseCourseAssociationsById**](CourseCourseAssociationsApi.md#getcoursecourseassociationsbyid) | **GET** /MN/courseCourseAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostcourseCourseAssociation**](CourseCourseAssociationsApi.md#postcoursecourseassociation) | **POST** /MN/courseCourseAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutcourseCourseAssociation**](CourseCourseAssociationsApi.md#putcoursecourseassociation) | **PUT** /MN/courseCourseAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletecoursecourseassociationbyid"></a>
# **DeletecourseCourseAssociationById**
> void DeletecourseCourseAssociationById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class DeletecourseCourseAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseCourseAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletecourseCourseAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseCourseAssociationsApi.DeletecourseCourseAssociationById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.coursecourseassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoursecourseassociations"></a>
# **GetCourseCourseAssociations**
> List<MnCourseCourseAssociationReadable> GetCourseCourseAssociations (int? offset = null, int? limit = null, bool? totalCount = null, string courseCode = null, int? educationOrganizationId = null, string toCourseCode = null, int? toCourseEducationOrganizationId = null, string id = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class GetCourseCourseAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseCourseAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var courseCode = courseCode_example;  // string | A unique alphanumeric code assigned to a course. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var toCourseCode = toCourseCode_example;  // string | A unique alphanumeric code assigned to a course. (optional) 
            var toCourseEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnCourseCourseAssociationReadable&gt; result = apiInstance.GetCourseCourseAssociations(offset, limit, totalCount, courseCode, educationOrganizationId, toCourseCode, toCourseEducationOrganizationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseCourseAssociationsApi.GetCourseCourseAssociations: " + e.Message );
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
 **courseCode** | **string**| A unique alphanumeric code assigned to a course. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **toCourseCode** | **string**| A unique alphanumeric code assigned to a course. | [optional] 
 **toCourseEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<MnCourseCourseAssociationReadable>**](MnCourseCourseAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.coursecourseassociation.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoursecourseassociationsbyid"></a>
# **GetCourseCourseAssociationsById**
> MnCourseCourseAssociationReadable GetCourseCourseAssociationsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class GetCourseCourseAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseCourseAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnCourseCourseAssociationReadable result = apiInstance.GetCourseCourseAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseCourseAssociationsApi.GetCourseCourseAssociationsById: " + e.Message );
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

[**MnCourseCourseAssociationReadable**](MnCourseCourseAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.coursecourseassociation.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcoursecourseassociation"></a>
# **PostcourseCourseAssociation**
> void PostcourseCourseAssociation (MnCourseCourseAssociationWritable courseCourseAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class PostcourseCourseAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseCourseAssociationsApi();
            var courseCourseAssociation = new MnCourseCourseAssociationWritable(); // MnCourseCourseAssociationWritable | The JSON representation of the \"courseCourseAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostcourseCourseAssociation(courseCourseAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseCourseAssociationsApi.PostcourseCourseAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseCourseAssociation** | [**MnCourseCourseAssociationWritable**](MnCourseCourseAssociationWritable.md)| The JSON representation of the \&quot;courseCourseAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.coursecourseassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcoursecourseassociation"></a>
# **PutcourseCourseAssociation**
> void PutcourseCourseAssociation (string id, MnCourseCourseAssociationWritable courseCourseAssociation, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class PutcourseCourseAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseCourseAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var courseCourseAssociation = new MnCourseCourseAssociationWritable(); // MnCourseCourseAssociationWritable | The JSON representation of the \"courseCourseAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutcourseCourseAssociation(id, courseCourseAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseCourseAssociationsApi.PutcourseCourseAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **courseCourseAssociation** | [**MnCourseCourseAssociationWritable**](MnCourseCourseAssociationWritable.md)| The JSON representation of the \&quot;courseCourseAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.coursecourseassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
