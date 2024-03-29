/**
 * Known Pose API
 * Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. `anyOf` as a response type and adding a  `discriminator` for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.  
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: Kai.Waelti@dfki.de
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', process.cwd()+'/src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require(process.cwd()+'/src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.KnownPoseClient);
  }
}(this, function(expect, KnownPoseClient) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new KnownPoseClient.AccuratePoseArray();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('AccuratePoseArray', function() {
    it('should create an instance of AccuratePoseArray', function() {
      // uncomment below and update the code to test AccuratePoseArray
      //var instane = new KnownPoseClient.AccuratePoseArray();
      //expect(instance).to.be.a(KnownPoseClient.AccuratePoseArray);
    });

    it('should have the property poseArray (base name: "pose_array")', function() {
      // uncomment below and update the code to test the property poseArray
      //var instane = new KnownPoseClient.AccuratePoseArray();
      //expect(instance).to.be();
    });

  });

}));
