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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using KnownPose.Client;
using KnownPose.Api;
using KnownPose.Model;

namespace KnownPose.Test
{
    /// <summary>
    ///  Class for testing DevelopersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DevelopersApiTests
    {
        private DevelopersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DevelopersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DevelopersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' DevelopersApi
            //Assert.IsInstanceOf(typeof(DevelopersApi), instance);
        }

        
        /// <summary>
        /// Test AddPose
        /// </summary>
        [Test]
        public void AddPoseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BasicPose basicPose = null;
            //instance.AddPose(basicPose);
            
        }
        
        /// <summary>
        /// Test PosesIdDelete
        /// </summary>
        [Test]
        public void PosesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PosesIdDelete(id);
            //Assert.IsInstanceOf(typeof(InlineResponse200), response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test SearchAccuratePose
        /// </summary>
        [Test]
        public void SearchAccuratePoseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchString = null;
            //int skip = null;
            //int limit = null;
            //var response = instance.SearchAccuratePose(searchString, skip, limit);
            //Assert.IsInstanceOf(typeof(AccuratePose), response, "response is AccuratePose");
        }
        
        /// <summary>
        /// Test SearchInaccuratePose
        /// </summary>
        [Test]
        public void SearchInaccuratePoseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchString = null;
            //int skip = null;
            //int limit = null;
            //var response = instance.SearchInaccuratePose(searchString, skip, limit);
            //Assert.IsInstanceOf(typeof(InaccuratePose), response, "response is InaccuratePose");
        }
        
        /// <summary>
        /// Test SearchPose
        /// </summary>
        [Test]
        public void SearchPoseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchString = null;
            //int skip = null;
            //int limit = null;
            //var response = instance.SearchPose(searchString, skip, limit);
            //Assert.IsInstanceOf(typeof(List<BasicPose>), response, "response is List<BasicPose>");
        }
        
    }

}