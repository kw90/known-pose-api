# IO.Swagger.Api.DevelopersApi

All URIs are relative to *https://virtserver.swaggerhub.com/kw90/known-pose-api/1.1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPose**](DevelopersApi.md#addpose) | **POST** /poses | adds a pose item
[**PosesIdDelete**](DevelopersApi.md#posesiddelete) | **DELETE** /poses/{id} | deletes a pose item
[**SearchAccuratePose**](DevelopersApi.md#searchaccuratepose) | **GET** /poses/accurate | searches accurate pose
[**SearchPose**](DevelopersApi.md#searchpose) | **GET** /poses | searches pose

<a name="addpose"></a>
# **AddPose**
> void AddPose (BasicPose body = null)

adds a pose item

Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddPoseExample
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var body = new BasicPose(); // BasicPose | Optional pose item to add (optional) 

            try
            {
                // adds a pose item
                apiInstance.AddPose(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.AddPose: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BasicPose**](BasicPose.md)| Optional pose item to add | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="posesiddelete"></a>
# **PosesIdDelete**
> InlineResponse200 PosesIdDelete (string id)

deletes a pose item

Deletes an accurate or inaccurate pose from the system using the `uuid`. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PosesIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var id = id_example;  // string | uuid

            try
            {
                // deletes a pose item
                InlineResponse200 result = apiInstance.PosesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.PosesIdDelete: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchaccuratepose"></a>
# **SearchAccuratePose**
> AccuratePose SearchAccuratePose (string id = null, string searchString = null, int? skip = null, int? limit = null)

searches accurate pose

By passing in the appropriate options, you can search for defined accurate semantic poses in the environment 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchAccuratePoseExample
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var id = id_example;  // string | optional uuid of a single accurate pose to be returned (optional) 
            var searchString = searchString_example;  // string | pass an optional search string for looking up a pose (optional) 
            var skip = 56;  // int? | number of records to skip for pagination (optional) 
            var limit = 56;  // int? | maximum number of records to return (optional) 

            try
            {
                // searches accurate pose
                AccuratePose result = apiInstance.SearchAccuratePose(id, searchString, skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.SearchAccuratePose: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| optional uuid of a single accurate pose to be returned | [optional] 
 **searchString** | **string**| pass an optional search string for looking up a pose | [optional] 
 **skip** | **int?**| number of records to skip for pagination | [optional] 
 **limit** | **int?**| maximum number of records to return | [optional] 

### Return type

[**AccuratePose**](AccuratePose.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchpose"></a>
# **SearchPose**
> List<InaccuratePose> SearchPose (string id = null, string searchString = null, int? skip = null, int? limit = null)

searches pose

By passing in the appropriate options, you can search for defined semantic poses in the environment 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchPoseExample
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var id = id_example;  // string | optional uuid of a single pose to be returned (optional) 
            var searchString = searchString_example;  // string | pass an optional search string for looking up a pose (optional) 
            var skip = 56;  // int? | number of records to skip for pagination (optional) 
            var limit = 56;  // int? | maximum number of records to return (optional) 

            try
            {
                // searches pose
                List&lt;InaccuratePose&gt; result = apiInstance.SearchPose(id, searchString, skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.SearchPose: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| optional uuid of a single pose to be returned | [optional] 
 **searchString** | **string**| pass an optional search string for looking up a pose | [optional] 
 **skip** | **int?**| number of records to skip for pagination | [optional] 
 **limit** | **int?**| maximum number of records to return | [optional] 

### Return type

[**List<InaccuratePose>**](InaccuratePose.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
