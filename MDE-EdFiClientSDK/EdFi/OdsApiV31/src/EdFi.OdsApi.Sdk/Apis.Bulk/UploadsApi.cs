/* 
 * Bulk API Endpoints
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface. The Ed-Fi ODS / API supports both transactional and bulk modes of operation.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using EdFi.OdsApi.Sdk.Client;

namespace EdFi.OdsApi.Sdk.Apis.Bulk
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUploadsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Allows for the upload of files parts of a larger upload file.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadid">uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API</param>
        /// <param name="offset">The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &amp;gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent.</param>
        /// <param name="size">The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes</param>
        /// <param name="uploadChunk">The chunk to be uploaded.</param>
        /// <returns>string</returns>
        string PostChunk (string uploadid, long? offset, long? size, System.IO.Stream uploadChunk);

        /// <summary>
        /// Allows for the upload of files parts of a larger upload file.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadid">uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API</param>
        /// <param name="offset">The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &amp;gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent.</param>
        /// <param name="size">The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes</param>
        /// <param name="uploadChunk">The chunk to be uploaded.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostChunkWithHttpInfo (string uploadid, long? offset, long? size, System.IO.Stream uploadChunk);
        /// <summary>
        /// Creates a Command to commit the uploaded chunks and validate the file appears composable.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadId">The id of the upload to commit to the bulk operation.</param>
        /// <returns>string</returns>
        string PostCommit (string uploadId);

        /// <summary>
        /// Creates a Command to commit the uploaded chunks and validate the file appears composable.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadId">The id of the upload to commit to the bulk operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostCommitWithHttpInfo (string uploadId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Allows for the upload of files parts of a larger upload file.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadid">uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API</param>
        /// <param name="offset">The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &amp;gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent.</param>
        /// <param name="size">The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes</param>
        /// <param name="uploadChunk">The chunk to be uploaded.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostChunkAsync (string uploadid, long? offset, long? size, System.IO.Stream uploadChunk);

        /// <summary>
        /// Allows for the upload of files parts of a larger upload file.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadid">uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API</param>
        /// <param name="offset">The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &amp;gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent.</param>
        /// <param name="size">The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes</param>
        /// <param name="uploadChunk">The chunk to be uploaded.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostChunkAsyncWithHttpInfo (string uploadid, long? offset, long? size, System.IO.Stream uploadChunk);
        /// <summary>
        /// Creates a Command to commit the uploaded chunks and validate the file appears composable.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadId">The id of the upload to commit to the bulk operation.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostCommitAsync (string uploadId);

        /// <summary>
        /// Creates a Command to commit the uploaded chunks and validate the file appears composable.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadId">The id of the upload to commit to the bulk operation.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostCommitAsyncWithHttpInfo (string uploadId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UploadsApi : IUploadsApi
    {
        private EdFi.OdsApi.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UploadsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = EdFi.OdsApi.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UploadsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = EdFi.OdsApi.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public EdFi.OdsApi.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Allows for the upload of files parts of a larger upload file. 
        /// </summary>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadid">uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API</param>
        /// <param name="offset">The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &amp;gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent.</param>
        /// <param name="size">The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes</param>
        /// <param name="uploadChunk">The chunk to be uploaded.</param>
        /// <returns>string</returns>
        public string PostChunk (string uploadid, long? offset, long? size, System.IO.Stream uploadChunk)
        {
             ApiResponse<string> localVarResponse = PostChunkWithHttpInfo(uploadid, offset, size, uploadChunk);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allows for the upload of files parts of a larger upload file. 
        /// </summary>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadid">uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API</param>
        /// <param name="offset">The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &amp;gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent.</param>
        /// <param name="size">The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes</param>
        /// <param name="uploadChunk">The chunk to be uploaded.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostChunkWithHttpInfo (string uploadid, long? offset, long? size, System.IO.Stream uploadChunk)
        {
            // verify the required parameter 'uploadid' is set
            if (uploadid == null)
                throw new ApiException(400, "Missing required parameter 'uploadid' when calling UploadsApi->PostChunk");
            // verify the required parameter 'offset' is set
            if (offset == null)
                throw new ApiException(400, "Missing required parameter 'offset' when calling UploadsApi->PostChunk");
            // verify the required parameter 'size' is set
            if (size == null)
                throw new ApiException(400, "Missing required parameter 'size' when calling UploadsApi->PostChunk");
            // verify the required parameter 'uploadChunk' is set
            if (uploadChunk == null)
                throw new ApiException(400, "Missing required parameter 'uploadChunk' when calling UploadsApi->PostChunk");

            var localVarPath = "/uploads/{uploadid}/chunk";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain; charset=utf-8", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uploadid != null) localVarPathParams.Add("uploadid", Configuration.ApiClient.ParameterToString(uploadid)); // path parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (size != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (uploadChunk != null) localVarFileParams.Add("uploadChunk", Configuration.ApiClient.ParameterToFile("uploadChunk", uploadChunk));

            // authentication (oauth2_client_credentials) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostChunk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Allows for the upload of files parts of a larger upload file. 
        /// </summary>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadid">uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API</param>
        /// <param name="offset">The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &amp;gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent.</param>
        /// <param name="size">The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes</param>
        /// <param name="uploadChunk">The chunk to be uploaded.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostChunkAsync (string uploadid, long? offset, long? size, System.IO.Stream uploadChunk)
        {
             ApiResponse<string> localVarResponse = await PostChunkAsyncWithHttpInfo(uploadid, offset, size, uploadChunk);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allows for the upload of files parts of a larger upload file. 
        /// </summary>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadid">uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API</param>
        /// <param name="offset">The byte offset of this chunk, relative to the beginning of the full file. This value will be used along with the total expected file size and the bytes value to validate the action. If the offset + bytes &amp;gt; expected bytes or if the bytes received do not match the bytes expected (for the chunk) a 400 Bad Request response will be sent.</param>
        /// <param name="size">The total bytes for this chunk. This value cannot exceed 157286400. If compression is used this should be compressed bytes and not uncompressed bytes</param>
        /// <param name="uploadChunk">The chunk to be uploaded.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostChunkAsyncWithHttpInfo (string uploadid, long? offset, long? size, System.IO.Stream uploadChunk)
        {
            // verify the required parameter 'uploadid' is set
            if (uploadid == null)
                throw new ApiException(400, "Missing required parameter 'uploadid' when calling UploadsApi->PostChunk");
            // verify the required parameter 'offset' is set
            if (offset == null)
                throw new ApiException(400, "Missing required parameter 'offset' when calling UploadsApi->PostChunk");
            // verify the required parameter 'size' is set
            if (size == null)
                throw new ApiException(400, "Missing required parameter 'size' when calling UploadsApi->PostChunk");
            // verify the required parameter 'uploadChunk' is set
            if (uploadChunk == null)
                throw new ApiException(400, "Missing required parameter 'uploadChunk' when calling UploadsApi->PostChunk");

            var localVarPath = "/uploads/{uploadid}/chunk";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/plain; charset=utf-8", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uploadid != null) localVarPathParams.Add("uploadid", Configuration.ApiClient.ParameterToString(uploadid)); // path parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (size != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "size", size)); // query parameter
            if (uploadChunk != null) localVarFileParams.Add("uploadChunk", Configuration.ApiClient.ParameterToFile("uploadChunk", uploadChunk));

            // authentication (oauth2_client_credentials) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostChunk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Creates a Command to commit the uploaded chunks and validate the file appears composable. 
        /// </summary>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadId">The id of the upload to commit to the bulk operation.</param>
        /// <returns>string</returns>
        public string PostCommit (string uploadId)
        {
             ApiResponse<string> localVarResponse = PostCommitWithHttpInfo(uploadId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a Command to commit the uploaded chunks and validate the file appears composable. 
        /// </summary>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadId">The id of the upload to commit to the bulk operation.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostCommitWithHttpInfo (string uploadId)
        {
            // verify the required parameter 'uploadId' is set
            if (uploadId == null)
                throw new ApiException(400, "Missing required parameter 'uploadId' when calling UploadsApi->PostCommit");

            var localVarPath = "/uploads/{uploadId}/commit";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uploadId != null) localVarPathParams.Add("uploadId", Configuration.ApiClient.ParameterToString(uploadId)); // path parameter

            // authentication (oauth2_client_credentials) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostCommit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Creates a Command to commit the uploaded chunks and validate the file appears composable. 
        /// </summary>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadId">The id of the upload to commit to the bulk operation.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostCommitAsync (string uploadId)
        {
             ApiResponse<string> localVarResponse = await PostCommitAsyncWithHttpInfo(uploadId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a Command to commit the uploaded chunks and validate the file appears composable. 
        /// </summary>
        /// <exception cref="EdFi.OdsApi.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uploadId">The id of the upload to commit to the bulk operation.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostCommitAsyncWithHttpInfo (string uploadId)
        {
            // verify the required parameter 'uploadId' is set
            if (uploadId == null)
                throw new ApiException(400, "Missing required parameter 'uploadId' when calling UploadsApi->PostCommit");

            var localVarPath = "/uploads/{uploadId}/commit";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uploadId != null) localVarPathParams.Add("uploadId", Configuration.ApiClient.ParameterToString(uploadId)); // path parameter

            // authentication (oauth2_client_credentials) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostCommit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
