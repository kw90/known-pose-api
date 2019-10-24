# KnownPose.Api.DevelopersApi

All URIs are relative to *https://virtserver.swaggerhub.com/kw90/known-pose-api/1.1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPose**](DevelopersApi.md#addpose) | **POST** /poses | adds a pose item
[**PosesIdDelete**](DevelopersApi.md#posesiddelete) | **DELETE** /poses/{id} | deletes a pose item
[**SearchPose**](DevelopersApi.md#searchpose) | **GET** /poses | searches pose



## AddPose

> void AddPose (BasicPose basicPose = null)

adds a pose item

Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using KnownPose.Api;
using KnownPose.Client;
using KnownPose.Model;

namespace Example
{
    public class AddPoseExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://virtserver.swaggerhub.com/kw90/known-pose-api/1.1.0";
            var apiInstance = new DevelopersApi(Configuration.Default);
            var basicPose = new BasicPose(); // BasicPose | Optional pose item to add (optional) 

            try
            {
                // adds a pose item
                apiInstance.AddPose(basicPose);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DevelopersApi.AddPose: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **basicPose** | [**BasicPose**](BasicPose.md)| Optional pose item to add | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | pose created |  -  |
| **400** | invalid input, object invalid |  -  |
| **409** | an existing pose already exists |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PosesIdDelete

> InlineResponse200 PosesIdDelete (string id)

deletes a pose item

Deletes an accurate or inaccurate pose from the system using the `uuid`. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using KnownPose.Api;
using KnownPose.Client;
using KnownPose.Model;

namespace Example
{
    public class PosesIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://virtserver.swaggerhub.com/kw90/known-pose-api/1.1.0";
            var apiInstance = new DevelopersApi(Configuration.Default);
            var id = id_example;  // string | uuid

            try
            {
                // deletes a pose item
                InlineResponse200 result = apiInstance.PosesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DevelopersApi.PosesIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| uuid | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delete was successful. |  * Request-Id - Request uuid <br>  |
| **400** | Bad Request. The data from the client is invalid. |  -  |
| **401** | Unauthorized. |  -  |
| **403** | Forbidden. Improper permissions for this operation. |  -  |
| **404** | Could not find the object. |  -  |
| **500** | Internal Server Error. For some unknown reason the server failed. |  -  |
| **503** | Service Unavailable. Please try again later. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchPose

> List&lt;OneOfAccuratePoseInaccuratePose&gt; SearchPose (string searchString = null, int skip = null, int limit = null)

searches pose

By passing in the appropriate options, you can search for defined semantic poses in the environment 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using KnownPose.Api;
using KnownPose.Client;
using KnownPose.Model;

namespace Example
{
    public class SearchPoseExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://virtserver.swaggerhub.com/kw90/known-pose-api/1.1.0";
            var apiInstance = new DevelopersApi(Configuration.Default);
            var searchString = searchString_example;  // string | pass an optional search string for looking up a pose (optional) 
            var skip = 56;  // int | number of records to skip for pagination (optional) 
            var limit = 56;  // int | maximum number of records to return (optional) 

            try
            {
                // searches pose
                List<OneOfAccuratePoseInaccuratePose> result = apiInstance.SearchPose(searchString, skip, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DevelopersApi.SearchPose: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchString** | **string**| pass an optional search string for looking up a pose | [optional] 
 **skip** | **int**| number of records to skip for pagination | [optional] 
 **limit** | **int**| maximum number of records to return | [optional] 

### Return type

[**List&lt;OneOfAccuratePoseInaccuratePose&gt;**](OneOfAccuratePoseInaccuratePose.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | search results matching criteria |  -  |
| **400** | bad input parameter |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

