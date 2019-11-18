# KnownPoseClient.DevelopersApi

All URIs are relative to *https://virtserver.swaggerhub.com/kw90/known-pose-api/1.1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addAccuratePose**](DevelopersApi.md#addAccuratePose) | **POST** /poses/accurate | adds an accurate pose item
[**addInaccuratePose**](DevelopersApi.md#addInaccuratePose) | **POST** /poses | adds an inaccurate pose item
[**posesIdDelete**](DevelopersApi.md#posesIdDelete) | **DELETE** /poses/{id} | deletes a pose item
[**searchAccuratePose**](DevelopersApi.md#searchAccuratePose) | **GET** /poses/accurate | searches accurate pose
[**searchPose**](DevelopersApi.md#searchPose) | **GET** /poses | searches pose



## addAccuratePose

> addAccuratePose(opts)

adds an accurate pose item

Adds an accurate pose to the system. Just give the Pose a name. 

### Example

```javascript
import KnownPoseClient from 'known-pose-client';

let apiInstance = new KnownPoseClient.DevelopersApi();
let opts = {
  'basicPose': new KnownPoseClient.BasicPose() // BasicPose | Optional pose item to add
};
apiInstance.addAccuratePose(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **basicPose** | [**BasicPose**](BasicPose.md)| Optional pose item to add | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## addInaccuratePose

> addInaccuratePose(opts)

adds an inaccurate pose item

Adds an inaccurate pose to the system. Just give the Pose a name and optionally a Pose in the map to use. 

### Example

```javascript
import KnownPoseClient from 'known-pose-client';

let apiInstance = new KnownPoseClient.DevelopersApi();
let opts = {
  'basicPose': new KnownPoseClient.BasicPose() // BasicPose | Optional pose item to add
};
apiInstance.addInaccuratePose(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **basicPose** | [**BasicPose**](BasicPose.md)| Optional pose item to add | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## posesIdDelete

> InlineResponse200 posesIdDelete(id)

deletes a pose item

Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;. 

### Example

```javascript
import KnownPoseClient from 'known-pose-client';

let apiInstance = new KnownPoseClient.DevelopersApi();
let id = "id_example"; // String | uuid
apiInstance.posesIdDelete(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| uuid | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## searchAccuratePose

> AccuratePoseArray searchAccuratePose(opts)

searches accurate pose

By passing in the appropriate options, you can search for defined accurate semantic poses in the environment 

### Example

```javascript
import KnownPoseClient from 'known-pose-client';

let apiInstance = new KnownPoseClient.DevelopersApi();
let opts = {
  'id': "id_example", // String | optional uuid of a single accurate pose to be returned
  'searchString': "searchString_example", // String | pass an optional search string for looking up a pose
  'skip': 56, // Number | number of records to skip for pagination
  'limit': 56 // Number | maximum number of records to return
};
apiInstance.searchAccuratePose(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| optional uuid of a single accurate pose to be returned | [optional] 
 **searchString** | **String**| pass an optional search string for looking up a pose | [optional] 
 **skip** | **Number**| number of records to skip for pagination | [optional] 
 **limit** | **Number**| maximum number of records to return | [optional] 

### Return type

[**AccuratePoseArray**](AccuratePoseArray.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## searchPose

> InaccuratePoseArray searchPose(opts)

searches pose

By passing in the appropriate options, you can search for defined semantic poses in the environment 

### Example

```javascript
import KnownPoseClient from 'known-pose-client';

let apiInstance = new KnownPoseClient.DevelopersApi();
let opts = {
  'id': "id_example", // String | optional uuid of a single pose to be returned
  'searchString': "searchString_example", // String | pass an optional search string for looking up a pose
  'skip': 56, // Number | number of records to skip for pagination
  'limit': 56 // Number | maximum number of records to return
};
apiInstance.searchPose(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| optional uuid of a single pose to be returned | [optional] 
 **searchString** | **String**| pass an optional search string for looking up a pose | [optional] 
 **skip** | **Number**| number of records to skip for pagination | [optional] 
 **limit** | **Number**| maximum number of records to return | [optional] 

### Return type

[**InaccuratePoseArray**](InaccuratePoseArray.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

