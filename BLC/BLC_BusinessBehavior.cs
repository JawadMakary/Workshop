using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
#region Reset_Industry_By_Coupons
public void Reset_Industry_By_Coupons(Coupons i_Coupons, List<Industry> i_Industry_List)
{
#region Declaration And Initialization Section.
Params_Delete_Industry_By_COUPONS_ID oParams_Delete_Industry_By_COUPONS_ID = new Params_Delete_Industry_By_COUPONS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Industry_By_Coupons");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Industry
//---------------------------------
oParams_Delete_Industry_By_COUPONS_ID.COUPONS_ID = i_Coupons.COUPONS_ID;
Delete_Industry_By_COUPONS_ID(oParams_Delete_Industry_By_COUPONS_ID);
//---------------------------------
// Edit Industry
//---------------------------------
Edit_Coupons_WithIndustry(i_Coupons, i_Industry_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Industry_By_Coupons");}
}
#endregion
#region Reset_Industry_By_Coupons
public void Reset_Industry_By_Coupons(Coupons i_Coupons, List<Industry> i_Industry_List_To_Delete,List<Industry> i_Industry_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Industry oParams_Delete_Industry = new Params_Delete_Industry();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Industry_By_Coupons");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Industry_List_To_Delete != null)
{
foreach (var oRow in i_Industry_List_To_Delete)
{
oParams_Delete_Industry.INDUSTRY_ID = oRow.INDUSTRY_ID;
Delete_Industry(oParams_Delete_Industry);
}
}
//---------------------------------
// Edit Industry
//---------------------------------
Edit_Coupons_WithIndustry(i_Coupons, i_Industry_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Industry_By_Coupons");}
}
#endregion
#region Edit_Coupons_With_Industry(Coupons i_Coupons,List<Industry> i_IndustryList)
public void Edit_Coupons_WithIndustry(Coupons i_Coupons,List<Industry> i_List_Industry)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coupons_WithIndustry");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Coupons(i_Coupons);
if (i_List_Industry != null)
{
foreach(Industry oIndustry in i_List_Industry)
{
oIndustry.COUPONS_ID = i_Coupons.COUPONS_ID;
Edit_Industry(oIndustry);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coupons_WithIndustry");}
}
#endregion
#region Reset_Productdistribution_By_Coupons
public void Reset_Productdistribution_By_Coupons(Coupons i_Coupons, List<Productdistribution> i_Productdistribution_List)
{
#region Declaration And Initialization Section.
Params_Delete_Productdistribution_By_COUPONS_ID oParams_Delete_Productdistribution_By_COUPONS_ID = new Params_Delete_Productdistribution_By_COUPONS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Productdistribution_By_Coupons");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Productdistribution
//---------------------------------
oParams_Delete_Productdistribution_By_COUPONS_ID.COUPONS_ID = i_Coupons.COUPONS_ID;
Delete_Productdistribution_By_COUPONS_ID(oParams_Delete_Productdistribution_By_COUPONS_ID);
//---------------------------------
// Edit Productdistribution
//---------------------------------
Edit_Coupons_WithProductdistribution(i_Coupons, i_Productdistribution_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Productdistribution_By_Coupons");}
}
#endregion
#region Reset_Productdistribution_By_Coupons
public void Reset_Productdistribution_By_Coupons(Coupons i_Coupons, List<Productdistribution> i_Productdistribution_List_To_Delete,List<Productdistribution> i_Productdistribution_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Productdistribution oParams_Delete_Productdistribution = new Params_Delete_Productdistribution();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Productdistribution_By_Coupons");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Productdistribution_List_To_Delete != null)
{
foreach (var oRow in i_Productdistribution_List_To_Delete)
{
oParams_Delete_Productdistribution.PRODUCTDISTRIBUTION_ID = oRow.PRODUCTDISTRIBUTION_ID;
Delete_Productdistribution(oParams_Delete_Productdistribution);
}
}
//---------------------------------
// Edit Productdistribution
//---------------------------------
Edit_Coupons_WithProductdistribution(i_Coupons, i_Productdistribution_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Productdistribution_By_Coupons");}
}
#endregion
#region Edit_Coupons_With_Productdistribution(Coupons i_Coupons,List<Productdistribution> i_ProductdistributionList)
public void Edit_Coupons_WithProductdistribution(Coupons i_Coupons,List<Productdistribution> i_List_Productdistribution)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coupons_WithProductdistribution");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Coupons(i_Coupons);
if (i_List_Productdistribution != null)
{
foreach(Productdistribution oProductdistribution in i_List_Productdistribution)
{
oProductdistribution.COUPONS_ID = i_Coupons.COUPONS_ID;
Edit_Productdistribution(oProductdistribution);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coupons_WithProductdistribution");}
}
#endregion
#region Reset_Supplier_By_Coupons
public void Reset_Supplier_By_Coupons(Coupons i_Coupons, List<Supplier> i_Supplier_List)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier_By_COUPONS_ID oParams_Delete_Supplier_By_COUPONS_ID = new Params_Delete_Supplier_By_COUPONS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_By_Coupons");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Supplier
//---------------------------------
oParams_Delete_Supplier_By_COUPONS_ID.COUPONS_ID = i_Coupons.COUPONS_ID;
Delete_Supplier_By_COUPONS_ID(oParams_Delete_Supplier_By_COUPONS_ID);
//---------------------------------
// Edit Supplier
//---------------------------------
Edit_Coupons_WithSupplier(i_Coupons, i_Supplier_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_By_Coupons");}
}
#endregion
#region Reset_Supplier_By_Coupons
public void Reset_Supplier_By_Coupons(Coupons i_Coupons, List<Supplier> i_Supplier_List_To_Delete,List<Supplier> i_Supplier_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier oParams_Delete_Supplier = new Params_Delete_Supplier();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_By_Coupons");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Supplier_List_To_Delete != null)
{
foreach (var oRow in i_Supplier_List_To_Delete)
{
oParams_Delete_Supplier.SUPPLIER_ID = oRow.SUPPLIER_ID;
Delete_Supplier(oParams_Delete_Supplier);
}
}
//---------------------------------
// Edit Supplier
//---------------------------------
Edit_Coupons_WithSupplier(i_Coupons, i_Supplier_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_By_Coupons");}
}
#endregion
#region Edit_Coupons_With_Supplier(Coupons i_Coupons,List<Supplier> i_SupplierList)
public void Edit_Coupons_WithSupplier(Coupons i_Coupons,List<Supplier> i_List_Supplier)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coupons_WithSupplier");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Coupons(i_Coupons);
if (i_List_Supplier != null)
{
foreach(Supplier oSupplier in i_List_Supplier)
{
oSupplier.COUPONS_ID = i_Coupons.COUPONS_ID;
Edit_Supplier(oSupplier);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coupons_WithSupplier");}
}
#endregion
#region Edit_Coupons_WithRelatedData(Coupons i_Coupons,List<Industry> i_List_Industry,List<Productdistribution> i_List_Productdistribution,List<Supplier> i_List_Supplier)
public void Edit_Coupons_WithRelatedData(Coupons i_Coupons,List<Industry> i_List_Industry,List<Productdistribution> i_List_Productdistribution,List<Supplier> i_List_Supplier)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coupons_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Coupons(i_Coupons);
if (i_List_Industry != null)
{
foreach(Industry oIndustry in i_List_Industry)
{
oIndustry.COUPONS_ID = i_Coupons.COUPONS_ID;
Edit_Industry(oIndustry);
}
}
if (i_List_Productdistribution != null)
{
foreach(Productdistribution oProductdistribution in i_List_Productdistribution)
{
oProductdistribution.COUPONS_ID = i_Coupons.COUPONS_ID;
Edit_Productdistribution(oProductdistribution);
}
}
if (i_List_Supplier != null)
{
foreach(Supplier oSupplier in i_List_Supplier)
{
oSupplier.COUPONS_ID = i_Coupons.COUPONS_ID;
Edit_Supplier(oSupplier);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coupons_WithRelatedData");}
}
#endregion
#region Delete_Coupons_With_Children(Coupons i_Coupons)
public void Delete_Coupons_With_Children(Coupons i_Coupons)
{
 #region Declaration And Initialization Section.
Params_Delete_Coupons oParams_Delete_Coupons = new Params_Delete_Coupons();
Params_Delete_Industry_By_COUPONS_ID oParams_Delete_Industry_By_COUPONS_ID = new Params_Delete_Industry_By_COUPONS_ID();
Params_Delete_Productdistribution_By_COUPONS_ID oParams_Delete_Productdistribution_By_COUPONS_ID = new Params_Delete_Productdistribution_By_COUPONS_ID();
Params_Delete_Supplier_By_COUPONS_ID oParams_Delete_Supplier_By_COUPONS_ID = new Params_Delete_Supplier_By_COUPONS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Coupons_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Industry_By_COUPONS_ID.COUPONS_ID = i_Coupons.COUPONS_ID;
Delete_Industry_By_COUPONS_ID(oParams_Delete_Industry_By_COUPONS_ID);
oParams_Delete_Productdistribution_By_COUPONS_ID.COUPONS_ID = i_Coupons.COUPONS_ID;
Delete_Productdistribution_By_COUPONS_ID(oParams_Delete_Productdistribution_By_COUPONS_ID);
oParams_Delete_Supplier_By_COUPONS_ID.COUPONS_ID = i_Coupons.COUPONS_ID;
Delete_Supplier_By_COUPONS_ID(oParams_Delete_Supplier_By_COUPONS_ID);
//-------------------------

//-------------------------
oParams_Delete_Coupons.COUPONS_ID = i_Coupons.COUPONS_ID;
Delete_Coupons(oParams_Delete_Coupons);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Coupons_With_Children");}
}
#endregion
#region Reset_Conversions_By_Currency
public void Reset_Conversions_By_Currency(Currency i_Currency, List<Conversions> i_Conversions_List)
{
#region Declaration And Initialization Section.
Params_Delete_Conversions_By_CURRENCY_ID oParams_Delete_Conversions_By_CURRENCY_ID = new Params_Delete_Conversions_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Conversions_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Conversions
//---------------------------------
oParams_Delete_Conversions_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Conversions_By_CURRENCY_ID(oParams_Delete_Conversions_By_CURRENCY_ID);
//---------------------------------
// Edit Conversions
//---------------------------------
Edit_Currency_WithConversions(i_Currency, i_Conversions_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Conversions_By_Currency");}
}
#endregion
#region Reset_Conversions_By_Currency
public void Reset_Conversions_By_Currency(Currency i_Currency, List<Conversions> i_Conversions_List_To_Delete,List<Conversions> i_Conversions_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Conversions oParams_Delete_Conversions = new Params_Delete_Conversions();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Conversions_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Conversions_List_To_Delete != null)
{
foreach (var oRow in i_Conversions_List_To_Delete)
{
oParams_Delete_Conversions.CONVERSIONS_ID = oRow.CONVERSIONS_ID;
Delete_Conversions(oParams_Delete_Conversions);
}
}
//---------------------------------
// Edit Conversions
//---------------------------------
Edit_Currency_WithConversions(i_Currency, i_Conversions_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Conversions_By_Currency");}
}
#endregion
#region Edit_Currency_With_Conversions(Currency i_Currency,List<Conversions> i_ConversionsList)
public void Edit_Currency_WithConversions(Currency i_Currency,List<Conversions> i_List_Conversions)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithConversions");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Conversions != null)
{
foreach(Conversions oConversions in i_List_Conversions)
{
oConversions.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Conversions(oConversions);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithConversions");}
}
#endregion
#region Reset_Coupons_By_Currency
public void Reset_Coupons_By_Currency(Currency i_Currency, List<Coupons> i_Coupons_List)
{
#region Declaration And Initialization Section.
Params_Delete_Coupons_By_CURRENCY_ID oParams_Delete_Coupons_By_CURRENCY_ID = new Params_Delete_Coupons_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Coupons_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Coupons
//---------------------------------
oParams_Delete_Coupons_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Coupons_By_CURRENCY_ID(oParams_Delete_Coupons_By_CURRENCY_ID);
//---------------------------------
// Edit Coupons
//---------------------------------
Edit_Currency_WithCoupons(i_Currency, i_Coupons_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Coupons_By_Currency");}
}
#endregion
#region Reset_Coupons_By_Currency
public void Reset_Coupons_By_Currency(Currency i_Currency, List<Coupons> i_Coupons_List_To_Delete,List<Coupons> i_Coupons_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Coupons oParams_Delete_Coupons = new Params_Delete_Coupons();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Coupons_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Coupons_List_To_Delete != null)
{
foreach (var oRow in i_Coupons_List_To_Delete)
{
oParams_Delete_Coupons.COUPONS_ID = oRow.COUPONS_ID;
Delete_Coupons(oParams_Delete_Coupons);
}
}
//---------------------------------
// Edit Coupons
//---------------------------------
Edit_Currency_WithCoupons(i_Currency, i_Coupons_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Coupons_By_Currency");}
}
#endregion
#region Edit_Currency_With_Coupons(Currency i_Currency,List<Coupons> i_CouponsList)
public void Edit_Currency_WithCoupons(Currency i_Currency,List<Coupons> i_List_Coupons)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithCoupons");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Coupons != null)
{
foreach(Coupons oCoupons in i_List_Coupons)
{
oCoupons.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Coupons(oCoupons);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithCoupons");}
}
#endregion
#region Reset_Fees_By_Currency
public void Reset_Fees_By_Currency(Currency i_Currency, List<Fees> i_Fees_List)
{
#region Declaration And Initialization Section.
Params_Delete_Fees_By_CURRENCY_ID oParams_Delete_Fees_By_CURRENCY_ID = new Params_Delete_Fees_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Fees
//---------------------------------
oParams_Delete_Fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Fees_By_CURRENCY_ID(oParams_Delete_Fees_By_CURRENCY_ID);
//---------------------------------
// Edit Fees
//---------------------------------
Edit_Currency_WithFees(i_Currency, i_Fees_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Fees_By_Currency");}
}
#endregion
#region Reset_Fees_By_Currency
public void Reset_Fees_By_Currency(Currency i_Currency, List<Fees> i_Fees_List_To_Delete,List<Fees> i_Fees_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Fees oParams_Delete_Fees = new Params_Delete_Fees();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Fees_List_To_Delete != null)
{
foreach (var oRow in i_Fees_List_To_Delete)
{
oParams_Delete_Fees.FEES_ID = oRow.FEES_ID;
Delete_Fees(oParams_Delete_Fees);
}
}
//---------------------------------
// Edit Fees
//---------------------------------
Edit_Currency_WithFees(i_Currency, i_Fees_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Fees_By_Currency");}
}
#endregion
#region Edit_Currency_With_Fees(Currency i_Currency,List<Fees> i_FeesList)
public void Edit_Currency_WithFees(Currency i_Currency,List<Fees> i_List_Fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithFees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Fees != null)
{
foreach(Fees oFees in i_List_Fees)
{
oFees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Fees(oFees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithFees");}
}
#endregion
#region Reset_Salary_By_Currency
public void Reset_Salary_By_Currency(Currency i_Currency, List<Salary> i_Salary_List)
{
#region Declaration And Initialization Section.
Params_Delete_Salary_By_CURRENCY_ID oParams_Delete_Salary_By_CURRENCY_ID = new Params_Delete_Salary_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Salary_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Salary
//---------------------------------
oParams_Delete_Salary_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Salary_By_CURRENCY_ID(oParams_Delete_Salary_By_CURRENCY_ID);
//---------------------------------
// Edit Salary
//---------------------------------
Edit_Currency_WithSalary(i_Currency, i_Salary_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Salary_By_Currency");}
}
#endregion
#region Reset_Salary_By_Currency
public void Reset_Salary_By_Currency(Currency i_Currency, List<Salary> i_Salary_List_To_Delete,List<Salary> i_Salary_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Salary oParams_Delete_Salary = new Params_Delete_Salary();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Salary_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Salary_List_To_Delete != null)
{
foreach (var oRow in i_Salary_List_To_Delete)
{
oParams_Delete_Salary.SALARY_ID = oRow.SALARY_ID;
Delete_Salary(oParams_Delete_Salary);
}
}
//---------------------------------
// Edit Salary
//---------------------------------
Edit_Currency_WithSalary(i_Currency, i_Salary_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Salary_By_Currency");}
}
#endregion
#region Edit_Currency_With_Salary(Currency i_Currency,List<Salary> i_SalaryList)
public void Edit_Currency_WithSalary(Currency i_Currency,List<Salary> i_List_Salary)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithSalary");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Salary != null)
{
foreach(Salary oSalary in i_List_Salary)
{
oSalary.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Salary(oSalary);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithSalary");}
}
#endregion
#region Reset_Staff_By_Currency
public void Reset_Staff_By_Currency(Currency i_Currency, List<Staff> i_Staff_List)
{
#region Declaration And Initialization Section.
Params_Delete_Staff_By_CURRENCY_ID oParams_Delete_Staff_By_CURRENCY_ID = new Params_Delete_Staff_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Staff
//---------------------------------
oParams_Delete_Staff_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Staff_By_CURRENCY_ID(oParams_Delete_Staff_By_CURRENCY_ID);
//---------------------------------
// Edit Staff
//---------------------------------
Edit_Currency_WithStaff(i_Currency, i_Staff_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_By_Currency");}
}
#endregion
#region Reset_Staff_By_Currency
public void Reset_Staff_By_Currency(Currency i_Currency, List<Staff> i_Staff_List_To_Delete,List<Staff> i_Staff_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Staff oParams_Delete_Staff = new Params_Delete_Staff();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Staff_List_To_Delete != null)
{
foreach (var oRow in i_Staff_List_To_Delete)
{
oParams_Delete_Staff.STAFF_ID = oRow.STAFF_ID;
Delete_Staff(oParams_Delete_Staff);
}
}
//---------------------------------
// Edit Staff
//---------------------------------
Edit_Currency_WithStaff(i_Currency, i_Staff_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_By_Currency");}
}
#endregion
#region Edit_Currency_With_Staff(Currency i_Currency,List<Staff> i_StaffList)
public void Edit_Currency_WithStaff(Currency i_Currency,List<Staff> i_List_Staff)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithStaff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Staff != null)
{
foreach(Staff oStaff in i_List_Staff)
{
oStaff.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Staff(oStaff);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithStaff");}
}
#endregion
#region Reset_Supplier_By_Currency
public void Reset_Supplier_By_Currency(Currency i_Currency, List<Supplier> i_Supplier_List)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier_By_CURRENCY_ID oParams_Delete_Supplier_By_CURRENCY_ID = new Params_Delete_Supplier_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Supplier
//---------------------------------
oParams_Delete_Supplier_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Supplier_By_CURRENCY_ID(oParams_Delete_Supplier_By_CURRENCY_ID);
//---------------------------------
// Edit Supplier
//---------------------------------
Edit_Currency_WithSupplier(i_Currency, i_Supplier_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_By_Currency");}
}
#endregion
#region Reset_Supplier_By_Currency
public void Reset_Supplier_By_Currency(Currency i_Currency, List<Supplier> i_Supplier_List_To_Delete,List<Supplier> i_Supplier_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier oParams_Delete_Supplier = new Params_Delete_Supplier();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Supplier_List_To_Delete != null)
{
foreach (var oRow in i_Supplier_List_To_Delete)
{
oParams_Delete_Supplier.SUPPLIER_ID = oRow.SUPPLIER_ID;
Delete_Supplier(oParams_Delete_Supplier);
}
}
//---------------------------------
// Edit Supplier
//---------------------------------
Edit_Currency_WithSupplier(i_Currency, i_Supplier_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_By_Currency");}
}
#endregion
#region Edit_Currency_With_Supplier(Currency i_Currency,List<Supplier> i_SupplierList)
public void Edit_Currency_WithSupplier(Currency i_Currency,List<Supplier> i_List_Supplier)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithSupplier");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Supplier != null)
{
foreach(Supplier oSupplier in i_List_Supplier)
{
oSupplier.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Supplier(oSupplier);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithSupplier");}
}
#endregion
#region Reset_Transaction_By_Currency
public void Reset_Transaction_By_Currency(Currency i_Currency, List<Transaction> i_Transaction_List)
{
#region Declaration And Initialization Section.
Params_Delete_Transaction_By_CURRENCY_ID oParams_Delete_Transaction_By_CURRENCY_ID = new Params_Delete_Transaction_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Transaction_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Transaction
//---------------------------------
oParams_Delete_Transaction_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Transaction_By_CURRENCY_ID(oParams_Delete_Transaction_By_CURRENCY_ID);
//---------------------------------
// Edit Transaction
//---------------------------------
Edit_Currency_WithTransaction(i_Currency, i_Transaction_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Transaction_By_Currency");}
}
#endregion
#region Reset_Transaction_By_Currency
public void Reset_Transaction_By_Currency(Currency i_Currency, List<Transaction> i_Transaction_List_To_Delete,List<Transaction> i_Transaction_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Transaction oParams_Delete_Transaction = new Params_Delete_Transaction();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Transaction_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Transaction_List_To_Delete != null)
{
foreach (var oRow in i_Transaction_List_To_Delete)
{
oParams_Delete_Transaction.TRANSACTION_ID = oRow.TRANSACTION_ID;
Delete_Transaction(oParams_Delete_Transaction);
}
}
//---------------------------------
// Edit Transaction
//---------------------------------
Edit_Currency_WithTransaction(i_Currency, i_Transaction_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Transaction_By_Currency");}
}
#endregion
#region Edit_Currency_With_Transaction(Currency i_Currency,List<Transaction> i_TransactionList)
public void Edit_Currency_WithTransaction(Currency i_Currency,List<Transaction> i_List_Transaction)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithTransaction");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Transaction != null)
{
foreach(Transaction oTransaction in i_List_Transaction)
{
oTransaction.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Transaction(oTransaction);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithTransaction");}
}
#endregion
#region Reset_Workshop_By_Currency
public void Reset_Workshop_By_Currency(Currency i_Currency, List<Workshop> i_Workshop_List)
{
#region Declaration And Initialization Section.
Params_Delete_Workshop_By_CURRENCY_ID oParams_Delete_Workshop_By_CURRENCY_ID = new Params_Delete_Workshop_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshop_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Workshop
//---------------------------------
oParams_Delete_Workshop_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Workshop_By_CURRENCY_ID(oParams_Delete_Workshop_By_CURRENCY_ID);
//---------------------------------
// Edit Workshop
//---------------------------------
Edit_Currency_WithWorkshop(i_Currency, i_Workshop_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshop_By_Currency");}
}
#endregion
#region Reset_Workshop_By_Currency
public void Reset_Workshop_By_Currency(Currency i_Currency, List<Workshop> i_Workshop_List_To_Delete,List<Workshop> i_Workshop_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Workshop oParams_Delete_Workshop = new Params_Delete_Workshop();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshop_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Workshop_List_To_Delete != null)
{
foreach (var oRow in i_Workshop_List_To_Delete)
{
oParams_Delete_Workshop.WORKSHOP_ID = oRow.WORKSHOP_ID;
Delete_Workshop(oParams_Delete_Workshop);
}
}
//---------------------------------
// Edit Workshop
//---------------------------------
Edit_Currency_WithWorkshop(i_Currency, i_Workshop_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshop_By_Currency");}
}
#endregion
#region Edit_Currency_With_Workshop(Currency i_Currency,List<Workshop> i_WorkshopList)
public void Edit_Currency_WithWorkshop(Currency i_Currency,List<Workshop> i_List_Workshop)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithWorkshop");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Workshop != null)
{
foreach(Workshop oWorkshop in i_List_Workshop)
{
oWorkshop.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Workshop(oWorkshop);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithWorkshop");}
}
#endregion
#region Reset_Workshops_By_Currency
public void Reset_Workshops_By_Currency(Currency i_Currency, List<Workshops> i_Workshops_List)
{
#region Declaration And Initialization Section.
Params_Delete_Workshops_By_CURRENCY_ID oParams_Delete_Workshops_By_CURRENCY_ID = new Params_Delete_Workshops_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshops_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Workshops
//---------------------------------
oParams_Delete_Workshops_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Workshops_By_CURRENCY_ID(oParams_Delete_Workshops_By_CURRENCY_ID);
//---------------------------------
// Edit Workshops
//---------------------------------
Edit_Currency_WithWorkshops(i_Currency, i_Workshops_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshops_By_Currency");}
}
#endregion
#region Reset_Workshops_By_Currency
public void Reset_Workshops_By_Currency(Currency i_Currency, List<Workshops> i_Workshops_List_To_Delete,List<Workshops> i_Workshops_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Workshops oParams_Delete_Workshops = new Params_Delete_Workshops();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshops_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Workshops_List_To_Delete != null)
{
foreach (var oRow in i_Workshops_List_To_Delete)
{
oParams_Delete_Workshops.WORKSHOPS_ID = oRow.WORKSHOPS_ID;
Delete_Workshops(oParams_Delete_Workshops);
}
}
//---------------------------------
// Edit Workshops
//---------------------------------
Edit_Currency_WithWorkshops(i_Currency, i_Workshops_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshops_By_Currency");}
}
#endregion
#region Edit_Currency_With_Workshops(Currency i_Currency,List<Workshops> i_WorkshopsList)
public void Edit_Currency_WithWorkshops(Currency i_Currency,List<Workshops> i_List_Workshops)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithWorkshops");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Workshops != null)
{
foreach(Workshops oWorkshops in i_List_Workshops)
{
oWorkshops.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Workshops(oWorkshops);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithWorkshops");}
}
#endregion
#region Edit_Currency_WithRelatedData(Currency i_Currency,List<Conversions> i_List_Conversions,List<Coupons> i_List_Coupons,List<Fees> i_List_Fees,List<Salary> i_List_Salary,List<Staff> i_List_Staff,List<Supplier> i_List_Supplier,List<Transaction> i_List_Transaction,List<Workshop> i_List_Workshop,List<Workshops> i_List_Workshops)
public void Edit_Currency_WithRelatedData(Currency i_Currency,List<Conversions> i_List_Conversions,List<Coupons> i_List_Coupons,List<Fees> i_List_Fees,List<Salary> i_List_Salary,List<Staff> i_List_Staff,List<Supplier> i_List_Supplier,List<Transaction> i_List_Transaction,List<Workshop> i_List_Workshop,List<Workshops> i_List_Workshops)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Conversions != null)
{
foreach(Conversions oConversions in i_List_Conversions)
{
oConversions.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Conversions(oConversions);
}
}
if (i_List_Coupons != null)
{
foreach(Coupons oCoupons in i_List_Coupons)
{
oCoupons.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Coupons(oCoupons);
}
}
if (i_List_Fees != null)
{
foreach(Fees oFees in i_List_Fees)
{
oFees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Fees(oFees);
}
}
if (i_List_Salary != null)
{
foreach(Salary oSalary in i_List_Salary)
{
oSalary.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Salary(oSalary);
}
}
if (i_List_Staff != null)
{
foreach(Staff oStaff in i_List_Staff)
{
oStaff.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Staff(oStaff);
}
}
if (i_List_Supplier != null)
{
foreach(Supplier oSupplier in i_List_Supplier)
{
oSupplier.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Supplier(oSupplier);
}
}
if (i_List_Transaction != null)
{
foreach(Transaction oTransaction in i_List_Transaction)
{
oTransaction.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Transaction(oTransaction);
}
}
if (i_List_Workshop != null)
{
foreach(Workshop oWorkshop in i_List_Workshop)
{
oWorkshop.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Workshop(oWorkshop);
}
}
if (i_List_Workshops != null)
{
foreach(Workshops oWorkshops in i_List_Workshops)
{
oWorkshops.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Workshops(oWorkshops);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithRelatedData");}
}
#endregion
#region Delete_Currency_With_Children(Currency i_Currency)
public void Delete_Currency_With_Children(Currency i_Currency)
{
 #region Declaration And Initialization Section.
Params_Delete_Currency oParams_Delete_Currency = new Params_Delete_Currency();
Params_Delete_Conversions_By_CURRENCY_ID oParams_Delete_Conversions_By_CURRENCY_ID = new Params_Delete_Conversions_By_CURRENCY_ID();
Params_Delete_Coupons_By_CURRENCY_ID oParams_Delete_Coupons_By_CURRENCY_ID = new Params_Delete_Coupons_By_CURRENCY_ID();
Params_Delete_Fees_By_CURRENCY_ID oParams_Delete_Fees_By_CURRENCY_ID = new Params_Delete_Fees_By_CURRENCY_ID();
Params_Delete_Salary_By_CURRENCY_ID oParams_Delete_Salary_By_CURRENCY_ID = new Params_Delete_Salary_By_CURRENCY_ID();
Params_Delete_Staff_By_CURRENCY_ID oParams_Delete_Staff_By_CURRENCY_ID = new Params_Delete_Staff_By_CURRENCY_ID();
Params_Delete_Supplier_By_CURRENCY_ID oParams_Delete_Supplier_By_CURRENCY_ID = new Params_Delete_Supplier_By_CURRENCY_ID();
Params_Delete_Transaction_By_CURRENCY_ID oParams_Delete_Transaction_By_CURRENCY_ID = new Params_Delete_Transaction_By_CURRENCY_ID();
Params_Delete_Workshop_By_CURRENCY_ID oParams_Delete_Workshop_By_CURRENCY_ID = new Params_Delete_Workshop_By_CURRENCY_ID();
Params_Delete_Workshops_By_CURRENCY_ID oParams_Delete_Workshops_By_CURRENCY_ID = new Params_Delete_Workshops_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Currency_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Conversions_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Conversions_By_CURRENCY_ID(oParams_Delete_Conversions_By_CURRENCY_ID);
oParams_Delete_Coupons_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Coupons_By_CURRENCY_ID(oParams_Delete_Coupons_By_CURRENCY_ID);
oParams_Delete_Fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Fees_By_CURRENCY_ID(oParams_Delete_Fees_By_CURRENCY_ID);
oParams_Delete_Salary_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Salary_By_CURRENCY_ID(oParams_Delete_Salary_By_CURRENCY_ID);
oParams_Delete_Staff_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Staff_By_CURRENCY_ID(oParams_Delete_Staff_By_CURRENCY_ID);
oParams_Delete_Supplier_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Supplier_By_CURRENCY_ID(oParams_Delete_Supplier_By_CURRENCY_ID);
oParams_Delete_Transaction_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Transaction_By_CURRENCY_ID(oParams_Delete_Transaction_By_CURRENCY_ID);
oParams_Delete_Workshop_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Workshop_By_CURRENCY_ID(oParams_Delete_Workshop_By_CURRENCY_ID);
oParams_Delete_Workshops_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Workshops_By_CURRENCY_ID(oParams_Delete_Workshops_By_CURRENCY_ID);
//-------------------------

//-------------------------
oParams_Delete_Currency.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Currency(oParams_Delete_Currency);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Currency_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Address(Loc_l1 i_Loc_l1,List<Address> i_AddressList)
public void Edit_Loc_l1_WithAddress(Loc_l1 i_Loc_l1,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithAddress");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l2
//---------------------------------
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List_To_Delete,List<Loc_l2> i_Loc_l2_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l2_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l2_List_To_Delete)
{
oParams_Delete_Loc_l2.LOC_L2_ID = oRow.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
}
}
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Loc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_Loc_l2List)
public void Edit_Loc_l1_WithLoc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithLoc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithLoc_l2");}
}
#endregion
#region Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
public void Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithRelatedData");}
}
#endregion
#region Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
public void Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l1 oParams_Delete_Loc_l1 = new Params_Delete_Loc_l1();
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l1.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l1(oParams_Delete_Loc_l1);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Address(Loc_l2 i_Loc_l2,List<Address> i_AddressList)
public void Edit_Loc_l2_WithAddress(Loc_l2 i_Loc_l2,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithAddress");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l3
//---------------------------------
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List_To_Delete,List<Loc_l3> i_Loc_l3_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l3_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l3_List_To_Delete)
{
oParams_Delete_Loc_l3.LOC_L3_ID = oRow.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
}
}
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Loc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_Loc_l3List)
public void Edit_Loc_l2_WithLoc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithLoc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithLoc_l3");}
}
#endregion
#region Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
public void Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithRelatedData");}
}
#endregion
#region Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
public void Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l2.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Address(Loc_l3 i_Loc_l3,List<Address> i_AddressList)
public void Edit_Loc_l3_WithAddress(Loc_l3 i_Loc_l3,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithAddress");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l4
//---------------------------------
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List_To_Delete,List<Loc_l4> i_Loc_l4_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l4_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l4_List_To_Delete)
{
oParams_Delete_Loc_l4.LOC_L4_ID = oRow.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
}
}
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Loc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_Loc_l4List)
public void Edit_Loc_l3_WithLoc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithLoc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithLoc_l4");}
}
#endregion
#region Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
public void Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithRelatedData");}
}
#endregion
#region Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
public void Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l3.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Edit_Loc_l4_With_Address(Loc_l4 i_Loc_l4,List<Address> i_AddressList)
public void Edit_Loc_l4_WithAddress(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithAddress");}
}
#endregion
#region Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
public void Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithRelatedData");}
}
#endregion
#region Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
public void Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l4.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_With_Children");}
}
#endregion
#region Reset_Workshop_By_Machine
public void Reset_Workshop_By_Machine(Machine i_Machine, List<Workshop> i_Workshop_List)
{
#region Declaration And Initialization Section.
Params_Delete_Workshop_By_MACHINE_ID oParams_Delete_Workshop_By_MACHINE_ID = new Params_Delete_Workshop_By_MACHINE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshop_By_Machine");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Workshop
//---------------------------------
oParams_Delete_Workshop_By_MACHINE_ID.MACHINE_ID = i_Machine.MACHINE_ID;
Delete_Workshop_By_MACHINE_ID(oParams_Delete_Workshop_By_MACHINE_ID);
//---------------------------------
// Edit Workshop
//---------------------------------
Edit_Machine_WithWorkshop(i_Machine, i_Workshop_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshop_By_Machine");}
}
#endregion
#region Reset_Workshop_By_Machine
public void Reset_Workshop_By_Machine(Machine i_Machine, List<Workshop> i_Workshop_List_To_Delete,List<Workshop> i_Workshop_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Workshop oParams_Delete_Workshop = new Params_Delete_Workshop();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshop_By_Machine");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Workshop_List_To_Delete != null)
{
foreach (var oRow in i_Workshop_List_To_Delete)
{
oParams_Delete_Workshop.WORKSHOP_ID = oRow.WORKSHOP_ID;
Delete_Workshop(oParams_Delete_Workshop);
}
}
//---------------------------------
// Edit Workshop
//---------------------------------
Edit_Machine_WithWorkshop(i_Machine, i_Workshop_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshop_By_Machine");}
}
#endregion
#region Edit_Machine_With_Workshop(Machine i_Machine,List<Workshop> i_WorkshopList)
public void Edit_Machine_WithWorkshop(Machine i_Machine,List<Workshop> i_List_Workshop)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Machine_WithWorkshop");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Machine(i_Machine);
if (i_List_Workshop != null)
{
foreach(Workshop oWorkshop in i_List_Workshop)
{
oWorkshop.MACHINE_ID = i_Machine.MACHINE_ID;
Edit_Workshop(oWorkshop);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Machine_WithWorkshop");}
}
#endregion
#region Reset_Workshops_By_Machine
public void Reset_Workshops_By_Machine(Machine i_Machine, List<Workshops> i_Workshops_List)
{
#region Declaration And Initialization Section.
Params_Delete_Workshops_By_MACHINE_ID oParams_Delete_Workshops_By_MACHINE_ID = new Params_Delete_Workshops_By_MACHINE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshops_By_Machine");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Workshops
//---------------------------------
oParams_Delete_Workshops_By_MACHINE_ID.MACHINE_ID = i_Machine.MACHINE_ID;
Delete_Workshops_By_MACHINE_ID(oParams_Delete_Workshops_By_MACHINE_ID);
//---------------------------------
// Edit Workshops
//---------------------------------
Edit_Machine_WithWorkshops(i_Machine, i_Workshops_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshops_By_Machine");}
}
#endregion
#region Reset_Workshops_By_Machine
public void Reset_Workshops_By_Machine(Machine i_Machine, List<Workshops> i_Workshops_List_To_Delete,List<Workshops> i_Workshops_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Workshops oParams_Delete_Workshops = new Params_Delete_Workshops();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshops_By_Machine");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Workshops_List_To_Delete != null)
{
foreach (var oRow in i_Workshops_List_To_Delete)
{
oParams_Delete_Workshops.WORKSHOPS_ID = oRow.WORKSHOPS_ID;
Delete_Workshops(oParams_Delete_Workshops);
}
}
//---------------------------------
// Edit Workshops
//---------------------------------
Edit_Machine_WithWorkshops(i_Machine, i_Workshops_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshops_By_Machine");}
}
#endregion
#region Edit_Machine_With_Workshops(Machine i_Machine,List<Workshops> i_WorkshopsList)
public void Edit_Machine_WithWorkshops(Machine i_Machine,List<Workshops> i_List_Workshops)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Machine_WithWorkshops");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Machine(i_Machine);
if (i_List_Workshops != null)
{
foreach(Workshops oWorkshops in i_List_Workshops)
{
oWorkshops.MACHINE_ID = i_Machine.MACHINE_ID;
Edit_Workshops(oWorkshops);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Machine_WithWorkshops");}
}
#endregion
#region Edit_Machine_WithRelatedData(Machine i_Machine,List<Workshop> i_List_Workshop,List<Workshops> i_List_Workshops)
public void Edit_Machine_WithRelatedData(Machine i_Machine,List<Workshop> i_List_Workshop,List<Workshops> i_List_Workshops)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Machine_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Machine(i_Machine);
if (i_List_Workshop != null)
{
foreach(Workshop oWorkshop in i_List_Workshop)
{
oWorkshop.MACHINE_ID = i_Machine.MACHINE_ID;
Edit_Workshop(oWorkshop);
}
}
if (i_List_Workshops != null)
{
foreach(Workshops oWorkshops in i_List_Workshops)
{
oWorkshops.MACHINE_ID = i_Machine.MACHINE_ID;
Edit_Workshops(oWorkshops);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Machine_WithRelatedData");}
}
#endregion
#region Delete_Machine_With_Children(Machine i_Machine)
public void Delete_Machine_With_Children(Machine i_Machine)
{
 #region Declaration And Initialization Section.
Params_Delete_Machine oParams_Delete_Machine = new Params_Delete_Machine();
Params_Delete_Workshop_By_MACHINE_ID oParams_Delete_Workshop_By_MACHINE_ID = new Params_Delete_Workshop_By_MACHINE_ID();
Params_Delete_Workshops_By_MACHINE_ID oParams_Delete_Workshops_By_MACHINE_ID = new Params_Delete_Workshops_By_MACHINE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Machine_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Workshop_By_MACHINE_ID.MACHINE_ID = i_Machine.MACHINE_ID;
Delete_Workshop_By_MACHINE_ID(oParams_Delete_Workshop_By_MACHINE_ID);
oParams_Delete_Workshops_By_MACHINE_ID.MACHINE_ID = i_Machine.MACHINE_ID;
Delete_Workshops_By_MACHINE_ID(oParams_Delete_Workshops_By_MACHINE_ID);
//-------------------------

//-------------------------
oParams_Delete_Machine.MACHINE_ID = i_Machine.MACHINE_ID;
Delete_Machine(oParams_Delete_Machine);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Machine_With_Children");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Edit_Person_With_Address(Person i_Person,List<Address> i_AddressList)
public void Edit_Person_WithAddress(Person i_Person,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithAddress");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List)
{
#region Declaration And Initialization Section.
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Contact
//---------------------------------
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List_To_Delete,List<Contact> i_Contact_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Contact oParams_Delete_Contact = new Params_Delete_Contact();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Contact_List_To_Delete != null)
{
foreach (var oRow in i_Contact_List_To_Delete)
{
oParams_Delete_Contact.CONTACT_ID = oRow.CONTACT_ID;
Delete_Contact(oParams_Delete_Contact);
}
}
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Edit_Person_With_Contact(Person i_Person,List<Contact> i_ContactList)
public void Edit_Person_WithContact(Person i_Person,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithContact");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithContact");}
}
#endregion
#region Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
public void Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithRelatedData");}
}
#endregion
#region Delete_Person_With_Children(Person i_Person)
public void Delete_Person_With_Children(Person i_Person)
{
 #region Declaration And Initialization Section.
Params_Delete_Person oParams_Delete_Person = new Params_Delete_Person();
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//-------------------------

//-------------------------
oParams_Delete_Person.PERSON_ID = i_Person.PERSON_ID;
Delete_Person(oParams_Delete_Person);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_With_Children");}
}
#endregion
#region Reset_Productdistribution_By_Staff
public void Reset_Productdistribution_By_Staff(Staff i_Staff, List<Productdistribution> i_Productdistribution_List)
{
#region Declaration And Initialization Section.
Params_Delete_Productdistribution_By_STAFF_ID oParams_Delete_Productdistribution_By_STAFF_ID = new Params_Delete_Productdistribution_By_STAFF_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Productdistribution_By_Staff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Productdistribution
//---------------------------------
oParams_Delete_Productdistribution_By_STAFF_ID.STAFF_ID = i_Staff.STAFF_ID;
Delete_Productdistribution_By_STAFF_ID(oParams_Delete_Productdistribution_By_STAFF_ID);
//---------------------------------
// Edit Productdistribution
//---------------------------------
Edit_Staff_WithProductdistribution(i_Staff, i_Productdistribution_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Productdistribution_By_Staff");}
}
#endregion
#region Reset_Productdistribution_By_Staff
public void Reset_Productdistribution_By_Staff(Staff i_Staff, List<Productdistribution> i_Productdistribution_List_To_Delete,List<Productdistribution> i_Productdistribution_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Productdistribution oParams_Delete_Productdistribution = new Params_Delete_Productdistribution();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Productdistribution_By_Staff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Productdistribution_List_To_Delete != null)
{
foreach (var oRow in i_Productdistribution_List_To_Delete)
{
oParams_Delete_Productdistribution.PRODUCTDISTRIBUTION_ID = oRow.PRODUCTDISTRIBUTION_ID;
Delete_Productdistribution(oParams_Delete_Productdistribution);
}
}
//---------------------------------
// Edit Productdistribution
//---------------------------------
Edit_Staff_WithProductdistribution(i_Staff, i_Productdistribution_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Productdistribution_By_Staff");}
}
#endregion
#region Edit_Staff_With_Productdistribution(Staff i_Staff,List<Productdistribution> i_ProductdistributionList)
public void Edit_Staff_WithProductdistribution(Staff i_Staff,List<Productdistribution> i_List_Productdistribution)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_WithProductdistribution");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Staff(i_Staff);
if (i_List_Productdistribution != null)
{
foreach(Productdistribution oProductdistribution in i_List_Productdistribution)
{
oProductdistribution.STAFF_ID = i_Staff.STAFF_ID;
Edit_Productdistribution(oProductdistribution);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_WithProductdistribution");}
}
#endregion
#region Reset_Salary_By_Staff
public void Reset_Salary_By_Staff(Staff i_Staff, List<Salary> i_Salary_List)
{
#region Declaration And Initialization Section.
Params_Delete_Salary_By_STAFF_ID oParams_Delete_Salary_By_STAFF_ID = new Params_Delete_Salary_By_STAFF_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Salary_By_Staff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Salary
//---------------------------------
oParams_Delete_Salary_By_STAFF_ID.STAFF_ID = i_Staff.STAFF_ID;
Delete_Salary_By_STAFF_ID(oParams_Delete_Salary_By_STAFF_ID);
//---------------------------------
// Edit Salary
//---------------------------------
Edit_Staff_WithSalary(i_Staff, i_Salary_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Salary_By_Staff");}
}
#endregion
#region Reset_Salary_By_Staff
public void Reset_Salary_By_Staff(Staff i_Staff, List<Salary> i_Salary_List_To_Delete,List<Salary> i_Salary_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Salary oParams_Delete_Salary = new Params_Delete_Salary();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Salary_By_Staff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Salary_List_To_Delete != null)
{
foreach (var oRow in i_Salary_List_To_Delete)
{
oParams_Delete_Salary.SALARY_ID = oRow.SALARY_ID;
Delete_Salary(oParams_Delete_Salary);
}
}
//---------------------------------
// Edit Salary
//---------------------------------
Edit_Staff_WithSalary(i_Staff, i_Salary_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Salary_By_Staff");}
}
#endregion
#region Edit_Staff_With_Salary(Staff i_Staff,List<Salary> i_SalaryList)
public void Edit_Staff_WithSalary(Staff i_Staff,List<Salary> i_List_Salary)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_WithSalary");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Staff(i_Staff);
if (i_List_Salary != null)
{
foreach(Salary oSalary in i_List_Salary)
{
oSalary.STAFF_ID = i_Staff.STAFF_ID;
Edit_Salary(oSalary);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_WithSalary");}
}
#endregion
#region Reset_Transaction_By_Staff
public void Reset_Transaction_By_Staff(Staff i_Staff, List<Transaction> i_Transaction_List)
{
#region Declaration And Initialization Section.
Params_Delete_Transaction_By_STAFF_ID oParams_Delete_Transaction_By_STAFF_ID = new Params_Delete_Transaction_By_STAFF_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Transaction_By_Staff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Transaction
//---------------------------------
oParams_Delete_Transaction_By_STAFF_ID.STAFF_ID = i_Staff.STAFF_ID;
Delete_Transaction_By_STAFF_ID(oParams_Delete_Transaction_By_STAFF_ID);
//---------------------------------
// Edit Transaction
//---------------------------------
Edit_Staff_WithTransaction(i_Staff, i_Transaction_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Transaction_By_Staff");}
}
#endregion
#region Reset_Transaction_By_Staff
public void Reset_Transaction_By_Staff(Staff i_Staff, List<Transaction> i_Transaction_List_To_Delete,List<Transaction> i_Transaction_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Transaction oParams_Delete_Transaction = new Params_Delete_Transaction();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Transaction_By_Staff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Transaction_List_To_Delete != null)
{
foreach (var oRow in i_Transaction_List_To_Delete)
{
oParams_Delete_Transaction.TRANSACTION_ID = oRow.TRANSACTION_ID;
Delete_Transaction(oParams_Delete_Transaction);
}
}
//---------------------------------
// Edit Transaction
//---------------------------------
Edit_Staff_WithTransaction(i_Staff, i_Transaction_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Transaction_By_Staff");}
}
#endregion
#region Edit_Staff_With_Transaction(Staff i_Staff,List<Transaction> i_TransactionList)
public void Edit_Staff_WithTransaction(Staff i_Staff,List<Transaction> i_List_Transaction)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_WithTransaction");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Staff(i_Staff);
if (i_List_Transaction != null)
{
foreach(Transaction oTransaction in i_List_Transaction)
{
oTransaction.STAFF_ID = i_Staff.STAFF_ID;
Edit_Transaction(oTransaction);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_WithTransaction");}
}
#endregion
#region Edit_Staff_WithRelatedData(Staff i_Staff,List<Productdistribution> i_List_Productdistribution,List<Salary> i_List_Salary,List<Transaction> i_List_Transaction)
public void Edit_Staff_WithRelatedData(Staff i_Staff,List<Productdistribution> i_List_Productdistribution,List<Salary> i_List_Salary,List<Transaction> i_List_Transaction)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Staff(i_Staff);
if (i_List_Productdistribution != null)
{
foreach(Productdistribution oProductdistribution in i_List_Productdistribution)
{
oProductdistribution.STAFF_ID = i_Staff.STAFF_ID;
Edit_Productdistribution(oProductdistribution);
}
}
if (i_List_Salary != null)
{
foreach(Salary oSalary in i_List_Salary)
{
oSalary.STAFF_ID = i_Staff.STAFF_ID;
Edit_Salary(oSalary);
}
}
if (i_List_Transaction != null)
{
foreach(Transaction oTransaction in i_List_Transaction)
{
oTransaction.STAFF_ID = i_Staff.STAFF_ID;
Edit_Transaction(oTransaction);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_WithRelatedData");}
}
#endregion
#region Delete_Staff_With_Children(Staff i_Staff)
public void Delete_Staff_With_Children(Staff i_Staff)
{
 #region Declaration And Initialization Section.
Params_Delete_Staff oParams_Delete_Staff = new Params_Delete_Staff();
Params_Delete_Productdistribution_By_STAFF_ID oParams_Delete_Productdistribution_By_STAFF_ID = new Params_Delete_Productdistribution_By_STAFF_ID();
Params_Delete_Salary_By_STAFF_ID oParams_Delete_Salary_By_STAFF_ID = new Params_Delete_Salary_By_STAFF_ID();
Params_Delete_Transaction_By_STAFF_ID oParams_Delete_Transaction_By_STAFF_ID = new Params_Delete_Transaction_By_STAFF_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Productdistribution_By_STAFF_ID.STAFF_ID = i_Staff.STAFF_ID;
Delete_Productdistribution_By_STAFF_ID(oParams_Delete_Productdistribution_By_STAFF_ID);
oParams_Delete_Salary_By_STAFF_ID.STAFF_ID = i_Staff.STAFF_ID;
Delete_Salary_By_STAFF_ID(oParams_Delete_Salary_By_STAFF_ID);
oParams_Delete_Transaction_By_STAFF_ID.STAFF_ID = i_Staff.STAFF_ID;
Delete_Transaction_By_STAFF_ID(oParams_Delete_Transaction_By_STAFF_ID);
//-------------------------

//-------------------------
oParams_Delete_Staff.STAFF_ID = i_Staff.STAFF_ID;
Delete_Staff(oParams_Delete_Staff);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_With_Children");}
}
#endregion
#region Reset_Industry_By_Stock
public void Reset_Industry_By_Stock(Stock i_Stock, List<Industry> i_Industry_List)
{
#region Declaration And Initialization Section.
Params_Delete_Industry_By_STOCK_ID oParams_Delete_Industry_By_STOCK_ID = new Params_Delete_Industry_By_STOCK_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Industry_By_Stock");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Industry
//---------------------------------
oParams_Delete_Industry_By_STOCK_ID.STOCK_ID = i_Stock.STOCK_ID;
Delete_Industry_By_STOCK_ID(oParams_Delete_Industry_By_STOCK_ID);
//---------------------------------
// Edit Industry
//---------------------------------
Edit_Stock_WithIndustry(i_Stock, i_Industry_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Industry_By_Stock");}
}
#endregion
#region Reset_Industry_By_Stock
public void Reset_Industry_By_Stock(Stock i_Stock, List<Industry> i_Industry_List_To_Delete,List<Industry> i_Industry_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Industry oParams_Delete_Industry = new Params_Delete_Industry();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Industry_By_Stock");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Industry_List_To_Delete != null)
{
foreach (var oRow in i_Industry_List_To_Delete)
{
oParams_Delete_Industry.INDUSTRY_ID = oRow.INDUSTRY_ID;
Delete_Industry(oParams_Delete_Industry);
}
}
//---------------------------------
// Edit Industry
//---------------------------------
Edit_Stock_WithIndustry(i_Stock, i_Industry_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Industry_By_Stock");}
}
#endregion
#region Edit_Stock_With_Industry(Stock i_Stock,List<Industry> i_IndustryList)
public void Edit_Stock_WithIndustry(Stock i_Stock,List<Industry> i_List_Industry)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Stock_WithIndustry");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Stock(i_Stock);
if (i_List_Industry != null)
{
foreach(Industry oIndustry in i_List_Industry)
{
oIndustry.STOCK_ID = i_Stock.STOCK_ID;
Edit_Industry(oIndustry);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Stock_WithIndustry");}
}
#endregion
#region Reset_Supplier_By_Stock
public void Reset_Supplier_By_Stock(Stock i_Stock, List<Supplier> i_Supplier_List)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier_By_STOCK_ID oParams_Delete_Supplier_By_STOCK_ID = new Params_Delete_Supplier_By_STOCK_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_By_Stock");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Supplier
//---------------------------------
oParams_Delete_Supplier_By_STOCK_ID.STOCK_ID = i_Stock.STOCK_ID;
Delete_Supplier_By_STOCK_ID(oParams_Delete_Supplier_By_STOCK_ID);
//---------------------------------
// Edit Supplier
//---------------------------------
Edit_Stock_WithSupplier(i_Stock, i_Supplier_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_By_Stock");}
}
#endregion
#region Reset_Supplier_By_Stock
public void Reset_Supplier_By_Stock(Stock i_Stock, List<Supplier> i_Supplier_List_To_Delete,List<Supplier> i_Supplier_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier oParams_Delete_Supplier = new Params_Delete_Supplier();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_By_Stock");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Supplier_List_To_Delete != null)
{
foreach (var oRow in i_Supplier_List_To_Delete)
{
oParams_Delete_Supplier.SUPPLIER_ID = oRow.SUPPLIER_ID;
Delete_Supplier(oParams_Delete_Supplier);
}
}
//---------------------------------
// Edit Supplier
//---------------------------------
Edit_Stock_WithSupplier(i_Stock, i_Supplier_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_By_Stock");}
}
#endregion
#region Edit_Stock_With_Supplier(Stock i_Stock,List<Supplier> i_SupplierList)
public void Edit_Stock_WithSupplier(Stock i_Stock,List<Supplier> i_List_Supplier)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Stock_WithSupplier");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Stock(i_Stock);
if (i_List_Supplier != null)
{
foreach(Supplier oSupplier in i_List_Supplier)
{
oSupplier.STOCK_ID = i_Stock.STOCK_ID;
Edit_Supplier(oSupplier);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Stock_WithSupplier");}
}
#endregion
#region Reset_Workshop_By_Stock
public void Reset_Workshop_By_Stock(Stock i_Stock, List<Workshop> i_Workshop_List)
{
#region Declaration And Initialization Section.
Params_Delete_Workshop_By_STOCK_ID oParams_Delete_Workshop_By_STOCK_ID = new Params_Delete_Workshop_By_STOCK_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshop_By_Stock");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Workshop
//---------------------------------
oParams_Delete_Workshop_By_STOCK_ID.STOCK_ID = i_Stock.STOCK_ID;
Delete_Workshop_By_STOCK_ID(oParams_Delete_Workshop_By_STOCK_ID);
//---------------------------------
// Edit Workshop
//---------------------------------
Edit_Stock_WithWorkshop(i_Stock, i_Workshop_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshop_By_Stock");}
}
#endregion
#region Reset_Workshop_By_Stock
public void Reset_Workshop_By_Stock(Stock i_Stock, List<Workshop> i_Workshop_List_To_Delete,List<Workshop> i_Workshop_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Workshop oParams_Delete_Workshop = new Params_Delete_Workshop();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshop_By_Stock");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Workshop_List_To_Delete != null)
{
foreach (var oRow in i_Workshop_List_To_Delete)
{
oParams_Delete_Workshop.WORKSHOP_ID = oRow.WORKSHOP_ID;
Delete_Workshop(oParams_Delete_Workshop);
}
}
//---------------------------------
// Edit Workshop
//---------------------------------
Edit_Stock_WithWorkshop(i_Stock, i_Workshop_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshop_By_Stock");}
}
#endregion
#region Edit_Stock_With_Workshop(Stock i_Stock,List<Workshop> i_WorkshopList)
public void Edit_Stock_WithWorkshop(Stock i_Stock,List<Workshop> i_List_Workshop)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Stock_WithWorkshop");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Stock(i_Stock);
if (i_List_Workshop != null)
{
foreach(Workshop oWorkshop in i_List_Workshop)
{
oWorkshop.STOCK_ID = i_Stock.STOCK_ID;
Edit_Workshop(oWorkshop);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Stock_WithWorkshop");}
}
#endregion
#region Reset_Workshops_By_Stock
public void Reset_Workshops_By_Stock(Stock i_Stock, List<Workshops> i_Workshops_List)
{
#region Declaration And Initialization Section.
Params_Delete_Workshops_By_STOCK_ID oParams_Delete_Workshops_By_STOCK_ID = new Params_Delete_Workshops_By_STOCK_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshops_By_Stock");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Workshops
//---------------------------------
oParams_Delete_Workshops_By_STOCK_ID.STOCK_ID = i_Stock.STOCK_ID;
Delete_Workshops_By_STOCK_ID(oParams_Delete_Workshops_By_STOCK_ID);
//---------------------------------
// Edit Workshops
//---------------------------------
Edit_Stock_WithWorkshops(i_Stock, i_Workshops_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshops_By_Stock");}
}
#endregion
#region Reset_Workshops_By_Stock
public void Reset_Workshops_By_Stock(Stock i_Stock, List<Workshops> i_Workshops_List_To_Delete,List<Workshops> i_Workshops_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Workshops oParams_Delete_Workshops = new Params_Delete_Workshops();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Workshops_By_Stock");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Workshops_List_To_Delete != null)
{
foreach (var oRow in i_Workshops_List_To_Delete)
{
oParams_Delete_Workshops.WORKSHOPS_ID = oRow.WORKSHOPS_ID;
Delete_Workshops(oParams_Delete_Workshops);
}
}
//---------------------------------
// Edit Workshops
//---------------------------------
Edit_Stock_WithWorkshops(i_Stock, i_Workshops_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Workshops_By_Stock");}
}
#endregion
#region Edit_Stock_With_Workshops(Stock i_Stock,List<Workshops> i_WorkshopsList)
public void Edit_Stock_WithWorkshops(Stock i_Stock,List<Workshops> i_List_Workshops)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Stock_WithWorkshops");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Stock(i_Stock);
if (i_List_Workshops != null)
{
foreach(Workshops oWorkshops in i_List_Workshops)
{
oWorkshops.STOCK_ID = i_Stock.STOCK_ID;
Edit_Workshops(oWorkshops);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Stock_WithWorkshops");}
}
#endregion
#region Edit_Stock_WithRelatedData(Stock i_Stock,List<Industry> i_List_Industry,List<Supplier> i_List_Supplier,List<Workshop> i_List_Workshop,List<Workshops> i_List_Workshops)
public void Edit_Stock_WithRelatedData(Stock i_Stock,List<Industry> i_List_Industry,List<Supplier> i_List_Supplier,List<Workshop> i_List_Workshop,List<Workshops> i_List_Workshops)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Stock_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Stock(i_Stock);
if (i_List_Industry != null)
{
foreach(Industry oIndustry in i_List_Industry)
{
oIndustry.STOCK_ID = i_Stock.STOCK_ID;
Edit_Industry(oIndustry);
}
}
if (i_List_Supplier != null)
{
foreach(Supplier oSupplier in i_List_Supplier)
{
oSupplier.STOCK_ID = i_Stock.STOCK_ID;
Edit_Supplier(oSupplier);
}
}
if (i_List_Workshop != null)
{
foreach(Workshop oWorkshop in i_List_Workshop)
{
oWorkshop.STOCK_ID = i_Stock.STOCK_ID;
Edit_Workshop(oWorkshop);
}
}
if (i_List_Workshops != null)
{
foreach(Workshops oWorkshops in i_List_Workshops)
{
oWorkshops.STOCK_ID = i_Stock.STOCK_ID;
Edit_Workshops(oWorkshops);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Stock_WithRelatedData");}
}
#endregion
#region Delete_Stock_With_Children(Stock i_Stock)
public void Delete_Stock_With_Children(Stock i_Stock)
{
 #region Declaration And Initialization Section.
Params_Delete_Stock oParams_Delete_Stock = new Params_Delete_Stock();
Params_Delete_Industry_By_STOCK_ID oParams_Delete_Industry_By_STOCK_ID = new Params_Delete_Industry_By_STOCK_ID();
Params_Delete_Supplier_By_STOCK_ID oParams_Delete_Supplier_By_STOCK_ID = new Params_Delete_Supplier_By_STOCK_ID();
Params_Delete_Workshop_By_STOCK_ID oParams_Delete_Workshop_By_STOCK_ID = new Params_Delete_Workshop_By_STOCK_ID();
Params_Delete_Workshops_By_STOCK_ID oParams_Delete_Workshops_By_STOCK_ID = new Params_Delete_Workshops_By_STOCK_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Stock_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Industry_By_STOCK_ID.STOCK_ID = i_Stock.STOCK_ID;
Delete_Industry_By_STOCK_ID(oParams_Delete_Industry_By_STOCK_ID);
oParams_Delete_Supplier_By_STOCK_ID.STOCK_ID = i_Stock.STOCK_ID;
Delete_Supplier_By_STOCK_ID(oParams_Delete_Supplier_By_STOCK_ID);
oParams_Delete_Workshop_By_STOCK_ID.STOCK_ID = i_Stock.STOCK_ID;
Delete_Workshop_By_STOCK_ID(oParams_Delete_Workshop_By_STOCK_ID);
oParams_Delete_Workshops_By_STOCK_ID.STOCK_ID = i_Stock.STOCK_ID;
Delete_Workshops_By_STOCK_ID(oParams_Delete_Workshops_By_STOCK_ID);
//-------------------------

//-------------------------
oParams_Delete_Stock.STOCK_ID = i_Stock.STOCK_ID;
Delete_Stock(oParams_Delete_Stock);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Stock_With_Children");}
}
#endregion
#region Reset_Productdistribution_By_Supplier
public void Reset_Productdistribution_By_Supplier(Supplier i_Supplier, List<Productdistribution> i_Productdistribution_List)
{
#region Declaration And Initialization Section.
Params_Delete_Productdistribution_By_SUPPLIER_ID oParams_Delete_Productdistribution_By_SUPPLIER_ID = new Params_Delete_Productdistribution_By_SUPPLIER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Productdistribution_By_Supplier");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Productdistribution
//---------------------------------
oParams_Delete_Productdistribution_By_SUPPLIER_ID.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Delete_Productdistribution_By_SUPPLIER_ID(oParams_Delete_Productdistribution_By_SUPPLIER_ID);
//---------------------------------
// Edit Productdistribution
//---------------------------------
Edit_Supplier_WithProductdistribution(i_Supplier, i_Productdistribution_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Productdistribution_By_Supplier");}
}
#endregion
#region Reset_Productdistribution_By_Supplier
public void Reset_Productdistribution_By_Supplier(Supplier i_Supplier, List<Productdistribution> i_Productdistribution_List_To_Delete,List<Productdistribution> i_Productdistribution_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Productdistribution oParams_Delete_Productdistribution = new Params_Delete_Productdistribution();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Productdistribution_By_Supplier");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Productdistribution_List_To_Delete != null)
{
foreach (var oRow in i_Productdistribution_List_To_Delete)
{
oParams_Delete_Productdistribution.PRODUCTDISTRIBUTION_ID = oRow.PRODUCTDISTRIBUTION_ID;
Delete_Productdistribution(oParams_Delete_Productdistribution);
}
}
//---------------------------------
// Edit Productdistribution
//---------------------------------
Edit_Supplier_WithProductdistribution(i_Supplier, i_Productdistribution_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Productdistribution_By_Supplier");}
}
#endregion
#region Edit_Supplier_With_Productdistribution(Supplier i_Supplier,List<Productdistribution> i_ProductdistributionList)
public void Edit_Supplier_WithProductdistribution(Supplier i_Supplier,List<Productdistribution> i_List_Productdistribution)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_WithProductdistribution");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Supplier(i_Supplier);
if (i_List_Productdistribution != null)
{
foreach(Productdistribution oProductdistribution in i_List_Productdistribution)
{
oProductdistribution.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Edit_Productdistribution(oProductdistribution);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_WithProductdistribution");}
}
#endregion
#region Edit_Supplier_WithRelatedData(Supplier i_Supplier,List<Productdistribution> i_List_Productdistribution)
public void Edit_Supplier_WithRelatedData(Supplier i_Supplier,List<Productdistribution> i_List_Productdistribution)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Supplier(i_Supplier);
if (i_List_Productdistribution != null)
{
foreach(Productdistribution oProductdistribution in i_List_Productdistribution)
{
oProductdistribution.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Edit_Productdistribution(oProductdistribution);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_WithRelatedData");}
}
#endregion
#region Delete_Supplier_With_Children(Supplier i_Supplier)
public void Delete_Supplier_With_Children(Supplier i_Supplier)
{
 #region Declaration And Initialization Section.
Params_Delete_Supplier oParams_Delete_Supplier = new Params_Delete_Supplier();
Params_Delete_Productdistribution_By_SUPPLIER_ID oParams_Delete_Productdistribution_By_SUPPLIER_ID = new Params_Delete_Productdistribution_By_SUPPLIER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Productdistribution_By_SUPPLIER_ID.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Delete_Productdistribution_By_SUPPLIER_ID(oParams_Delete_Productdistribution_By_SUPPLIER_ID);
//-------------------------

//-------------------------
oParams_Delete_Supplier.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Delete_Supplier(oParams_Delete_Supplier);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_With_Children");}
}
#endregion
#region Reset_Machine_By_Workshop
public void Reset_Machine_By_Workshop(Workshop i_Workshop, List<Machine> i_Machine_List)
{
#region Declaration And Initialization Section.
Params_Delete_Machine_By_WORKSHOP_ID oParams_Delete_Machine_By_WORKSHOP_ID = new Params_Delete_Machine_By_WORKSHOP_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Machine_By_Workshop");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Machine
//---------------------------------
oParams_Delete_Machine_By_WORKSHOP_ID.WORKSHOP_ID = i_Workshop.WORKSHOP_ID;
Delete_Machine_By_WORKSHOP_ID(oParams_Delete_Machine_By_WORKSHOP_ID);
//---------------------------------
// Edit Machine
//---------------------------------
Edit_Workshop_WithMachine(i_Workshop, i_Machine_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Machine_By_Workshop");}
}
#endregion
#region Reset_Machine_By_Workshop
public void Reset_Machine_By_Workshop(Workshop i_Workshop, List<Machine> i_Machine_List_To_Delete,List<Machine> i_Machine_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Machine oParams_Delete_Machine = new Params_Delete_Machine();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Machine_By_Workshop");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Machine_List_To_Delete != null)
{
foreach (var oRow in i_Machine_List_To_Delete)
{
oParams_Delete_Machine.MACHINE_ID = oRow.MACHINE_ID;
Delete_Machine(oParams_Delete_Machine);
}
}
//---------------------------------
// Edit Machine
//---------------------------------
Edit_Workshop_WithMachine(i_Workshop, i_Machine_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Machine_By_Workshop");}
}
#endregion
#region Edit_Workshop_With_Machine(Workshop i_Workshop,List<Machine> i_MachineList)
public void Edit_Workshop_WithMachine(Workshop i_Workshop,List<Machine> i_List_Machine)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Workshop_WithMachine");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Workshop(i_Workshop);
if (i_List_Machine != null)
{
foreach(Machine oMachine in i_List_Machine)
{
oMachine.WORKSHOP_ID = i_Workshop.WORKSHOP_ID;
Edit_Machine(oMachine);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Workshop_WithMachine");}
}
#endregion
#region Reset_Staff_By_Workshop
public void Reset_Staff_By_Workshop(Workshop i_Workshop, List<Staff> i_Staff_List)
{
#region Declaration And Initialization Section.
Params_Delete_Staff_By_WORKSHOP_ID oParams_Delete_Staff_By_WORKSHOP_ID = new Params_Delete_Staff_By_WORKSHOP_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_By_Workshop");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Staff
//---------------------------------
oParams_Delete_Staff_By_WORKSHOP_ID.WORKSHOP_ID = i_Workshop.WORKSHOP_ID;
Delete_Staff_By_WORKSHOP_ID(oParams_Delete_Staff_By_WORKSHOP_ID);
//---------------------------------
// Edit Staff
//---------------------------------
Edit_Workshop_WithStaff(i_Workshop, i_Staff_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_By_Workshop");}
}
#endregion
#region Reset_Staff_By_Workshop
public void Reset_Staff_By_Workshop(Workshop i_Workshop, List<Staff> i_Staff_List_To_Delete,List<Staff> i_Staff_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Staff oParams_Delete_Staff = new Params_Delete_Staff();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_By_Workshop");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Staff_List_To_Delete != null)
{
foreach (var oRow in i_Staff_List_To_Delete)
{
oParams_Delete_Staff.STAFF_ID = oRow.STAFF_ID;
Delete_Staff(oParams_Delete_Staff);
}
}
//---------------------------------
// Edit Staff
//---------------------------------
Edit_Workshop_WithStaff(i_Workshop, i_Staff_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_By_Workshop");}
}
#endregion
#region Edit_Workshop_With_Staff(Workshop i_Workshop,List<Staff> i_StaffList)
public void Edit_Workshop_WithStaff(Workshop i_Workshop,List<Staff> i_List_Staff)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Workshop_WithStaff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Workshop(i_Workshop);
if (i_List_Staff != null)
{
foreach(Staff oStaff in i_List_Staff)
{
oStaff.WORKSHOP_ID = i_Workshop.WORKSHOP_ID;
Edit_Staff(oStaff);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Workshop_WithStaff");}
}
#endregion
#region Edit_Workshop_WithRelatedData(Workshop i_Workshop,List<Machine> i_List_Machine,List<Staff> i_List_Staff)
public void Edit_Workshop_WithRelatedData(Workshop i_Workshop,List<Machine> i_List_Machine,List<Staff> i_List_Staff)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Workshop_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Workshop(i_Workshop);
if (i_List_Machine != null)
{
foreach(Machine oMachine in i_List_Machine)
{
oMachine.WORKSHOP_ID = i_Workshop.WORKSHOP_ID;
Edit_Machine(oMachine);
}
}
if (i_List_Staff != null)
{
foreach(Staff oStaff in i_List_Staff)
{
oStaff.WORKSHOP_ID = i_Workshop.WORKSHOP_ID;
Edit_Staff(oStaff);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Workshop_WithRelatedData");}
}
#endregion
#region Delete_Workshop_With_Children(Workshop i_Workshop)
public void Delete_Workshop_With_Children(Workshop i_Workshop)
{
 #region Declaration And Initialization Section.
Params_Delete_Workshop oParams_Delete_Workshop = new Params_Delete_Workshop();
Params_Delete_Machine_By_WORKSHOP_ID oParams_Delete_Machine_By_WORKSHOP_ID = new Params_Delete_Machine_By_WORKSHOP_ID();
Params_Delete_Staff_By_WORKSHOP_ID oParams_Delete_Staff_By_WORKSHOP_ID = new Params_Delete_Staff_By_WORKSHOP_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshop_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Machine_By_WORKSHOP_ID.WORKSHOP_ID = i_Workshop.WORKSHOP_ID;
Delete_Machine_By_WORKSHOP_ID(oParams_Delete_Machine_By_WORKSHOP_ID);
oParams_Delete_Staff_By_WORKSHOP_ID.WORKSHOP_ID = i_Workshop.WORKSHOP_ID;
Delete_Staff_By_WORKSHOP_ID(oParams_Delete_Staff_By_WORKSHOP_ID);
//-------------------------

//-------------------------
oParams_Delete_Workshop.WORKSHOP_ID = i_Workshop.WORKSHOP_ID;
Delete_Workshop(oParams_Delete_Workshop);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshop_With_Children");}
}
#endregion
}
}
