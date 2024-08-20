using MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models;
using System.ComponentModel.DataAnnotations;

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

                //3. List all orders made by a specific customer ALFKI
                var Cust_Orders = db.Customers.SelectMany(c => c.Orders).Where(c => c.CustomerId == "ALFKI") .ToList();

                foreach (var cust_order in Cust_Orders)
                {
                    Console.WriteLine($"{cust_order.OrderDate} - {cust_order.CustomerId}");
                }
            };
        }
    }
}
