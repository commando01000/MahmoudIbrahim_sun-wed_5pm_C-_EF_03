﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_03.Models
{
    public partial interface INorthwindContextProcedures
    {
        Task<List<CustOrderHistResult>> CustOrderHistAsync(string CustomerID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<CustOrdersDetailResult>> CustOrdersDetailAsync(int? OrderID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<CustOrdersOrdersResult>> CustOrdersOrdersAsync(string CustomerID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteCategoryByCategoryIDAsync(int? CategoryID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteEmployeeByIDAsync(int? EmployeeID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteProductByIDAsync(int? ProductId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<DiscontinuedProductsResult>> DiscontinuedProductsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<EmployeeSalesbyCountryResult>> EmployeeSalesbyCountryAsync(DateTime? Beginning_Date, DateTime? Ending_Date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> NewProductDeleteCommandAsync(int? Original_ProductID, string Original_ProductName, int? IsNull_SupplierID, int? Original_SupplierID, int? IsNull_CategoryID, int? Original_CategoryID, int? IsNull_QuantityPerUnit, string Original_QuantityPerUnit, int? IsNull_UnitPrice, decimal? Original_UnitPrice, int? IsNull_UnitsInStock, short? Original_UnitsInStock, int? IsNull_UnitsOnOrder, short? Original_UnitsOnOrder, int? IsNull_ReorderLevel, short? Original_ReorderLevel, bool? Original_Discontinued, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<NewProductInsertCommandResult>> NewProductInsertCommandAsync(string ProductName, int? SupplierID, int? CategoryID, string QuantityPerUnit, decimal? UnitPrice, short? UnitsInStock, short? UnitsOnOrder, short? ReorderLevel, bool? Discontinued, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<NewProductSelectCommandResult>> NewProductSelectCommandAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<NewProductUpdateCommandResult>> NewProductUpdateCommandAsync(string ProductName, int? SupplierID, int? CategoryID, string QuantityPerUnit, decimal? UnitPrice, short? UnitsInStock, short? UnitsOnOrder, short? ReorderLevel, bool? Discontinued, int? Original_ProductID, string Original_ProductName, int? IsNull_SupplierID, int? Original_SupplierID, int? IsNull_CategoryID, int? Original_CategoryID, int? IsNull_QuantityPerUnit, string Original_QuantityPerUnit, int? IsNull_UnitPrice, decimal? Original_UnitPrice, int? IsNull_UnitsInStock, short? Original_UnitsInStock, int? IsNull_UnitsOnOrder, short? Original_UnitsOnOrder, int? IsNull_ReorderLevel, short? Original_ReorderLevel, bool? Original_Discontinued, int? ProductID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> PrdsDeleteCommandAsync(int? Original_ProductID, string Original_ProductName, int? IsNull_SupplierID, int? Original_SupplierID, int? IsNull_CategoryID, int? Original_CategoryID, int? IsNull_QuantityPerUnit, string Original_QuantityPerUnit, int? IsNull_UnitPrice, decimal? Original_UnitPrice, int? IsNull_UnitsInStock, short? Original_UnitsInStock, int? IsNull_UnitsOnOrder, short? Original_UnitsOnOrder, int? IsNull_ReorderLevel, short? Original_ReorderLevel, bool? Original_Discontinued, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<PrdsInsertCommandResult>> PrdsInsertCommandAsync(string ProductName, int? SupplierID, int? CategoryID, string QuantityPerUnit, decimal? UnitPrice, short? UnitsInStock, short? UnitsOnOrder, short? ReorderLevel, bool? Discontinued, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<PrdsSelectCommandResult>> PrdsSelectCommandAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<PrdsUpdateCommandResult>> PrdsUpdateCommandAsync(string ProductName, int? SupplierID, int? CategoryID, string QuantityPerUnit, decimal? UnitPrice, short? UnitsInStock, short? UnitsOnOrder, short? ReorderLevel, bool? Discontinued, int? Original_ProductID, string Original_ProductName, int? IsNull_SupplierID, int? Original_SupplierID, int? IsNull_CategoryID, int? Original_CategoryID, int? IsNull_QuantityPerUnit, string Original_QuantityPerUnit, int? IsNull_UnitPrice, decimal? Original_UnitPrice, int? IsNull_UnitsInStock, short? Original_UnitsInStock, int? IsNull_UnitsOnOrder, short? Original_UnitsOnOrder, int? IsNull_ReorderLevel, short? Original_ReorderLevel, bool? Original_Discontinued, int? ProductID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SalesbyYearResult>> SalesbyYearAsync(DateTime? Beginning_Date, DateTime? Ending_Date, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SalesByCategoryResult>> SalesByCategoryAsync(string CategoryName, string OrdYear, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectAllCategoriesResult>> SelectAllCategoriesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectALLEmployeesResult>> SelectALLEmployeesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SelectAllProductsResult>> SelectAllProductsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<TenMostExpensiveProductsResult>> TenMostExpensiveProductsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<TestPrdResult>> TestPrdAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateProductNameByProductIDAsync(int? ProductID, string ProductName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
