using MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static Azure.Core.HttpHeader;

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                // 1. List all products with their supplier names
                //var products = db.Products.Select(p => new { p.ProductName, p.Supplier.CompanyName }).ToList();

                //foreach (var product in products)
                //{
                //    Console.WriteLine($"{product.ProductName} - {product.CompanyName}");
                //}

                // 2. Find all employees in a specific territory 01581
                //var EmployeesInTerritory = db.EmployeeTerritories.Join(db.Employees, ET => ET.EmployeeId, E => E.EmployeeId,
                //    (ET, E) => new { ET, E }).Where(x => x.ET.TerritoryId == "01581").ToList();

                //foreach (var employee in EmployeesInTerritory)
                //{
                //    Console.WriteLine($"{employee.E.FirstName} {employee.E.LastName}");
                //}

                // 3. List all orders made by a specific customer ALFKI
                //var Cust_Orders = db.Customers.SelectMany(c => c.Orders).Where(c => c.CustomerId == "ALFKI").ToList();

                //foreach (var cust_order in Cust_Orders)
                //{
                //    Console.WriteLine($"{cust_order.OrderDate} - {cust_order.CustomerId}");
                //}

                // 4. List all categories

                //var Categories = db.Categories.Select(c => c.CategoryName).ToList();

                //foreach (var category in Categories)
                //{
                //    Console.WriteLine($"{category}");
                //}

                // 5.Get the total number of orders for each employee

                //var Emp_Orders = db.Employees.SelectMany(E => E.Orders).GroupBy(E => E.Employee.FirstName).ToList();

                // foreach (var emp_order in Emp_Orders)
                // {
                //     Console.WriteLine($"{emp_order.Key} - {emp_order.Count()}");
                // }

                // 6. List all products within a specific category Condiments
                //var ProductsByCategory = db.Products.Select(p => new { p.ProductName, p.Category.CategoryName }).Where(p => p.CategoryName == "Condiments").ToList();

                //foreach (var product in ProductsByCategory)
                //{
                //    Console.WriteLine($"{product.ProductName} - {product.CategoryName}");
                //}

                // 7. Get the details of orders shipped by a specific shipper Speedy Express

                //var Order_Details_By_Shipper = db.Orders.SelectMany(o => o.OrderDetails).Select(x => new { x.UnitPrice, x.Quantity, x.Order.ShippedDate, x.Order.ShipViaNavigation }).Where(o => o.ShipViaNavigation.CompanyName == "Speedy Express").ToList();

                //foreach (var order_detail in Order_Details_By_Shipper)
                //{
                //    Console.WriteLine($"{order_detail.ShippedDate} - {order_detail.ShipViaNavigation.CompanyName} - {order_detail.UnitPrice} - {order_detail.Quantity}");
                //}
                // another solution
                //var Order_Details_By_Shipper = db.Orders.SelectMany(o => o.OrderDetails.Select(od => new { od.UnitPrice, od.Quantity, o.ShippedDate, o.ShipViaNavigation }).Where(o => o.ShipViaNavigation.CompanyName == "Federal Shipping")).ToList();
                //Console.WriteLine(Order_Details_By_Shipper.Count());
                //foreach (var order_detail in Order_Details_By_Shipper)
                //{
                //     Console.WriteLine($"{order_detail.ShippedDate} - {order_detail.ShipViaNavigation.CompanyName} - {order_detail.UnitPrice} - {order_detail.Quantity}");
                //}

                // 8. List all customers with their orders

                //var Cust_Orders = db.Customers.SelectMany(c => c.Orders).Select(x => x).GroupBy(c => c.CustomerId).ToList();

                //foreach (var cust_order in Cust_Orders)
                //{
                //    Console.WriteLine($"{cust_order.Key} - {cust_order.Count()}");
                //}

                // 9. Calculate the total sales by each employee
                //var totalSalesByEmployee = db.Employees.SelectMany(e => e.Orders).GroupBy(e => e.EmployeeId).Select(e => new { EmployeeId = e.Key, TotalSales = e.Sum(o => o.Freight) }).ToList();

                //foreach (var totalSale in totalSalesByEmployee)
                //{
                //    Console.WriteLine($"{totalSale.EmployeeId} - {totalSale.TotalSales}");
                //}

                // Procedures
                //get customer order details
                var northwindContextProcedures = new NorthwindContextProcedures(db);
                //OutputParameter<int> returnValue = new OutputParameter<int>();
                //ICollection<CustOrdersDetailResult> result = northwindContextProcedures.CustOrdersDetailAsync(10248).Result;
                //Console.WriteLine(result.Count());
                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice} - {item.Quantity} - {item.Discount}");
                //}

                //ICollection<DiscontinuedProductsResult> result = northwindContextProcedures.DiscontinuedProductsAsync().Result;
                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.ProductName}");
                //}

                //ICollection<SalesByCategoryResult> result = northwindContextProcedures.SalesByCategoryAsync("Beverages", "1997").Result;

                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.ProductName} - {item.TotalPurchase}");
                //}

                //ICollection<SalesByCategoryResult> result = northwindContextProcedures.SalesByCategoryAsync("Seafood", "1997").Result;

                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item.ProductName} - {item.TotalPurchase}");
                //}
            };
        }
    }
}
