# dotnet_assessment
### Steps to Run
$```git clone https://github.com/techiehkr/dotnet_assessment.git``` <br />
$```cd dotnet_assessment``` <br />
$```cd BookApi``` <br />
$```dotnet run``` <br />
#### http://localhost:5130/swagger/index.html <br />
API links:- <br />
### Book
#### GET
/api/Book/publisher-author-title <br />
#### GET
/api/Book/author-title <br />
#### GET
/api/Book/total-price <br />
#### POST
/api/Book/bulk-insert <br />
#### GET
/api/Book/SP-publisher-author-title <br />
#### GET
/api/Book/SP-author-title <br />

### BookControllerDto
#### GET
/api/BookControllerDto/publisher-author-title
#### GET
/api/BookControllerDto/author-title
#### GET
/api/BookControllerDto/total-price
#### POST
/api/BookControllerDto/bulk-insert


![alt text](https://github.com/techiehkr/dotnet_assessment/blob/main/Screenshot%20from%202024-06-28%2000-32-48.png)
### Steps to Run Tests <br />
$```cd dotnet_assessment``` <br />
$```cd BookApi.Tests``` <br />
$```dotnet test``` <br />

### Output
```
Determining projects to restore... <br />
  Restored /home/user/Desktop/dotnet_assessment/BookApi.Tests/BookApi.Tests.csproj (in 401 ms). <br />
  1 of 2 projects are up-to-date for restore. <br />
  BookApi -> /home/user/Desktop/dotnet_assessment/BookApi/bin/Debug/net8.0/BookApi.dll <br />
  BookApi.Tests -> /home/user/Desktop/dotnet_assessment/BookApi.Tests/bin/Debug/net8.0/BookApi.Tests.dll <br />
Test run for /home/user/Desktop/dotnet_assessment/BookApi.Tests/bin/Debug/net8.0/BookApi.Tests.dll (.NETCoreApp,Version=v8.0) <br />
Microsoft (R) Test Execution Command Line Tool Version 17.8.0 (x64) <br />
Copyright (c) Microsoft Corporation.  All rights reserved. <br />

Starting test execution, please wait... <br />
A total of 1 test files matched the specified pattern. <br />

Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5, Duration: 95 ms - BookApi.Tests.dll (net8.0) <br />
```

### Dotnet version 8 <br />

### Used Dependencies <br />
"AutoMapper": "12.0.0", <br />
"AutoMapper.Extensions.Microsoft.DependencyInjection": "12.0.0", <br />
"EFCore.BulkExtensions": "8.0.4", <br />
"Microsoft.AspNetCore.OpenApi": "8.0.5", <br />
"Microsoft.EntityFrameworkCore.Design": "8.0.6", <br />
"Microsoft.EntityFrameworkCore.Sqlite": "8.0.6", <br />
"Microsoft.EntityFrameworkCore.Tools": "8.0.6", <br />
"Swashbuckle.AspNetCore": "6.6.2" <br />




