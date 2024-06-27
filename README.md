# dotnet_assessment
### Steps to Run
$```git clone https://github.com/techiehkr/dotnet_assessment.git``` <br />
$```cd dotnet_assessment``` <br />
$```cd BookApi``` <br />
$```dotnet run``` <br />
#### http://localhost:5130/swagger/index.html <br />

### Steps to Run Tests <br />
$```cd dotnet_assessment``` <br />
$```cd BookApi.Tests``` <br />
$```dotnet test``` <br />

### Used Dependencies <br />
"AutoMapper": "12.0.0", <br />
"AutoMapper.Extensions.Microsoft.DependencyInjection": "12.0.0", <br />
"EFCore.BulkExtensions": "8.0.4", <br />
"Microsoft.AspNetCore.OpenApi": "8.0.5", <br />
"Microsoft.EntityFrameworkCore.Design": "8.0.6", <br />
"Microsoft.EntityFrameworkCore.Sqlite": "8.0.6", <br />
"Microsoft.EntityFrameworkCore.Tools": "8.0.6", <br />
"Swashbuckle.AspNetCore": "6.6.2" <br />

### Dotnet version 8 <br />

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
