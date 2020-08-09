# Cloudmersive.APIClient.NET.DataIntegration.Api.BackupConvertApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataintegrationBackupConvertMssqlBakGetTablesPost**](BackupConvertApi.md#dataintegrationbackupconvertmssqlbakgettablespost) | **POST** /dataintegration/backup/convert/mssql/bak/get/tables | Lists all tables stored in a SQL Server Backup (.BAK) file
[**DataintegrationBackupConvertMssqlBakToCsvPost**](BackupConvertApi.md#dataintegrationbackupconvertmssqlbaktocsvpost) | **POST** /dataintegration/backup/convert/mssql/bak/to/csv | Converts a SQL Server Backup (.BAK) file into CSV for a specified table


<a name="dataintegrationbackupconvertmssqlbakgettablespost"></a>
# **DataintegrationBackupConvertMssqlBakGetTablesPost**
> MssqlBakEnumerateTablesResult DataintegrationBackupConvertMssqlBakGetTablesPost (System.IO.Stream inputFile = null)

Lists all tables stored in a SQL Server Backup (.BAK) file

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DataIntegration.Api;
using Cloudmersive.APIClient.NET.DataIntegration.Client;
using Cloudmersive.APIClient.NET.DataIntegration.Model;

namespace Example
{
    public class DataintegrationBackupConvertMssqlBakGetTablesPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new BackupConvertApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on (optional) 

            try
            {
                // Lists all tables stored in a SQL Server Backup (.BAK) file
                MssqlBakEnumerateTablesResult result = apiInstance.DataintegrationBackupConvertMssqlBakGetTablesPost(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupConvertApi.DataintegrationBackupConvertMssqlBakGetTablesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on | [optional] 

### Return type

[**MssqlBakEnumerateTablesResult**](MssqlBakEnumerateTablesResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dataintegrationbackupconvertmssqlbaktocsvpost"></a>
# **DataintegrationBackupConvertMssqlBakToCsvPost**
> byte[] DataintegrationBackupConvertMssqlBakToCsvPost (string tableName = null, System.IO.Stream inputFile = null)

Converts a SQL Server Backup (.BAK) file into CSV for a specified table

Input the target table to extract the data as a CSV format file.  Supports a wide array of SQL Server .BAK files and SQL Server backup file versions.  Consumes 1 API call per MB of input data.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DataIntegration.Api;
using Cloudmersive.APIClient.NET.DataIntegration.Client;
using Cloudmersive.APIClient.NET.DataIntegration.Model;

namespace Example
{
    public class DataintegrationBackupConvertMssqlBakToCsvPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new BackupConvertApi();
            var tableName = tableName_example;  // string | Name of the table to return (optional) 
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on (optional) 

            try
            {
                // Converts a SQL Server Backup (.BAK) file into CSV for a specified table
                byte[] result = apiInstance.DataintegrationBackupConvertMssqlBakToCsvPost(tableName, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BackupConvertApi.DataintegrationBackupConvertMssqlBakToCsvPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tableName** | **string**| Name of the table to return | [optional] 
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/csv

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

