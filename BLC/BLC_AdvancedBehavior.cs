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
public Address Get_Address_By_ADDRESS_ID_Adv(Params_Get_Address_By_ADDRESS_ID i_Params_Get_Address_By_ADDRESS_ID)
{
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_ADDRESS_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_ADDRESS_ID));}
#region Body Section.
DALC.Address oDBEntry = _AppContext.Get_Address_By_ADDRESS_ID_Adv(i_Params_Get_Address_By_ADDRESS_ID.ADDRESS_ID);
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_Adv");}
return oAddress;
}
public Contact Get_Contact_By_CONTACT_ID_Adv(Params_Get_Contact_By_CONTACT_ID i_Params_Get_Contact_By_CONTACT_ID)
{
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_CONTACT_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_CONTACT_ID));}
#region Body Section.
DALC.Contact oDBEntry = _AppContext.Get_Contact_By_CONTACT_ID_Adv(i_Params_Get_Contact_By_CONTACT_ID.CONTACT_ID);
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_Adv");}
return oContact;
}
public Conversions Get_Conversions_By_CONVERSIONS_ID_Adv(Params_Get_Conversions_By_CONVERSIONS_ID i_Params_Get_Conversions_By_CONVERSIONS_ID)
{
Conversions oConversions = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_CONVERSIONS_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_CONVERSIONS_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_CONVERSIONS_ID));}
#region Body Section.
DALC.Conversions oDBEntry = _AppContext.Get_Conversions_By_CONVERSIONS_ID_Adv(i_Params_Get_Conversions_By_CONVERSIONS_ID.CONVERSIONS_ID);
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_CONVERSIONS_ID_Adv");}
return oConversions;
}
public Coupons Get_Coupons_By_COUPONS_ID_Adv(Params_Get_Coupons_By_COUPONS_ID i_Params_Get_Coupons_By_COUPONS_ID)
{
Coupons oCoupons = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_COUPONS_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_COUPONS_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_COUPONS_ID));}
#region Body Section.
DALC.Coupons oDBEntry = _AppContext.Get_Coupons_By_COUPONS_ID_Adv(i_Params_Get_Coupons_By_COUPONS_ID.COUPONS_ID);
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_COUPONS_ID_Adv");}
return oCoupons;
}
public Currency Get_Currency_By_CURRENCY_ID_Adv(Params_Get_Currency_By_CURRENCY_ID i_Params_Get_Currency_By_CURRENCY_ID)
{
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_CURRENCY_ID));}
#region Body Section.
DALC.Currency oDBEntry = _AppContext.Get_Currency_By_CURRENCY_ID_Adv(i_Params_Get_Currency_By_CURRENCY_ID.CURRENCY_ID);
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID_Adv");}
return oCurrency;
}
public Fees Get_Fees_By_FEES_ID_Adv(Params_Get_Fees_By_FEES_ID i_Params_Get_Fees_By_FEES_ID)
{
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_FEES_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_FEES_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_FEES_ID));}
#region Body Section.
DALC.Fees oDBEntry = _AppContext.Get_Fees_By_FEES_ID_Adv(i_Params_Get_Fees_By_FEES_ID.FEES_ID);
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_FEES_ID_Adv");}
return oFees;
}
public Industry Get_Industry_By_INDUSTRY_ID_Adv(Params_Get_Industry_By_INDUSTRY_ID i_Params_Get_Industry_By_INDUSTRY_ID)
{
Industry oIndustry = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_INDUSTRY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_INDUSTRY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_INDUSTRY_ID));}
#region Body Section.
DALC.Industry oDBEntry = _AppContext.Get_Industry_By_INDUSTRY_ID_Adv(i_Params_Get_Industry_By_INDUSTRY_ID.INDUSTRY_ID);
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oIndustry.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oIndustry.My_Coupons);
oIndustry.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oIndustry.My_Stock);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_INDUSTRY_ID_Adv");}
return oIndustry;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv(Params_Get_Loc_l1_By_LOC_L1_ID i_Params_Get_Loc_l1_By_LOC_L1_ID)
{
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_LOC_L1_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_LOC_L1_ID));}
#region Body Section.
DALC.Loc_l1 oDBEntry = _AppContext.Get_Loc_l1_By_LOC_L1_ID_Adv(i_Params_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID);
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_Adv");}
return oLoc_l1;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv(Params_Get_Loc_l2_By_LOC_L2_ID i_Params_Get_Loc_l2_By_LOC_L2_ID)
{
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L2_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L2_ID));}
#region Body Section.
DALC.Loc_l2 oDBEntry = _AppContext.Get_Loc_l2_By_LOC_L2_ID_Adv(i_Params_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID);
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_Adv");}
return oLoc_l2;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv(Params_Get_Loc_l3_By_LOC_L3_ID i_Params_Get_Loc_l3_By_LOC_L3_ID)
{
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L3_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L3_ID));}
#region Body Section.
DALC.Loc_l3 oDBEntry = _AppContext.Get_Loc_l3_By_LOC_L3_ID_Adv(i_Params_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID);
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_Adv");}
return oLoc_l3;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv(Params_Get_Loc_l4_By_LOC_L4_ID i_Params_Get_Loc_l4_By_LOC_L4_ID)
{
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L4_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L4_ID));}
#region Body Section.
DALC.Loc_l4 oDBEntry = _AppContext.Get_Loc_l4_By_LOC_L4_ID_Adv(i_Params_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID);
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_Adv");}
return oLoc_l4;
}
public Machine Get_Machine_By_MACHINE_ID_Adv(Params_Get_Machine_By_MACHINE_ID i_Params_Get_Machine_By_MACHINE_ID)
{
Machine oMachine = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_MACHINE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_MACHINE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_MACHINE_ID));}
#region Body Section.
DALC.Machine oDBEntry = _AppContext.Get_Machine_By_MACHINE_ID_Adv(i_Params_Get_Machine_By_MACHINE_ID.MACHINE_ID);
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_MACHINE_ID_Adv");}
return oMachine;
}
public Method_run Get_Method_run_By_METHOD_RUN_ID_Adv(Params_Get_Method_run_By_METHOD_RUN_ID i_Params_Get_Method_run_By_METHOD_RUN_ID)
{
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_METHOD_RUN_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID));}
#region Body Section.
DALC.Method_run oDBEntry = _AppContext.Get_Method_run_By_METHOD_RUN_ID_Adv(i_Params_Get_Method_run_By_METHOD_RUN_ID.METHOD_RUN_ID);
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID_Adv");}
return oMethod_run;
}
public Person Get_Person_By_PERSON_ID_Adv(Params_Get_Person_By_PERSON_ID i_Params_Get_Person_By_PERSON_ID)
{
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_PERSON_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_PERSON_ID));}
#region Body Section.
DALC.Person oDBEntry = _AppContext.Get_Person_By_PERSON_ID_Adv(i_Params_Get_Person_By_PERSON_ID.PERSON_ID);
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_Adv");}
return oPerson;
}
public Productdistribution Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_Adv(Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID)
{
Productdistribution oProductdistribution = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID));}
#region Body Section.
DALC.Productdistribution oDBEntry = _AppContext.Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_Adv(i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID.PRODUCTDISTRIBUTION_ID);
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oProductdistribution.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oProductdistribution.My_Staff);
oProductdistribution.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oProductdistribution.My_Supplier);
oProductdistribution.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oProductdistribution.My_Coupons);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_Adv");}
return oProductdistribution;
}
public Salary Get_Salary_By_SALARY_ID_Adv(Params_Get_Salary_By_SALARY_ID i_Params_Get_Salary_By_SALARY_ID)
{
Salary oSalary = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_SALARY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_SALARY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_SALARY_ID));}
#region Body Section.
DALC.Salary oDBEntry = _AppContext.Get_Salary_By_SALARY_ID_Adv(i_Params_Get_Salary_By_SALARY_ID.SALARY_ID);
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_SALARY_ID_Adv");}
return oSalary;
}
public Staff Get_Staff_By_STAFF_ID_Adv(Params_Get_Staff_By_STAFF_ID i_Params_Get_Staff_By_STAFF_ID)
{
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_STAFF_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_STAFF_ID));}
#region Body Section.
DALC.Staff oDBEntry = _AppContext.Get_Staff_By_STAFF_ID_Adv(i_Params_Get_Staff_By_STAFF_ID.STAFF_ID);
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID_Adv");}
return oStaff;
}
public Stock Get_Stock_By_STOCK_ID_Adv(Params_Get_Stock_By_STOCK_ID i_Params_Get_Stock_By_STOCK_ID)
{
Stock oStock = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_STOCK_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_STOCK_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_STOCK_ID));}
#region Body Section.
DALC.Stock oDBEntry = _AppContext.Get_Stock_By_STOCK_ID_Adv(i_Params_Get_Stock_By_STOCK_ID.STOCK_ID);
oStock = new Stock();
oTools.CopyPropValues(oDBEntry, oStock);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_STOCK_ID_Adv");}
return oStock;
}
public Supplier Get_Supplier_By_SUPPLIER_ID_Adv(Params_Get_Supplier_By_SUPPLIER_ID i_Params_Get_Supplier_By_SUPPLIER_ID)
{
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_SUPPLIER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_SUPPLIER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_SUPPLIER_ID));}
#region Body Section.
DALC.Supplier oDBEntry = _AppContext.Get_Supplier_By_SUPPLIER_ID_Adv(i_Params_Get_Supplier_By_SUPPLIER_ID.SUPPLIER_ID);
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_SUPPLIER_ID_Adv");}
return oSupplier;
}
public Transaction Get_Transaction_By_TRANSACTION_ID_Adv(Params_Get_Transaction_By_TRANSACTION_ID i_Params_Get_Transaction_By_TRANSACTION_ID)
{
Transaction oTransaction = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_TRANSACTION_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_TRANSACTION_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_TRANSACTION_ID));}
#region Body Section.
DALC.Transaction oDBEntry = _AppContext.Get_Transaction_By_TRANSACTION_ID_Adv(i_Params_Get_Transaction_By_TRANSACTION_ID.TRANSACTION_ID);
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oTransaction.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oTransaction.My_Currency);
oTransaction.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oTransaction.My_Staff);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_TRANSACTION_ID_Adv");}
return oTransaction;
}
public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID));}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_Adv");}
return oUser;
}
public Workshop Get_Workshop_By_WORKSHOP_ID_Adv(Params_Get_Workshop_By_WORKSHOP_ID i_Params_Get_Workshop_By_WORKSHOP_ID)
{
Workshop oWorkshop = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_WORKSHOP_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_WORKSHOP_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_WORKSHOP_ID));}
#region Body Section.
DALC.Workshop oDBEntry = _AppContext.Get_Workshop_By_WORKSHOP_ID_Adv(i_Params_Get_Workshop_By_WORKSHOP_ID.WORKSHOP_ID);
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_WORKSHOP_ID_Adv");}
return oWorkshop;
}
public Workshops Get_Workshops_By_WORKSHOPS_ID_Adv(Params_Get_Workshops_By_WORKSHOPS_ID i_Params_Get_Workshops_By_WORKSHOPS_ID)
{
Workshops oWorkshops = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_WORKSHOPS_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_WORKSHOPS_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_WORKSHOPS_ID));}
#region Body Section.
DALC.Workshops oDBEntry = _AppContext.Get_Workshops_By_WORKSHOPS_ID_Adv(i_Params_Get_Workshops_By_WORKSHOPS_ID.WORKSHOPS_ID);
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_WORKSHOPS_ID_Adv");}
return oWorkshops;
}
public List<Address> Get_Address_By_ADDRESS_ID_List_Adv(Params_Get_Address_By_ADDRESS_ID_List i_Params_Get_Address_By_ADDRESS_ID_List)
{
Address oAddress = null;
List<Address> oList = new List<Address>();
Params_Get_Address_By_ADDRESS_ID_List_SP oParams_Get_Address_By_ADDRESS_ID_List_SP = new Params_Get_Address_By_ADDRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_ADDRESS_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_ADDRESS_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_ADDRESS_ID_List_Adv(i_Params_Get_Address_By_ADDRESS_ID_List.ADDRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_List_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List_Adv(Params_Get_Contact_By_CONTACT_ID_List i_Params_Get_Contact_By_CONTACT_ID_List)
{
Contact oContact = null;
List<Contact> oList = new List<Contact>();
Params_Get_Contact_By_CONTACT_ID_List_SP oParams_Get_Contact_By_CONTACT_ID_List_SP = new Params_Get_Contact_By_CONTACT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_CONTACT_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_CONTACT_ID_List));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_CONTACT_ID_List_Adv(i_Params_Get_Contact_By_CONTACT_ID_List.CONTACT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_List_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_CONVERSIONS_ID_List_Adv(Params_Get_Conversions_By_CONVERSIONS_ID_List i_Params_Get_Conversions_By_CONVERSIONS_ID_List)
{
Conversions oConversions = null;
List<Conversions> oList = new List<Conversions>();
Params_Get_Conversions_By_CONVERSIONS_ID_List_SP oParams_Get_Conversions_By_CONVERSIONS_ID_List_SP = new Params_Get_Conversions_By_CONVERSIONS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_CONVERSIONS_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_CONVERSIONS_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_CONVERSIONS_ID_List));}
#region Body Section.
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_CONVERSIONS_ID_List_Adv(i_Params_Get_Conversions_By_CONVERSIONS_ID_List.CONVERSIONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_CONVERSIONS_ID_List_Adv");}
return oList;
}
public List<Coupons> Get_Coupons_By_COUPONS_ID_List_Adv(Params_Get_Coupons_By_COUPONS_ID_List i_Params_Get_Coupons_By_COUPONS_ID_List)
{
Coupons oCoupons = null;
List<Coupons> oList = new List<Coupons>();
Params_Get_Coupons_By_COUPONS_ID_List_SP oParams_Get_Coupons_By_COUPONS_ID_List_SP = new Params_Get_Coupons_By_COUPONS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_COUPONS_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_COUPONS_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_COUPONS_ID_List));}
#region Body Section.
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_COUPONS_ID_List_Adv(i_Params_Get_Coupons_By_COUPONS_ID_List.COUPONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_COUPONS_ID_List_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List_Adv(Params_Get_Currency_By_CURRENCY_ID_List i_Params_Get_Currency_By_CURRENCY_ID_List)
{
Currency oCurrency = null;
List<Currency> oList = new List<Currency>();
Params_Get_Currency_By_CURRENCY_ID_List_SP oParams_Get_Currency_By_CURRENCY_ID_List_SP = new Params_Get_Currency_By_CURRENCY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_CURRENCY_ID_List_Adv(i_Params_Get_Currency_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_FEES_ID_List_Adv(Params_Get_Fees_By_FEES_ID_List i_Params_Get_Fees_By_FEES_ID_List)
{
Fees oFees = null;
List<Fees> oList = new List<Fees>();
Params_Get_Fees_By_FEES_ID_List_SP oParams_Get_Fees_By_FEES_ID_List_SP = new Params_Get_Fees_By_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_FEES_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_FEES_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_FEES_ID_List));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_FEES_ID_List_Adv(i_Params_Get_Fees_By_FEES_ID_List.FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_FEES_ID_List_Adv");}
return oList;
}
public List<Industry> Get_Industry_By_INDUSTRY_ID_List_Adv(Params_Get_Industry_By_INDUSTRY_ID_List i_Params_Get_Industry_By_INDUSTRY_ID_List)
{
Industry oIndustry = null;
List<Industry> oList = new List<Industry>();
Params_Get_Industry_By_INDUSTRY_ID_List_SP oParams_Get_Industry_By_INDUSTRY_ID_List_SP = new Params_Get_Industry_By_INDUSTRY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_INDUSTRY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_INDUSTRY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_INDUSTRY_ID_List));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_INDUSTRY_ID_List_Adv(i_Params_Get_Industry_By_INDUSTRY_ID_List.INDUSTRY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oIndustry.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oIndustry.My_Coupons);
oIndustry.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oIndustry.My_Stock);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_INDUSTRY_ID_List_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv(Params_Get_Loc_l1_By_LOC_L1_ID_List i_Params_Get_Loc_l1_By_LOC_L1_ID_List)
{
Loc_l1 oLoc_l1 = null;
List<Loc_l1> oList = new List<Loc_l1>();
Params_Get_Loc_l1_By_LOC_L1_ID_List_SP oParams_Get_Loc_l1_By_LOC_L1_ID_List_SP = new Params_Get_Loc_l1_By_LOC_L1_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_LOC_L1_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_LOC_L1_ID_List_Adv(i_Params_Get_Loc_l1_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv(Params_Get_Loc_l2_By_LOC_L2_ID_List i_Params_Get_Loc_l2_By_LOC_L2_ID_List)
{
Loc_l2 oLoc_l2 = null;
List<Loc_l2> oList = new List<Loc_l2>();
Params_Get_Loc_l2_By_LOC_L2_ID_List_SP oParams_Get_Loc_l2_By_LOC_L2_ID_List_SP = new Params_Get_Loc_l2_By_LOC_L2_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L2_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L2_ID_List_Adv(i_Params_Get_Loc_l2_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv(Params_Get_Loc_l3_By_LOC_L3_ID_List i_Params_Get_Loc_l3_By_LOC_L3_ID_List)
{
Loc_l3 oLoc_l3 = null;
List<Loc_l3> oList = new List<Loc_l3>();
Params_Get_Loc_l3_By_LOC_L3_ID_List_SP oParams_Get_Loc_l3_By_LOC_L3_ID_List_SP = new Params_Get_Loc_l3_By_LOC_L3_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L3_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L3_ID_List_Adv(i_Params_Get_Loc_l3_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv(Params_Get_Loc_l4_By_LOC_L4_ID_List i_Params_Get_Loc_l4_By_LOC_L4_ID_List)
{
Loc_l4 oLoc_l4 = null;
List<Loc_l4> oList = new List<Loc_l4>();
Params_Get_Loc_l4_By_LOC_L4_ID_List_SP oParams_Get_Loc_l4_By_LOC_L4_ID_List_SP = new Params_Get_Loc_l4_By_LOC_L4_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L4_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L4_ID_List));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L4_ID_List_Adv(i_Params_Get_Loc_l4_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_List_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_MACHINE_ID_List_Adv(Params_Get_Machine_By_MACHINE_ID_List i_Params_Get_Machine_By_MACHINE_ID_List)
{
Machine oMachine = null;
List<Machine> oList = new List<Machine>();
Params_Get_Machine_By_MACHINE_ID_List_SP oParams_Get_Machine_By_MACHINE_ID_List_SP = new Params_Get_Machine_By_MACHINE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_MACHINE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_MACHINE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_MACHINE_ID_List));}
#region Body Section.
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_MACHINE_ID_List_Adv(i_Params_Get_Machine_By_MACHINE_ID_List.MACHINE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_MACHINE_ID_List_Adv");}
return oList;
}
public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List_Adv(Params_Get_Method_run_By_METHOD_RUN_ID_List i_Params_Get_Method_run_By_METHOD_RUN_ID_List)
{
Method_run oMethod_run = null;
List<Method_run> oList = new List<Method_run>();
Params_Get_Method_run_By_METHOD_RUN_ID_List_SP oParams_Get_Method_run_By_METHOD_RUN_ID_List_SP = new Params_Get_Method_run_By_METHOD_RUN_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_METHOD_RUN_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID_List));}
#region Body Section.
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_METHOD_RUN_ID_List_Adv(i_Params_Get_Method_run_By_METHOD_RUN_ID_List.METHOD_RUN_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID_List_Adv");}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List_Adv(Params_Get_Person_By_PERSON_ID_List i_Params_Get_Person_By_PERSON_ID_List)
{
Person oPerson = null;
List<Person> oList = new List<Person>();
Params_Get_Person_By_PERSON_ID_List_SP oParams_Get_Person_By_PERSON_ID_List_SP = new Params_Get_Person_By_PERSON_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_PERSON_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_PERSON_ID_List_Adv(i_Params_Get_Person_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_Adv(Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List)
{
Productdistribution oProductdistribution = null;
List<Productdistribution> oList = new List<Productdistribution>();
Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_SP oParams_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_SP = new Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_Adv(i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List.PRODUCTDISTRIBUTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oProductdistribution.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oProductdistribution.My_Staff);
oProductdistribution.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oProductdistribution.My_Supplier);
oProductdistribution.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oProductdistribution.My_Coupons);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_SALARY_ID_List_Adv(Params_Get_Salary_By_SALARY_ID_List i_Params_Get_Salary_By_SALARY_ID_List)
{
Salary oSalary = null;
List<Salary> oList = new List<Salary>();
Params_Get_Salary_By_SALARY_ID_List_SP oParams_Get_Salary_By_SALARY_ID_List_SP = new Params_Get_Salary_By_SALARY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_SALARY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_SALARY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_SALARY_ID_List));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_SALARY_ID_List_Adv(i_Params_Get_Salary_By_SALARY_ID_List.SALARY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_SALARY_ID_List_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List_Adv(Params_Get_Staff_By_STAFF_ID_List i_Params_Get_Staff_By_STAFF_ID_List)
{
Staff oStaff = null;
List<Staff> oList = new List<Staff>();
Params_Get_Staff_By_STAFF_ID_List_SP oParams_Get_Staff_By_STAFF_ID_List_SP = new Params_Get_Staff_By_STAFF_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_STAFF_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_STAFF_ID_List_Adv(i_Params_Get_Staff_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID_List_Adv");}
return oList;
}
public List<Stock> Get_Stock_By_STOCK_ID_List_Adv(Params_Get_Stock_By_STOCK_ID_List i_Params_Get_Stock_By_STOCK_ID_List)
{
Stock oStock = null;
List<Stock> oList = new List<Stock>();
Params_Get_Stock_By_STOCK_ID_List_SP oParams_Get_Stock_By_STOCK_ID_List_SP = new Params_Get_Stock_By_STOCK_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_STOCK_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_STOCK_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Stock> oList_DBEntries = _AppContext.Get_Stock_By_STOCK_ID_List_Adv(i_Params_Get_Stock_By_STOCK_ID_List.STOCK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStock = new Stock();
oTools.CopyPropValues(oDBEntry, oStock);
oList.Add(oStock);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_STOCK_ID_List_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_SUPPLIER_ID_List_Adv(Params_Get_Supplier_By_SUPPLIER_ID_List i_Params_Get_Supplier_By_SUPPLIER_ID_List)
{
Supplier oSupplier = null;
List<Supplier> oList = new List<Supplier>();
Params_Get_Supplier_By_SUPPLIER_ID_List_SP oParams_Get_Supplier_By_SUPPLIER_ID_List_SP = new Params_Get_Supplier_By_SUPPLIER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_SUPPLIER_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_SUPPLIER_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_SUPPLIER_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_SUPPLIER_ID_List_Adv(i_Params_Get_Supplier_By_SUPPLIER_ID_List.SUPPLIER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_SUPPLIER_ID_List_Adv");}
return oList;
}
public List<Transaction> Get_Transaction_By_TRANSACTION_ID_List_Adv(Params_Get_Transaction_By_TRANSACTION_ID_List i_Params_Get_Transaction_By_TRANSACTION_ID_List)
{
Transaction oTransaction = null;
List<Transaction> oList = new List<Transaction>();
Params_Get_Transaction_By_TRANSACTION_ID_List_SP oParams_Get_Transaction_By_TRANSACTION_ID_List_SP = new Params_Get_Transaction_By_TRANSACTION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_TRANSACTION_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_TRANSACTION_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_TRANSACTION_ID_List));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_TRANSACTION_ID_List_Adv(i_Params_Get_Transaction_By_TRANSACTION_ID_List.TRANSACTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oTransaction.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oTransaction.My_Currency);
oTransaction.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oTransaction.My_Staff);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_TRANSACTION_ID_List_Adv");}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USER_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_WORKSHOP_ID_List_Adv(Params_Get_Workshop_By_WORKSHOP_ID_List i_Params_Get_Workshop_By_WORKSHOP_ID_List)
{
Workshop oWorkshop = null;
List<Workshop> oList = new List<Workshop>();
Params_Get_Workshop_By_WORKSHOP_ID_List_SP oParams_Get_Workshop_By_WORKSHOP_ID_List_SP = new Params_Get_Workshop_By_WORKSHOP_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_WORKSHOP_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_WORKSHOP_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_WORKSHOP_ID_List));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_WORKSHOP_ID_List_Adv(i_Params_Get_Workshop_By_WORKSHOP_ID_List.WORKSHOP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_WORKSHOP_ID_List_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_WORKSHOPS_ID_List_Adv(Params_Get_Workshops_By_WORKSHOPS_ID_List i_Params_Get_Workshops_By_WORKSHOPS_ID_List)
{
Workshops oWorkshops = null;
List<Workshops> oList = new List<Workshops>();
Params_Get_Workshops_By_WORKSHOPS_ID_List_SP oParams_Get_Workshops_By_WORKSHOPS_ID_List_SP = new Params_Get_Workshops_By_WORKSHOPS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_WORKSHOPS_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_WORKSHOPS_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_WORKSHOPS_ID_List));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_WORKSHOPS_ID_List_Adv(i_Params_Get_Workshops_By_WORKSHOPS_ID_List.WORKSHOPS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_WORKSHOPS_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_Adv(Params_Get_Address_By_PERSON_ID i_Params_Get_Address_By_PERSON_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_Adv(i_Params_Get_Address_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_Adv(Params_Get_Address_By_LOC_L1_ID i_Params_Get_Address_By_LOC_L1_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L1_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L1_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_Adv(i_Params_Get_Address_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_Adv(Params_Get_Address_By_LOC_L2_ID i_Params_Get_Address_By_LOC_L2_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L2_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L2_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_Adv(i_Params_Get_Address_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_Adv(Params_Get_Address_By_LOC_L3_ID i_Params_Get_Address_By_LOC_L3_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L3_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L3_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_Adv(i_Params_Get_Address_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID_Adv(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_OWNER_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_OWNER_ID_Adv(i_Params_Get_Address_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_OWNER_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv(Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_Adv(Params_Get_Address_By_LOC_L4_ID i_Params_Get_Address_By_LOC_L4_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L4_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L4_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_Adv(i_Params_Get_Address_By_LOC_L4_ID.LOC_L4_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_Adv(Params_Get_Contact_By_PERSON_ID i_Params_Get_Contact_By_PERSON_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_Adv(i_Params_Get_Contact_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv(Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID_Adv(Params_Get_Contact_By_OWNER_ID i_Params_Get_Contact_By_OWNER_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_OWNER_ID));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_OWNER_ID_Adv(i_Params_Get_Contact_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_OWNER_ID_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_OWNER_ID_Adv(Params_Get_Conversions_By_OWNER_ID i_Params_Get_Conversions_By_OWNER_ID)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_OWNER_ID));}
#region Body Section.
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_OWNER_ID_Adv(i_Params_Get_Conversions_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_OWNER_ID_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_CURRENCY_ID_Adv(Params_Get_Conversions_By_CURRENCY_ID i_Params_Get_Conversions_By_CURRENCY_ID)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_CURRENCY_ID_Adv(i_Params_Get_Conversions_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Coupons> Get_Coupons_By_OWNER_ID_Adv(Params_Get_Coupons_By_OWNER_ID i_Params_Get_Coupons_By_OWNER_ID)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_OWNER_ID));}
#region Body Section.
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_OWNER_ID_Adv(i_Params_Get_Coupons_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_OWNER_ID_Adv");}
return oList;
}
public List<Coupons> Get_Coupons_By_CURRENCY_ID_Adv(Params_Get_Coupons_By_CURRENCY_ID i_Params_Get_Coupons_By_CURRENCY_ID)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_CURRENCY_ID_Adv(i_Params_Get_Coupons_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID_Adv(Params_Get_Currency_By_OWNER_ID i_Params_Get_Currency_By_OWNER_ID)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_OWNER_ID));}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_OWNER_ID_Adv(i_Params_Get_Currency_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_OWNER_ID_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_OWNER_ID_Adv(Params_Get_Fees_By_OWNER_ID i_Params_Get_Fees_By_OWNER_ID)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_OWNER_ID_Adv(i_Params_Get_Fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_OWNER_ID_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_Adv(Params_Get_Fees_By_CURRENCY_ID i_Params_Get_Fees_By_CURRENCY_ID)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_CURRENCY_ID_Adv(i_Params_Get_Fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Industry> Get_Industry_By_OWNER_ID_Adv(Params_Get_Industry_By_OWNER_ID i_Params_Get_Industry_By_OWNER_ID)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_OWNER_ID));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_OWNER_ID_Adv(i_Params_Get_Industry_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oIndustry.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oIndustry.My_Coupons);
oIndustry.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oIndustry.My_Stock);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_OWNER_ID_Adv");}
return oList;
}
public List<Industry> Get_Industry_By_COUPONS_ID_Adv(Params_Get_Industry_By_COUPONS_ID i_Params_Get_Industry_By_COUPONS_ID)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_COUPONS_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_COUPONS_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_COUPONS_ID));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_COUPONS_ID_Adv(i_Params_Get_Industry_By_COUPONS_ID.COUPONS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oIndustry.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oIndustry.My_Coupons);
oIndustry.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oIndustry.My_Stock);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_COUPONS_ID_Adv");}
return oList;
}
public List<Industry> Get_Industry_By_STOCK_ID_Adv(Params_Get_Industry_By_STOCK_ID i_Params_Get_Industry_By_STOCK_ID)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_STOCK_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_STOCK_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_STOCK_ID));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_STOCK_ID_Adv(i_Params_Get_Industry_By_STOCK_ID.STOCK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oIndustry.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oIndustry.My_Coupons);
oIndustry.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oIndustry.My_Stock);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_STOCK_ID_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE_Adv(Params_Get_Loc_l1_By_CODE i_Params_Get_Loc_l1_By_CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_CODE));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_CODE_Adv(i_Params_Get_Loc_l1_By_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_CODE_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv(Params_Get_Loc_l1_By_OWNER_ID i_Params_Get_Loc_l1_By_OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_OWNER_ID_Adv(i_Params_Get_Loc_l1_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv(Params_Get_Loc_l2_By_LOC_L1_ID_CODE i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_CODE_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv(Params_Get_Loc_l2_By_LOC_L1_ID i_Params_Get_Loc_l2_By_LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv(Params_Get_Loc_l2_By_OWNER_ID i_Params_Get_Loc_l2_By_OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_OWNER_ID_Adv(i_Params_Get_Loc_l2_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv(Params_Get_Loc_l3_By_LOC_L2_ID_CODE i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_CODE_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv(Params_Get_Loc_l3_By_LOC_L2_ID i_Params_Get_Loc_l3_By_LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv(Params_Get_Loc_l3_By_OWNER_ID i_Params_Get_Loc_l3_By_OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_OWNER_ID_Adv(i_Params_Get_Loc_l3_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv(Params_Get_Loc_l4_By_LOC_L3_ID_CODE i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_CODE_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv(Params_Get_Loc_l4_By_LOC_L3_ID i_Params_Get_Loc_l4_By_LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv(Params_Get_Loc_l4_By_OWNER_ID i_Params_Get_Loc_l4_By_OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_OWNER_ID_Adv(i_Params_Get_Loc_l4_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_OWNER_ID_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_OWNER_ID_Adv(Params_Get_Machine_By_OWNER_ID i_Params_Get_Machine_By_OWNER_ID)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_OWNER_ID));}
#region Body Section.
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_OWNER_ID_Adv(i_Params_Get_Machine_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_OWNER_ID_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_WORKSHOP_ID_Adv(Params_Get_Machine_By_WORKSHOP_ID i_Params_Get_Machine_By_WORKSHOP_ID)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_WORKSHOP_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_WORKSHOP_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_WORKSHOP_ID));}
#region Body Section.
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_WORKSHOP_ID_Adv(i_Params_Get_Machine_By_WORKSHOP_ID.WORKSHOP_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_WORKSHOP_ID_Adv");}
return oList;
}
public List<Method_run> Get_Method_run_By_OWNER_ID_Adv(Params_Get_Method_run_By_OWNER_ID i_Params_Get_Method_run_By_OWNER_ID)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_OWNER_ID));}
#region Body Section.
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_OWNER_ID_Adv(i_Params_Get_Method_run_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_OWNER_ID_Adv");}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID_Adv(Params_Get_Person_By_OWNER_ID i_Params_Get_Person_By_OWNER_ID)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_OWNER_ID));}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_OWNER_ID_Adv(i_Params_Get_Person_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_OWNER_ID_Adv");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_OWNER_ID_Adv(Params_Get_Productdistribution_By_OWNER_ID i_Params_Get_Productdistribution_By_OWNER_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_OWNER_ID));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_OWNER_ID_Adv(i_Params_Get_Productdistribution_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oProductdistribution.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oProductdistribution.My_Staff);
oProductdistribution.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oProductdistribution.My_Supplier);
oProductdistribution.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oProductdistribution.My_Coupons);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_OWNER_ID_Adv");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_STAFF_ID_Adv(Params_Get_Productdistribution_By_STAFF_ID i_Params_Get_Productdistribution_By_STAFF_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_STAFF_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_STAFF_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_STAFF_ID));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_STAFF_ID_Adv(i_Params_Get_Productdistribution_By_STAFF_ID.STAFF_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oProductdistribution.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oProductdistribution.My_Staff);
oProductdistribution.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oProductdistribution.My_Supplier);
oProductdistribution.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oProductdistribution.My_Coupons);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_STAFF_ID_Adv");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID_Adv(Params_Get_Productdistribution_By_SUPPLIER_ID i_Params_Get_Productdistribution_By_SUPPLIER_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_SUPPLIER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_SUPPLIER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_SUPPLIER_ID));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_SUPPLIER_ID_Adv(i_Params_Get_Productdistribution_By_SUPPLIER_ID.SUPPLIER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oProductdistribution.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oProductdistribution.My_Staff);
oProductdistribution.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oProductdistribution.My_Supplier);
oProductdistribution.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oProductdistribution.My_Coupons);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_SUPPLIER_ID_Adv");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_COUPONS_ID_Adv(Params_Get_Productdistribution_By_COUPONS_ID i_Params_Get_Productdistribution_By_COUPONS_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_COUPONS_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_COUPONS_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_COUPONS_ID));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_COUPONS_ID_Adv(i_Params_Get_Productdistribution_By_COUPONS_ID.COUPONS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oProductdistribution.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oProductdistribution.My_Staff);
oProductdistribution.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oProductdistribution.My_Supplier);
oProductdistribution.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oProductdistribution.My_Coupons);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_COUPONS_ID_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_OWNER_ID_Adv(Params_Get_Salary_By_OWNER_ID i_Params_Get_Salary_By_OWNER_ID)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_OWNER_ID));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_OWNER_ID_Adv(i_Params_Get_Salary_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_OWNER_ID_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_STAFF_ID_Adv(Params_Get_Salary_By_STAFF_ID i_Params_Get_Salary_By_STAFF_ID)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_STAFF_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_STAFF_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_STAFF_ID));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_STAFF_ID_Adv(i_Params_Get_Salary_By_STAFF_ID.STAFF_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_STAFF_ID_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_CURRENCY_ID_Adv(Params_Get_Salary_By_CURRENCY_ID i_Params_Get_Salary_By_CURRENCY_ID)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_CURRENCY_ID_Adv(i_Params_Get_Salary_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID_Adv(Params_Get_Staff_By_OWNER_ID i_Params_Get_Staff_By_OWNER_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_OWNER_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_OWNER_ID_Adv(i_Params_Get_Staff_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_OWNER_ID_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_WORKSHOP_ID_Adv(Params_Get_Staff_By_WORKSHOP_ID i_Params_Get_Staff_By_WORKSHOP_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_WORKSHOP_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_WORKSHOP_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_WORKSHOP_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_WORKSHOP_ID_Adv(i_Params_Get_Staff_By_WORKSHOP_ID.WORKSHOP_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_WORKSHOP_ID_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_CURRENCY_ID_Adv(Params_Get_Staff_By_CURRENCY_ID i_Params_Get_Staff_By_CURRENCY_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_CURRENCY_ID_Adv(i_Params_Get_Staff_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Stock> Get_Stock_By_OWNER_ID_Adv(Params_Get_Stock_By_OWNER_ID i_Params_Get_Stock_By_OWNER_ID)
{
List<Stock> oList = new List<Stock>();
Stock oStock = new Stock();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_OWNER_ID));}
#region Body Section.
List<DALC.Stock> oList_DBEntries = _AppContext.Get_Stock_By_OWNER_ID_Adv(i_Params_Get_Stock_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStock = new Stock();
oTools.CopyPropValues(oDBEntry, oStock);
oList.Add(oStock);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_OWNER_ID_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_OWNER_ID_Adv(Params_Get_Supplier_By_OWNER_ID i_Params_Get_Supplier_By_OWNER_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_OWNER_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_OWNER_ID_Adv(i_Params_Get_Supplier_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_OWNER_ID_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_COUPONS_ID_Adv(Params_Get_Supplier_By_COUPONS_ID i_Params_Get_Supplier_By_COUPONS_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_COUPONS_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_COUPONS_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_COUPONS_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_COUPONS_ID_Adv(i_Params_Get_Supplier_By_COUPONS_ID.COUPONS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_COUPONS_ID_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_CURRENCY_ID_Adv(Params_Get_Supplier_By_CURRENCY_ID i_Params_Get_Supplier_By_CURRENCY_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_CURRENCY_ID_Adv(i_Params_Get_Supplier_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_STOCK_ID_Adv(Params_Get_Supplier_By_STOCK_ID i_Params_Get_Supplier_By_STOCK_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_STOCK_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_STOCK_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_STOCK_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_STOCK_ID_Adv(i_Params_Get_Supplier_By_STOCK_ID.STOCK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_STOCK_ID_Adv");}
return oList;
}
public List<Transaction> Get_Transaction_By_OWNER_ID_Adv(Params_Get_Transaction_By_OWNER_ID i_Params_Get_Transaction_By_OWNER_ID)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_OWNER_ID));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_OWNER_ID_Adv(i_Params_Get_Transaction_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oTransaction.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oTransaction.My_Currency);
oTransaction.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oTransaction.My_Staff);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_OWNER_ID_Adv");}
return oList;
}
public List<Transaction> Get_Transaction_By_CURRENCY_ID_Adv(Params_Get_Transaction_By_CURRENCY_ID i_Params_Get_Transaction_By_CURRENCY_ID)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_CURRENCY_ID_Adv(i_Params_Get_Transaction_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oTransaction.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oTransaction.My_Currency);
oTransaction.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oTransaction.My_Staff);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Transaction> Get_Transaction_By_STAFF_ID_Adv(Params_Get_Transaction_By_STAFF_ID i_Params_Get_Transaction_By_STAFF_ID)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_STAFF_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_STAFF_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_STAFF_ID));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_STAFF_ID_Adv(i_Params_Get_Transaction_By_STAFF_ID.STAFF_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oTransaction.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oTransaction.My_Currency);
oTransaction.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oTransaction.My_Staff);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_STAFF_ID_Adv");}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID_Adv(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USERNAME_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USERNAME));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME_Adv(i_Params_Get_User_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_OWNER_ID_Adv(Params_Get_Workshop_By_OWNER_ID i_Params_Get_Workshop_By_OWNER_ID)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_OWNER_ID));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_OWNER_ID_Adv(i_Params_Get_Workshop_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_OWNER_ID_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_CURRENCY_ID_Adv(Params_Get_Workshop_By_CURRENCY_ID i_Params_Get_Workshop_By_CURRENCY_ID)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_CURRENCY_ID_Adv(i_Params_Get_Workshop_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_STOCK_ID_Adv(Params_Get_Workshop_By_STOCK_ID i_Params_Get_Workshop_By_STOCK_ID)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_STOCK_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_STOCK_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_STOCK_ID));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_STOCK_ID_Adv(i_Params_Get_Workshop_By_STOCK_ID.STOCK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_STOCK_ID_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_MACHINE_ID_Adv(Params_Get_Workshop_By_MACHINE_ID i_Params_Get_Workshop_By_MACHINE_ID)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_MACHINE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_MACHINE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_MACHINE_ID));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_MACHINE_ID_Adv(i_Params_Get_Workshop_By_MACHINE_ID.MACHINE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_MACHINE_ID_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_OWNER_ID_Adv(Params_Get_Workshops_By_OWNER_ID i_Params_Get_Workshops_By_OWNER_ID)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_OWNER_ID));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_OWNER_ID_Adv(i_Params_Get_Workshops_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_OWNER_ID_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_CURRENCY_ID_Adv(Params_Get_Workshops_By_CURRENCY_ID i_Params_Get_Workshops_By_CURRENCY_ID)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_CURRENCY_ID_Adv(i_Params_Get_Workshops_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_STOCK_ID_Adv(Params_Get_Workshops_By_STOCK_ID i_Params_Get_Workshops_By_STOCK_ID)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_STOCK_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_STOCK_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_STOCK_ID));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_STOCK_ID_Adv(i_Params_Get_Workshops_By_STOCK_ID.STOCK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_STOCK_ID_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_MACHINE_ID_Adv(Params_Get_Workshops_By_MACHINE_ID i_Params_Get_Workshops_By_MACHINE_ID)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_MACHINE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_MACHINE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_MACHINE_ID));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_MACHINE_ID_Adv(i_Params_Get_Workshops_By_MACHINE_ID.MACHINE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_MACHINE_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List_Adv(Params_Get_Address_By_PERSON_ID_List i_Params_Get_Address_By_PERSON_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_List_Adv(i_Params_Get_Address_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List_Adv(Params_Get_Address_By_LOC_L1_ID_List i_Params_Get_Address_By_LOC_L1_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L1_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_List_Adv(i_Params_Get_Address_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List_Adv(Params_Get_Address_By_LOC_L2_ID_List i_Params_Get_Address_By_LOC_L2_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L2_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_List_Adv(i_Params_Get_Address_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List_Adv(Params_Get_Address_By_LOC_L3_ID_List i_Params_Get_Address_By_LOC_L3_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L3_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_List_Adv(i_Params_Get_Address_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List_Adv(Params_Get_Address_By_LOC_L4_ID_List i_Params_Get_Address_By_LOC_L4_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L4_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L4_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_List_Adv(i_Params_Get_Address_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_List_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List_Adv(Params_Get_Contact_By_PERSON_ID_List i_Params_Get_Contact_By_PERSON_ID_List)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_List_Adv(i_Params_Get_Contact_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_CURRENCY_ID_List_Adv(Params_Get_Conversions_By_CURRENCY_ID_List i_Params_Get_Conversions_By_CURRENCY_ID_List)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_CURRENCY_ID_List_Adv(i_Params_Get_Conversions_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Coupons> Get_Coupons_By_CURRENCY_ID_List_Adv(Params_Get_Coupons_By_CURRENCY_ID_List i_Params_Get_Coupons_By_CURRENCY_ID_List)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_CURRENCY_ID_List_Adv(i_Params_Get_Coupons_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_List_Adv(Params_Get_Fees_By_CURRENCY_ID_List i_Params_Get_Fees_By_CURRENCY_ID_List)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_CURRENCY_ID_List_Adv(i_Params_Get_Fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Industry> Get_Industry_By_COUPONS_ID_List_Adv(Params_Get_Industry_By_COUPONS_ID_List i_Params_Get_Industry_By_COUPONS_ID_List)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_COUPONS_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_COUPONS_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_COUPONS_ID_List));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_COUPONS_ID_List_Adv(i_Params_Get_Industry_By_COUPONS_ID_List.COUPONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oIndustry.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oIndustry.My_Coupons);
oIndustry.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oIndustry.My_Stock);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_COUPONS_ID_List_Adv");}
return oList;
}
public List<Industry> Get_Industry_By_STOCK_ID_List_Adv(Params_Get_Industry_By_STOCK_ID_List i_Params_Get_Industry_By_STOCK_ID_List)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_STOCK_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_STOCK_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_STOCK_ID_List_Adv(i_Params_Get_Industry_By_STOCK_ID_List.STOCK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oIndustry.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oIndustry.My_Coupons);
oIndustry.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oIndustry.My_Stock);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_STOCK_ID_List_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv(Params_Get_Loc_l2_By_LOC_L1_ID_List i_Params_Get_Loc_l2_By_LOC_L1_ID_List)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_List_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv(Params_Get_Loc_l3_By_LOC_L2_ID_List i_Params_Get_Loc_l3_By_LOC_L2_ID_List)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_List_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv(Params_Get_Loc_l4_By_LOC_L3_ID_List i_Params_Get_Loc_l4_By_LOC_L3_ID_List)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_List_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_WORKSHOP_ID_List_Adv(Params_Get_Machine_By_WORKSHOP_ID_List i_Params_Get_Machine_By_WORKSHOP_ID_List)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_WORKSHOP_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_WORKSHOP_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_WORKSHOP_ID_List));}
#region Body Section.
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_WORKSHOP_ID_List_Adv(i_Params_Get_Machine_By_WORKSHOP_ID_List.WORKSHOP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_WORKSHOP_ID_List_Adv");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_STAFF_ID_List_Adv(Params_Get_Productdistribution_By_STAFF_ID_List i_Params_Get_Productdistribution_By_STAFF_ID_List)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_STAFF_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_STAFF_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_STAFF_ID_List_Adv(i_Params_Get_Productdistribution_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oProductdistribution.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oProductdistribution.My_Staff);
oProductdistribution.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oProductdistribution.My_Supplier);
oProductdistribution.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oProductdistribution.My_Coupons);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_STAFF_ID_List_Adv");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID_List_Adv(Params_Get_Productdistribution_By_SUPPLIER_ID_List i_Params_Get_Productdistribution_By_SUPPLIER_ID_List)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_SUPPLIER_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_SUPPLIER_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_SUPPLIER_ID_List));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_SUPPLIER_ID_List_Adv(i_Params_Get_Productdistribution_By_SUPPLIER_ID_List.SUPPLIER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oProductdistribution.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oProductdistribution.My_Staff);
oProductdistribution.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oProductdistribution.My_Supplier);
oProductdistribution.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oProductdistribution.My_Coupons);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_SUPPLIER_ID_List_Adv");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_COUPONS_ID_List_Adv(Params_Get_Productdistribution_By_COUPONS_ID_List i_Params_Get_Productdistribution_By_COUPONS_ID_List)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_COUPONS_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_COUPONS_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_COUPONS_ID_List));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_COUPONS_ID_List_Adv(i_Params_Get_Productdistribution_By_COUPONS_ID_List.COUPONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oProductdistribution.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oProductdistribution.My_Staff);
oProductdistribution.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oProductdistribution.My_Supplier);
oProductdistribution.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oProductdistribution.My_Coupons);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_COUPONS_ID_List_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_STAFF_ID_List_Adv(Params_Get_Salary_By_STAFF_ID_List i_Params_Get_Salary_By_STAFF_ID_List)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_STAFF_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_STAFF_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_STAFF_ID_List_Adv(i_Params_Get_Salary_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_STAFF_ID_List_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_CURRENCY_ID_List_Adv(Params_Get_Salary_By_CURRENCY_ID_List i_Params_Get_Salary_By_CURRENCY_ID_List)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_CURRENCY_ID_List_Adv(i_Params_Get_Salary_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_WORKSHOP_ID_List_Adv(Params_Get_Staff_By_WORKSHOP_ID_List i_Params_Get_Staff_By_WORKSHOP_ID_List)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_WORKSHOP_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_WORKSHOP_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_WORKSHOP_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_WORKSHOP_ID_List_Adv(i_Params_Get_Staff_By_WORKSHOP_ID_List.WORKSHOP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_WORKSHOP_ID_List_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_CURRENCY_ID_List_Adv(Params_Get_Staff_By_CURRENCY_ID_List i_Params_Get_Staff_By_CURRENCY_ID_List)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_CURRENCY_ID_List_Adv(i_Params_Get_Staff_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_COUPONS_ID_List_Adv(Params_Get_Supplier_By_COUPONS_ID_List i_Params_Get_Supplier_By_COUPONS_ID_List)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_COUPONS_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_COUPONS_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_COUPONS_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_COUPONS_ID_List_Adv(i_Params_Get_Supplier_By_COUPONS_ID_List.COUPONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_COUPONS_ID_List_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_CURRENCY_ID_List_Adv(Params_Get_Supplier_By_CURRENCY_ID_List i_Params_Get_Supplier_By_CURRENCY_ID_List)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_CURRENCY_ID_List_Adv(i_Params_Get_Supplier_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_STOCK_ID_List_Adv(Params_Get_Supplier_By_STOCK_ID_List i_Params_Get_Supplier_By_STOCK_ID_List)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_STOCK_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_STOCK_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_STOCK_ID_List_Adv(i_Params_Get_Supplier_By_STOCK_ID_List.STOCK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_STOCK_ID_List_Adv");}
return oList;
}
public List<Transaction> Get_Transaction_By_CURRENCY_ID_List_Adv(Params_Get_Transaction_By_CURRENCY_ID_List i_Params_Get_Transaction_By_CURRENCY_ID_List)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_CURRENCY_ID_List_Adv(i_Params_Get_Transaction_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oTransaction.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oTransaction.My_Currency);
oTransaction.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oTransaction.My_Staff);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Transaction> Get_Transaction_By_STAFF_ID_List_Adv(Params_Get_Transaction_By_STAFF_ID_List i_Params_Get_Transaction_By_STAFF_ID_List)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_STAFF_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_STAFF_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_STAFF_ID_List_Adv(i_Params_Get_Transaction_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oTransaction.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oTransaction.My_Currency);
oTransaction.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oTransaction.My_Staff);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_STAFF_ID_List_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_CURRENCY_ID_List_Adv(Params_Get_Workshop_By_CURRENCY_ID_List i_Params_Get_Workshop_By_CURRENCY_ID_List)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_CURRENCY_ID_List_Adv(i_Params_Get_Workshop_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_STOCK_ID_List_Adv(Params_Get_Workshop_By_STOCK_ID_List i_Params_Get_Workshop_By_STOCK_ID_List)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_STOCK_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_STOCK_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_STOCK_ID_List_Adv(i_Params_Get_Workshop_By_STOCK_ID_List.STOCK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_STOCK_ID_List_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_MACHINE_ID_List_Adv(Params_Get_Workshop_By_MACHINE_ID_List i_Params_Get_Workshop_By_MACHINE_ID_List)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_MACHINE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_MACHINE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_MACHINE_ID_List));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_MACHINE_ID_List_Adv(i_Params_Get_Workshop_By_MACHINE_ID_List.MACHINE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_MACHINE_ID_List_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_CURRENCY_ID_List_Adv(Params_Get_Workshops_By_CURRENCY_ID_List i_Params_Get_Workshops_By_CURRENCY_ID_List)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_CURRENCY_ID_List_Adv(i_Params_Get_Workshops_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_STOCK_ID_List_Adv(Params_Get_Workshops_By_STOCK_ID_List i_Params_Get_Workshops_By_STOCK_ID_List)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_STOCK_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_STOCK_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_STOCK_ID_List_Adv(i_Params_Get_Workshops_By_STOCK_ID_List.STOCK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_STOCK_ID_List_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_MACHINE_ID_List_Adv(Params_Get_Workshops_By_MACHINE_ID_List i_Params_Get_Workshops_By_MACHINE_ID_List)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_MACHINE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_MACHINE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_MACHINE_ID_List));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_MACHINE_ID_List_Adv(i_Params_Get_Workshops_By_MACHINE_ID_List.MACHINE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_MACHINE_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv(Params_Get_Address_By_Criteria i_Params_Get_Address_By_Criteria)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria.START_ROW == null) { i_Params_Get_Address_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria.END_ROW == null) || (i_Params_Get_Address_By_Criteria.END_ROW == 0)) { i_Params_Get_Address_By_Criteria.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_Adv(i_Params_Get_Address_By_Criteria.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria.STREET,i_Params_Get_Address_By_Criteria.BUILDING,i_Params_Get_Address_By_Criteria.FLOOR,i_Params_Get_Address_By_Criteria.POBOX,i_Params_Get_Address_By_Criteria.OWNER_ID,i_Params_Get_Address_By_Criteria.START_ROW,i_Params_Get_Address_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_Adv");}
return oList;
}
public List<Address> Get_Address_By_Where_Adv(Params_Get_Address_By_Where i_Params_Get_Address_By_Where)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where));}
#region Body Section.
if ((i_Params_Get_Address_By_Where.OWNER_ID == null) || (i_Params_Get_Address_By_Where.OWNER_ID == 0)) { i_Params_Get_Address_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where.START_ROW == null) { i_Params_Get_Address_By_Where.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where.END_ROW == null) || (i_Params_Get_Address_By_Where.END_ROW == 0)) { i_Params_Get_Address_By_Where.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_Adv(i_Params_Get_Address_By_Where.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where.STREET,i_Params_Get_Address_By_Where.BUILDING,i_Params_Get_Address_By_Where.FLOOR,i_Params_Get_Address_By_Where.POBOX,i_Params_Get_Address_By_Where.OWNER_ID,i_Params_Get_Address_By_Where.START_ROW,i_Params_Get_Address_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv_V2(Params_Get_Address_By_Criteria_V2 i_Params_Get_Address_By_Criteria_V2)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_Adv_V2(i_Params_Get_Address_By_Criteria_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_V2.STREET,i_Params_Get_Address_By_Criteria_V2.BUILDING,i_Params_Get_Address_By_Criteria_V2.FLOOR,i_Params_Get_Address_By_Criteria_V2.POBOX,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_V2.START_ROW,i_Params_Get_Address_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_Adv_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_Adv_V2(Params_Get_Address_By_Where_V2 i_Params_Get_Address_By_Where_V2)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_V2.START_ROW == null) { i_Params_Get_Address_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_Adv_V2(i_Params_Get_Address_By_Where_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_V2.STREET,i_Params_Get_Address_By_Where_V2.BUILDING,i_Params_Get_Address_By_Where_V2.FLOOR,i_Params_Get_Address_By_Where_V2.POBOX,i_Params_Get_Address_By_Where_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_V2.OWNER_ID,i_Params_Get_Address_By_Where_V2.START_ROW,i_Params_Get_Address_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_Adv_V2");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_Adv(Params_Get_Contact_By_Criteria i_Params_Get_Contact_By_Criteria)
{
List<Contact> oList = new List<Contact>();
long? tmp_TOTAL_COUNT = 0;
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria.START_ROW == null) { i_Params_Get_Contact_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria.END_ROW == null) || (i_Params_Get_Contact_By_Criteria.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_Adv(i_Params_Get_Contact_By_Criteria.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria.CONTACT,i_Params_Get_Contact_By_Criteria.DESCRIPTION,i_Params_Get_Contact_By_Criteria.OWNER_ID,i_Params_Get_Contact_By_Criteria.START_ROW,i_Params_Get_Contact_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Where_Adv(Params_Get_Contact_By_Where i_Params_Get_Contact_By_Where)
{
List<Contact> oList = new List<Contact>();
long? tmp_TOTAL_COUNT = 0;
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Where));}
#region Body Section.
if ((i_Params_Get_Contact_By_Where.OWNER_ID == null) || (i_Params_Get_Contact_By_Where.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where.START_ROW == null) { i_Params_Get_Contact_By_Where.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where.END_ROW == null) || (i_Params_Get_Contact_By_Where.END_ROW == 0)) { i_Params_Get_Contact_By_Where.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_Adv(i_Params_Get_Contact_By_Where.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where.CONTACT,i_Params_Get_Contact_By_Where.DESCRIPTION,i_Params_Get_Contact_By_Where.OWNER_ID,i_Params_Get_Contact_By_Where.START_ROW,i_Params_Get_Contact_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_Adv(Params_Get_Conversions_By_Criteria i_Params_Get_Conversions_By_Criteria)
{
List<Conversions> oList = new List<Conversions>();
long? tmp_TOTAL_COUNT = 0;
Conversions oConversions = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Criteria.OWNER_ID == null) || (i_Params_Get_Conversions_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Criteria.START_ROW == null) { i_Params_Get_Conversions_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Criteria.END_ROW == null) || (i_Params_Get_Conversions_By_Criteria.END_ROW == 0)) { i_Params_Get_Conversions_By_Criteria.END_ROW = 1000000; }
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Criteria_Adv(i_Params_Get_Conversions_By_Criteria.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Criteria.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Criteria.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Criteria.OWNER_ID,i_Params_Get_Conversions_By_Criteria.START_ROW,i_Params_Get_Conversions_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Criteria_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_Where_Adv(Params_Get_Conversions_By_Where i_Params_Get_Conversions_By_Where)
{
List<Conversions> oList = new List<Conversions>();
long? tmp_TOTAL_COUNT = 0;
Conversions oConversions = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Where));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Where.OWNER_ID == null) || (i_Params_Get_Conversions_By_Where.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Where.START_ROW == null) { i_Params_Get_Conversions_By_Where.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Where.END_ROW == null) || (i_Params_Get_Conversions_By_Where.END_ROW == 0)) { i_Params_Get_Conversions_By_Where.END_ROW = 1000000; }
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Where_Adv(i_Params_Get_Conversions_By_Where.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Where.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Where.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Where.OWNER_ID,i_Params_Get_Conversions_By_Where.START_ROW,i_Params_Get_Conversions_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Where_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_Adv_V2(Params_Get_Conversions_By_Criteria_V2 i_Params_Get_Conversions_By_Criteria_V2)
{
List<Conversions> oList = new List<Conversions>();
long? tmp_TOTAL_COUNT = 0;
Conversions oConversions = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Conversions_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Criteria_V2.START_ROW == null) { i_Params_Get_Conversions_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Conversions_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Conversions_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Criteria_Adv_V2(i_Params_Get_Conversions_By_Criteria_V2.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Criteria_V2.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Criteria_V2.CONVERSIONS_DATE,i_Params_Get_Conversions_By_Criteria_V2.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Criteria_V2.OWNER_ID,i_Params_Get_Conversions_By_Criteria_V2.START_ROW,i_Params_Get_Conversions_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Criteria_Adv_V2");}
return oList;
}
public List<Conversions> Get_Conversions_By_Where_Adv_V2(Params_Get_Conversions_By_Where_V2 i_Params_Get_Conversions_By_Where_V2)
{
List<Conversions> oList = new List<Conversions>();
long? tmp_TOTAL_COUNT = 0;
Conversions oConversions = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Conversions_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Where_V2.START_ROW == null) { i_Params_Get_Conversions_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Where_V2.END_ROW == null) || (i_Params_Get_Conversions_By_Where_V2.END_ROW == 0)) { i_Params_Get_Conversions_By_Where_V2.END_ROW = 1000000; }
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Where_Adv_V2(i_Params_Get_Conversions_By_Where_V2.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Where_V2.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Where_V2.CONVERSIONS_DATE,i_Params_Get_Conversions_By_Where_V2.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Where_V2.OWNER_ID,i_Params_Get_Conversions_By_Where_V2.START_ROW,i_Params_Get_Conversions_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Where_Adv_V2");}
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_Adv(Params_Get_Coupons_By_Criteria i_Params_Get_Coupons_By_Criteria)
{
List<Coupons> oList = new List<Coupons>();
long? tmp_TOTAL_COUNT = 0;
Coupons oCoupons = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Criteria.OWNER_ID == null) || (i_Params_Get_Coupons_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Criteria.START_ROW == null) { i_Params_Get_Coupons_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Criteria.END_ROW == null) || (i_Params_Get_Coupons_By_Criteria.END_ROW == 0)) { i_Params_Get_Coupons_By_Criteria.END_ROW = 1000000; }
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Criteria_Adv(i_Params_Get_Coupons_By_Criteria.COUPONS_TYPE,i_Params_Get_Coupons_By_Criteria.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Criteria.COUPONS_STORE,i_Params_Get_Coupons_By_Criteria.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Criteria.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Criteria.COUPONS_FOR,i_Params_Get_Coupons_By_Criteria.COUPONS_NOTE,i_Params_Get_Coupons_By_Criteria.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Criteria.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Criteria.COUPONS_MACHINE,i_Params_Get_Coupons_By_Criteria.OWNER_ID,i_Params_Get_Coupons_By_Criteria.START_ROW,i_Params_Get_Coupons_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Criteria_Adv");}
return oList;
}
public List<Coupons> Get_Coupons_By_Where_Adv(Params_Get_Coupons_By_Where i_Params_Get_Coupons_By_Where)
{
List<Coupons> oList = new List<Coupons>();
long? tmp_TOTAL_COUNT = 0;
Coupons oCoupons = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Where));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Where.OWNER_ID == null) || (i_Params_Get_Coupons_By_Where.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Where.START_ROW == null) { i_Params_Get_Coupons_By_Where.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Where.END_ROW == null) || (i_Params_Get_Coupons_By_Where.END_ROW == 0)) { i_Params_Get_Coupons_By_Where.END_ROW = 1000000; }
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Where_Adv(i_Params_Get_Coupons_By_Where.COUPONS_TYPE,i_Params_Get_Coupons_By_Where.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Where.COUPONS_STORE,i_Params_Get_Coupons_By_Where.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Where.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Where.COUPONS_FOR,i_Params_Get_Coupons_By_Where.COUPONS_NOTE,i_Params_Get_Coupons_By_Where.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Where.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Where.COUPONS_MACHINE,i_Params_Get_Coupons_By_Where.OWNER_ID,i_Params_Get_Coupons_By_Where.START_ROW,i_Params_Get_Coupons_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Where_Adv");}
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_Adv_V2(Params_Get_Coupons_By_Criteria_V2 i_Params_Get_Coupons_By_Criteria_V2)
{
List<Coupons> oList = new List<Coupons>();
long? tmp_TOTAL_COUNT = 0;
Coupons oCoupons = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Coupons_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Criteria_V2.START_ROW == null) { i_Params_Get_Coupons_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Coupons_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Coupons_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Criteria_Adv_V2(i_Params_Get_Coupons_By_Criteria_V2.COUPONS_TYPE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_STORE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_DATE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_FOR,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_NOTE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_MACHINE,i_Params_Get_Coupons_By_Criteria_V2.OWNER_ID,i_Params_Get_Coupons_By_Criteria_V2.START_ROW,i_Params_Get_Coupons_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Criteria_Adv_V2");}
return oList;
}
public List<Coupons> Get_Coupons_By_Where_Adv_V2(Params_Get_Coupons_By_Where_V2 i_Params_Get_Coupons_By_Where_V2)
{
List<Coupons> oList = new List<Coupons>();
long? tmp_TOTAL_COUNT = 0;
Coupons oCoupons = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Coupons_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Where_V2.START_ROW == null) { i_Params_Get_Coupons_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Where_V2.END_ROW == null) || (i_Params_Get_Coupons_By_Where_V2.END_ROW == 0)) { i_Params_Get_Coupons_By_Where_V2.END_ROW = 1000000; }
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Where_Adv_V2(i_Params_Get_Coupons_By_Where_V2.COUPONS_TYPE,i_Params_Get_Coupons_By_Where_V2.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Where_V2.COUPONS_STORE,i_Params_Get_Coupons_By_Where_V2.COUPONS_DATE,i_Params_Get_Coupons_By_Where_V2.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Where_V2.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Where_V2.COUPONS_FOR,i_Params_Get_Coupons_By_Where_V2.COUPONS_NOTE,i_Params_Get_Coupons_By_Where_V2.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Where_V2.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Where_V2.COUPONS_MACHINE,i_Params_Get_Coupons_By_Where_V2.OWNER_ID,i_Params_Get_Coupons_By_Where_V2.START_ROW,i_Params_Get_Coupons_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Where_Adv_V2");}
return oList;
}
public List<Currency> Get_Currency_By_Criteria_Adv(Params_Get_Currency_By_Criteria i_Params_Get_Currency_By_Criteria)
{
List<Currency> oList = new List<Currency>();
long? tmp_TOTAL_COUNT = 0;
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Currency_By_Criteria.OWNER_ID == null) || (i_Params_Get_Currency_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Currency_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Criteria.START_ROW == null) { i_Params_Get_Currency_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Criteria.END_ROW == null) || (i_Params_Get_Currency_By_Criteria.END_ROW == 0)) { i_Params_Get_Currency_By_Criteria.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Criteria_Adv(i_Params_Get_Currency_By_Criteria.CURRENCY_TYPE,i_Params_Get_Currency_By_Criteria.CURRENCY_SYMBOL,i_Params_Get_Currency_By_Criteria.OWNER_ID,i_Params_Get_Currency_By_Criteria.START_ROW,i_Params_Get_Currency_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
i_Params_Get_Currency_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Criteria_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_Where_Adv(Params_Get_Currency_By_Where i_Params_Get_Currency_By_Where)
{
List<Currency> oList = new List<Currency>();
long? tmp_TOTAL_COUNT = 0;
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_Where));}
#region Body Section.
if ((i_Params_Get_Currency_By_Where.OWNER_ID == null) || (i_Params_Get_Currency_By_Where.OWNER_ID == 0)) { i_Params_Get_Currency_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Where.START_ROW == null) { i_Params_Get_Currency_By_Where.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Where.END_ROW == null) || (i_Params_Get_Currency_By_Where.END_ROW == 0)) { i_Params_Get_Currency_By_Where.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Where_Adv(i_Params_Get_Currency_By_Where.CURRENCY_TYPE,i_Params_Get_Currency_By_Where.CURRENCY_SYMBOL,i_Params_Get_Currency_By_Where.OWNER_ID,i_Params_Get_Currency_By_Where.START_ROW,i_Params_Get_Currency_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
i_Params_Get_Currency_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Where_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_Adv(Params_Get_Fees_By_Criteria i_Params_Get_Fees_By_Criteria)
{
List<Fees> oList = new List<Fees>();
long? tmp_TOTAL_COUNT = 0;
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria.START_ROW == null) { i_Params_Get_Fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria.END_ROW == null) || (i_Params_Get_Fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_Adv(i_Params_Get_Fees_By_Criteria.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Criteria.FEES_STATUS,i_Params_Get_Fees_By_Criteria.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Criteria.FEES_STORE,i_Params_Get_Fees_By_Criteria.FEES_TYPE,i_Params_Get_Fees_By_Criteria.OWNER_ID,i_Params_Get_Fees_By_Criteria.START_ROW,i_Params_Get_Fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Where_Adv(Params_Get_Fees_By_Where i_Params_Get_Fees_By_Where)
{
List<Fees> oList = new List<Fees>();
long? tmp_TOTAL_COUNT = 0;
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where.OWNER_ID == null) || (i_Params_Get_Fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where.START_ROW == null) { i_Params_Get_Fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where.END_ROW == null) || (i_Params_Get_Fees_By_Where.END_ROW == 0)) { i_Params_Get_Fees_By_Where.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_Adv(i_Params_Get_Fees_By_Where.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Where.FEES_STATUS,i_Params_Get_Fees_By_Where.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Where.FEES_STORE,i_Params_Get_Fees_By_Where.FEES_TYPE,i_Params_Get_Fees_By_Where.OWNER_ID,i_Params_Get_Fees_By_Where.START_ROW,i_Params_Get_Fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_Adv_V2(Params_Get_Fees_By_Criteria_V2 i_Params_Get_Fees_By_Criteria_V2)
{
List<Fees> oList = new List<Fees>();
long? tmp_TOTAL_COUNT = 0;
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria_V2.START_ROW == null) { i_Params_Get_Fees_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Fees_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_Adv_V2(i_Params_Get_Fees_By_Criteria_V2.FEES_DATE,i_Params_Get_Fees_By_Criteria_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_V2.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Criteria_V2.FEES_STATUS,i_Params_Get_Fees_By_Criteria_V2.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Criteria_V2.FEES_STORE,i_Params_Get_Fees_By_Criteria_V2.FEES_TYPE,i_Params_Get_Fees_By_Criteria_V2.OWNER_ID,i_Params_Get_Fees_By_Criteria_V2.START_ROW,i_Params_Get_Fees_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_Adv_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Where_Adv_V2(Params_Get_Fees_By_Where_V2 i_Params_Get_Fees_By_Where_V2)
{
List<Fees> oList = new List<Fees>();
long? tmp_TOTAL_COUNT = 0;
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where_V2.START_ROW == null) { i_Params_Get_Fees_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where_V2.END_ROW == null) || (i_Params_Get_Fees_By_Where_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Where_V2.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_Adv_V2(i_Params_Get_Fees_By_Where_V2.FEES_DATE,i_Params_Get_Fees_By_Where_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_V2.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Where_V2.FEES_STATUS,i_Params_Get_Fees_By_Where_V2.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Where_V2.FEES_STORE,i_Params_Get_Fees_By_Where_V2.FEES_TYPE,i_Params_Get_Fees_By_Where_V2.OWNER_ID,i_Params_Get_Fees_By_Where_V2.START_ROW,i_Params_Get_Fees_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_Adv_V2");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria_Adv(Params_Get_Loc_l1_By_Criteria i_Params_Get_Loc_l1_By_Criteria)
{
List<Loc_l1> oList = new List<Loc_l1>();
long? tmp_TOTAL_COUNT = 0;
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l1_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l1_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Criteria_Adv(i_Params_Get_Loc_l1_By_Criteria.CODE,i_Params_Get_Loc_l1_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l1_By_Criteria.OWNER_ID,i_Params_Get_Loc_l1_By_Criteria.START_ROW,i_Params_Get_Loc_l1_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Criteria_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where_Adv(Params_Get_Loc_l1_By_Where i_Params_Get_Loc_l1_By_Where)
{
List<Loc_l1> oList = new List<Loc_l1>();
long? tmp_TOTAL_COUNT = 0;
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Where.START_ROW == null) { i_Params_Get_Loc_l1_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Where.END_ROW == null) || (i_Params_Get_Loc_l1_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Where_Adv(i_Params_Get_Loc_l1_By_Where.CODE,i_Params_Get_Loc_l1_By_Where.DESCRIPTION,i_Params_Get_Loc_l1_By_Where.OWNER_ID,i_Params_Get_Loc_l1_By_Where.START_ROW,i_Params_Get_Loc_l1_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Where_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_Adv(Params_Get_Loc_l2_By_Criteria i_Params_Get_Loc_l2_By_Criteria)
{
List<Loc_l2> oList = new List<Loc_l2>();
long? tmp_TOTAL_COUNT = 0;
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_Adv(i_Params_Get_Loc_l2_By_Criteria.CODE,i_Params_Get_Loc_l2_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria.START_ROW,i_Params_Get_Loc_l2_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_Adv(Params_Get_Loc_l2_By_Where i_Params_Get_Loc_l2_By_Where)
{
List<Loc_l2> oList = new List<Loc_l2>();
long? tmp_TOTAL_COUNT = 0;
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where.START_ROW == null) { i_Params_Get_Loc_l2_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_Adv(i_Params_Get_Loc_l2_By_Where.CODE,i_Params_Get_Loc_l2_By_Where.DESCRIPTION,i_Params_Get_Loc_l2_By_Where.OWNER_ID,i_Params_Get_Loc_l2_By_Where.START_ROW,i_Params_Get_Loc_l2_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_Adv(Params_Get_Loc_l3_By_Criteria i_Params_Get_Loc_l3_By_Criteria)
{
List<Loc_l3> oList = new List<Loc_l3>();
long? tmp_TOTAL_COUNT = 0;
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_Adv(i_Params_Get_Loc_l3_By_Criteria.CODE,i_Params_Get_Loc_l3_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria.START_ROW,i_Params_Get_Loc_l3_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_Adv(Params_Get_Loc_l3_By_Where i_Params_Get_Loc_l3_By_Where)
{
List<Loc_l3> oList = new List<Loc_l3>();
long? tmp_TOTAL_COUNT = 0;
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where.START_ROW == null) { i_Params_Get_Loc_l3_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_Adv(i_Params_Get_Loc_l3_By_Where.CODE,i_Params_Get_Loc_l3_By_Where.DESCRIPTION,i_Params_Get_Loc_l3_By_Where.OWNER_ID,i_Params_Get_Loc_l3_By_Where.START_ROW,i_Params_Get_Loc_l3_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_Adv(Params_Get_Loc_l4_By_Criteria i_Params_Get_Loc_l4_By_Criteria)
{
List<Loc_l4> oList = new List<Loc_l4>();
long? tmp_TOTAL_COUNT = 0;
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_Adv(i_Params_Get_Loc_l4_By_Criteria.CODE,i_Params_Get_Loc_l4_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria.START_ROW,i_Params_Get_Loc_l4_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_Adv(Params_Get_Loc_l4_By_Where i_Params_Get_Loc_l4_By_Where)
{
List<Loc_l4> oList = new List<Loc_l4>();
long? tmp_TOTAL_COUNT = 0;
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where.START_ROW == null) { i_Params_Get_Loc_l4_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_Adv(i_Params_Get_Loc_l4_By_Where.CODE,i_Params_Get_Loc_l4_By_Where.DESCRIPTION,i_Params_Get_Loc_l4_By_Where.OWNER_ID,i_Params_Get_Loc_l4_By_Where.START_ROW,i_Params_Get_Loc_l4_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_Criteria_Adv(Params_Get_Machine_By_Criteria i_Params_Get_Machine_By_Criteria)
{
List<Machine> oList = new List<Machine>();
long? tmp_TOTAL_COUNT = 0;
Machine oMachine = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Machine_By_Criteria.OWNER_ID == null) || (i_Params_Get_Machine_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Machine_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Criteria.START_ROW == null) { i_Params_Get_Machine_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Criteria.END_ROW == null) || (i_Params_Get_Machine_By_Criteria.END_ROW == 0)) { i_Params_Get_Machine_By_Criteria.END_ROW = 1000000; }
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Criteria_Adv(i_Params_Get_Machine_By_Criteria.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Criteria.MACHINE_NOTES,i_Params_Get_Machine_By_Criteria.OWNER_ID,i_Params_Get_Machine_By_Criteria.START_ROW,i_Params_Get_Machine_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Criteria_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_Where_Adv(Params_Get_Machine_By_Where i_Params_Get_Machine_By_Where)
{
List<Machine> oList = new List<Machine>();
long? tmp_TOTAL_COUNT = 0;
Machine oMachine = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Where));}
#region Body Section.
if ((i_Params_Get_Machine_By_Where.OWNER_ID == null) || (i_Params_Get_Machine_By_Where.OWNER_ID == 0)) { i_Params_Get_Machine_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Where.START_ROW == null) { i_Params_Get_Machine_By_Where.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Where.END_ROW == null) || (i_Params_Get_Machine_By_Where.END_ROW == 0)) { i_Params_Get_Machine_By_Where.END_ROW = 1000000; }
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Where_Adv(i_Params_Get_Machine_By_Where.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Where.MACHINE_NOTES,i_Params_Get_Machine_By_Where.OWNER_ID,i_Params_Get_Machine_By_Where.START_ROW,i_Params_Get_Machine_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Where_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_Criteria_Adv_V2(Params_Get_Machine_By_Criteria_V2 i_Params_Get_Machine_By_Criteria_V2)
{
List<Machine> oList = new List<Machine>();
long? tmp_TOTAL_COUNT = 0;
Machine oMachine = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Machine_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Machine_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Machine_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Criteria_V2.START_ROW == null) { i_Params_Get_Machine_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Machine_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Machine_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Criteria_Adv_V2(i_Params_Get_Machine_By_Criteria_V2.MACHINE_DATE,i_Params_Get_Machine_By_Criteria_V2.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Criteria_V2.MACHINE_NOTES,i_Params_Get_Machine_By_Criteria_V2.OWNER_ID,i_Params_Get_Machine_By_Criteria_V2.START_ROW,i_Params_Get_Machine_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Criteria_Adv_V2");}
return oList;
}
public List<Machine> Get_Machine_By_Where_Adv_V2(Params_Get_Machine_By_Where_V2 i_Params_Get_Machine_By_Where_V2)
{
List<Machine> oList = new List<Machine>();
long? tmp_TOTAL_COUNT = 0;
Machine oMachine = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Machine_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Machine_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Machine_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Where_V2.START_ROW == null) { i_Params_Get_Machine_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Where_V2.END_ROW == null) || (i_Params_Get_Machine_By_Where_V2.END_ROW == 0)) { i_Params_Get_Machine_By_Where_V2.END_ROW = 1000000; }
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Where_Adv_V2(i_Params_Get_Machine_By_Where_V2.MACHINE_DATE,i_Params_Get_Machine_By_Where_V2.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Where_V2.MACHINE_NOTES,i_Params_Get_Machine_By_Where_V2.OWNER_ID,i_Params_Get_Machine_By_Where_V2.START_ROW,i_Params_Get_Machine_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Where_Adv_V2");}
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_Adv(Params_Get_Method_run_By_Criteria i_Params_Get_Method_run_By_Criteria)
{
List<Method_run> oList = new List<Method_run>();
long? tmp_TOTAL_COUNT = 0;
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Criteria.OWNER_ID == null) || (i_Params_Get_Method_run_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Criteria.START_ROW == null) { i_Params_Get_Method_run_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Criteria.END_ROW == null) || (i_Params_Get_Method_run_By_Criteria.END_ROW == 0)) { i_Params_Get_Method_run_By_Criteria.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Criteria_Adv(i_Params_Get_Method_run_By_Criteria.METHOD_NAME,i_Params_Get_Method_run_By_Criteria.INPUT_PARAM,i_Params_Get_Method_run_By_Criteria.OWNER_ID,i_Params_Get_Method_run_By_Criteria.START_ROW,i_Params_Get_Method_run_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
i_Params_Get_Method_run_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Criteria_Adv");}
return oList;
}
public List<Method_run> Get_Method_run_By_Where_Adv(Params_Get_Method_run_By_Where i_Params_Get_Method_run_By_Where)
{
List<Method_run> oList = new List<Method_run>();
long? tmp_TOTAL_COUNT = 0;
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Where.OWNER_ID == null) || (i_Params_Get_Method_run_By_Where.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Where.START_ROW == null) { i_Params_Get_Method_run_By_Where.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Where.END_ROW == null) || (i_Params_Get_Method_run_By_Where.END_ROW == 0)) { i_Params_Get_Method_run_By_Where.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Where_Adv(i_Params_Get_Method_run_By_Where.METHOD_NAME,i_Params_Get_Method_run_By_Where.INPUT_PARAM,i_Params_Get_Method_run_By_Where.OWNER_ID,i_Params_Get_Method_run_By_Where.START_ROW,i_Params_Get_Method_run_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
i_Params_Get_Method_run_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Where_Adv");}
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_Adv_V2(Params_Get_Method_run_By_Criteria_V2 i_Params_Get_Method_run_By_Criteria_V2)
{
List<Method_run> oList = new List<Method_run>();
long? tmp_TOTAL_COUNT = 0;
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Criteria_V2.START_ROW == null) { i_Params_Get_Method_run_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Method_run_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Method_run_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Criteria_Adv_V2(i_Params_Get_Method_run_By_Criteria_V2.METHOD_NAME,i_Params_Get_Method_run_By_Criteria_V2.RUN_DATE,i_Params_Get_Method_run_By_Criteria_V2.INPUT_PARAM,i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID,i_Params_Get_Method_run_By_Criteria_V2.START_ROW,i_Params_Get_Method_run_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
i_Params_Get_Method_run_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Criteria_Adv_V2");}
return oList;
}
public List<Method_run> Get_Method_run_By_Where_Adv_V2(Params_Get_Method_run_By_Where_V2 i_Params_Get_Method_run_By_Where_V2)
{
List<Method_run> oList = new List<Method_run>();
long? tmp_TOTAL_COUNT = 0;
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Method_run_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Where_V2.START_ROW == null) { i_Params_Get_Method_run_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Where_V2.END_ROW == null) || (i_Params_Get_Method_run_By_Where_V2.END_ROW == 0)) { i_Params_Get_Method_run_By_Where_V2.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Where_Adv_V2(i_Params_Get_Method_run_By_Where_V2.METHOD_NAME,i_Params_Get_Method_run_By_Where_V2.RUN_DATE,i_Params_Get_Method_run_By_Where_V2.INPUT_PARAM,i_Params_Get_Method_run_By_Where_V2.OWNER_ID,i_Params_Get_Method_run_By_Where_V2.START_ROW,i_Params_Get_Method_run_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
i_Params_Get_Method_run_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Where_Adv_V2");}
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv(Params_Get_Person_By_Criteria i_Params_Get_Person_By_Criteria)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria.START_ROW == null) { i_Params_Get_Person_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria.END_ROW == null) || (i_Params_Get_Person_By_Criteria.END_ROW == 0)) { i_Params_Get_Person_By_Criteria.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_Adv(i_Params_Get_Person_By_Criteria.FIRST_NAME,i_Params_Get_Person_By_Criteria.LAST_NAME,i_Params_Get_Person_By_Criteria.FATHER_NAME,i_Params_Get_Person_By_Criteria.MOTHER_NAME,i_Params_Get_Person_By_Criteria.TITLE_CODE,i_Params_Get_Person_By_Criteria.GENDER_CODE,i_Params_Get_Person_By_Criteria.RELIGION_CODE,i_Params_Get_Person_By_Criteria.DESCRIPTION,i_Params_Get_Person_By_Criteria.OWNER_ID,i_Params_Get_Person_By_Criteria.START_ROW,i_Params_Get_Person_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_Adv");}
return oList;
}
public List<Person> Get_Person_By_Where_Adv(Params_Get_Person_By_Where i_Params_Get_Person_By_Where)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Where));}
#region Body Section.
if ((i_Params_Get_Person_By_Where.OWNER_ID == null) || (i_Params_Get_Person_By_Where.OWNER_ID == 0)) { i_Params_Get_Person_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where.START_ROW == null) { i_Params_Get_Person_By_Where.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where.END_ROW == null) || (i_Params_Get_Person_By_Where.END_ROW == 0)) { i_Params_Get_Person_By_Where.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_Adv(i_Params_Get_Person_By_Where.FIRST_NAME,i_Params_Get_Person_By_Where.LAST_NAME,i_Params_Get_Person_By_Where.FATHER_NAME,i_Params_Get_Person_By_Where.MOTHER_NAME,i_Params_Get_Person_By_Where.TITLE_CODE,i_Params_Get_Person_By_Where.GENDER_CODE,i_Params_Get_Person_By_Where.RELIGION_CODE,i_Params_Get_Person_By_Where.DESCRIPTION,i_Params_Get_Person_By_Where.OWNER_ID,i_Params_Get_Person_By_Where.START_ROW,i_Params_Get_Person_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_Adv");}
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv_V2(Params_Get_Person_By_Criteria_V2 i_Params_Get_Person_By_Criteria_V2)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria_V2.START_ROW == null) { i_Params_Get_Person_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Person_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Person_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_Adv_V2(i_Params_Get_Person_By_Criteria_V2.FIRST_NAME,i_Params_Get_Person_By_Criteria_V2.LAST_NAME,i_Params_Get_Person_By_Criteria_V2.FATHER_NAME,i_Params_Get_Person_By_Criteria_V2.MOTHER_NAME,i_Params_Get_Person_By_Criteria_V2.TITLE_CODE,i_Params_Get_Person_By_Criteria_V2.GENDER_CODE,i_Params_Get_Person_By_Criteria_V2.RELIGION_CODE,i_Params_Get_Person_By_Criteria_V2.BIRTH_DATE,i_Params_Get_Person_By_Criteria_V2.DESCRIPTION,i_Params_Get_Person_By_Criteria_V2.OWNER_ID,i_Params_Get_Person_By_Criteria_V2.START_ROW,i_Params_Get_Person_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_Adv_V2");}
return oList;
}
public List<Person> Get_Person_By_Where_Adv_V2(Params_Get_Person_By_Where_V2 i_Params_Get_Person_By_Where_V2)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Person_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where_V2.START_ROW == null) { i_Params_Get_Person_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where_V2.END_ROW == null) || (i_Params_Get_Person_By_Where_V2.END_ROW == 0)) { i_Params_Get_Person_By_Where_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_Adv_V2(i_Params_Get_Person_By_Where_V2.FIRST_NAME,i_Params_Get_Person_By_Where_V2.LAST_NAME,i_Params_Get_Person_By_Where_V2.FATHER_NAME,i_Params_Get_Person_By_Where_V2.MOTHER_NAME,i_Params_Get_Person_By_Where_V2.TITLE_CODE,i_Params_Get_Person_By_Where_V2.GENDER_CODE,i_Params_Get_Person_By_Where_V2.RELIGION_CODE,i_Params_Get_Person_By_Where_V2.BIRTH_DATE,i_Params_Get_Person_By_Where_V2.DESCRIPTION,i_Params_Get_Person_By_Where_V2.OWNER_ID,i_Params_Get_Person_By_Where_V2.START_ROW,i_Params_Get_Person_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_Adv_V2");}
return oList;
}
public List<Salary> Get_Salary_By_Criteria_Adv(Params_Get_Salary_By_Criteria i_Params_Get_Salary_By_Criteria)
{
List<Salary> oList = new List<Salary>();
long? tmp_TOTAL_COUNT = 0;
Salary oSalary = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Salary_By_Criteria.OWNER_ID == null) || (i_Params_Get_Salary_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Salary_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Criteria.START_ROW == null) { i_Params_Get_Salary_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Criteria.END_ROW == null) || (i_Params_Get_Salary_By_Criteria.END_ROW == 0)) { i_Params_Get_Salary_By_Criteria.END_ROW = 1000000; }
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Criteria_Adv(i_Params_Get_Salary_By_Criteria.DESCRIPTION,i_Params_Get_Salary_By_Criteria.OWNER_ID,i_Params_Get_Salary_By_Criteria.START_ROW,i_Params_Get_Salary_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Criteria_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_Where_Adv(Params_Get_Salary_By_Where i_Params_Get_Salary_By_Where)
{
List<Salary> oList = new List<Salary>();
long? tmp_TOTAL_COUNT = 0;
Salary oSalary = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Where));}
#region Body Section.
if ((i_Params_Get_Salary_By_Where.OWNER_ID == null) || (i_Params_Get_Salary_By_Where.OWNER_ID == 0)) { i_Params_Get_Salary_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Where.START_ROW == null) { i_Params_Get_Salary_By_Where.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Where.END_ROW == null) || (i_Params_Get_Salary_By_Where.END_ROW == 0)) { i_Params_Get_Salary_By_Where.END_ROW = 1000000; }
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Where_Adv(i_Params_Get_Salary_By_Where.DESCRIPTION,i_Params_Get_Salary_By_Where.OWNER_ID,i_Params_Get_Salary_By_Where.START_ROW,i_Params_Get_Salary_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Where_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_Criteria_Adv_V2(Params_Get_Salary_By_Criteria_V2 i_Params_Get_Salary_By_Criteria_V2)
{
List<Salary> oList = new List<Salary>();
long? tmp_TOTAL_COUNT = 0;
Salary oSalary = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Salary_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Salary_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Salary_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Criteria_V2.START_ROW == null) { i_Params_Get_Salary_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Salary_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Salary_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Criteria_Adv_V2(i_Params_Get_Salary_By_Criteria_V2.SALARY_DATE,i_Params_Get_Salary_By_Criteria_V2.DESCRIPTION,i_Params_Get_Salary_By_Criteria_V2.OWNER_ID,i_Params_Get_Salary_By_Criteria_V2.START_ROW,i_Params_Get_Salary_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Criteria_Adv_V2");}
return oList;
}
public List<Salary> Get_Salary_By_Where_Adv_V2(Params_Get_Salary_By_Where_V2 i_Params_Get_Salary_By_Where_V2)
{
List<Salary> oList = new List<Salary>();
long? tmp_TOTAL_COUNT = 0;
Salary oSalary = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Salary_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Salary_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Salary_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Where_V2.START_ROW == null) { i_Params_Get_Salary_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Where_V2.END_ROW == null) || (i_Params_Get_Salary_By_Where_V2.END_ROW == 0)) { i_Params_Get_Salary_By_Where_V2.END_ROW = 1000000; }
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Where_Adv_V2(i_Params_Get_Salary_By_Where_V2.SALARY_DATE,i_Params_Get_Salary_By_Where_V2.DESCRIPTION,i_Params_Get_Salary_By_Where_V2.OWNER_ID,i_Params_Get_Salary_By_Where_V2.START_ROW,i_Params_Get_Salary_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Where_Adv_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_Adv(Params_Get_Staff_By_Criteria i_Params_Get_Staff_By_Criteria)
{
List<Staff> oList = new List<Staff>();
long? tmp_TOTAL_COUNT = 0;
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria.START_ROW == null) { i_Params_Get_Staff_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria.END_ROW == null) || (i_Params_Get_Staff_By_Criteria.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_Adv(i_Params_Get_Staff_By_Criteria.STAFF_NAME,i_Params_Get_Staff_By_Criteria.STAFF_PAYMENT_DESCRIPTION,i_Params_Get_Staff_By_Criteria.STAFF_REFERENCE,i_Params_Get_Staff_By_Criteria.OWNER_ID,i_Params_Get_Staff_By_Criteria.START_ROW,i_Params_Get_Staff_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_Where_Adv(Params_Get_Staff_By_Where i_Params_Get_Staff_By_Where)
{
List<Staff> oList = new List<Staff>();
long? tmp_TOTAL_COUNT = 0;
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where.OWNER_ID == null) || (i_Params_Get_Staff_By_Where.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where.START_ROW == null) { i_Params_Get_Staff_By_Where.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where.END_ROW == null) || (i_Params_Get_Staff_By_Where.END_ROW == 0)) { i_Params_Get_Staff_By_Where.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_Adv(i_Params_Get_Staff_By_Where.STAFF_NAME,i_Params_Get_Staff_By_Where.STAFF_PAYMENT_DESCRIPTION,i_Params_Get_Staff_By_Where.STAFF_REFERENCE,i_Params_Get_Staff_By_Where.OWNER_ID,i_Params_Get_Staff_By_Where.START_ROW,i_Params_Get_Staff_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_Adv");}
return oList;
}
public List<Stock> Get_Stock_By_Criteria_Adv(Params_Get_Stock_By_Criteria i_Params_Get_Stock_By_Criteria)
{
List<Stock> oList = new List<Stock>();
long? tmp_TOTAL_COUNT = 0;
Stock oStock = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Stock_By_Criteria.OWNER_ID == null) || (i_Params_Get_Stock_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Stock_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Stock_By_Criteria.START_ROW == null) { i_Params_Get_Stock_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Stock_By_Criteria.END_ROW == null) || (i_Params_Get_Stock_By_Criteria.END_ROW == 0)) { i_Params_Get_Stock_By_Criteria.END_ROW = 1000000; }
List<DALC.Stock> oList_DBEntries = _AppContext.Get_Stock_By_Criteria_Adv(i_Params_Get_Stock_By_Criteria.STOCK_DESCRIPTION,i_Params_Get_Stock_By_Criteria.STOCK_CATEGORY,i_Params_Get_Stock_By_Criteria.STOCK_SCALE,i_Params_Get_Stock_By_Criteria.STOCK_MAIN_PERSON,i_Params_Get_Stock_By_Criteria.STOCK_NOTE,i_Params_Get_Stock_By_Criteria.OWNER_ID,i_Params_Get_Stock_By_Criteria.START_ROW,i_Params_Get_Stock_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStock = new Stock();
oTools.CopyPropValues(oDBEntry, oStock);
oList.Add(oStock);
}
}
i_Params_Get_Stock_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_Criteria_Adv");}
return oList;
}
public List<Stock> Get_Stock_By_Where_Adv(Params_Get_Stock_By_Where i_Params_Get_Stock_By_Where)
{
List<Stock> oList = new List<Stock>();
long? tmp_TOTAL_COUNT = 0;
Stock oStock = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_Where));}
#region Body Section.
if ((i_Params_Get_Stock_By_Where.OWNER_ID == null) || (i_Params_Get_Stock_By_Where.OWNER_ID == 0)) { i_Params_Get_Stock_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Stock_By_Where.START_ROW == null) { i_Params_Get_Stock_By_Where.START_ROW = 0; }
if ((i_Params_Get_Stock_By_Where.END_ROW == null) || (i_Params_Get_Stock_By_Where.END_ROW == 0)) { i_Params_Get_Stock_By_Where.END_ROW = 1000000; }
List<DALC.Stock> oList_DBEntries = _AppContext.Get_Stock_By_Where_Adv(i_Params_Get_Stock_By_Where.STOCK_DESCRIPTION,i_Params_Get_Stock_By_Where.STOCK_CATEGORY,i_Params_Get_Stock_By_Where.STOCK_SCALE,i_Params_Get_Stock_By_Where.STOCK_MAIN_PERSON,i_Params_Get_Stock_By_Where.STOCK_NOTE,i_Params_Get_Stock_By_Where.OWNER_ID,i_Params_Get_Stock_By_Where.START_ROW,i_Params_Get_Stock_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStock = new Stock();
oTools.CopyPropValues(oDBEntry, oStock);
oList.Add(oStock);
}
}
i_Params_Get_Stock_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_Where_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_Adv(Params_Get_Supplier_By_Criteria i_Params_Get_Supplier_By_Criteria)
{
List<Supplier> oList = new List<Supplier>();
long? tmp_TOTAL_COUNT = 0;
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria.START_ROW == null) { i_Params_Get_Supplier_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_Adv(i_Params_Get_Supplier_By_Criteria.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Criteria.OWNER_ID,i_Params_Get_Supplier_By_Criteria.START_ROW,i_Params_Get_Supplier_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_Adv(Params_Get_Supplier_By_Where i_Params_Get_Supplier_By_Where)
{
List<Supplier> oList = new List<Supplier>();
long? tmp_TOTAL_COUNT = 0;
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where.START_ROW == null) { i_Params_Get_Supplier_By_Where.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where.END_ROW == null) || (i_Params_Get_Supplier_By_Where.END_ROW == 0)) { i_Params_Get_Supplier_By_Where.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_Adv(i_Params_Get_Supplier_By_Where.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Where.OWNER_ID,i_Params_Get_Supplier_By_Where.START_ROW,i_Params_Get_Supplier_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_Adv_V2(Params_Get_Supplier_By_Criteria_V2 i_Params_Get_Supplier_By_Criteria_V2)
{
List<Supplier> oList = new List<Supplier>();
long? tmp_TOTAL_COUNT = 0;
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_V2.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_Adv_V2(i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_PAYMENT_DATE,i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID,i_Params_Get_Supplier_By_Criteria_V2.START_ROW,i_Params_Get_Supplier_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_Adv_V2");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_Adv_V2(Params_Get_Supplier_By_Where_V2 i_Params_Get_Supplier_By_Where_V2)
{
List<Supplier> oList = new List<Supplier>();
long? tmp_TOTAL_COUNT = 0;
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_V2.START_ROW == null) { i_Params_Get_Supplier_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Where_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_V2.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_Adv_V2(i_Params_Get_Supplier_By_Where_V2.SUPPLIER_PAYMENT_DATE,i_Params_Get_Supplier_By_Where_V2.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Where_V2.OWNER_ID,i_Params_Get_Supplier_By_Where_V2.START_ROW,i_Params_Get_Supplier_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_Adv_V2");}
return oList;
}
public List<User> Get_User_By_Criteria_Adv(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_Criteria));}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_Adv");}
return oList;
}
public List<User> Get_User_By_Where_Adv(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_Where));}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_Adv(Params_Get_Workshop_By_Criteria i_Params_Get_Workshop_By_Criteria)
{
List<Workshop> oList = new List<Workshop>();
long? tmp_TOTAL_COUNT = 0;
Workshop oWorkshop = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Criteria.OWNER_ID == null) || (i_Params_Get_Workshop_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Criteria.START_ROW == null) { i_Params_Get_Workshop_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Criteria.END_ROW == null) || (i_Params_Get_Workshop_By_Criteria.END_ROW == 0)) { i_Params_Get_Workshop_By_Criteria.END_ROW = 1000000; }
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Criteria_Adv(i_Params_Get_Workshop_By_Criteria.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Criteria.OWNER_ID,i_Params_Get_Workshop_By_Criteria.START_ROW,i_Params_Get_Workshop_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Criteria_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_Where_Adv(Params_Get_Workshop_By_Where i_Params_Get_Workshop_By_Where)
{
List<Workshop> oList = new List<Workshop>();
long? tmp_TOTAL_COUNT = 0;
Workshop oWorkshop = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Where));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Where.OWNER_ID == null) || (i_Params_Get_Workshop_By_Where.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Where.START_ROW == null) { i_Params_Get_Workshop_By_Where.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Where.END_ROW == null) || (i_Params_Get_Workshop_By_Where.END_ROW == 0)) { i_Params_Get_Workshop_By_Where.END_ROW = 1000000; }
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Where_Adv(i_Params_Get_Workshop_By_Where.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Where.OWNER_ID,i_Params_Get_Workshop_By_Where.START_ROW,i_Params_Get_Workshop_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Where_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_Adv_V2(Params_Get_Workshop_By_Criteria_V2 i_Params_Get_Workshop_By_Criteria_V2)
{
List<Workshop> oList = new List<Workshop>();
long? tmp_TOTAL_COUNT = 0;
Workshop oWorkshop = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Workshop_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Criteria_V2.START_ROW == null) { i_Params_Get_Workshop_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Workshop_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Workshop_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Criteria_Adv_V2(i_Params_Get_Workshop_By_Criteria_V2.WORKSHOP_BEGINNING_DATE,i_Params_Get_Workshop_By_Criteria_V2.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Criteria_V2.OWNER_ID,i_Params_Get_Workshop_By_Criteria_V2.START_ROW,i_Params_Get_Workshop_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Criteria_Adv_V2");}
return oList;
}
public List<Workshop> Get_Workshop_By_Where_Adv_V2(Params_Get_Workshop_By_Where_V2 i_Params_Get_Workshop_By_Where_V2)
{
List<Workshop> oList = new List<Workshop>();
long? tmp_TOTAL_COUNT = 0;
Workshop oWorkshop = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Workshop_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Where_V2.START_ROW == null) { i_Params_Get_Workshop_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Where_V2.END_ROW == null) || (i_Params_Get_Workshop_By_Where_V2.END_ROW == 0)) { i_Params_Get_Workshop_By_Where_V2.END_ROW = 1000000; }
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Where_Adv_V2(i_Params_Get_Workshop_By_Where_V2.WORKSHOP_BEGINNING_DATE,i_Params_Get_Workshop_By_Where_V2.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Where_V2.OWNER_ID,i_Params_Get_Workshop_By_Where_V2.START_ROW,i_Params_Get_Workshop_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Where_Adv_V2");}
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_Adv(Params_Get_Workshops_By_Criteria i_Params_Get_Workshops_By_Criteria)
{
List<Workshops> oList = new List<Workshops>();
long? tmp_TOTAL_COUNT = 0;
Workshops oWorkshops = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Criteria.OWNER_ID == null) || (i_Params_Get_Workshops_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Criteria.START_ROW == null) { i_Params_Get_Workshops_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Criteria.END_ROW == null) || (i_Params_Get_Workshops_By_Criteria.END_ROW == 0)) { i_Params_Get_Workshops_By_Criteria.END_ROW = 1000000; }
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Criteria_Adv(i_Params_Get_Workshops_By_Criteria.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Criteria.OWNER_ID,i_Params_Get_Workshops_By_Criteria.START_ROW,i_Params_Get_Workshops_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Criteria_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_Where_Adv(Params_Get_Workshops_By_Where i_Params_Get_Workshops_By_Where)
{
List<Workshops> oList = new List<Workshops>();
long? tmp_TOTAL_COUNT = 0;
Workshops oWorkshops = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Where));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Where.OWNER_ID == null) || (i_Params_Get_Workshops_By_Where.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Where.START_ROW == null) { i_Params_Get_Workshops_By_Where.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Where.END_ROW == null) || (i_Params_Get_Workshops_By_Where.END_ROW == 0)) { i_Params_Get_Workshops_By_Where.END_ROW = 1000000; }
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Where_Adv(i_Params_Get_Workshops_By_Where.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Where.OWNER_ID,i_Params_Get_Workshops_By_Where.START_ROW,i_Params_Get_Workshops_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Where_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_Adv_V2(Params_Get_Workshops_By_Criteria_V2 i_Params_Get_Workshops_By_Criteria_V2)
{
List<Workshops> oList = new List<Workshops>();
long? tmp_TOTAL_COUNT = 0;
Workshops oWorkshops = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Workshops_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Criteria_V2.START_ROW == null) { i_Params_Get_Workshops_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Workshops_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Workshops_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Criteria_Adv_V2(i_Params_Get_Workshops_By_Criteria_V2.WORKSHOPS_BEGINNING_DATE,i_Params_Get_Workshops_By_Criteria_V2.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Criteria_V2.OWNER_ID,i_Params_Get_Workshops_By_Criteria_V2.START_ROW,i_Params_Get_Workshops_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Criteria_Adv_V2");}
return oList;
}
public List<Workshops> Get_Workshops_By_Where_Adv_V2(Params_Get_Workshops_By_Where_V2 i_Params_Get_Workshops_By_Where_V2)
{
List<Workshops> oList = new List<Workshops>();
long? tmp_TOTAL_COUNT = 0;
Workshops oWorkshops = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Workshops_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Where_V2.START_ROW == null) { i_Params_Get_Workshops_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Where_V2.END_ROW == null) || (i_Params_Get_Workshops_By_Where_V2.END_ROW == 0)) { i_Params_Get_Workshops_By_Where_V2.END_ROW = 1000000; }
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Where_Adv_V2(i_Params_Get_Workshops_By_Where_V2.WORKSHOPS_BEGINNING_DATE,i_Params_Get_Workshops_By_Where_V2.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Where_V2.OWNER_ID,i_Params_Get_Workshops_By_Where_V2.START_ROW,i_Params_Get_Workshops_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Where_Adv_V2");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv(Params_Get_Address_By_Criteria_InList i_Params_Get_Address_By_Criteria_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Criteria_InList_SP oParams_Get_Address_By_Criteria_InList_SP = new Params_Get_Address_By_Criteria_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Address_By_Criteria_InList.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP.STREET = i_Params_Get_Address_By_Criteria_InList.STREET;
oParams_Get_Address_By_Criteria_InList_SP.BUILDING = i_Params_Get_Address_By_Criteria_InList.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP.FLOOR = i_Params_Get_Address_By_Criteria_InList.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP.POBOX = i_Params_Get_Address_By_Criteria_InList.POBOX;
if ( i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP.START_ROW = i_Params_Get_Address_By_Criteria_InList.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP.END_ROW = i_Params_Get_Address_By_Criteria_InList.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_Adv(i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList.STREET,i_Params_Get_Address_By_Criteria_InList.BUILDING,i_Params_Get_Address_By_Criteria_InList.FLOOR,i_Params_Get_Address_By_Criteria_InList.POBOX,i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList.OWNER_ID,i_Params_Get_Address_By_Criteria_InList.START_ROW,i_Params_Get_Address_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_Adv");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv(Params_Get_Address_By_Where_InList i_Params_Get_Address_By_Where_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Where_InList_SP oParams_Get_Address_By_Where_InList_SP = new Params_Get_Address_By_Where_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList.START_ROW == null) { i_Params_Get_Address_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList.END_ROW == null) || (i_Params_Get_Address_By_Where_InList.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP.OWNER_ID = i_Params_Get_Address_By_Where_InList.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP.STREET = i_Params_Get_Address_By_Where_InList.STREET;
oParams_Get_Address_By_Where_InList_SP.BUILDING = i_Params_Get_Address_By_Where_InList.BUILDING;
oParams_Get_Address_By_Where_InList_SP.FLOOR = i_Params_Get_Address_By_Where_InList.FLOOR;
oParams_Get_Address_By_Where_InList_SP.POBOX = i_Params_Get_Address_By_Where_InList.POBOX;
if ( i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP.START_ROW = i_Params_Get_Address_By_Where_InList.START_ROW;
oParams_Get_Address_By_Where_InList_SP.END_ROW = i_Params_Get_Address_By_Where_InList.END_ROW;
oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_Adv(i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList.STREET,i_Params_Get_Address_By_Where_InList.BUILDING,i_Params_Get_Address_By_Where_InList.FLOOR,i_Params_Get_Address_By_Where_InList.POBOX,i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList.OWNER_ID,i_Params_Get_Address_By_Where_InList.START_ROW,i_Params_Get_Address_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv_V2(Params_Get_Address_By_Criteria_InList_V2 i_Params_Get_Address_By_Criteria_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Criteria_InList_SP_V2 oParams_Get_Address_By_Criteria_InList_SP_V2 = new Params_Get_Address_By_Criteria_InList_SP_V2();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP_V2.STREET = i_Params_Get_Address_By_Criteria_InList_V2.STREET;
oParams_Get_Address_By_Criteria_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Criteria_InList_V2.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Criteria_InList_V2.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP_V2.POBOX = i_Params_Get_Address_By_Criteria_InList_V2.POBOX;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Criteria_InList_V2.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Criteria_InList_V2.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_Adv_V2(i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList_V2.STREET,i_Params_Get_Address_By_Criteria_InList_V2.BUILDING,i_Params_Get_Address_By_Criteria_InList_V2.FLOOR,i_Params_Get_Address_By_Criteria_InList_V2.POBOX,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_InList_V2.START_ROW,i_Params_Get_Address_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv_V2(Params_Get_Address_By_Where_InList_V2 i_Params_Get_Address_By_Where_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Where_InList_SP_V2 oParams_Get_Address_By_Where_InList_SP_V2 = new Params_Get_Address_By_Where_InList_SP_V2();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Where_InList_V2.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP_V2.STREET = i_Params_Get_Address_By_Where_InList_V2.STREET;
oParams_Get_Address_By_Where_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Where_InList_V2.BUILDING;
oParams_Get_Address_By_Where_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Where_InList_V2.FLOOR;
oParams_Get_Address_By_Where_InList_SP_V2.POBOX = i_Params_Get_Address_By_Where_InList_V2.POBOX;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Where_InList_V2.START_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Where_InList_V2.END_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_Adv_V2(i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList_V2.STREET,i_Params_Get_Address_By_Where_InList_V2.BUILDING,i_Params_Get_Address_By_Where_InList_V2.FLOOR,i_Params_Get_Address_By_Where_InList_V2.POBOX,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.OWNER_ID,i_Params_Get_Address_By_Where_InList_V2.START_ROW,i_Params_Get_Address_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_Adv_V2");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList_Adv(Params_Get_Contact_By_Criteria_InList i_Params_Get_Contact_By_Criteria_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Contact_By_Criteria_InList_SP oParams_Get_Contact_By_Criteria_InList_SP = new Params_Get_Contact_By_Criteria_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria_InList.START_ROW == null) { i_Params_Get_Contact_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Contact_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Criteria_InList.OWNER_ID;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT = i_Params_Get_Contact_By_Criteria_InList.CONTACT;
oParams_Get_Contact_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Criteria_InList_SP.START_ROW = i_Params_Get_Contact_By_Criteria_InList.START_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.END_ROW = i_Params_Get_Contact_By_Criteria_InList.END_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_InList_Adv(i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria_InList.CONTACT,i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION,i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Criteria_InList.OWNER_ID,i_Params_Get_Contact_By_Criteria_InList.START_ROW,i_Params_Get_Contact_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_InList_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Where_InList_Adv(Params_Get_Contact_By_Where_InList i_Params_Get_Contact_By_Where_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Contact_By_Where_InList_SP oParams_Get_Contact_By_Where_InList_SP = new Params_Get_Contact_By_Where_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Contact_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where_InList.START_ROW == null) { i_Params_Get_Contact_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where_InList.END_ROW == null) || (i_Params_Get_Contact_By_Where_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Where_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Where_InList.OWNER_ID;
oParams_Get_Contact_By_Where_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Where_InList_SP.CONTACT = i_Params_Get_Contact_By_Where_InList.CONTACT;
oParams_Get_Contact_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Where_InList_SP.START_ROW = i_Params_Get_Contact_By_Where_InList.START_ROW;
oParams_Get_Contact_By_Where_InList_SP.END_ROW = i_Params_Get_Contact_By_Where_InList.END_ROW;
oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_InList_Adv(i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where_InList.CONTACT,i_Params_Get_Contact_By_Where_InList.DESCRIPTION,i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Where_InList.OWNER_ID,i_Params_Get_Contact_By_Where_InList.START_ROW,i_Params_Get_Contact_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_InList_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_InList_Adv(Params_Get_Conversions_By_Criteria_InList i_Params_Get_Conversions_By_Criteria_InList)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Conversions_By_Criteria_InList_SP oParams_Get_Conversions_By_Criteria_InList_SP = new Params_Get_Conversions_By_Criteria_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Conversions_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Criteria_InList.START_ROW == null) { i_Params_Get_Conversions_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Conversions_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Conversions_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Conversions_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Conversions_By_Criteria_InList.OWNER_ID;
oParams_Get_Conversions_By_Criteria_InList_SP.CONVERSIONS_FROM = i_Params_Get_Conversions_By_Criteria_InList.CONVERSIONS_FROM;
oParams_Get_Conversions_By_Criteria_InList_SP.CONVERSIONS_FOR = i_Params_Get_Conversions_By_Criteria_InList.CONVERSIONS_FOR;
oParams_Get_Conversions_By_Criteria_InList_SP.CONVERSIONS_DESCRIPTION = i_Params_Get_Conversions_By_Criteria_InList.CONVERSIONS_DESCRIPTION;
if ( i_Params_Get_Conversions_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Conversions_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Conversions_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Conversions_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Conversions_By_Criteria_InList_SP.START_ROW = i_Params_Get_Conversions_By_Criteria_InList.START_ROW;
oParams_Get_Conversions_By_Criteria_InList_SP.END_ROW = i_Params_Get_Conversions_By_Criteria_InList.END_ROW;
oParams_Get_Conversions_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Conversions_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Criteria_InList_Adv(i_Params_Get_Conversions_By_Criteria_InList.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Criteria_InList.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Criteria_InList.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Conversions_By_Criteria_InList.OWNER_ID,i_Params_Get_Conversions_By_Criteria_InList.START_ROW,i_Params_Get_Conversions_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Conversions_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Conversions_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Criteria_InList_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_Where_InList_Adv(Params_Get_Conversions_By_Where_InList i_Params_Get_Conversions_By_Where_InList)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Conversions_By_Where_InList_SP oParams_Get_Conversions_By_Where_InList_SP = new Params_Get_Conversions_By_Where_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Conversions_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Where_InList.START_ROW == null) { i_Params_Get_Conversions_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Where_InList.END_ROW == null) || (i_Params_Get_Conversions_By_Where_InList.END_ROW == 0)) { i_Params_Get_Conversions_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Conversions_By_Where_InList_SP.OWNER_ID = i_Params_Get_Conversions_By_Where_InList.OWNER_ID;
oParams_Get_Conversions_By_Where_InList_SP.CONVERSIONS_FROM = i_Params_Get_Conversions_By_Where_InList.CONVERSIONS_FROM;
oParams_Get_Conversions_By_Where_InList_SP.CONVERSIONS_FOR = i_Params_Get_Conversions_By_Where_InList.CONVERSIONS_FOR;
oParams_Get_Conversions_By_Where_InList_SP.CONVERSIONS_DESCRIPTION = i_Params_Get_Conversions_By_Where_InList.CONVERSIONS_DESCRIPTION;
if ( i_Params_Get_Conversions_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Conversions_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Conversions_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Conversions_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Conversions_By_Where_InList_SP.START_ROW = i_Params_Get_Conversions_By_Where_InList.START_ROW;
oParams_Get_Conversions_By_Where_InList_SP.END_ROW = i_Params_Get_Conversions_By_Where_InList.END_ROW;
oParams_Get_Conversions_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Conversions_By_Where_InList.TOTAL_COUNT;
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Where_InList_Adv(i_Params_Get_Conversions_By_Where_InList.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Where_InList.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Where_InList.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Conversions_By_Where_InList.OWNER_ID,i_Params_Get_Conversions_By_Where_InList.START_ROW,i_Params_Get_Conversions_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Where_InList.TOTAL_COUNT = oParams_Get_Conversions_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Conversions_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Where_InList_Adv");}
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_InList_Adv_V2(Params_Get_Conversions_By_Criteria_InList_V2 i_Params_Get_Conversions_By_Criteria_InList_V2)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Conversions_By_Criteria_InList_SP_V2 oParams_Get_Conversions_By_Criteria_InList_SP_V2 = new Params_Get_Conversions_By_Criteria_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Conversions_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Conversions_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Conversions_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Conversions_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Conversions_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Conversions_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Conversions_By_Criteria_InList_SP_V2.CONVERSIONS_FROM = i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_FROM;
oParams_Get_Conversions_By_Criteria_InList_SP_V2.CONVERSIONS_FOR = i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_FOR;
oParams_Get_Conversions_By_Criteria_InList_SP_V2.CONVERSIONS_DATE = i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_DATE;
oParams_Get_Conversions_By_Criteria_InList_SP_V2.CONVERSIONS_DESCRIPTION = i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_DESCRIPTION;
if ( i_Params_Get_Conversions_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Conversions_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Conversions_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Conversions_By_Criteria_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Conversions_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Conversions_By_Criteria_InList_V2.START_ROW;
oParams_Get_Conversions_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Conversions_By_Criteria_InList_V2.END_ROW;
oParams_Get_Conversions_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Conversions_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Criteria_InList_Adv_V2(i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_DATE,i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Conversions_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Conversions_By_Criteria_InList_V2.START_ROW,i_Params_Get_Conversions_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Conversions_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Conversions_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Conversions> Get_Conversions_By_Where_InList_Adv_V2(Params_Get_Conversions_By_Where_InList_V2 i_Params_Get_Conversions_By_Where_InList_V2)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Conversions_By_Where_InList_SP_V2 oParams_Get_Conversions_By_Where_InList_SP_V2 = new Params_Get_Conversions_By_Where_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Conversions_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Conversions_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Conversions_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Conversions_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Conversions_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Conversions_By_Where_InList_V2.OWNER_ID;
oParams_Get_Conversions_By_Where_InList_SP_V2.CONVERSIONS_FROM = i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_FROM;
oParams_Get_Conversions_By_Where_InList_SP_V2.CONVERSIONS_FOR = i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_FOR;
oParams_Get_Conversions_By_Where_InList_SP_V2.CONVERSIONS_DATE = i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_DATE;
oParams_Get_Conversions_By_Where_InList_SP_V2.CONVERSIONS_DESCRIPTION = i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_DESCRIPTION;
if ( i_Params_Get_Conversions_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Conversions_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Conversions_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Conversions_By_Where_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Conversions_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Conversions_By_Where_InList_V2.START_ROW;
oParams_Get_Conversions_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Conversions_By_Where_InList_V2.END_ROW;
oParams_Get_Conversions_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Conversions_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Where_InList_Adv_V2(i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_DATE,i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Conversions_By_Where_InList_V2.OWNER_ID,i_Params_Get_Conversions_By_Where_InList_V2.START_ROW,i_Params_Get_Conversions_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oConversions.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oConversions.My_Currency);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Conversions_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Conversions_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Where_InList_Adv_V2");}
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_InList_Adv(Params_Get_Coupons_By_Criteria_InList i_Params_Get_Coupons_By_Criteria_InList)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Coupons_By_Criteria_InList_SP oParams_Get_Coupons_By_Criteria_InList_SP = new Params_Get_Coupons_By_Criteria_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Coupons_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Criteria_InList.START_ROW == null) { i_Params_Get_Coupons_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Coupons_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Coupons_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Coupons_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Coupons_By_Criteria_InList.OWNER_ID;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_TYPE = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_TYPE;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_DESCRIPTION = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_DESCRIPTION;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_STORE = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_STORE;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_PAYMENT_WAITED = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_PAYMENT_WAITED;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_PAYMENT_DELIVERED = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_PAYMENT_DELIVERED;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_FOR = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_FOR;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_NOTE = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_NOTE;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_ITEM_TYPE = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_ITEM_TYPE;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_ITEM_QUANTITY = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_ITEM_QUANTITY;
oParams_Get_Coupons_By_Criteria_InList_SP.COUPONS_MACHINE = i_Params_Get_Coupons_By_Criteria_InList.COUPONS_MACHINE;
if ( i_Params_Get_Coupons_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Coupons_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Coupons_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Coupons_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Coupons_By_Criteria_InList_SP.START_ROW = i_Params_Get_Coupons_By_Criteria_InList.START_ROW;
oParams_Get_Coupons_By_Criteria_InList_SP.END_ROW = i_Params_Get_Coupons_By_Criteria_InList.END_ROW;
oParams_Get_Coupons_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Coupons_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Criteria_InList_Adv(i_Params_Get_Coupons_By_Criteria_InList.COUPONS_TYPE,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_STORE,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_FOR,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_NOTE,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_MACHINE,i_Params_Get_Coupons_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Coupons_By_Criteria_InList.OWNER_ID,i_Params_Get_Coupons_By_Criteria_InList.START_ROW,i_Params_Get_Coupons_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Coupons_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Coupons_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Criteria_InList_Adv");}
return oList;
}
public List<Coupons> Get_Coupons_By_Where_InList_Adv(Params_Get_Coupons_By_Where_InList i_Params_Get_Coupons_By_Where_InList)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Coupons_By_Where_InList_SP oParams_Get_Coupons_By_Where_InList_SP = new Params_Get_Coupons_By_Where_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Coupons_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Where_InList.START_ROW == null) { i_Params_Get_Coupons_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Where_InList.END_ROW == null) || (i_Params_Get_Coupons_By_Where_InList.END_ROW == 0)) { i_Params_Get_Coupons_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Coupons_By_Where_InList_SP.OWNER_ID = i_Params_Get_Coupons_By_Where_InList.OWNER_ID;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_TYPE = i_Params_Get_Coupons_By_Where_InList.COUPONS_TYPE;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_DESCRIPTION = i_Params_Get_Coupons_By_Where_InList.COUPONS_DESCRIPTION;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_STORE = i_Params_Get_Coupons_By_Where_InList.COUPONS_STORE;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_PAYMENT_WAITED = i_Params_Get_Coupons_By_Where_InList.COUPONS_PAYMENT_WAITED;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_PAYMENT_DELIVERED = i_Params_Get_Coupons_By_Where_InList.COUPONS_PAYMENT_DELIVERED;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_FOR = i_Params_Get_Coupons_By_Where_InList.COUPONS_FOR;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_NOTE = i_Params_Get_Coupons_By_Where_InList.COUPONS_NOTE;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_ITEM_TYPE = i_Params_Get_Coupons_By_Where_InList.COUPONS_ITEM_TYPE;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_ITEM_QUANTITY = i_Params_Get_Coupons_By_Where_InList.COUPONS_ITEM_QUANTITY;
oParams_Get_Coupons_By_Where_InList_SP.COUPONS_MACHINE = i_Params_Get_Coupons_By_Where_InList.COUPONS_MACHINE;
if ( i_Params_Get_Coupons_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Coupons_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Coupons_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Coupons_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Coupons_By_Where_InList_SP.START_ROW = i_Params_Get_Coupons_By_Where_InList.START_ROW;
oParams_Get_Coupons_By_Where_InList_SP.END_ROW = i_Params_Get_Coupons_By_Where_InList.END_ROW;
oParams_Get_Coupons_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Coupons_By_Where_InList.TOTAL_COUNT;
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Where_InList_Adv(i_Params_Get_Coupons_By_Where_InList.COUPONS_TYPE,i_Params_Get_Coupons_By_Where_InList.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Where_InList.COUPONS_STORE,i_Params_Get_Coupons_By_Where_InList.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Where_InList.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Where_InList.COUPONS_FOR,i_Params_Get_Coupons_By_Where_InList.COUPONS_NOTE,i_Params_Get_Coupons_By_Where_InList.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Where_InList.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Where_InList.COUPONS_MACHINE,i_Params_Get_Coupons_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Coupons_By_Where_InList.OWNER_ID,i_Params_Get_Coupons_By_Where_InList.START_ROW,i_Params_Get_Coupons_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Where_InList.TOTAL_COUNT = oParams_Get_Coupons_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Coupons_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Where_InList_Adv");}
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_InList_Adv_V2(Params_Get_Coupons_By_Criteria_InList_V2 i_Params_Get_Coupons_By_Criteria_InList_V2)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Coupons_By_Criteria_InList_SP_V2 oParams_Get_Coupons_By_Criteria_InList_SP_V2 = new Params_Get_Coupons_By_Criteria_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Coupons_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Coupons_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Coupons_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Coupons_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Coupons_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Coupons_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_TYPE = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_TYPE;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_DESCRIPTION = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_DESCRIPTION;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_STORE = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_STORE;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_DATE = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_DATE;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_PAYMENT_WAITED = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_PAYMENT_WAITED;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_PAYMENT_DELIVERED = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_PAYMENT_DELIVERED;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_FOR = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_FOR;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_NOTE = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_NOTE;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_ITEM_TYPE = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_ITEM_TYPE;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_ITEM_QUANTITY = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_ITEM_QUANTITY;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.COUPONS_MACHINE = i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_MACHINE;
if ( i_Params_Get_Coupons_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Coupons_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Coupons_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Coupons_By_Criteria_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Coupons_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Coupons_By_Criteria_InList_V2.START_ROW;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Coupons_By_Criteria_InList_V2.END_ROW;
oParams_Get_Coupons_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Coupons_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Criteria_InList_Adv_V2(i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_TYPE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_STORE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_DATE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_FOR,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_NOTE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_MACHINE,i_Params_Get_Coupons_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Coupons_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Coupons_By_Criteria_InList_V2.START_ROW,i_Params_Get_Coupons_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Coupons_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Coupons_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Coupons> Get_Coupons_By_Where_InList_Adv_V2(Params_Get_Coupons_By_Where_InList_V2 i_Params_Get_Coupons_By_Where_InList_V2)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Coupons_By_Where_InList_SP_V2 oParams_Get_Coupons_By_Where_InList_SP_V2 = new Params_Get_Coupons_By_Where_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Coupons_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Coupons_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Coupons_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Coupons_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Coupons_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Coupons_By_Where_InList_V2.OWNER_ID;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_TYPE = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_TYPE;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_DESCRIPTION = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_DESCRIPTION;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_STORE = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_STORE;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_DATE = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_DATE;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_PAYMENT_WAITED = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_PAYMENT_WAITED;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_PAYMENT_DELIVERED = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_PAYMENT_DELIVERED;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_FOR = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_FOR;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_NOTE = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_NOTE;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_ITEM_TYPE = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_ITEM_TYPE;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_ITEM_QUANTITY = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_ITEM_QUANTITY;
oParams_Get_Coupons_By_Where_InList_SP_V2.COUPONS_MACHINE = i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_MACHINE;
if ( i_Params_Get_Coupons_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Coupons_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Coupons_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Coupons_By_Where_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Coupons_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Coupons_By_Where_InList_V2.START_ROW;
oParams_Get_Coupons_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Coupons_By_Where_InList_V2.END_ROW;
oParams_Get_Coupons_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Coupons_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Where_InList_Adv_V2(i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_TYPE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_STORE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_DATE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_FOR,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_NOTE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_MACHINE,i_Params_Get_Coupons_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Coupons_By_Where_InList_V2.OWNER_ID,i_Params_Get_Coupons_By_Where_InList_V2.START_ROW,i_Params_Get_Coupons_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oCoupons.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oCoupons.My_Currency);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Coupons_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Coupons_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Where_InList_Adv_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_Adv(Params_Get_Fees_By_Criteria_InList i_Params_Get_Fees_By_Criteria_InList)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Fees_By_Criteria_InList_SP oParams_Get_Fees_By_Criteria_InList_SP = new Params_Get_Fees_By_Criteria_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria_InList.START_ROW == null) { i_Params_Get_Fees_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Fees_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Fees_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Fees_By_Criteria_InList.OWNER_ID;
oParams_Get_Fees_By_Criteria_InList_SP.FEES_DESCRIPTION = i_Params_Get_Fees_By_Criteria_InList.FEES_DESCRIPTION;
oParams_Get_Fees_By_Criteria_InList_SP.WORKSHOP_PAYMENT_DESCRIPTION = i_Params_Get_Fees_By_Criteria_InList.WORKSHOP_PAYMENT_DESCRIPTION;
oParams_Get_Fees_By_Criteria_InList_SP.FEES_STATUS = i_Params_Get_Fees_By_Criteria_InList.FEES_STATUS;
oParams_Get_Fees_By_Criteria_InList_SP.FEES_PAYMENT_GATEWAY = i_Params_Get_Fees_By_Criteria_InList.FEES_PAYMENT_GATEWAY;
oParams_Get_Fees_By_Criteria_InList_SP.FEES_STORE = i_Params_Get_Fees_By_Criteria_InList.FEES_STORE;
oParams_Get_Fees_By_Criteria_InList_SP.FEES_TYPE = i_Params_Get_Fees_By_Criteria_InList.FEES_TYPE;
if ( i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Fees_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Fees_By_Criteria_InList_SP.START_ROW = i_Params_Get_Fees_By_Criteria_InList.START_ROW;
oParams_Get_Fees_By_Criteria_InList_SP.END_ROW = i_Params_Get_Fees_By_Criteria_InList.END_ROW;
oParams_Get_Fees_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_InList_Adv(i_Params_Get_Fees_By_Criteria_InList.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList.FEES_STATUS,i_Params_Get_Fees_By_Criteria_InList.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Criteria_InList.FEES_STORE,i_Params_Get_Fees_By_Criteria_InList.FEES_TYPE,i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Fees_By_Criteria_InList.START_ROW,i_Params_Get_Fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_InList_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_Adv(Params_Get_Fees_By_Where_InList i_Params_Get_Fees_By_Where_InList)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Fees_By_Where_InList_SP oParams_Get_Fees_By_Where_InList_SP = new Params_Get_Fees_By_Where_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Fees_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where_InList.START_ROW == null) { i_Params_Get_Fees_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where_InList.END_ROW == null) || (i_Params_Get_Fees_By_Where_InList.END_ROW == 0)) { i_Params_Get_Fees_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Fees_By_Where_InList_SP.OWNER_ID = i_Params_Get_Fees_By_Where_InList.OWNER_ID;
oParams_Get_Fees_By_Where_InList_SP.FEES_DESCRIPTION = i_Params_Get_Fees_By_Where_InList.FEES_DESCRIPTION;
oParams_Get_Fees_By_Where_InList_SP.WORKSHOP_PAYMENT_DESCRIPTION = i_Params_Get_Fees_By_Where_InList.WORKSHOP_PAYMENT_DESCRIPTION;
oParams_Get_Fees_By_Where_InList_SP.FEES_STATUS = i_Params_Get_Fees_By_Where_InList.FEES_STATUS;
oParams_Get_Fees_By_Where_InList_SP.FEES_PAYMENT_GATEWAY = i_Params_Get_Fees_By_Where_InList.FEES_PAYMENT_GATEWAY;
oParams_Get_Fees_By_Where_InList_SP.FEES_STORE = i_Params_Get_Fees_By_Where_InList.FEES_STORE;
oParams_Get_Fees_By_Where_InList_SP.FEES_TYPE = i_Params_Get_Fees_By_Where_InList.FEES_TYPE;
if ( i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Fees_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Fees_By_Where_InList_SP.START_ROW = i_Params_Get_Fees_By_Where_InList.START_ROW;
oParams_Get_Fees_By_Where_InList_SP.END_ROW = i_Params_Get_Fees_By_Where_InList.END_ROW;
oParams_Get_Fees_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT;
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_InList_Adv(i_Params_Get_Fees_By_Where_InList.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_InList.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Where_InList.FEES_STATUS,i_Params_Get_Fees_By_Where_InList.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Where_InList.FEES_STORE,i_Params_Get_Fees_By_Where_InList.FEES_TYPE,i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Where_InList.OWNER_ID,i_Params_Get_Fees_By_Where_InList.START_ROW,i_Params_Get_Fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_InList_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_Adv_V2(Params_Get_Fees_By_Criteria_InList_V2 i_Params_Get_Fees_By_Criteria_InList_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Fees_By_Criteria_InList_SP_V2 oParams_Get_Fees_By_Criteria_InList_SP_V2 = new Params_Get_Fees_By_Criteria_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Fees_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Fees_By_Criteria_InList_SP_V2.FEES_DATE = i_Params_Get_Fees_By_Criteria_InList_V2.FEES_DATE;
oParams_Get_Fees_By_Criteria_InList_SP_V2.FEES_DESCRIPTION = i_Params_Get_Fees_By_Criteria_InList_V2.FEES_DESCRIPTION;
oParams_Get_Fees_By_Criteria_InList_SP_V2.WORKSHOP_PAYMENT_DESCRIPTION = i_Params_Get_Fees_By_Criteria_InList_V2.WORKSHOP_PAYMENT_DESCRIPTION;
oParams_Get_Fees_By_Criteria_InList_SP_V2.FEES_STATUS = i_Params_Get_Fees_By_Criteria_InList_V2.FEES_STATUS;
oParams_Get_Fees_By_Criteria_InList_SP_V2.FEES_PAYMENT_GATEWAY = i_Params_Get_Fees_By_Criteria_InList_V2.FEES_PAYMENT_GATEWAY;
oParams_Get_Fees_By_Criteria_InList_SP_V2.FEES_STORE = i_Params_Get_Fees_By_Criteria_InList_V2.FEES_STORE;
oParams_Get_Fees_By_Criteria_InList_SP_V2.FEES_TYPE = i_Params_Get_Fees_By_Criteria_InList_V2.FEES_TYPE;
if ( i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Fees_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Fees_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW;
oParams_Get_Fees_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW;
oParams_Get_Fees_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_InList_Adv_V2(i_Params_Get_Fees_By_Criteria_InList_V2.FEES_DATE,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList_V2.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_STATUS,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_STORE,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_TYPE,i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW,i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Fees_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_Adv_V2(Params_Get_Fees_By_Where_InList_V2 i_Params_Get_Fees_By_Where_InList_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Fees_By_Where_InList_SP_V2 oParams_Get_Fees_By_Where_InList_SP_V2 = new Params_Get_Fees_By_Where_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Fees_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Fees_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Fees_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID;
oParams_Get_Fees_By_Where_InList_SP_V2.FEES_DATE = i_Params_Get_Fees_By_Where_InList_V2.FEES_DATE;
oParams_Get_Fees_By_Where_InList_SP_V2.FEES_DESCRIPTION = i_Params_Get_Fees_By_Where_InList_V2.FEES_DESCRIPTION;
oParams_Get_Fees_By_Where_InList_SP_V2.WORKSHOP_PAYMENT_DESCRIPTION = i_Params_Get_Fees_By_Where_InList_V2.WORKSHOP_PAYMENT_DESCRIPTION;
oParams_Get_Fees_By_Where_InList_SP_V2.FEES_STATUS = i_Params_Get_Fees_By_Where_InList_V2.FEES_STATUS;
oParams_Get_Fees_By_Where_InList_SP_V2.FEES_PAYMENT_GATEWAY = i_Params_Get_Fees_By_Where_InList_V2.FEES_PAYMENT_GATEWAY;
oParams_Get_Fees_By_Where_InList_SP_V2.FEES_STORE = i_Params_Get_Fees_By_Where_InList_V2.FEES_STORE;
oParams_Get_Fees_By_Where_InList_SP_V2.FEES_TYPE = i_Params_Get_Fees_By_Where_InList_V2.FEES_TYPE;
if ( i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Fees_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Fees_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Fees_By_Where_InList_V2.START_ROW;
oParams_Get_Fees_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Fees_By_Where_InList_V2.END_ROW;
oParams_Get_Fees_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_InList_Adv_V2(i_Params_Get_Fees_By_Where_InList_V2.FEES_DATE,i_Params_Get_Fees_By_Where_InList_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_InList_V2.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Where_InList_V2.FEES_STATUS,i_Params_Get_Fees_By_Where_InList_V2.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Where_InList_V2.FEES_STORE,i_Params_Get_Fees_By_Where_InList_V2.FEES_TYPE,i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID,i_Params_Get_Fees_By_Where_InList_V2.START_ROW,i_Params_Get_Fees_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Fees_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_InList_Adv_V2");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv(Params_Get_Loc_l2_By_Criteria_InList i_Params_Get_Loc_l2_By_Criteria_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l2_By_Criteria_InList_SP oParams_Get_Loc_l2_By_Criteria_InList_SP = new Params_Get_Loc_l2_By_Criteria_InList_SP();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l2_By_Criteria_InList.CODE;
oParams_Get_Loc_l2_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_InList_Adv(i_Params_Get_Loc_l2_By_Criteria_InList.CODE,i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv(Params_Get_Loc_l2_By_Where_InList i_Params_Get_Loc_l2_By_Where_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l2_By_Where_InList_SP oParams_Get_Loc_l2_By_Where_InList_SP = new Params_Get_Loc_l2_By_Where_InList_SP();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Where_InList_SP.CODE = i_Params_Get_Loc_l2_By_Where_InList.CODE;
oParams_Get_Loc_l2_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Where_InList.START_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Where_InList.END_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_InList_Adv(i_Params_Get_Loc_l2_By_Where_InList.CODE,i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Where_InList.START_ROW,i_Params_Get_Loc_l2_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv(Params_Get_Loc_l3_By_Criteria_InList i_Params_Get_Loc_l3_By_Criteria_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l3_By_Criteria_InList_SP oParams_Get_Loc_l3_By_Criteria_InList_SP = new Params_Get_Loc_l3_By_Criteria_InList_SP();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l3_By_Criteria_InList.CODE;
oParams_Get_Loc_l3_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_InList_Adv(i_Params_Get_Loc_l3_By_Criteria_InList.CODE,i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv(Params_Get_Loc_l3_By_Where_InList i_Params_Get_Loc_l3_By_Where_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l3_By_Where_InList_SP oParams_Get_Loc_l3_By_Where_InList_SP = new Params_Get_Loc_l3_By_Where_InList_SP();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Where_InList_SP.CODE = i_Params_Get_Loc_l3_By_Where_InList.CODE;
oParams_Get_Loc_l3_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Where_InList.START_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Where_InList.END_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_InList_Adv(i_Params_Get_Loc_l3_By_Where_InList.CODE,i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Where_InList.START_ROW,i_Params_Get_Loc_l3_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv(Params_Get_Loc_l4_By_Criteria_InList i_Params_Get_Loc_l4_By_Criteria_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l4_By_Criteria_InList_SP oParams_Get_Loc_l4_By_Criteria_InList_SP = new Params_Get_Loc_l4_By_Criteria_InList_SP();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l4_By_Criteria_InList.CODE;
oParams_Get_Loc_l4_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_InList_Adv(i_Params_Get_Loc_l4_By_Criteria_InList.CODE,i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv(Params_Get_Loc_l4_By_Where_InList i_Params_Get_Loc_l4_By_Where_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l4_By_Where_InList_SP oParams_Get_Loc_l4_By_Where_InList_SP = new Params_Get_Loc_l4_By_Where_InList_SP();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Where_InList_SP.CODE = i_Params_Get_Loc_l4_By_Where_InList.CODE;
oParams_Get_Loc_l4_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Where_InList.START_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Where_InList.END_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_InList_Adv(i_Params_Get_Loc_l4_By_Where_InList.CODE,i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Where_InList.START_ROW,i_Params_Get_Loc_l4_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_InList_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_Criteria_InList_Adv(Params_Get_Machine_By_Criteria_InList i_Params_Get_Machine_By_Criteria_InList)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Machine_By_Criteria_InList_SP oParams_Get_Machine_By_Criteria_InList_SP = new Params_Get_Machine_By_Criteria_InList_SP();
Params_Get_Workshop_By_WORKSHOP_ID oParams_Get_Workshop_By_WORKSHOP_ID = new Params_Get_Workshop_By_WORKSHOP_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Machine_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Machine_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Machine_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Criteria_InList.START_ROW == null) { i_Params_Get_Machine_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Machine_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Machine_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Machine_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Machine_By_Criteria_InList.OWNER_ID;
oParams_Get_Machine_By_Criteria_InList_SP.MACHINE_DESCRIPTION = i_Params_Get_Machine_By_Criteria_InList.MACHINE_DESCRIPTION;
oParams_Get_Machine_By_Criteria_InList_SP.MACHINE_NOTES = i_Params_Get_Machine_By_Criteria_InList.MACHINE_NOTES;
if ( i_Params_Get_Machine_By_Criteria_InList.WORKSHOP_ID_LIST == null)
{
i_Params_Get_Machine_By_Criteria_InList.WORKSHOP_ID_LIST = new List<Int32?>();
}
oParams_Get_Machine_By_Criteria_InList_SP.WORKSHOP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Machine_By_Criteria_InList.WORKSHOP_ID_LIST);
oParams_Get_Machine_By_Criteria_InList_SP.START_ROW = i_Params_Get_Machine_By_Criteria_InList.START_ROW;
oParams_Get_Machine_By_Criteria_InList_SP.END_ROW = i_Params_Get_Machine_By_Criteria_InList.END_ROW;
oParams_Get_Machine_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Machine_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Criteria_InList_Adv(i_Params_Get_Machine_By_Criteria_InList.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Criteria_InList.MACHINE_NOTES,i_Params_Get_Machine_By_Criteria_InList.WORKSHOP_ID_LIST,i_Params_Get_Machine_By_Criteria_InList.OWNER_ID,i_Params_Get_Machine_By_Criteria_InList.START_ROW,i_Params_Get_Machine_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Machine_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Machine_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Criteria_InList_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_Where_InList_Adv(Params_Get_Machine_By_Where_InList i_Params_Get_Machine_By_Where_InList)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Machine_By_Where_InList_SP oParams_Get_Machine_By_Where_InList_SP = new Params_Get_Machine_By_Where_InList_SP();
Params_Get_Workshop_By_WORKSHOP_ID oParams_Get_Workshop_By_WORKSHOP_ID = new Params_Get_Workshop_By_WORKSHOP_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Machine_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Machine_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Machine_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Where_InList.START_ROW == null) { i_Params_Get_Machine_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Where_InList.END_ROW == null) || (i_Params_Get_Machine_By_Where_InList.END_ROW == 0)) { i_Params_Get_Machine_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Machine_By_Where_InList_SP.OWNER_ID = i_Params_Get_Machine_By_Where_InList.OWNER_ID;
oParams_Get_Machine_By_Where_InList_SP.MACHINE_DESCRIPTION = i_Params_Get_Machine_By_Where_InList.MACHINE_DESCRIPTION;
oParams_Get_Machine_By_Where_InList_SP.MACHINE_NOTES = i_Params_Get_Machine_By_Where_InList.MACHINE_NOTES;
if ( i_Params_Get_Machine_By_Where_InList.WORKSHOP_ID_LIST == null)
{
i_Params_Get_Machine_By_Where_InList.WORKSHOP_ID_LIST = new List<Int32?>();
}
oParams_Get_Machine_By_Where_InList_SP.WORKSHOP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Machine_By_Where_InList.WORKSHOP_ID_LIST);
oParams_Get_Machine_By_Where_InList_SP.START_ROW = i_Params_Get_Machine_By_Where_InList.START_ROW;
oParams_Get_Machine_By_Where_InList_SP.END_ROW = i_Params_Get_Machine_By_Where_InList.END_ROW;
oParams_Get_Machine_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Machine_By_Where_InList.TOTAL_COUNT;
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Where_InList_Adv(i_Params_Get_Machine_By_Where_InList.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Where_InList.MACHINE_NOTES,i_Params_Get_Machine_By_Where_InList.WORKSHOP_ID_LIST,i_Params_Get_Machine_By_Where_InList.OWNER_ID,i_Params_Get_Machine_By_Where_InList.START_ROW,i_Params_Get_Machine_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Where_InList.TOTAL_COUNT = oParams_Get_Machine_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Machine_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Where_InList_Adv");}
return oList;
}
public List<Machine> Get_Machine_By_Criteria_InList_Adv_V2(Params_Get_Machine_By_Criteria_InList_V2 i_Params_Get_Machine_By_Criteria_InList_V2)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Machine_By_Criteria_InList_SP_V2 oParams_Get_Machine_By_Criteria_InList_SP_V2 = new Params_Get_Machine_By_Criteria_InList_SP_V2();
Params_Get_Workshop_By_WORKSHOP_ID oParams_Get_Workshop_By_WORKSHOP_ID = new Params_Get_Workshop_By_WORKSHOP_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Machine_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Machine_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Machine_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Machine_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Machine_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Machine_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Machine_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Machine_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Machine_By_Criteria_InList_SP_V2.MACHINE_DATE = i_Params_Get_Machine_By_Criteria_InList_V2.MACHINE_DATE;
oParams_Get_Machine_By_Criteria_InList_SP_V2.MACHINE_DESCRIPTION = i_Params_Get_Machine_By_Criteria_InList_V2.MACHINE_DESCRIPTION;
oParams_Get_Machine_By_Criteria_InList_SP_V2.MACHINE_NOTES = i_Params_Get_Machine_By_Criteria_InList_V2.MACHINE_NOTES;
if ( i_Params_Get_Machine_By_Criteria_InList_V2.WORKSHOP_ID_LIST == null)
{
i_Params_Get_Machine_By_Criteria_InList_V2.WORKSHOP_ID_LIST = new List<Int32?>();
}
oParams_Get_Machine_By_Criteria_InList_SP_V2.WORKSHOP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Machine_By_Criteria_InList_V2.WORKSHOP_ID_LIST);
oParams_Get_Machine_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Machine_By_Criteria_InList_V2.START_ROW;
oParams_Get_Machine_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Machine_By_Criteria_InList_V2.END_ROW;
oParams_Get_Machine_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Machine_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Criteria_InList_Adv_V2(i_Params_Get_Machine_By_Criteria_InList_V2.MACHINE_DATE,i_Params_Get_Machine_By_Criteria_InList_V2.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Criteria_InList_V2.MACHINE_NOTES,i_Params_Get_Machine_By_Criteria_InList_V2.WORKSHOP_ID_LIST,i_Params_Get_Machine_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Machine_By_Criteria_InList_V2.START_ROW,i_Params_Get_Machine_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Machine_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Machine_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Machine> Get_Machine_By_Where_InList_Adv_V2(Params_Get_Machine_By_Where_InList_V2 i_Params_Get_Machine_By_Where_InList_V2)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Machine_By_Where_InList_SP_V2 oParams_Get_Machine_By_Where_InList_SP_V2 = new Params_Get_Machine_By_Where_InList_SP_V2();
Params_Get_Workshop_By_WORKSHOP_ID oParams_Get_Workshop_By_WORKSHOP_ID = new Params_Get_Workshop_By_WORKSHOP_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Machine_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Machine_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Machine_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Machine_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Machine_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Machine_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Machine_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Machine_By_Where_InList_V2.OWNER_ID;
oParams_Get_Machine_By_Where_InList_SP_V2.MACHINE_DATE = i_Params_Get_Machine_By_Where_InList_V2.MACHINE_DATE;
oParams_Get_Machine_By_Where_InList_SP_V2.MACHINE_DESCRIPTION = i_Params_Get_Machine_By_Where_InList_V2.MACHINE_DESCRIPTION;
oParams_Get_Machine_By_Where_InList_SP_V2.MACHINE_NOTES = i_Params_Get_Machine_By_Where_InList_V2.MACHINE_NOTES;
if ( i_Params_Get_Machine_By_Where_InList_V2.WORKSHOP_ID_LIST == null)
{
i_Params_Get_Machine_By_Where_InList_V2.WORKSHOP_ID_LIST = new List<Int32?>();
}
oParams_Get_Machine_By_Where_InList_SP_V2.WORKSHOP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Machine_By_Where_InList_V2.WORKSHOP_ID_LIST);
oParams_Get_Machine_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Machine_By_Where_InList_V2.START_ROW;
oParams_Get_Machine_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Machine_By_Where_InList_V2.END_ROW;
oParams_Get_Machine_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Machine_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Where_InList_Adv_V2(i_Params_Get_Machine_By_Where_InList_V2.MACHINE_DATE,i_Params_Get_Machine_By_Where_InList_V2.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Where_InList_V2.MACHINE_NOTES,i_Params_Get_Machine_By_Where_InList_V2.WORKSHOP_ID_LIST,i_Params_Get_Machine_By_Where_InList_V2.OWNER_ID,i_Params_Get_Machine_By_Where_InList_V2.START_ROW,i_Params_Get_Machine_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oMachine.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oMachine.My_Workshop);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Machine_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Machine_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Where_InList_Adv_V2");}
return oList;
}
public List<Salary> Get_Salary_By_Criteria_InList_Adv(Params_Get_Salary_By_Criteria_InList i_Params_Get_Salary_By_Criteria_InList)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Salary_By_Criteria_InList_SP oParams_Get_Salary_By_Criteria_InList_SP = new Params_Get_Salary_By_Criteria_InList_SP();
Params_Get_Staff_By_STAFF_ID oParams_Get_Staff_By_STAFF_ID = new Params_Get_Staff_By_STAFF_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Salary_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Salary_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Salary_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Criteria_InList.START_ROW == null) { i_Params_Get_Salary_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Salary_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Salary_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Salary_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Salary_By_Criteria_InList.OWNER_ID;
oParams_Get_Salary_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Salary_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Salary_By_Criteria_InList.STAFF_ID_LIST == null)
{
i_Params_Get_Salary_By_Criteria_InList.STAFF_ID_LIST = new List<Int32?>();
}
oParams_Get_Salary_By_Criteria_InList_SP.STAFF_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Salary_By_Criteria_InList.STAFF_ID_LIST);
if ( i_Params_Get_Salary_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Salary_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Salary_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Salary_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Salary_By_Criteria_InList_SP.START_ROW = i_Params_Get_Salary_By_Criteria_InList.START_ROW;
oParams_Get_Salary_By_Criteria_InList_SP.END_ROW = i_Params_Get_Salary_By_Criteria_InList.END_ROW;
oParams_Get_Salary_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Salary_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Criteria_InList_Adv(i_Params_Get_Salary_By_Criteria_InList.DESCRIPTION,i_Params_Get_Salary_By_Criteria_InList.STAFF_ID_LIST,i_Params_Get_Salary_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Salary_By_Criteria_InList.OWNER_ID,i_Params_Get_Salary_By_Criteria_InList.START_ROW,i_Params_Get_Salary_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Salary_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Salary_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Criteria_InList_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_Where_InList_Adv(Params_Get_Salary_By_Where_InList i_Params_Get_Salary_By_Where_InList)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Salary_By_Where_InList_SP oParams_Get_Salary_By_Where_InList_SP = new Params_Get_Salary_By_Where_InList_SP();
Params_Get_Staff_By_STAFF_ID oParams_Get_Staff_By_STAFF_ID = new Params_Get_Staff_By_STAFF_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Salary_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Salary_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Salary_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Where_InList.START_ROW == null) { i_Params_Get_Salary_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Where_InList.END_ROW == null) || (i_Params_Get_Salary_By_Where_InList.END_ROW == 0)) { i_Params_Get_Salary_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Salary_By_Where_InList_SP.OWNER_ID = i_Params_Get_Salary_By_Where_InList.OWNER_ID;
oParams_Get_Salary_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Salary_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Salary_By_Where_InList.STAFF_ID_LIST == null)
{
i_Params_Get_Salary_By_Where_InList.STAFF_ID_LIST = new List<Int32?>();
}
oParams_Get_Salary_By_Where_InList_SP.STAFF_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Salary_By_Where_InList.STAFF_ID_LIST);
if ( i_Params_Get_Salary_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Salary_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Salary_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Salary_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Salary_By_Where_InList_SP.START_ROW = i_Params_Get_Salary_By_Where_InList.START_ROW;
oParams_Get_Salary_By_Where_InList_SP.END_ROW = i_Params_Get_Salary_By_Where_InList.END_ROW;
oParams_Get_Salary_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Salary_By_Where_InList.TOTAL_COUNT;
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Where_InList_Adv(i_Params_Get_Salary_By_Where_InList.DESCRIPTION,i_Params_Get_Salary_By_Where_InList.STAFF_ID_LIST,i_Params_Get_Salary_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Salary_By_Where_InList.OWNER_ID,i_Params_Get_Salary_By_Where_InList.START_ROW,i_Params_Get_Salary_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Where_InList.TOTAL_COUNT = oParams_Get_Salary_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Salary_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Where_InList_Adv");}
return oList;
}
public List<Salary> Get_Salary_By_Criteria_InList_Adv_V2(Params_Get_Salary_By_Criteria_InList_V2 i_Params_Get_Salary_By_Criteria_InList_V2)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Salary_By_Criteria_InList_SP_V2 oParams_Get_Salary_By_Criteria_InList_SP_V2 = new Params_Get_Salary_By_Criteria_InList_SP_V2();
Params_Get_Staff_By_STAFF_ID oParams_Get_Staff_By_STAFF_ID = new Params_Get_Staff_By_STAFF_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Salary_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Salary_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Salary_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Salary_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Salary_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Salary_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Salary_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Salary_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Salary_By_Criteria_InList_SP_V2.SALARY_DATE = i_Params_Get_Salary_By_Criteria_InList_V2.SALARY_DATE;
oParams_Get_Salary_By_Criteria_InList_SP_V2.DESCRIPTION = i_Params_Get_Salary_By_Criteria_InList_V2.DESCRIPTION;
if ( i_Params_Get_Salary_By_Criteria_InList_V2.STAFF_ID_LIST == null)
{
i_Params_Get_Salary_By_Criteria_InList_V2.STAFF_ID_LIST = new List<Int32?>();
}
oParams_Get_Salary_By_Criteria_InList_SP_V2.STAFF_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Salary_By_Criteria_InList_V2.STAFF_ID_LIST);
if ( i_Params_Get_Salary_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Salary_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Salary_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Salary_By_Criteria_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Salary_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Salary_By_Criteria_InList_V2.START_ROW;
oParams_Get_Salary_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Salary_By_Criteria_InList_V2.END_ROW;
oParams_Get_Salary_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Salary_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Criteria_InList_Adv_V2(i_Params_Get_Salary_By_Criteria_InList_V2.SALARY_DATE,i_Params_Get_Salary_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Salary_By_Criteria_InList_V2.STAFF_ID_LIST,i_Params_Get_Salary_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Salary_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Salary_By_Criteria_InList_V2.START_ROW,i_Params_Get_Salary_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Salary_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Salary_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Salary> Get_Salary_By_Where_InList_Adv_V2(Params_Get_Salary_By_Where_InList_V2 i_Params_Get_Salary_By_Where_InList_V2)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Salary_By_Where_InList_SP_V2 oParams_Get_Salary_By_Where_InList_SP_V2 = new Params_Get_Salary_By_Where_InList_SP_V2();
Params_Get_Staff_By_STAFF_ID oParams_Get_Staff_By_STAFF_ID = new Params_Get_Staff_By_STAFF_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Salary_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Salary_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Salary_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Salary_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Salary_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Salary_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Salary_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Salary_By_Where_InList_V2.OWNER_ID;
oParams_Get_Salary_By_Where_InList_SP_V2.SALARY_DATE = i_Params_Get_Salary_By_Where_InList_V2.SALARY_DATE;
oParams_Get_Salary_By_Where_InList_SP_V2.DESCRIPTION = i_Params_Get_Salary_By_Where_InList_V2.DESCRIPTION;
if ( i_Params_Get_Salary_By_Where_InList_V2.STAFF_ID_LIST == null)
{
i_Params_Get_Salary_By_Where_InList_V2.STAFF_ID_LIST = new List<Int32?>();
}
oParams_Get_Salary_By_Where_InList_SP_V2.STAFF_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Salary_By_Where_InList_V2.STAFF_ID_LIST);
if ( i_Params_Get_Salary_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Salary_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Salary_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Salary_By_Where_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Salary_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Salary_By_Where_InList_V2.START_ROW;
oParams_Get_Salary_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Salary_By_Where_InList_V2.END_ROW;
oParams_Get_Salary_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Salary_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Where_InList_Adv_V2(i_Params_Get_Salary_By_Where_InList_V2.SALARY_DATE,i_Params_Get_Salary_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Salary_By_Where_InList_V2.STAFF_ID_LIST,i_Params_Get_Salary_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Salary_By_Where_InList_V2.OWNER_ID,i_Params_Get_Salary_By_Where_InList_V2.START_ROW,i_Params_Get_Salary_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oSalary.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oSalary.My_Staff);
oSalary.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSalary.My_Currency);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Salary_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Salary_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Where_InList_Adv_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList_Adv(Params_Get_Staff_By_Criteria_InList i_Params_Get_Staff_By_Criteria_InList)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Staff_By_Criteria_InList_SP oParams_Get_Staff_By_Criteria_InList_SP = new Params_Get_Staff_By_Criteria_InList_SP();
Params_Get_Workshop_By_WORKSHOP_ID oParams_Get_Workshop_By_WORKSHOP_ID = new Params_Get_Workshop_By_WORKSHOP_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria_InList.START_ROW == null) { i_Params_Get_Staff_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Staff_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Staff_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Staff_By_Criteria_InList.OWNER_ID;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_NAME = i_Params_Get_Staff_By_Criteria_InList.STAFF_NAME;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_PAYMENT_DESCRIPTION = i_Params_Get_Staff_By_Criteria_InList.STAFF_PAYMENT_DESCRIPTION;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_REFERENCE = i_Params_Get_Staff_By_Criteria_InList.STAFF_REFERENCE;
if ( i_Params_Get_Staff_By_Criteria_InList.WORKSHOP_ID_LIST == null)
{
i_Params_Get_Staff_By_Criteria_InList.WORKSHOP_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Criteria_InList_SP.WORKSHOP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Criteria_InList.WORKSHOP_ID_LIST);
if ( i_Params_Get_Staff_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Staff_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Staff_By_Criteria_InList_SP.START_ROW = i_Params_Get_Staff_By_Criteria_InList.START_ROW;
oParams_Get_Staff_By_Criteria_InList_SP.END_ROW = i_Params_Get_Staff_By_Criteria_InList.END_ROW;
oParams_Get_Staff_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_InList_Adv(i_Params_Get_Staff_By_Criteria_InList.STAFF_NAME,i_Params_Get_Staff_By_Criteria_InList.STAFF_PAYMENT_DESCRIPTION,i_Params_Get_Staff_By_Criteria_InList.STAFF_REFERENCE,i_Params_Get_Staff_By_Criteria_InList.WORKSHOP_ID_LIST,i_Params_Get_Staff_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Staff_By_Criteria_InList.OWNER_ID,i_Params_Get_Staff_By_Criteria_InList.START_ROW,i_Params_Get_Staff_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Staff_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_InList_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_Where_InList_Adv(Params_Get_Staff_By_Where_InList i_Params_Get_Staff_By_Where_InList)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Staff_By_Where_InList_SP oParams_Get_Staff_By_Where_InList_SP = new Params_Get_Staff_By_Where_InList_SP();
Params_Get_Workshop_By_WORKSHOP_ID oParams_Get_Workshop_By_WORKSHOP_ID = new Params_Get_Workshop_By_WORKSHOP_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Staff_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where_InList.START_ROW == null) { i_Params_Get_Staff_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where_InList.END_ROW == null) || (i_Params_Get_Staff_By_Where_InList.END_ROW == 0)) { i_Params_Get_Staff_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Staff_By_Where_InList_SP.OWNER_ID = i_Params_Get_Staff_By_Where_InList.OWNER_ID;
oParams_Get_Staff_By_Where_InList_SP.STAFF_NAME = i_Params_Get_Staff_By_Where_InList.STAFF_NAME;
oParams_Get_Staff_By_Where_InList_SP.STAFF_PAYMENT_DESCRIPTION = i_Params_Get_Staff_By_Where_InList.STAFF_PAYMENT_DESCRIPTION;
oParams_Get_Staff_By_Where_InList_SP.STAFF_REFERENCE = i_Params_Get_Staff_By_Where_InList.STAFF_REFERENCE;
if ( i_Params_Get_Staff_By_Where_InList.WORKSHOP_ID_LIST == null)
{
i_Params_Get_Staff_By_Where_InList.WORKSHOP_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Where_InList_SP.WORKSHOP_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Where_InList.WORKSHOP_ID_LIST);
if ( i_Params_Get_Staff_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Staff_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Staff_By_Where_InList_SP.START_ROW = i_Params_Get_Staff_By_Where_InList.START_ROW;
oParams_Get_Staff_By_Where_InList_SP.END_ROW = i_Params_Get_Staff_By_Where_InList.END_ROW;
oParams_Get_Staff_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_InList_Adv(i_Params_Get_Staff_By_Where_InList.STAFF_NAME,i_Params_Get_Staff_By_Where_InList.STAFF_PAYMENT_DESCRIPTION,i_Params_Get_Staff_By_Where_InList.STAFF_REFERENCE,i_Params_Get_Staff_By_Where_InList.WORKSHOP_ID_LIST,i_Params_Get_Staff_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Staff_By_Where_InList.OWNER_ID,i_Params_Get_Staff_By_Where_InList.START_ROW,i_Params_Get_Staff_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Workshop = new Workshop();
oTools.CopyPropValues(oDBEntry.My_Workshop, oStaff.My_Workshop);
oStaff.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff.My_Currency);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT = oParams_Get_Staff_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_InList_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_Adv(Params_Get_Supplier_By_Criteria_InList i_Params_Get_Supplier_By_Criteria_InList)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_By_Criteria_InList_SP oParams_Get_Supplier_By_Criteria_InList_SP = new Params_Get_Supplier_By_Criteria_InList_SP();
Params_Get_Coupons_By_COUPONS_ID oParams_Get_Coupons_By_COUPONS_ID = new Params_Get_Coupons_By_COUPONS_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_InList.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Supplier_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID;
oParams_Get_Supplier_By_Criteria_InList_SP.SUPPLIER_PAYMENT_CAUSE = i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_PAYMENT_CAUSE;
if ( i_Params_Get_Supplier_By_Criteria_InList.COUPONS_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList.COUPONS_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP.COUPONS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList.COUPONS_ID_LIST);
if ( i_Params_Get_Supplier_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList.CURRENCY_ID_LIST);
if ( i_Params_Get_Supplier_By_Criteria_InList.STOCK_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList.STOCK_ID_LIST);
oParams_Get_Supplier_By_Criteria_InList_SP.START_ROW = i_Params_Get_Supplier_By_Criteria_InList.START_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP.END_ROW = i_Params_Get_Supplier_By_Criteria_InList.END_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_InList_Adv(i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Criteria_InList.COUPONS_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList.STOCK_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID,i_Params_Get_Supplier_By_Criteria_InList.START_ROW,i_Params_Get_Supplier_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Supplier_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_InList_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_Adv(Params_Get_Supplier_By_Where_InList i_Params_Get_Supplier_By_Where_InList)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_By_Where_InList_SP oParams_Get_Supplier_By_Where_InList_SP = new Params_Get_Supplier_By_Where_InList_SP();
Params_Get_Coupons_By_COUPONS_ID oParams_Get_Coupons_By_COUPONS_ID = new Params_Get_Coupons_By_COUPONS_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_InList.START_ROW == null) { i_Params_Get_Supplier_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_InList.END_ROW == null) || (i_Params_Get_Supplier_By_Where_InList.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Supplier_By_Where_InList_SP.OWNER_ID = i_Params_Get_Supplier_By_Where_InList.OWNER_ID;
oParams_Get_Supplier_By_Where_InList_SP.SUPPLIER_PAYMENT_CAUSE = i_Params_Get_Supplier_By_Where_InList.SUPPLIER_PAYMENT_CAUSE;
if ( i_Params_Get_Supplier_By_Where_InList.COUPONS_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList.COUPONS_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP.COUPONS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList.COUPONS_ID_LIST);
if ( i_Params_Get_Supplier_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList.CURRENCY_ID_LIST);
if ( i_Params_Get_Supplier_By_Where_InList.STOCK_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList.STOCK_ID_LIST);
oParams_Get_Supplier_By_Where_InList_SP.START_ROW = i_Params_Get_Supplier_By_Where_InList.START_ROW;
oParams_Get_Supplier_By_Where_InList_SP.END_ROW = i_Params_Get_Supplier_By_Where_InList.END_ROW;
oParams_Get_Supplier_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_InList_Adv(i_Params_Get_Supplier_By_Where_InList.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Where_InList.COUPONS_ID_LIST,i_Params_Get_Supplier_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Supplier_By_Where_InList.STOCK_ID_LIST,i_Params_Get_Supplier_By_Where_InList.OWNER_ID,i_Params_Get_Supplier_By_Where_InList.START_ROW,i_Params_Get_Supplier_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT = oParams_Get_Supplier_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_InList_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_Adv_V2(Params_Get_Supplier_By_Criteria_InList_V2 i_Params_Get_Supplier_By_Criteria_InList_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_By_Criteria_InList_SP_V2 oParams_Get_Supplier_By_Criteria_InList_SP_V2 = new Params_Get_Supplier_By_Criteria_InList_SP_V2();
Params_Get_Coupons_By_COUPONS_ID oParams_Get_Coupons_By_COUPONS_ID = new Params_Get_Coupons_By_COUPONS_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Supplier_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_PAYMENT_DATE = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PAYMENT_DATE;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_PAYMENT_CAUSE = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PAYMENT_CAUSE;
if ( i_Params_Get_Supplier_By_Criteria_InList_V2.COUPONS_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList_V2.COUPONS_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP_V2.COUPONS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList_V2.COUPONS_ID_LIST);
if ( i_Params_Get_Supplier_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList_V2.CURRENCY_ID_LIST);
if ( i_Params_Get_Supplier_By_Criteria_InList_V2.STOCK_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList_V2.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP_V2.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList_V2.STOCK_ID_LIST);
oParams_Get_Supplier_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_InList_Adv_V2(i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PAYMENT_DATE,i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Criteria_InList_V2.COUPONS_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList_V2.STOCK_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW,i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Supplier_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_Adv_V2(Params_Get_Supplier_By_Where_InList_V2 i_Params_Get_Supplier_By_Where_InList_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_By_Where_InList_SP_V2 oParams_Get_Supplier_By_Where_InList_SP_V2 = new Params_Get_Supplier_By_Where_InList_SP_V2();
Params_Get_Coupons_By_COUPONS_ID oParams_Get_Coupons_By_COUPONS_ID = new Params_Get_Coupons_By_COUPONS_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Supplier_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Supplier_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_PAYMENT_DATE = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PAYMENT_DATE;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_PAYMENT_CAUSE = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PAYMENT_CAUSE;
if ( i_Params_Get_Supplier_By_Where_InList_V2.COUPONS_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList_V2.COUPONS_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP_V2.COUPONS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList_V2.COUPONS_ID_LIST);
if ( i_Params_Get_Supplier_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList_V2.CURRENCY_ID_LIST);
if ( i_Params_Get_Supplier_By_Where_InList_V2.STOCK_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList_V2.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP_V2.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList_V2.STOCK_ID_LIST);
oParams_Get_Supplier_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Supplier_By_Where_InList_V2.START_ROW;
oParams_Get_Supplier_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Supplier_By_Where_InList_V2.END_ROW;
oParams_Get_Supplier_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_InList_Adv_V2(i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PAYMENT_DATE,i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Where_InList_V2.COUPONS_ID_LIST,i_Params_Get_Supplier_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Supplier_By_Where_InList_V2.STOCK_ID_LIST,i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID,i_Params_Get_Supplier_By_Where_InList_V2.START_ROW,i_Params_Get_Supplier_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Coupons = new Coupons();
oTools.CopyPropValues(oDBEntry.My_Coupons, oSupplier.My_Coupons);
oSupplier.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier.My_Currency);
oSupplier.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oSupplier.My_Stock);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Supplier_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_InList_Adv_V2");}
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_InList_Adv(Params_Get_Workshop_By_Criteria_InList i_Params_Get_Workshop_By_Criteria_InList)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Workshop_By_Criteria_InList_SP oParams_Get_Workshop_By_Criteria_InList_SP = new Params_Get_Workshop_By_Criteria_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
Params_Get_Machine_By_MACHINE_ID oParams_Get_Machine_By_MACHINE_ID = new Params_Get_Machine_By_MACHINE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Workshop_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Criteria_InList.START_ROW == null) { i_Params_Get_Workshop_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Workshop_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Workshop_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Workshop_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Workshop_By_Criteria_InList.OWNER_ID;
oParams_Get_Workshop_By_Criteria_InList_SP.WORKSHOP_FEES_DESCRIPTION = i_Params_Get_Workshop_By_Criteria_InList.WORKSHOP_FEES_DESCRIPTION;
if ( i_Params_Get_Workshop_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Workshop_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Criteria_InList.CURRENCY_ID_LIST);
if ( i_Params_Get_Workshop_By_Criteria_InList.STOCK_ID_LIST == null)
{
i_Params_Get_Workshop_By_Criteria_InList.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Criteria_InList_SP.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Criteria_InList.STOCK_ID_LIST);
if ( i_Params_Get_Workshop_By_Criteria_InList.MACHINE_ID_LIST == null)
{
i_Params_Get_Workshop_By_Criteria_InList.MACHINE_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Criteria_InList_SP.MACHINE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Criteria_InList.MACHINE_ID_LIST);
oParams_Get_Workshop_By_Criteria_InList_SP.START_ROW = i_Params_Get_Workshop_By_Criteria_InList.START_ROW;
oParams_Get_Workshop_By_Criteria_InList_SP.END_ROW = i_Params_Get_Workshop_By_Criteria_InList.END_ROW;
oParams_Get_Workshop_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Workshop_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Criteria_InList_Adv(i_Params_Get_Workshop_By_Criteria_InList.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList.STOCK_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList.MACHINE_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList.OWNER_ID,i_Params_Get_Workshop_By_Criteria_InList.START_ROW,i_Params_Get_Workshop_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Workshop_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Workshop_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Criteria_InList_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_Where_InList_Adv(Params_Get_Workshop_By_Where_InList i_Params_Get_Workshop_By_Where_InList)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Workshop_By_Where_InList_SP oParams_Get_Workshop_By_Where_InList_SP = new Params_Get_Workshop_By_Where_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
Params_Get_Machine_By_MACHINE_ID oParams_Get_Machine_By_MACHINE_ID = new Params_Get_Machine_By_MACHINE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Workshop_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Where_InList.START_ROW == null) { i_Params_Get_Workshop_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Where_InList.END_ROW == null) || (i_Params_Get_Workshop_By_Where_InList.END_ROW == 0)) { i_Params_Get_Workshop_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Workshop_By_Where_InList_SP.OWNER_ID = i_Params_Get_Workshop_By_Where_InList.OWNER_ID;
oParams_Get_Workshop_By_Where_InList_SP.WORKSHOP_FEES_DESCRIPTION = i_Params_Get_Workshop_By_Where_InList.WORKSHOP_FEES_DESCRIPTION;
if ( i_Params_Get_Workshop_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Workshop_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Where_InList.CURRENCY_ID_LIST);
if ( i_Params_Get_Workshop_By_Where_InList.STOCK_ID_LIST == null)
{
i_Params_Get_Workshop_By_Where_InList.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Where_InList_SP.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Where_InList.STOCK_ID_LIST);
if ( i_Params_Get_Workshop_By_Where_InList.MACHINE_ID_LIST == null)
{
i_Params_Get_Workshop_By_Where_InList.MACHINE_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Where_InList_SP.MACHINE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Where_InList.MACHINE_ID_LIST);
oParams_Get_Workshop_By_Where_InList_SP.START_ROW = i_Params_Get_Workshop_By_Where_InList.START_ROW;
oParams_Get_Workshop_By_Where_InList_SP.END_ROW = i_Params_Get_Workshop_By_Where_InList.END_ROW;
oParams_Get_Workshop_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Workshop_By_Where_InList.TOTAL_COUNT;
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Where_InList_Adv(i_Params_Get_Workshop_By_Where_InList.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Workshop_By_Where_InList.STOCK_ID_LIST,i_Params_Get_Workshop_By_Where_InList.MACHINE_ID_LIST,i_Params_Get_Workshop_By_Where_InList.OWNER_ID,i_Params_Get_Workshop_By_Where_InList.START_ROW,i_Params_Get_Workshop_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Where_InList.TOTAL_COUNT = oParams_Get_Workshop_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Workshop_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Where_InList_Adv");}
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_InList_Adv_V2(Params_Get_Workshop_By_Criteria_InList_V2 i_Params_Get_Workshop_By_Criteria_InList_V2)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Workshop_By_Criteria_InList_SP_V2 oParams_Get_Workshop_By_Criteria_InList_SP_V2 = new Params_Get_Workshop_By_Criteria_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
Params_Get_Machine_By_MACHINE_ID oParams_Get_Machine_By_MACHINE_ID = new Params_Get_Machine_By_MACHINE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Workshop_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Workshop_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Workshop_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Workshop_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Workshop_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Workshop_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Workshop_By_Criteria_InList_SP_V2.WORKSHOP_BEGINNING_DATE = i_Params_Get_Workshop_By_Criteria_InList_V2.WORKSHOP_BEGINNING_DATE;
oParams_Get_Workshop_By_Criteria_InList_SP_V2.WORKSHOP_FEES_DESCRIPTION = i_Params_Get_Workshop_By_Criteria_InList_V2.WORKSHOP_FEES_DESCRIPTION;
if ( i_Params_Get_Workshop_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Workshop_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Criteria_InList_V2.CURRENCY_ID_LIST);
if ( i_Params_Get_Workshop_By_Criteria_InList_V2.STOCK_ID_LIST == null)
{
i_Params_Get_Workshop_By_Criteria_InList_V2.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Criteria_InList_SP_V2.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Criteria_InList_V2.STOCK_ID_LIST);
if ( i_Params_Get_Workshop_By_Criteria_InList_V2.MACHINE_ID_LIST == null)
{
i_Params_Get_Workshop_By_Criteria_InList_V2.MACHINE_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Criteria_InList_SP_V2.MACHINE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Criteria_InList_V2.MACHINE_ID_LIST);
oParams_Get_Workshop_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Workshop_By_Criteria_InList_V2.START_ROW;
oParams_Get_Workshop_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Workshop_By_Criteria_InList_V2.END_ROW;
oParams_Get_Workshop_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Workshop_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Criteria_InList_Adv_V2(i_Params_Get_Workshop_By_Criteria_InList_V2.WORKSHOP_BEGINNING_DATE,i_Params_Get_Workshop_By_Criteria_InList_V2.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList_V2.STOCK_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList_V2.MACHINE_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Workshop_By_Criteria_InList_V2.START_ROW,i_Params_Get_Workshop_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Workshop_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Workshop_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Workshop> Get_Workshop_By_Where_InList_Adv_V2(Params_Get_Workshop_By_Where_InList_V2 i_Params_Get_Workshop_By_Where_InList_V2)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Workshop_By_Where_InList_SP_V2 oParams_Get_Workshop_By_Where_InList_SP_V2 = new Params_Get_Workshop_By_Where_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
Params_Get_Machine_By_MACHINE_ID oParams_Get_Machine_By_MACHINE_ID = new Params_Get_Machine_By_MACHINE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Workshop_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Workshop_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Workshop_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Workshop_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Workshop_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Workshop_By_Where_InList_V2.OWNER_ID;
oParams_Get_Workshop_By_Where_InList_SP_V2.WORKSHOP_BEGINNING_DATE = i_Params_Get_Workshop_By_Where_InList_V2.WORKSHOP_BEGINNING_DATE;
oParams_Get_Workshop_By_Where_InList_SP_V2.WORKSHOP_FEES_DESCRIPTION = i_Params_Get_Workshop_By_Where_InList_V2.WORKSHOP_FEES_DESCRIPTION;
if ( i_Params_Get_Workshop_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Workshop_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Where_InList_V2.CURRENCY_ID_LIST);
if ( i_Params_Get_Workshop_By_Where_InList_V2.STOCK_ID_LIST == null)
{
i_Params_Get_Workshop_By_Where_InList_V2.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Where_InList_SP_V2.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Where_InList_V2.STOCK_ID_LIST);
if ( i_Params_Get_Workshop_By_Where_InList_V2.MACHINE_ID_LIST == null)
{
i_Params_Get_Workshop_By_Where_InList_V2.MACHINE_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshop_By_Where_InList_SP_V2.MACHINE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshop_By_Where_InList_V2.MACHINE_ID_LIST);
oParams_Get_Workshop_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Workshop_By_Where_InList_V2.START_ROW;
oParams_Get_Workshop_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Workshop_By_Where_InList_V2.END_ROW;
oParams_Get_Workshop_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Workshop_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Where_InList_Adv_V2(i_Params_Get_Workshop_By_Where_InList_V2.WORKSHOP_BEGINNING_DATE,i_Params_Get_Workshop_By_Where_InList_V2.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Workshop_By_Where_InList_V2.STOCK_ID_LIST,i_Params_Get_Workshop_By_Where_InList_V2.MACHINE_ID_LIST,i_Params_Get_Workshop_By_Where_InList_V2.OWNER_ID,i_Params_Get_Workshop_By_Where_InList_V2.START_ROW,i_Params_Get_Workshop_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oWorkshop.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshop.My_Currency);
oWorkshop.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshop.My_Stock);
oWorkshop.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshop.My_Machine);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Workshop_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Workshop_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Where_InList_Adv_V2");}
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_InList_Adv(Params_Get_Workshops_By_Criteria_InList i_Params_Get_Workshops_By_Criteria_InList)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Workshops_By_Criteria_InList_SP oParams_Get_Workshops_By_Criteria_InList_SP = new Params_Get_Workshops_By_Criteria_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
Params_Get_Machine_By_MACHINE_ID oParams_Get_Machine_By_MACHINE_ID = new Params_Get_Machine_By_MACHINE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Workshops_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Criteria_InList.START_ROW == null) { i_Params_Get_Workshops_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Workshops_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Workshops_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Workshops_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Workshops_By_Criteria_InList.OWNER_ID;
oParams_Get_Workshops_By_Criteria_InList_SP.WORKSHOPS_FEES_DESCRIPTION = i_Params_Get_Workshops_By_Criteria_InList.WORKSHOPS_FEES_DESCRIPTION;
if ( i_Params_Get_Workshops_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Workshops_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Criteria_InList.CURRENCY_ID_LIST);
if ( i_Params_Get_Workshops_By_Criteria_InList.STOCK_ID_LIST == null)
{
i_Params_Get_Workshops_By_Criteria_InList.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Criteria_InList_SP.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Criteria_InList.STOCK_ID_LIST);
if ( i_Params_Get_Workshops_By_Criteria_InList.MACHINE_ID_LIST == null)
{
i_Params_Get_Workshops_By_Criteria_InList.MACHINE_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Criteria_InList_SP.MACHINE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Criteria_InList.MACHINE_ID_LIST);
oParams_Get_Workshops_By_Criteria_InList_SP.START_ROW = i_Params_Get_Workshops_By_Criteria_InList.START_ROW;
oParams_Get_Workshops_By_Criteria_InList_SP.END_ROW = i_Params_Get_Workshops_By_Criteria_InList.END_ROW;
oParams_Get_Workshops_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Workshops_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Criteria_InList_Adv(i_Params_Get_Workshops_By_Criteria_InList.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList.STOCK_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList.MACHINE_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList.OWNER_ID,i_Params_Get_Workshops_By_Criteria_InList.START_ROW,i_Params_Get_Workshops_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Workshops_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Workshops_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Criteria_InList_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_Where_InList_Adv(Params_Get_Workshops_By_Where_InList i_Params_Get_Workshops_By_Where_InList)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Workshops_By_Where_InList_SP oParams_Get_Workshops_By_Where_InList_SP = new Params_Get_Workshops_By_Where_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
Params_Get_Machine_By_MACHINE_ID oParams_Get_Machine_By_MACHINE_ID = new Params_Get_Machine_By_MACHINE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Workshops_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Where_InList.START_ROW == null) { i_Params_Get_Workshops_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Where_InList.END_ROW == null) || (i_Params_Get_Workshops_By_Where_InList.END_ROW == 0)) { i_Params_Get_Workshops_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Workshops_By_Where_InList_SP.OWNER_ID = i_Params_Get_Workshops_By_Where_InList.OWNER_ID;
oParams_Get_Workshops_By_Where_InList_SP.WORKSHOPS_FEES_DESCRIPTION = i_Params_Get_Workshops_By_Where_InList.WORKSHOPS_FEES_DESCRIPTION;
if ( i_Params_Get_Workshops_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Workshops_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Where_InList.CURRENCY_ID_LIST);
if ( i_Params_Get_Workshops_By_Where_InList.STOCK_ID_LIST == null)
{
i_Params_Get_Workshops_By_Where_InList.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Where_InList_SP.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Where_InList.STOCK_ID_LIST);
if ( i_Params_Get_Workshops_By_Where_InList.MACHINE_ID_LIST == null)
{
i_Params_Get_Workshops_By_Where_InList.MACHINE_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Where_InList_SP.MACHINE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Where_InList.MACHINE_ID_LIST);
oParams_Get_Workshops_By_Where_InList_SP.START_ROW = i_Params_Get_Workshops_By_Where_InList.START_ROW;
oParams_Get_Workshops_By_Where_InList_SP.END_ROW = i_Params_Get_Workshops_By_Where_InList.END_ROW;
oParams_Get_Workshops_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Workshops_By_Where_InList.TOTAL_COUNT;
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Where_InList_Adv(i_Params_Get_Workshops_By_Where_InList.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Workshops_By_Where_InList.STOCK_ID_LIST,i_Params_Get_Workshops_By_Where_InList.MACHINE_ID_LIST,i_Params_Get_Workshops_By_Where_InList.OWNER_ID,i_Params_Get_Workshops_By_Where_InList.START_ROW,i_Params_Get_Workshops_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Where_InList.TOTAL_COUNT = oParams_Get_Workshops_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Workshops_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Where_InList_Adv");}
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_InList_Adv_V2(Params_Get_Workshops_By_Criteria_InList_V2 i_Params_Get_Workshops_By_Criteria_InList_V2)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Workshops_By_Criteria_InList_SP_V2 oParams_Get_Workshops_By_Criteria_InList_SP_V2 = new Params_Get_Workshops_By_Criteria_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
Params_Get_Machine_By_MACHINE_ID oParams_Get_Machine_By_MACHINE_ID = new Params_Get_Machine_By_MACHINE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Workshops_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Workshops_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Workshops_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Workshops_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Workshops_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Workshops_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Workshops_By_Criteria_InList_SP_V2.WORKSHOPS_BEGINNING_DATE = i_Params_Get_Workshops_By_Criteria_InList_V2.WORKSHOPS_BEGINNING_DATE;
oParams_Get_Workshops_By_Criteria_InList_SP_V2.WORKSHOPS_FEES_DESCRIPTION = i_Params_Get_Workshops_By_Criteria_InList_V2.WORKSHOPS_FEES_DESCRIPTION;
if ( i_Params_Get_Workshops_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Workshops_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Criteria_InList_V2.CURRENCY_ID_LIST);
if ( i_Params_Get_Workshops_By_Criteria_InList_V2.STOCK_ID_LIST == null)
{
i_Params_Get_Workshops_By_Criteria_InList_V2.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Criteria_InList_SP_V2.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Criteria_InList_V2.STOCK_ID_LIST);
if ( i_Params_Get_Workshops_By_Criteria_InList_V2.MACHINE_ID_LIST == null)
{
i_Params_Get_Workshops_By_Criteria_InList_V2.MACHINE_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Criteria_InList_SP_V2.MACHINE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Criteria_InList_V2.MACHINE_ID_LIST);
oParams_Get_Workshops_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Workshops_By_Criteria_InList_V2.START_ROW;
oParams_Get_Workshops_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Workshops_By_Criteria_InList_V2.END_ROW;
oParams_Get_Workshops_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Workshops_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Criteria_InList_Adv_V2(i_Params_Get_Workshops_By_Criteria_InList_V2.WORKSHOPS_BEGINNING_DATE,i_Params_Get_Workshops_By_Criteria_InList_V2.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList_V2.STOCK_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList_V2.MACHINE_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Workshops_By_Criteria_InList_V2.START_ROW,i_Params_Get_Workshops_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Workshops_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Workshops_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Workshops> Get_Workshops_By_Where_InList_Adv_V2(Params_Get_Workshops_By_Where_InList_V2 i_Params_Get_Workshops_By_Where_InList_V2)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Workshops_By_Where_InList_SP_V2 oParams_Get_Workshops_By_Where_InList_SP_V2 = new Params_Get_Workshops_By_Where_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
Params_Get_Machine_By_MACHINE_ID oParams_Get_Machine_By_MACHINE_ID = new Params_Get_Machine_By_MACHINE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Workshops_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Workshops_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Workshops_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Workshops_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Workshops_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Workshops_By_Where_InList_V2.OWNER_ID;
oParams_Get_Workshops_By_Where_InList_SP_V2.WORKSHOPS_BEGINNING_DATE = i_Params_Get_Workshops_By_Where_InList_V2.WORKSHOPS_BEGINNING_DATE;
oParams_Get_Workshops_By_Where_InList_SP_V2.WORKSHOPS_FEES_DESCRIPTION = i_Params_Get_Workshops_By_Where_InList_V2.WORKSHOPS_FEES_DESCRIPTION;
if ( i_Params_Get_Workshops_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Workshops_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Where_InList_V2.CURRENCY_ID_LIST);
if ( i_Params_Get_Workshops_By_Where_InList_V2.STOCK_ID_LIST == null)
{
i_Params_Get_Workshops_By_Where_InList_V2.STOCK_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Where_InList_SP_V2.STOCK_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Where_InList_V2.STOCK_ID_LIST);
if ( i_Params_Get_Workshops_By_Where_InList_V2.MACHINE_ID_LIST == null)
{
i_Params_Get_Workshops_By_Where_InList_V2.MACHINE_ID_LIST = new List<Int32?>();
}
oParams_Get_Workshops_By_Where_InList_SP_V2.MACHINE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Workshops_By_Where_InList_V2.MACHINE_ID_LIST);
oParams_Get_Workshops_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Workshops_By_Where_InList_V2.START_ROW;
oParams_Get_Workshops_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Workshops_By_Where_InList_V2.END_ROW;
oParams_Get_Workshops_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Workshops_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Where_InList_Adv_V2(i_Params_Get_Workshops_By_Where_InList_V2.WORKSHOPS_BEGINNING_DATE,i_Params_Get_Workshops_By_Where_InList_V2.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Workshops_By_Where_InList_V2.STOCK_ID_LIST,i_Params_Get_Workshops_By_Where_InList_V2.MACHINE_ID_LIST,i_Params_Get_Workshops_By_Where_InList_V2.OWNER_ID,i_Params_Get_Workshops_By_Where_InList_V2.START_ROW,i_Params_Get_Workshops_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oWorkshops.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oWorkshops.My_Currency);
oWorkshops.My_Stock = new Stock();
oTools.CopyPropValues(oDBEntry.My_Stock, oWorkshops.My_Stock);
oWorkshops.My_Machine = new Machine();
oTools.CopyPropValues(oDBEntry.My_Machine, oWorkshops.My_Machine);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Workshops_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Workshops_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Where_InList_Adv_V2");}
return oList;
}
}
}
