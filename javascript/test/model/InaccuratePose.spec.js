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
    instance = new KnownPoseClient.InaccuratePose();
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

  describe('InaccuratePose', function() {
    it('should create an instance of InaccuratePose', function() {
      // uncomment below and update the code to test InaccuratePose
      //var instane = new KnownPoseClient.InaccuratePose();
      //expect(instance).to.be.a(KnownPoseClient.InaccuratePose);
    });

    it('should have the property id (base name: "id")', function() {
      // uncomment below and update the code to test the property id
      //var instane = new KnownPoseClient.InaccuratePose();
      //expect(instance).to.be();
    });

    it('should have the property dns (base name: "dns")', function() {
      // uncomment below and update the code to test the property dns
      //var instane = new KnownPoseClient.InaccuratePose();
      //expect(instance).to.be();
    });

    it('should have the property basicPose (base name: "basic_pose")', function() {
      // uncomment below and update the code to test the property basicPose
      //var instane = new KnownPoseClient.InaccuratePose();
      //expect(instance).to.be();
    });

    it('should have the property isAccurate (base name: "is_accurate")', function() {
      // uncomment below and update the code to test the property isAccurate
      //var instane = new KnownPoseClient.InaccuratePose();
      //expect(instance).to.be();
    });

    it('should have the property takenAt (base name: "taken_at")', function() {
      // uncomment below and update the code to test the property takenAt
      //var instane = new KnownPoseClient.InaccuratePose();
      //expect(instance).to.be();
    });

  });

}));
