# EdFi.OdsApi.Sdk.Apis.All.InstitutionTelephoneNumberTypeDescriptorsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInstitutionTelephoneNumberTypeDescriptorById**](InstitutionTelephoneNumberTypeDescriptorsApi.md#deleteinstitutiontelephonenumbertypedescriptorbyid) | **DELETE** /ed-fi/institutionTelephoneNumberTypeDescriptors/{id} | Deletes an existing resource using the resource identifier.
[**GetInstitutionTelephoneNumberTypeDescriptors**](InstitutionTelephoneNumberTypeDescriptorsApi.md#getinstitutiontelephonenumbertypedescriptors) | **GET** /ed-fi/institutionTelephoneNumberTypeDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetInstitutionTelephoneNumberTypeDescriptorsById**](InstitutionTelephoneNumberTypeDescriptorsApi.md#getinstitutiontelephonenumbertypedescriptorsbyid) | **GET** /ed-fi/institutionTelephoneNumberTypeDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostInstitutionTelephoneNumberTypeDescriptor**](InstitutionTelephoneNumberTypeDescriptorsApi.md#postinstitutiontelephonenumbertypedescriptor) | **POST** /ed-fi/institutionTelephoneNumberTypeDescriptors | Creates or updates resources based on the natural key values of the supplied resource.
[**PutInstitutionTelephoneNumberTypeDescriptor**](InstitutionTelephoneNumberTypeDescriptorsApi.md#putinstitutiontelephonenumbertypedescriptor) | **PUT** /ed-fi/institutionTelephoneNumberTypeDescriptors/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteinstitutiontelephonenumbertypedescriptorbyid"></a>
# **DeleteInstitutionTelephoneNumberTypeDescriptorById**
> void DeleteInstitutionTelephoneNumberTypeDescriptorById (string id, string ifMatch = null)

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
    public class DeleteInstitutionTelephoneNumberTypeDescriptorByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstitutionTelephoneNumberTypeDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteInstitutionTelephoneNumberTypeDescriptorById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstitutionTelephoneNumberTypeDescriptorsApi.DeleteInstitutionTelephoneNumberTypeDescriptorById: " + e.Message );
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

<a name="getinstitutiontelephonenumbertypedescriptors"></a>
# **GetInstitutionTelephoneNumberTypeDescriptors**
> List<EdFiInstitutionTelephoneNumberTypeDescriptor> GetInstitutionTelephoneNumberTypeDescriptors (int? offset = null, int? limit = null, bool? totalCount = null, int? institutionTelephoneNumberTypeDescriptorId = null)

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
    public class GetInstitutionTelephoneNumberTypeDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstitutionTelephoneNumberTypeDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var institutionTelephoneNumberTypeDescriptorId = 56;  // int? | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiInstitutionTelephoneNumberTypeDescriptor&gt; result = apiInstance.GetInstitutionTelephoneNumberTypeDescriptors(offset, limit, totalCount, institutionTelephoneNumberTypeDescriptorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstitutionTelephoneNumberTypeDescriptorsApi.GetInstitutionTelephoneNumberTypeDescriptors: " + e.Message );
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
 **institutionTelephoneNumberTypeDescriptorId** | **int?**| A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 

### Return type

[**List<EdFiInstitutionTelephoneNumberTypeDescriptor>**](EdFiInstitutionTelephoneNumberTypeDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstitutiontelephonenumbertypedescriptorsbyid"></a>
# **GetInstitutionTelephoneNumberTypeDescriptorsById**
> EdFiInstitutionTelephoneNumberTypeDescriptor GetInstitutionTelephoneNumberTypeDescriptorsById (string id, string ifNoneMatch = null)

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
    public class GetInstitutionTelephoneNumberTypeDescriptorsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstitutionTelephoneNumberTypeDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiInstitutionTelephoneNumberTypeDescriptor result = apiInstance.GetInstitutionTelephoneNumberTypeDescriptorsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstitutionTelephoneNumberTypeDescriptorsApi.GetInstitutionTelephoneNumberTypeDescriptorsById: " + e.Message );
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

[**EdFiInstitutionTelephoneNumberTypeDescriptor**](EdFiInstitutionTelephoneNumberTypeDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinstitutiontelephonenumbertypedescriptor"></a>
# **PostInstitutionTelephoneNumberTypeDescriptor**
> void PostInstitutionTelephoneNumberTypeDescriptor (EdFiInstitutionTelephoneNumberTypeDescriptor institutionTelephoneNumberTypeDescriptor)

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
    public class PostInstitutionTelephoneNumberTypeDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstitutionTelephoneNumberTypeDescriptorsApi();
            var institutionTelephoneNumberTypeDescriptor = new EdFiInstitutionTelephoneNumberTypeDescriptor(); // EdFiInstitutionTelephoneNumberTypeDescriptor | The JSON representation of the \"institutionTelephoneNumberTypeDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostInstitutionTelephoneNumberTypeDescriptor(institutionTelephoneNumberTypeDescriptor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstitutionTelephoneNumberTypeDescriptorsApi.PostInstitutionTelephoneNumberTypeDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **institutionTelephoneNumberTypeDescriptor** | [**EdFiInstitutionTelephoneNumberTypeDescriptor**](EdFiInstitutionTelephoneNumberTypeDescriptor.md)| The JSON representation of the \&quot;institutionTelephoneNumberTypeDescriptor\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putinstitutiontelephonenumbertypedescriptor"></a>
# **PutInstitutionTelephoneNumberTypeDescriptor**
> void PutInstitutionTelephoneNumberTypeDescriptor (string id, EdFiInstitutionTelephoneNumberTypeDescriptor institutionTelephoneNumberTypeDescriptor, string ifMatch = null)

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
    public class PutInstitutionTelephoneNumberTypeDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstitutionTelephoneNumberTypeDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var institutionTelephoneNumberTypeDescriptor = new EdFiInstitutionTelephoneNumberTypeDescriptor(); // EdFiInstitutionTelephoneNumberTypeDescriptor | The JSON representation of the \"institutionTelephoneNumberTypeDescriptor\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutInstitutionTelephoneNumberTypeDescriptor(id, institutionTelephoneNumberTypeDescriptor, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstitutionTelephoneNumberTypeDescriptorsApi.PutInstitutionTelephoneNumberTypeDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **institutionTelephoneNumberTypeDescriptor** | [**EdFiInstitutionTelephoneNumberTypeDescriptor**](EdFiInstitutionTelephoneNumberTypeDescriptor.md)| The JSON representation of the \&quot;institutionTelephoneNumberTypeDescriptor\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

