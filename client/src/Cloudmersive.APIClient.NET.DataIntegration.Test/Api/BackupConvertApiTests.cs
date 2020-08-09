/* 
 * dataintegrationapi
 *
 * Easily and directly query database backup files, convert into other file formats.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.DataIntegration.Client;
using Cloudmersive.APIClient.NET.DataIntegration.Api;
using Cloudmersive.APIClient.NET.DataIntegration.Model;

namespace Cloudmersive.APIClient.NET.DataIntegration.Test
{
    /// <summary>
    ///  Class for testing BackupConvertApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BackupConvertApiTests
    {
        private BackupConvertApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BackupConvertApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BackupConvertApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BackupConvertApi
            //Assert.IsInstanceOfType(typeof(BackupConvertApi), instance, "instance is a BackupConvertApi");
        }

        
        /// <summary>
        /// Test DataintegrationBackupConvertMssqlBakGetTablesPost
        /// </summary>
        [Test]
        public void DataintegrationBackupConvertMssqlBakGetTablesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.DataintegrationBackupConvertMssqlBakGetTablesPost(inputFile);
            //Assert.IsInstanceOf<MssqlBakEnumerateTablesResult> (response, "response is MssqlBakEnumerateTablesResult");
        }
        
        /// <summary>
        /// Test DataintegrationBackupConvertMssqlBakToCsvPost
        /// </summary>
        [Test]
        public void DataintegrationBackupConvertMssqlBakToCsvPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tableName = null;
            //System.IO.Stream inputFile = null;
            //var response = instance.DataintegrationBackupConvertMssqlBakToCsvPost(tableName, inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
