/* 
 * Known Pose API
 *
 * Define and retrieve (accurate) semantic poses in a 2D environment.
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: Kai.Waelti@dfki.de
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using KnownPose.Client;
using KnownPose.Model;

namespace KnownPose.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDevelopersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// adds a pose item
        /// </summary>
        /// <remarks>
        /// Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="basicPose">Optional pose item to add (optional)</param>
        /// <returns></returns>
        void AddPose (BasicPose basicPose = default(BasicPose));

        /// <summary>
        /// adds a pose item
        /// </summary>
        /// <remarks>
        /// Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="basicPose">Optional pose item to add (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddPoseWithHttpInfo (BasicPose basicPose = default(BasicPose));
        /// <summary>
        /// deletes a pose item
        /// </summary>
        /// <remarks>
        /// Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;. 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">uuid</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 PosesIdDelete (string id);

        /// <summary>
        /// deletes a pose item
        /// </summary>
        /// <remarks>
        /// Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;. 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">uuid</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> PosesIdDeleteWithHttpInfo (string id);
        /// <summary>
        /// searches pose
        /// </summary>
        /// <remarks>
        /// By passing in the appropriate options, you can search for defined semantic poses in the environment 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchString">pass an optional search string for looking up a pose (optional)</param>
        /// <param name="skip">number of records to skip for pagination (optional)</param>
        /// <param name="limit">maximum number of records to return (optional)</param>
        /// <returns>List&lt;OneOfAccuratePoseInaccuratePose&gt;</returns>
        List<OneOfAccuratePoseInaccuratePose> SearchPose (string searchString = default(string), int skip = default(int), int limit = default(int));

        /// <summary>
        /// searches pose
        /// </summary>
        /// <remarks>
        /// By passing in the appropriate options, you can search for defined semantic poses in the environment 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchString">pass an optional search string for looking up a pose (optional)</param>
        /// <param name="skip">number of records to skip for pagination (optional)</param>
        /// <param name="limit">maximum number of records to return (optional)</param>
        /// <returns>ApiResponse of List&lt;OneOfAccuratePoseInaccuratePose&gt;</returns>
        ApiResponse<List<OneOfAccuratePoseInaccuratePose>> SearchPoseWithHttpInfo (string searchString = default(string), int skip = default(int), int limit = default(int));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// adds a pose item
        /// </summary>
        /// <remarks>
        /// Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="basicPose">Optional pose item to add (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddPoseAsync (BasicPose basicPose = default(BasicPose));

        /// <summary>
        /// adds a pose item
        /// </summary>
        /// <remarks>
        /// Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="basicPose">Optional pose item to add (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddPoseAsyncWithHttpInfo (BasicPose basicPose = default(BasicPose));
        /// <summary>
        /// deletes a pose item
        /// </summary>
        /// <remarks>
        /// Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;. 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">uuid</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> PosesIdDeleteAsync (string id);

        /// <summary>
        /// deletes a pose item
        /// </summary>
        /// <remarks>
        /// Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;. 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">uuid</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> PosesIdDeleteAsyncWithHttpInfo (string id);
        /// <summary>
        /// searches pose
        /// </summary>
        /// <remarks>
        /// By passing in the appropriate options, you can search for defined semantic poses in the environment 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchString">pass an optional search string for looking up a pose (optional)</param>
        /// <param name="skip">number of records to skip for pagination (optional)</param>
        /// <param name="limit">maximum number of records to return (optional)</param>
        /// <returns>Task of List&lt;OneOfAccuratePoseInaccuratePose&gt;</returns>
        System.Threading.Tasks.Task<List<OneOfAccuratePoseInaccuratePose>> SearchPoseAsync (string searchString = default(string), int skip = default(int), int limit = default(int));

        /// <summary>
        /// searches pose
        /// </summary>
        /// <remarks>
        /// By passing in the appropriate options, you can search for defined semantic poses in the environment 
        /// </remarks>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchString">pass an optional search string for looking up a pose (optional)</param>
        /// <param name="skip">number of records to skip for pagination (optional)</param>
        /// <param name="limit">maximum number of records to return (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OneOfAccuratePoseInaccuratePose&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OneOfAccuratePoseInaccuratePose>>> SearchPoseAsyncWithHttpInfo (string searchString = default(string), int skip = default(int), int limit = default(int));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DevelopersApi : IDevelopersApi
    {
        private KnownPose.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DevelopersApi(String basePath)
        {
            this.Configuration = new KnownPose.Client.Configuration { BasePath = basePath };

            ExceptionFactory = KnownPose.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopersApi"/> class
        /// </summary>
        /// <returns></returns>
        public DevelopersApi()
        {
            this.Configuration = KnownPose.Client.Configuration.Default;

            ExceptionFactory = KnownPose.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DevelopersApi(KnownPose.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = KnownPose.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = KnownPose.Client.Configuration.DefaultExceptionFactory;
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
        public KnownPose.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public KnownPose.Client.ExceptionFactory ExceptionFactory
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
        /// adds a pose item Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="basicPose">Optional pose item to add (optional)</param>
        /// <returns></returns>
        public void AddPose (BasicPose basicPose = default(BasicPose))
        {
             AddPoseWithHttpInfo(basicPose);
        }

        /// <summary>
        /// adds a pose item Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="basicPose">Optional pose item to add (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddPoseWithHttpInfo (BasicPose basicPose = default(BasicPose))
        {

            var localVarPath = "/poses";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (basicPose != null && basicPose.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(basicPose); // http body (model) parameter
            }
            else
            {
                localVarPostBody = basicPose; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddPose", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// adds a pose item Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="basicPose">Optional pose item to add (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddPoseAsync (BasicPose basicPose = default(BasicPose))
        {
             await AddPoseAsyncWithHttpInfo(basicPose);

        }

        /// <summary>
        /// adds a pose item Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="basicPose">Optional pose item to add (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddPoseAsyncWithHttpInfo (BasicPose basicPose = default(BasicPose))
        {

            var localVarPath = "/poses";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (basicPose != null && basicPose.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(basicPose); // http body (model) parameter
            }
            else
            {
                localVarPostBody = basicPose; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddPose", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// deletes a pose item Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;. 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">uuid</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 PosesIdDelete (string id)
        {
             ApiResponse<InlineResponse200> localVarResponse = PosesIdDeleteWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// deletes a pose item Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;. 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">uuid</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse<InlineResponse200> PosesIdDeleteWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DevelopersApi->PosesIdDelete");

            var localVarPath = "/poses/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PosesIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
        }

        /// <summary>
        /// deletes a pose item Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;. 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">uuid</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> PosesIdDeleteAsync (string id)
        {
             ApiResponse<InlineResponse200> localVarResponse = await PosesIdDeleteAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// deletes a pose item Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;. 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">uuid</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> PosesIdDeleteAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DevelopersApi->PosesIdDelete");

            var localVarPath = "/poses/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PosesIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
        }

        /// <summary>
        /// searches pose By passing in the appropriate options, you can search for defined semantic poses in the environment 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchString">pass an optional search string for looking up a pose (optional)</param>
        /// <param name="skip">number of records to skip for pagination (optional)</param>
        /// <param name="limit">maximum number of records to return (optional)</param>
        /// <returns>List&lt;OneOfAccuratePoseInaccuratePose&gt;</returns>
        public List<OneOfAccuratePoseInaccuratePose> SearchPose (string searchString = default(string), int skip = default(int), int limit = default(int))
        {
             ApiResponse<List<OneOfAccuratePoseInaccuratePose>> localVarResponse = SearchPoseWithHttpInfo(searchString, skip, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// searches pose By passing in the appropriate options, you can search for defined semantic poses in the environment 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchString">pass an optional search string for looking up a pose (optional)</param>
        /// <param name="skip">number of records to skip for pagination (optional)</param>
        /// <param name="limit">maximum number of records to return (optional)</param>
        /// <returns>ApiResponse of List&lt;OneOfAccuratePoseInaccuratePose&gt;</returns>
        public ApiResponse<List<OneOfAccuratePoseInaccuratePose>> SearchPoseWithHttpInfo (string searchString = default(string), int skip = default(int), int limit = default(int))
        {

            var localVarPath = "/poses";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchString != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "searchString", searchString)); // query parameter
            if (skip != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "skip", skip)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchPose", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<OneOfAccuratePoseInaccuratePose>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<OneOfAccuratePoseInaccuratePose>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OneOfAccuratePoseInaccuratePose>)));
        }

        /// <summary>
        /// searches pose By passing in the appropriate options, you can search for defined semantic poses in the environment 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchString">pass an optional search string for looking up a pose (optional)</param>
        /// <param name="skip">number of records to skip for pagination (optional)</param>
        /// <param name="limit">maximum number of records to return (optional)</param>
        /// <returns>Task of List&lt;OneOfAccuratePoseInaccuratePose&gt;</returns>
        public async System.Threading.Tasks.Task<List<OneOfAccuratePoseInaccuratePose>> SearchPoseAsync (string searchString = default(string), int skip = default(int), int limit = default(int))
        {
             ApiResponse<List<OneOfAccuratePoseInaccuratePose>> localVarResponse = await SearchPoseAsyncWithHttpInfo(searchString, skip, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// searches pose By passing in the appropriate options, you can search for defined semantic poses in the environment 
        /// </summary>
        /// <exception cref="KnownPose.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchString">pass an optional search string for looking up a pose (optional)</param>
        /// <param name="skip">number of records to skip for pagination (optional)</param>
        /// <param name="limit">maximum number of records to return (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OneOfAccuratePoseInaccuratePose&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OneOfAccuratePoseInaccuratePose>>> SearchPoseAsyncWithHttpInfo (string searchString = default(string), int skip = default(int), int limit = default(int))
        {

            var localVarPath = "/poses";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchString != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "searchString", searchString)); // query parameter
            if (skip != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "skip", skip)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchPose", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<OneOfAccuratePoseInaccuratePose>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<OneOfAccuratePoseInaccuratePose>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OneOfAccuratePoseInaccuratePose>)));
        }

    }
}