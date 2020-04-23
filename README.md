# C# Programming: LINQ

[*Versión en español*](./README-es.md)

Sample program with some LINQ functions.

Although LINQ allows us to use a SQL-like syntax embedded in C#, here we just use the undrlying methods, which still let us perform some interesting data manipulations.

The application consists of a window showing a list of person records paginated 10 by 10.

Data itself is not in a database, but a CSV file randomly generated using an online tool [►](https://www.generatedata.com/).

Points of interest:

* Windows Forms [►](https://docs.microsoft.com/en-us/dotnet/framework/winforms/).
  * Data binding
* LINQ functions [►](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
  * Filtering
  * Transformation
  * Pagination
* Caching (simple)
