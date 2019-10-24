# known_pose.DevelopersApi

All URIs are relative to *https://virtserver.swaggerhub.com/kw90/known-pose-api/1.1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**add_pose**](DevelopersApi.md#add_pose) | **POST** /poses | adds a pose item
[**poses_id_delete**](DevelopersApi.md#poses_id_delete) | **DELETE** /poses/{id} | deletes a pose item
[**search_pose**](DevelopersApi.md#search_pose) | **GET** /poses | searches pose


# **add_pose**
> add_pose(basic_pose=basic_pose)

adds a pose item

Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose. 

### Example

```python
from __future__ import print_function
import time
import known_pose
from known_pose.rest import ApiException
from pprint import pprint

# Create an instance of the API class
api_instance = known_pose.DevelopersApi()
basic_pose = known_pose.BasicPose() # BasicPose | Optional pose item to add (optional)

try:
    # adds a pose item
    api_instance.add_pose(basic_pose=basic_pose)
except ApiException as e:
    print("Exception when calling DevelopersApi->add_pose: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **basic_pose** | [**BasicPose**](BasicPose.md)| Optional pose item to add | [optional] 

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
**201** | pose created |  -  |
**400** | invalid input, object invalid |  -  |
**409** | an existing pose already exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **poses_id_delete**
> InlineResponse200 poses_id_delete(id)

deletes a pose item

Deletes an accurate or inaccurate pose from the system using the `uuid`. 

### Example

```python
from __future__ import print_function
import time
import known_pose
from known_pose.rest import ApiException
from pprint import pprint

# Create an instance of the API class
api_instance = known_pose.DevelopersApi()
id = 'id_example' # str | uuid

try:
    # deletes a pose item
    api_response = api_instance.poses_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DevelopersApi->poses_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| uuid | 

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
**200** | Delete was successful. |  * Request-Id - Request uuid <br>  |
**400** | Bad Request. The data from the client is invalid. |  -  |
**401** | Unauthorized. |  -  |
**403** | Forbidden. Improper permissions for this operation. |  -  |
**404** | Could not find the object. |  -  |
**500** | Internal Server Error. For some unknown reason the server failed. |  -  |
**503** | Service Unavailable. Please try again later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **search_pose**
> list[OneOfAccuratePoseInaccuratePose] search_pose(search_string=search_string, skip=skip, limit=limit)

searches pose

By passing in the appropriate options, you can search for defined semantic poses in the environment 

### Example

```python
from __future__ import print_function
import time
import known_pose
from known_pose.rest import ApiException
from pprint import pprint

# Create an instance of the API class
api_instance = known_pose.DevelopersApi()
search_string = 'search_string_example' # str | pass an optional search string for looking up a pose (optional)
skip = 56 # int | number of records to skip for pagination (optional)
limit = 56 # int | maximum number of records to return (optional)

try:
    # searches pose
    api_response = api_instance.search_pose(search_string=search_string, skip=skip, limit=limit)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DevelopersApi->search_pose: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search_string** | **str**| pass an optional search string for looking up a pose | [optional] 
 **skip** | **int**| number of records to skip for pagination | [optional] 
 **limit** | **int**| maximum number of records to return | [optional] 

### Return type

[**list[OneOfAccuratePoseInaccuratePose]**](OneOfAccuratePoseInaccuratePose.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | search results matching criteria |  -  |
**400** | bad input parameter |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

