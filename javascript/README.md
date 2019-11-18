# known-pose-client

KnownPoseClient - JavaScript client for known-pose-client
Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. `anyOf` as a response type and adding a  `discriminator` for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.  
This SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.1.0
- Package version: 1.1.10
- Build package: org.openapitools.codegen.languages.JavascriptClientCodegen

## Installation

### For [Node.js](https://nodejs.org/)

#### npm

To publish the library as a [npm](https://www.npmjs.com/), please follow the procedure in ["Publishing npm packages"](https://docs.npmjs.com/getting-started/publishing-npm-packages).

Then install it via:

```shell
npm install known-pose-client --save
```

Finally, you need to build the module:

```shell
npm run build
```

##### Local development

To use the library locally without publishing to a remote npm registry, first install the dependencies by changing into the directory containing `package.json` (and this README). Let's call this `JAVASCRIPT_CLIENT_DIR`. Then run:

```shell
npm install
```

Next, [link](https://docs.npmjs.com/cli/link) it globally in npm with the following, also from `JAVASCRIPT_CLIENT_DIR`:

```shell
npm link
```

To use the link you just defined in your project, switch to the directory you want to use your known-pose-client from, and run:

```shell
npm link /path/to/<JAVASCRIPT_CLIENT_DIR>
```

Finally, you need to build the module:

```shell
npm run build
```

#### git

If the library is hosted at a git repository, e.g.https://github.com/GIT_USER_ID/GIT_REPO_ID
then install it via:

```shell
    npm install GIT_USER_ID/GIT_REPO_ID --save
```

### For browser

The library also works in the browser environment via npm and [browserify](http://browserify.org/). After following
the above steps with Node.js and installing browserify with `npm install -g browserify`,
perform the following (assuming *main.js* is your entry file):

```shell
browserify main.js > bundle.js
```

Then include *bundle.js* in the HTML pages.

### Webpack Configuration

Using Webpack you may encounter the following error: "Module not found: Error:
Cannot resolve module", most certainly you should disable AMD loader. Add/merge
the following section to your webpack config:

```javascript
module: {
  rules: [
    {
      parser: {
        amd: false
      }
    }
  ]
}
```

## Getting Started

Please follow the [installation](#installation) instruction and execute the following JS code:

```javascript
var KnownPoseClient = require('known-pose-client');


var api = new KnownPoseClient.DevelopersApi()
var opts = {
  'basicPose': new KnownPoseClient.BasicPose() // {BasicPose} Optional pose item to add
};
var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
api.addAccuratePose(opts, callback);

```

## Documentation for API Endpoints

All URIs are relative to *https://virtserver.swaggerhub.com/kw90/known-pose-api/1.1.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*KnownPoseClient.DevelopersApi* | [**addAccuratePose**](docs/DevelopersApi.md#addAccuratePose) | **POST** /poses/accurate | adds an accurate pose item
*KnownPoseClient.DevelopersApi* | [**addInaccuratePose**](docs/DevelopersApi.md#addInaccuratePose) | **POST** /poses | adds an inaccurate pose item
*KnownPoseClient.DevelopersApi* | [**posesIdDelete**](docs/DevelopersApi.md#posesIdDelete) | **DELETE** /poses/{id} | deletes a pose item
*KnownPoseClient.DevelopersApi* | [**searchAccuratePose**](docs/DevelopersApi.md#searchAccuratePose) | **GET** /poses/accurate | searches accurate pose
*KnownPoseClient.DevelopersApi* | [**searchPose**](docs/DevelopersApi.md#searchPose) | **GET** /poses | searches pose


## Documentation for Models

 - [KnownPoseClient.AccuratePose](docs/AccuratePose.md)
 - [KnownPoseClient.AccuratePoseArray](docs/AccuratePoseArray.md)
 - [KnownPoseClient.BasicPose](docs/BasicPose.md)
 - [KnownPoseClient.InaccuratePose](docs/InaccuratePose.md)
 - [KnownPoseClient.InaccuratePoseArray](docs/InaccuratePoseArray.md)
 - [KnownPoseClient.InlineResponse200](docs/InlineResponse200.md)
 - [KnownPoseClient.Orientation](docs/Orientation.md)
 - [KnownPoseClient.Position](docs/Position.md)


## Documentation for Authorization

All endpoints do not require authorization.