# EdFi.OdsApi.Sdk.Apis.All.StaffsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStaffById**](StaffsApi.md#deletestaffbyid) | **DELETE** /ed-fi/staffs/{id} | Deletes an existing resource using the resource identifier.
[**GetStaffs**](StaffsApi.md#getstaffs) | **GET** /ed-fi/staffs | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStaffsById**](StaffsApi.md#getstaffsbyid) | **GET** /ed-fi/staffs/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStaff**](StaffsApi.md#poststaff) | **POST** /ed-fi/staffs | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStaff**](StaffsApi.md#putstaff) | **PUT** /ed-fi/staffs/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestaffbyid"></a>
# **DeleteStaffById**
> void DeleteStaffById (string id, string ifMatch = null)

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
    public class DeleteStaffByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStaffById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffsApi.DeleteStaffById: " + e.Message );
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

<a name="getstaffs"></a>
# **GetStaffs**
> List<EdFiStaff> GetStaffs (int? offset = null, int? limit = null, bool? totalCount = null, string staffUniqueId = null, string citizenshipStatusDescriptor = null, string highestCompletedLevelOfEducationDescriptor = null, string oldEthnicityDescriptor = null, string sexDescriptor = null, DateTime? birthDate = null, string firstName = null, string generationCodeSuffix = null, bool? highlyQualifiedTeacher = null, bool? hispanicLatinoEthnicity = null, string id = null, string lastSurname = null, string loginId = null, string maidenName = null, string middleName = null, string personalTitlePrefix = null, double? yearsOfPriorProfessionalExperience = null, double? yearsOfPriorTeachingExperience = null)

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
    public class GetStaffsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var citizenshipStatusDescriptor = citizenshipStatusDescriptor_example;  // string | An indicator of whether or not the person is a U.S. citizen. (optional) 
            var highestCompletedLevelOfEducationDescriptor = highestCompletedLevelOfEducationDescriptor_example;  // string | The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received). (optional) 
            var oldEthnicityDescriptor = oldEthnicityDescriptor_example;  // string | Previous definition of Ethnicity combining Hispanic/Latino and race:          1 - American Indian or Alaskan Native          2 - Asian or Pacific Islander          3 - Black, not of Hispanic origin          4 - Hispanic          5 - White, not of Hispanic origin. (optional) 
            var sexDescriptor = sexDescriptor_example;  // string | A person's gender. (optional) 
            var birthDate = 2013-10-20;  // DateTime? | The month, day, and year on which an individual was born. (optional) 
            var firstName = firstName_example;  // string | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (optional) 
            var generationCodeSuffix = generationCodeSuffix_example;  // string | An appendage, if any, used to denote an individual's generation in his family (e.g., Jr., Sr., III). (optional) 
            var highlyQualifiedTeacher = true;  // bool? | An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for ALL Sections being taught. (optional) 
            var hispanicLatinoEthnicity = true;  // bool? | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \"Spanish origin,\" can be used in addition to \"Hispanic or Latino.\" (optional) 
            var id = id_example;  // string |  (optional) 
            var lastSurname = lastSurname_example;  // string | The name borne in common by members of a family. (optional) 
            var loginId = loginId_example;  // string | The login ID for the user; used for security access control interface. (optional) 
            var maidenName = maidenName_example;  // string | The person's maiden name. (optional) 
            var middleName = middleName_example;  // string | A secondary name given to an individual at birth, baptism, or during another naming ceremony. (optional) 
            var personalTitlePrefix = personalTitlePrefix_example;  // string | A prefix used to denote the title, degree, position, or seniority of the person. (optional) 
            var yearsOfPriorProfessionalExperience = 1.2;  // double? | The total number of years that an individual has previously held a similar professional position in one or more education institutions. (optional) 
            var yearsOfPriorTeachingExperience = 1.2;  // double? | The total number of years that an individual has previously held a teaching position in one or more education institutions. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStaff&gt; result = apiInstance.GetStaffs(offset, limit, totalCount, staffUniqueId, citizenshipStatusDescriptor, highestCompletedLevelOfEducationDescriptor, oldEthnicityDescriptor, sexDescriptor, birthDate, firstName, generationCodeSuffix, highlyQualifiedTeacher, hispanicLatinoEthnicity, id, lastSurname, loginId, maidenName, middleName, personalTitlePrefix, yearsOfPriorProfessionalExperience, yearsOfPriorTeachingExperience);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffsApi.GetStaffs: " + e.Message );
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
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **citizenshipStatusDescriptor** | **string**| An indicator of whether or not the person is a U.S. citizen. | [optional] 
 **highestCompletedLevelOfEducationDescriptor** | **string**| The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received). | [optional] 
 **oldEthnicityDescriptor** | **string**| Previous definition of Ethnicity combining Hispanic/Latino and race:          1 - American Indian or Alaskan Native          2 - Asian or Pacific Islander          3 - Black, not of Hispanic origin          4 - Hispanic          5 - White, not of Hispanic origin. | [optional] 
 **sexDescriptor** | **string**| A person&#39;s gender. | [optional] 
 **birthDate** | **DateTime?**| The month, day, and year on which an individual was born. | [optional] 
 **firstName** | **string**| A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. | [optional] 
 **generationCodeSuffix** | **string**| An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III). | [optional] 
 **highlyQualifiedTeacher** | **bool?**| An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for ALL Sections being taught. | [optional] 
 **hispanicLatinoEthnicity** | **bool?**| An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot; | [optional] 
 **id** | **string**|  | [optional] 
 **lastSurname** | **string**| The name borne in common by members of a family. | [optional] 
 **loginId** | **string**| The login ID for the user; used for security access control interface. | [optional] 
 **maidenName** | **string**| The person&#39;s maiden name. | [optional] 
 **middleName** | **string**| A secondary name given to an individual at birth, baptism, or during another naming ceremony. | [optional] 
 **personalTitlePrefix** | **string**| A prefix used to denote the title, degree, position, or seniority of the person. | [optional] 
 **yearsOfPriorProfessionalExperience** | **double?**| The total number of years that an individual has previously held a similar professional position in one or more education institutions. | [optional] 
 **yearsOfPriorTeachingExperience** | **double?**| The total number of years that an individual has previously held a teaching position in one or more education institutions. | [optional] 

### Return type

[**List<EdFiStaff>**](EdFiStaff.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffsbyid"></a>
# **GetStaffsById**
> EdFiStaff GetStaffsById (string id, string ifNoneMatch = null)

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
    public class GetStaffsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStaff result = apiInstance.GetStaffsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffsApi.GetStaffsById: " + e.Message );
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

[**EdFiStaff**](EdFiStaff.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststaff"></a>
# **PostStaff**
> void PostStaff (EdFiStaff staff)

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
    public class PostStaffExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi();
            var staff = new EdFiStaff(); // EdFiStaff | The JSON representation of the \"staff\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStaff(staff);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffsApi.PostStaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staff** | [**EdFiStaff**](EdFiStaff.md)| The JSON representation of the \&quot;staff\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstaff"></a>
# **PutStaff**
> void PutStaff (string id, EdFiStaff staff, string ifMatch = null)

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
    public class PutStaffExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var staff = new EdFiStaff(); // EdFiStaff | The JSON representation of the \"staff\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStaff(id, staff, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffsApi.PutStaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **staff** | [**EdFiStaff**](EdFiStaff.md)| The JSON representation of the \&quot;staff\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

