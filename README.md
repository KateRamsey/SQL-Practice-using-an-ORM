# SQL-Practice-using-an-ORM

You will need the NuGet Package PetaPoco.Core.Compiled (v5.1.153).

You will also need to change the connectionString in App.config to your database server.


For reference, these are the assignment specs:
Explorer Mode

Using the tables you created in the previous assignment we're going to use Petapoco to insert and select information from our tables. Example Data
Copy CodeSales Made:
Name, SaleDate, Pretax Amount
Deacon, 10/15/15, 2846
Deacon, 09/21/15, 8852
Edan, 12/07/15, 5255
Edan, 02/27/16, 5259
Yardley, 11/23/15, 7244
Farrah, 12/21/15, 8711
Deacon, 10/02/15 ,740
Jessamine, 04/02/15 ,9970
Isabelle, 12/25/15 ,6009
Judah, 07/03/14, 9703


For the following steps - use petapoco for any database operations and write out to the console any results you get. You will need to create c# classes to represent a row for each of your select.
1.Insert data for each row using petapoco
2.Write a SQL Statement which will find all records (with all fields) in the table
3.Write a SQL Statement which will tell you the largest and smallest sale amount.
4.Get a distinct list of all sales people

Adventure Mode
1.Find the difference in time between the last and first sale.
2.Find the number of sales by month (for example the month of december has 3 sales)
3.Find the total sales for each salesperson

Epic Mode
1.Fire Deacon. Remove him and his sales from the database 
2.Add a column to the sales class that will hold the tax amount of the sale. Query all the sales using petapoco and in c# code calculate the 6% sales tax for each sale. In c# Sum up the tax column for all sales and print it to the console.
