# EdFi.OdsApi.Sdk.Apis.All.LearningObjectivesApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLearningObjectiveById**](LearningObjectivesApi.md#deletelearningobjectivebyid) | **DELETE** /ed-fi/learningObjectives/{id} | Deletes an existing resource using the resource identifier.
[**GetLearningObjectives**](LearningObjectivesApi.md#getlearningobjectives) | **GET** /ed-fi/learningObjectives | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetLearningObjectivesById**](LearningObjectivesApi.md#getlearningobjectivesbyid) | **GET** /ed-fi/learningObjectives/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostLearningObjective**](LearningObjectivesApi.md#postlearningobjective) | **POST** /ed-fi/learningObjectives | Creates or updates resources based on the natural key values of the supplied resource.
[**PutLearningObjective**](LearningObjectivesApi.md#putlearningobjective) | **PUT** /ed-fi/learningObjectives/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletelearningobjectivebyid"></a>
# **DeleteLearningObjectiveById**
> void DeleteLearningObjectiveById (string id, string ifMatch = null)

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
    public class DeleteLearningObjectiveByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteLearningObjectiveById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningObjectivesApi.DeleteLearningObjectiveById: " + e.Message );
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

<a name="getlearningobjectives"></a>
# **GetLearningObjectives**
> List<EdFiLearningObjective> GetLearningObjectives (int? offset = null, int? limit = null, bool? totalCount = null, string learningObjectiveId = null, string _namespace = null, string parentLearningObjectiveId = null, string parentNamespace = null, string description = null, string id = null, string nomenclature = null, string objective = null, string successCriteria = null)

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
    public class GetLearningObjectivesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningObjectivesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var learningObjectiveId = learningObjectiveId_example;  // string | The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the LearningObjective. (optional) 
            var parentLearningObjectiveId = parentLearningObjectiveId_example;  // string | The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). (optional) 
            var parentNamespace = parentNamespace_example;  // string | Namespace for the LearningObjective. (optional) 
            var description = description_example;  // string | The description of the LearningObjective. (optional) 
            var id = id_example;  // string |  (optional) 
            var nomenclature = nomenclature_example;  // string | Reflects the specific nomenclature used for the LearningObjective. (optional) 
            var objective = objective_example;  // string | The designated title of the LearningObjective. (optional) 
            var successCriteria = successCriteria_example;  // string | One or more statements that describes the criteria used by teachers and students to check for attainment of a learning objective. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the LearningObjective. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiLearningObjective&gt; result = apiInstance.GetLearningObjectives(offset, limit, totalCount, learningObjectiveId, _namespace, parentLearningObjectiveId, parentNamespace, description, id, nomenclature, objective, successCriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningObjectivesApi.GetLearningObjectives: " + e.Message );
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
 **learningObjectiveId** | **string**| The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). | [optional] 
 **_namespace** | **string**| Namespace for the LearningObjective. | [optional] 
 **parentLearningObjectiveId** | **string**| The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). | [optional] 
 **parentNamespace** | **string**| Namespace for the LearningObjective. | [optional] 
 **description** | **string**| The description of the LearningObjective. | [optional] 
 **id** | **string**|  | [optional] 
 **nomenclature** | **string**| Reflects the specific nomenclature used for the LearningObjective. | [optional] 
 **objective** | **string**| The designated title of the LearningObjective. | [optional] 
 **successCriteria** | **string**| One or more statements that describes the criteria used by teachers and students to check for attainment of a learning objective. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the LearningObjective. | [optional] 

### Return type

[**List<EdFiLearningObjective>**](EdFiLearningObjective.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlearningobjectivesbyid"></a>
# **GetLearningObjectivesById**
> EdFiLearningObjective GetLearningObjectivesById (string id, string ifNoneMatch = null)

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
    public class GetLearningObjectivesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiLearningObjective result = apiInstance.GetLearningObjectivesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningObjectivesApi.GetLearningObjectivesById: " + e.Message );
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

[**EdFiLearningObjective**](EdFiLearningObjective.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlearningobjective"></a>
# **PostLearningObjective**
> void PostLearningObjective (EdFiLearningObjective learningObjective)

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
    public class PostLearningObjectiveExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningObjectivesApi();
            var learningObjective = new EdFiLearningObjective(); // EdFiLearningObjective | The JSON representation of the \"learningObjective\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostLearningObjective(learningObjective);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningObjectivesApi.PostLearningObjective: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **learningObjective** | [**EdFiLearningObjective**](EdFiLearningObjective.md)| The JSON representation of the \&quot;learningObjective\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlearningobjective"></a>
# **PutLearningObjective**
> void PutLearningObjective (string id, EdFiLearningObjective learningObjective, string ifMatch = null)

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
    public class PutLearningObjectiveExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var learningObjective = new EdFiLearningObjective(); // EdFiLearningObjective | The JSON representation of the \"learningObjective\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutLearningObjective(id, learningObjective, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningObjectivesApi.PutLearningObjective: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **learningObjective** | [**EdFiLearningObjective**](EdFiLearningObjective.md)| The JSON representation of the \&quot;learningObjective\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

