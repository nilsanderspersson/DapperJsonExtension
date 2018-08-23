# Introduction

Dapper Json Extensions is a small library that complements Dapper by adding FOR JSON PATH extension with SQL Server 2016.

# Example

 ```csharp
using (var cn = new SqlConnection("your connection string"))
{
    var sql = @"select col1, col2, col3 from table for json path";
    var data = cn.QueryJson(sql);

    return Ok(data);
 }
  ```
  
 Read more about JSON Output here:<br>
 https://docs.microsoft.com/en-us/sql/relational-databases/json/format-json-output-automatically-with-auto-mode-sql-server?view=sql-server-2017
 
