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
#region Members
#region Used For Delete Operations
private Address _Address;
private Contact _Contact;
private Conversions _Conversions;
private Coupons _Coupons;
private Currency _Currency;
private Fees _Fees;
private Industry _Industry;
private Loc_l1 _Loc_l1;
private Loc_l2 _Loc_l2;
private Loc_l3 _Loc_l3;
private Loc_l4 _Loc_l4;
private Machine _Machine;
private Method_run _Method_run;
private Owner _Owner;
private Person _Person;
private Productdistribution _Productdistribution;
private Salary _Salary;
private Staff _Staff;
private Stock _Stock;
private Supplier _Supplier;
private Transaction _Transaction;
private User _User;
private Workshop _Workshop;
private Workshops _Workshops;
#endregion
#region Stop Executing Flags For Edit and Delete Operations
private bool _Stop_Edit_Address_Execution;
private bool _Stop_Delete_Address_Execution;
private bool _Stop_Edit_Contact_Execution;
private bool _Stop_Delete_Contact_Execution;
private bool _Stop_Edit_Conversions_Execution;
private bool _Stop_Delete_Conversions_Execution;
private bool _Stop_Edit_Coupons_Execution;
private bool _Stop_Delete_Coupons_Execution;
private bool _Stop_Edit_Currency_Execution;
private bool _Stop_Delete_Currency_Execution;
private bool _Stop_Edit_Fees_Execution;
private bool _Stop_Delete_Fees_Execution;
private bool _Stop_Edit_Industry_Execution;
private bool _Stop_Delete_Industry_Execution;
private bool _Stop_Edit_Loc_l1_Execution;
private bool _Stop_Delete_Loc_l1_Execution;
private bool _Stop_Edit_Loc_l2_Execution;
private bool _Stop_Delete_Loc_l2_Execution;
private bool _Stop_Edit_Loc_l3_Execution;
private bool _Stop_Delete_Loc_l3_Execution;
private bool _Stop_Edit_Loc_l4_Execution;
private bool _Stop_Delete_Loc_l4_Execution;
private bool _Stop_Edit_Machine_Execution;
private bool _Stop_Delete_Machine_Execution;
private bool _Stop_Edit_Method_run_Execution;
private bool _Stop_Delete_Method_run_Execution;
private bool _Stop_Edit_Owner_Execution;
private bool _Stop_Delete_Owner_Execution;
private bool _Stop_Edit_Person_Execution;
private bool _Stop_Delete_Person_Execution;
private bool _Stop_Edit_Productdistribution_Execution;
private bool _Stop_Delete_Productdistribution_Execution;
private bool _Stop_Edit_Salary_Execution;
private bool _Stop_Delete_Salary_Execution;
private bool _Stop_Edit_Staff_Execution;
private bool _Stop_Delete_Staff_Execution;
private bool _Stop_Edit_Stock_Execution;
private bool _Stop_Delete_Stock_Execution;
private bool _Stop_Edit_Supplier_Execution;
private bool _Stop_Delete_Supplier_Execution;
private bool _Stop_Edit_Transaction_Execution;
private bool _Stop_Delete_Transaction_Execution;
private bool _Stop_Edit_User_Execution;
private bool _Stop_Delete_User_Execution;
private bool _Stop_Edit_Workshop_Execution;
private bool _Stop_Delete_Workshop_Execution;
private bool _Stop_Edit_Workshops_Execution;
private bool _Stop_Delete_Workshops_Execution;
#endregion
#endregion
public Address Get_Address_By_ADDRESS_ID(Params_Get_Address_By_ADDRESS_ID i_Params_Get_Address_By_ADDRESS_ID)
{
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_ADDRESS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_ADDRESS_ID));}
#region Body Section.
DALC.Address oDBEntry = _AppContext.Get_Address_By_ADDRESS_ID(i_Params_Get_Address_By_ADDRESS_ID.ADDRESS_ID);
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID");}
return oAddress;
}
public Contact Get_Contact_By_CONTACT_ID(Params_Get_Contact_By_CONTACT_ID i_Params_Get_Contact_By_CONTACT_ID)
{
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_CONTACT_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_CONTACT_ID));}
#region Body Section.
DALC.Contact oDBEntry = _AppContext.Get_Contact_By_CONTACT_ID(i_Params_Get_Contact_By_CONTACT_ID.CONTACT_ID);
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID");}
return oContact;
}
public Conversions Get_Conversions_By_CONVERSIONS_ID(Params_Get_Conversions_By_CONVERSIONS_ID i_Params_Get_Conversions_By_CONVERSIONS_ID)
{
Conversions oConversions = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_CONVERSIONS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_CONVERSIONS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_CONVERSIONS_ID));}
#region Body Section.
DALC.Conversions oDBEntry = _AppContext.Get_Conversions_By_CONVERSIONS_ID(i_Params_Get_Conversions_By_CONVERSIONS_ID.CONVERSIONS_ID);
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_CONVERSIONS_ID");}
return oConversions;
}
public Coupons Get_Coupons_By_COUPONS_ID(Params_Get_Coupons_By_COUPONS_ID i_Params_Get_Coupons_By_COUPONS_ID)
{
Coupons oCoupons = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_COUPONS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_COUPONS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_COUPONS_ID));}
#region Body Section.
DALC.Coupons oDBEntry = _AppContext.Get_Coupons_By_COUPONS_ID(i_Params_Get_Coupons_By_COUPONS_ID.COUPONS_ID);
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_COUPONS_ID");}
return oCoupons;
}
public Currency Get_Currency_By_CURRENCY_ID(Params_Get_Currency_By_CURRENCY_ID i_Params_Get_Currency_By_CURRENCY_ID)
{
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_CURRENCY_ID));}
#region Body Section.
DALC.Currency oDBEntry = _AppContext.Get_Currency_By_CURRENCY_ID(i_Params_Get_Currency_By_CURRENCY_ID.CURRENCY_ID);
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID");}
return oCurrency;
}
public Fees Get_Fees_By_FEES_ID(Params_Get_Fees_By_FEES_ID i_Params_Get_Fees_By_FEES_ID)
{
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_FEES_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_FEES_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_FEES_ID));}
#region Body Section.
DALC.Fees oDBEntry = _AppContext.Get_Fees_By_FEES_ID(i_Params_Get_Fees_By_FEES_ID.FEES_ID);
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_FEES_ID");}
return oFees;
}
public Industry Get_Industry_By_INDUSTRY_ID(Params_Get_Industry_By_INDUSTRY_ID i_Params_Get_Industry_By_INDUSTRY_ID)
{
Industry oIndustry = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_INDUSTRY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_INDUSTRY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_INDUSTRY_ID));}
#region Body Section.
DALC.Industry oDBEntry = _AppContext.Get_Industry_By_INDUSTRY_ID(i_Params_Get_Industry_By_INDUSTRY_ID.INDUSTRY_ID);
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_INDUSTRY_ID");}
return oIndustry;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID(Params_Get_Loc_l1_By_LOC_L1_ID i_Params_Get_Loc_l1_By_LOC_L1_ID)
{
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_LOC_L1_ID));}
#region Body Section.
DALC.Loc_l1 oDBEntry = _AppContext.Get_Loc_l1_By_LOC_L1_ID(i_Params_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID);
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
return oLoc_l1;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID(Params_Get_Loc_l2_By_LOC_L2_ID i_Params_Get_Loc_l2_By_LOC_L2_ID)
{
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L2_ID));}
#region Body Section.
DALC.Loc_l2 oDBEntry = _AppContext.Get_Loc_l2_By_LOC_L2_ID(i_Params_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID);
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
return oLoc_l2;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID(Params_Get_Loc_l3_By_LOC_L3_ID i_Params_Get_Loc_l3_By_LOC_L3_ID)
{
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L3_ID));}
#region Body Section.
DALC.Loc_l3 oDBEntry = _AppContext.Get_Loc_l3_By_LOC_L3_ID(i_Params_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID);
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
return oLoc_l3;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID(Params_Get_Loc_l4_By_LOC_L4_ID i_Params_Get_Loc_l4_By_LOC_L4_ID)
{
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L4_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L4_ID));}
#region Body Section.
DALC.Loc_l4 oDBEntry = _AppContext.Get_Loc_l4_By_LOC_L4_ID(i_Params_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID);
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
return oLoc_l4;
}
public Machine Get_Machine_By_MACHINE_ID(Params_Get_Machine_By_MACHINE_ID i_Params_Get_Machine_By_MACHINE_ID)
{
Machine oMachine = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_MACHINE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_MACHINE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_MACHINE_ID));}
#region Body Section.
DALC.Machine oDBEntry = _AppContext.Get_Machine_By_MACHINE_ID(i_Params_Get_Machine_By_MACHINE_ID.MACHINE_ID);
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_MACHINE_ID");}
return oMachine;
}
public Method_run Get_Method_run_By_METHOD_RUN_ID(Params_Get_Method_run_By_METHOD_RUN_ID i_Params_Get_Method_run_By_METHOD_RUN_ID)
{
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_METHOD_RUN_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID));}
#region Body Section.
DALC.Method_run oDBEntry = _AppContext.Get_Method_run_By_METHOD_RUN_ID(i_Params_Get_Method_run_By_METHOD_RUN_ID.METHOD_RUN_ID);
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID");}
return oMethod_run;
}
public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
{
Owner oOwner = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_OWNER_ID));}
#region Body Section.
DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID");}
return oOwner;
}
public Person Get_Person_By_PERSON_ID(Params_Get_Person_By_PERSON_ID i_Params_Get_Person_By_PERSON_ID)
{
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_PERSON_ID));}
#region Body Section.
DALC.Person oDBEntry = _AppContext.Get_Person_By_PERSON_ID(i_Params_Get_Person_By_PERSON_ID.PERSON_ID);
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID");}
return oPerson;
}
public Productdistribution Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID(Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID)
{
Productdistribution oProductdistribution = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID));}
#region Body Section.
DALC.Productdistribution oDBEntry = _AppContext.Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID(i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID.PRODUCTDISTRIBUTION_ID);
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID");}
return oProductdistribution;
}
public Salary Get_Salary_By_SALARY_ID(Params_Get_Salary_By_SALARY_ID i_Params_Get_Salary_By_SALARY_ID)
{
Salary oSalary = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_SALARY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_SALARY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_SALARY_ID));}
#region Body Section.
DALC.Salary oDBEntry = _AppContext.Get_Salary_By_SALARY_ID(i_Params_Get_Salary_By_SALARY_ID.SALARY_ID);
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_SALARY_ID");}
return oSalary;
}
public Staff Get_Staff_By_STAFF_ID(Params_Get_Staff_By_STAFF_ID i_Params_Get_Staff_By_STAFF_ID)
{
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_STAFF_ID));}
#region Body Section.
DALC.Staff oDBEntry = _AppContext.Get_Staff_By_STAFF_ID(i_Params_Get_Staff_By_STAFF_ID.STAFF_ID);
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID");}
return oStaff;
}
public Stock Get_Stock_By_STOCK_ID(Params_Get_Stock_By_STOCK_ID i_Params_Get_Stock_By_STOCK_ID)
{
Stock oStock = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_STOCK_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_STOCK_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_STOCK_ID));}
#region Body Section.
DALC.Stock oDBEntry = _AppContext.Get_Stock_By_STOCK_ID(i_Params_Get_Stock_By_STOCK_ID.STOCK_ID);
oStock = new Stock();
oTools.CopyPropValues(oDBEntry, oStock);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_STOCK_ID");}
return oStock;
}
public Supplier Get_Supplier_By_SUPPLIER_ID(Params_Get_Supplier_By_SUPPLIER_ID i_Params_Get_Supplier_By_SUPPLIER_ID)
{
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_SUPPLIER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_SUPPLIER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_SUPPLIER_ID));}
#region Body Section.
DALC.Supplier oDBEntry = _AppContext.Get_Supplier_By_SUPPLIER_ID(i_Params_Get_Supplier_By_SUPPLIER_ID.SUPPLIER_ID);
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_SUPPLIER_ID");}
return oSupplier;
}
public Transaction Get_Transaction_By_TRANSACTION_ID(Params_Get_Transaction_By_TRANSACTION_ID i_Params_Get_Transaction_By_TRANSACTION_ID)
{
Transaction oTransaction = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_TRANSACTION_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_TRANSACTION_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_TRANSACTION_ID));}
#region Body Section.
DALC.Transaction oDBEntry = _AppContext.Get_Transaction_By_TRANSACTION_ID(i_Params_Get_Transaction_By_TRANSACTION_ID.TRANSACTION_ID);
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_TRANSACTION_ID");}
return oTransaction;
}
public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID));}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID");}
return oUser;
}
public Workshop Get_Workshop_By_WORKSHOP_ID(Params_Get_Workshop_By_WORKSHOP_ID i_Params_Get_Workshop_By_WORKSHOP_ID)
{
Workshop oWorkshop = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_WORKSHOP_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_WORKSHOP_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_WORKSHOP_ID));}
#region Body Section.
DALC.Workshop oDBEntry = _AppContext.Get_Workshop_By_WORKSHOP_ID(i_Params_Get_Workshop_By_WORKSHOP_ID.WORKSHOP_ID);
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_WORKSHOP_ID");}
return oWorkshop;
}
public Workshops Get_Workshops_By_WORKSHOPS_ID(Params_Get_Workshops_By_WORKSHOPS_ID i_Params_Get_Workshops_By_WORKSHOPS_ID)
{
Workshops oWorkshops = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_WORKSHOPS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_WORKSHOPS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_WORKSHOPS_ID));}
#region Body Section.
DALC.Workshops oDBEntry = _AppContext.Get_Workshops_By_WORKSHOPS_ID(i_Params_Get_Workshops_By_WORKSHOPS_ID.WORKSHOPS_ID);
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_WORKSHOPS_ID");}
return oWorkshops;
}
public List<Address> Get_Address_By_ADDRESS_ID_List(Params_Get_Address_By_ADDRESS_ID_List i_Params_Get_Address_By_ADDRESS_ID_List)
{
Address oAddress = null;
List<Address> oList = new List<Address>();
Params_Get_Address_By_ADDRESS_ID_List_SP oParams_Get_Address_By_ADDRESS_ID_List_SP = new Params_Get_Address_By_ADDRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_ADDRESS_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_ADDRESS_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_ADDRESS_ID_List(i_Params_Get_Address_By_ADDRESS_ID_List.ADDRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List(Params_Get_Contact_By_CONTACT_ID_List i_Params_Get_Contact_By_CONTACT_ID_List)
{
Contact oContact = null;
List<Contact> oList = new List<Contact>();
Params_Get_Contact_By_CONTACT_ID_List_SP oParams_Get_Contact_By_CONTACT_ID_List_SP = new Params_Get_Contact_By_CONTACT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_CONTACT_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_CONTACT_ID_List));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_CONTACT_ID_List(i_Params_Get_Contact_By_CONTACT_ID_List.CONTACT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_List");}
return oList;
}
public List<Conversions> Get_Conversions_By_CONVERSIONS_ID_List(Params_Get_Conversions_By_CONVERSIONS_ID_List i_Params_Get_Conversions_By_CONVERSIONS_ID_List)
{
Conversions oConversions = null;
List<Conversions> oList = new List<Conversions>();
Params_Get_Conversions_By_CONVERSIONS_ID_List_SP oParams_Get_Conversions_By_CONVERSIONS_ID_List_SP = new Params_Get_Conversions_By_CONVERSIONS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_CONVERSIONS_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_CONVERSIONS_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_CONVERSIONS_ID_List));}
#region Body Section.
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_CONVERSIONS_ID_List(i_Params_Get_Conversions_By_CONVERSIONS_ID_List.CONVERSIONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_CONVERSIONS_ID_List");}
return oList;
}
public List<Coupons> Get_Coupons_By_COUPONS_ID_List(Params_Get_Coupons_By_COUPONS_ID_List i_Params_Get_Coupons_By_COUPONS_ID_List)
{
Coupons oCoupons = null;
List<Coupons> oList = new List<Coupons>();
Params_Get_Coupons_By_COUPONS_ID_List_SP oParams_Get_Coupons_By_COUPONS_ID_List_SP = new Params_Get_Coupons_By_COUPONS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_COUPONS_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_COUPONS_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_COUPONS_ID_List));}
#region Body Section.
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_COUPONS_ID_List(i_Params_Get_Coupons_By_COUPONS_ID_List.COUPONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_COUPONS_ID_List");}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List(Params_Get_Currency_By_CURRENCY_ID_List i_Params_Get_Currency_By_CURRENCY_ID_List)
{
Currency oCurrency = null;
List<Currency> oList = new List<Currency>();
Params_Get_Currency_By_CURRENCY_ID_List_SP oParams_Get_Currency_By_CURRENCY_ID_List_SP = new Params_Get_Currency_By_CURRENCY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_CURRENCY_ID_List(i_Params_Get_Currency_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID_List");}
return oList;
}
public List<Fees> Get_Fees_By_FEES_ID_List(Params_Get_Fees_By_FEES_ID_List i_Params_Get_Fees_By_FEES_ID_List)
{
Fees oFees = null;
List<Fees> oList = new List<Fees>();
Params_Get_Fees_By_FEES_ID_List_SP oParams_Get_Fees_By_FEES_ID_List_SP = new Params_Get_Fees_By_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_FEES_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_FEES_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_FEES_ID_List));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_FEES_ID_List(i_Params_Get_Fees_By_FEES_ID_List.FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_FEES_ID_List");}
return oList;
}
public List<Industry> Get_Industry_By_INDUSTRY_ID_List(Params_Get_Industry_By_INDUSTRY_ID_List i_Params_Get_Industry_By_INDUSTRY_ID_List)
{
Industry oIndustry = null;
List<Industry> oList = new List<Industry>();
Params_Get_Industry_By_INDUSTRY_ID_List_SP oParams_Get_Industry_By_INDUSTRY_ID_List_SP = new Params_Get_Industry_By_INDUSTRY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_INDUSTRY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_INDUSTRY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_INDUSTRY_ID_List));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_INDUSTRY_ID_List(i_Params_Get_Industry_By_INDUSTRY_ID_List.INDUSTRY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_INDUSTRY_ID_List");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List(Params_Get_Loc_l1_By_LOC_L1_ID_List i_Params_Get_Loc_l1_By_LOC_L1_ID_List)
{
Loc_l1 oLoc_l1 = null;
List<Loc_l1> oList = new List<Loc_l1>();
Params_Get_Loc_l1_By_LOC_L1_ID_List_SP oParams_Get_Loc_l1_By_LOC_L1_ID_List_SP = new Params_Get_Loc_l1_By_LOC_L1_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_LOC_L1_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_LOC_L1_ID_List(i_Params_Get_Loc_l1_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List(Params_Get_Loc_l2_By_LOC_L2_ID_List i_Params_Get_Loc_l2_By_LOC_L2_ID_List)
{
Loc_l2 oLoc_l2 = null;
List<Loc_l2> oList = new List<Loc_l2>();
Params_Get_Loc_l2_By_LOC_L2_ID_List_SP oParams_Get_Loc_l2_By_LOC_L2_ID_List_SP = new Params_Get_Loc_l2_By_LOC_L2_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L2_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L2_ID_List(i_Params_Get_Loc_l2_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List(Params_Get_Loc_l3_By_LOC_L3_ID_List i_Params_Get_Loc_l3_By_LOC_L3_ID_List)
{
Loc_l3 oLoc_l3 = null;
List<Loc_l3> oList = new List<Loc_l3>();
Params_Get_Loc_l3_By_LOC_L3_ID_List_SP oParams_Get_Loc_l3_By_LOC_L3_ID_List_SP = new Params_Get_Loc_l3_By_LOC_L3_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L3_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L3_ID_List(i_Params_Get_Loc_l3_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List(Params_Get_Loc_l4_By_LOC_L4_ID_List i_Params_Get_Loc_l4_By_LOC_L4_ID_List)
{
Loc_l4 oLoc_l4 = null;
List<Loc_l4> oList = new List<Loc_l4>();
Params_Get_Loc_l4_By_LOC_L4_ID_List_SP oParams_Get_Loc_l4_By_LOC_L4_ID_List_SP = new Params_Get_Loc_l4_By_LOC_L4_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L4_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L4_ID_List));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L4_ID_List(i_Params_Get_Loc_l4_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
return oList;
}
public List<Machine> Get_Machine_By_MACHINE_ID_List(Params_Get_Machine_By_MACHINE_ID_List i_Params_Get_Machine_By_MACHINE_ID_List)
{
Machine oMachine = null;
List<Machine> oList = new List<Machine>();
Params_Get_Machine_By_MACHINE_ID_List_SP oParams_Get_Machine_By_MACHINE_ID_List_SP = new Params_Get_Machine_By_MACHINE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_MACHINE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_MACHINE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_MACHINE_ID_List));}
#region Body Section.
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_MACHINE_ID_List(i_Params_Get_Machine_By_MACHINE_ID_List.MACHINE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_MACHINE_ID_List");}
return oList;
}
public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List(Params_Get_Method_run_By_METHOD_RUN_ID_List i_Params_Get_Method_run_By_METHOD_RUN_ID_List)
{
Method_run oMethod_run = null;
List<Method_run> oList = new List<Method_run>();
Params_Get_Method_run_By_METHOD_RUN_ID_List_SP oParams_Get_Method_run_By_METHOD_RUN_ID_List_SP = new Params_Get_Method_run_By_METHOD_RUN_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_METHOD_RUN_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID_List));}
#region Body Section.
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_METHOD_RUN_ID_List(i_Params_Get_Method_run_By_METHOD_RUN_ID_List.METHOD_RUN_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID_List");}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
{
Owner oOwner = null;
List<Owner> oList = new List<Owner>();
Params_Get_Owner_By_OWNER_ID_List_SP oParams_Get_Owner_By_OWNER_ID_List_SP = new Params_Get_Owner_By_OWNER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_OWNER_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_OWNER_ID_List));}
#region Body Section.
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID_List");}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List(Params_Get_Person_By_PERSON_ID_List i_Params_Get_Person_By_PERSON_ID_List)
{
Person oPerson = null;
List<Person> oList = new List<Person>();
Params_Get_Person_By_PERSON_ID_List_SP oParams_Get_Person_By_PERSON_ID_List_SP = new Params_Get_Person_By_PERSON_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_PERSON_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_PERSON_ID_List(i_Params_Get_Person_By_PERSON_ID_List.PERSON_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_List");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List(Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List)
{
Productdistribution oProductdistribution = null;
List<Productdistribution> oList = new List<Productdistribution>();
Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_SP oParams_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_SP = new Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List(i_Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List.PRODUCTDISTRIBUTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List");}
return oList;
}
public List<Salary> Get_Salary_By_SALARY_ID_List(Params_Get_Salary_By_SALARY_ID_List i_Params_Get_Salary_By_SALARY_ID_List)
{
Salary oSalary = null;
List<Salary> oList = new List<Salary>();
Params_Get_Salary_By_SALARY_ID_List_SP oParams_Get_Salary_By_SALARY_ID_List_SP = new Params_Get_Salary_By_SALARY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_SALARY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_SALARY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_SALARY_ID_List));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_SALARY_ID_List(i_Params_Get_Salary_By_SALARY_ID_List.SALARY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_SALARY_ID_List");}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List(Params_Get_Staff_By_STAFF_ID_List i_Params_Get_Staff_By_STAFF_ID_List)
{
Staff oStaff = null;
List<Staff> oList = new List<Staff>();
Params_Get_Staff_By_STAFF_ID_List_SP oParams_Get_Staff_By_STAFF_ID_List_SP = new Params_Get_Staff_By_STAFF_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_STAFF_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_STAFF_ID_List(i_Params_Get_Staff_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID_List");}
return oList;
}
public List<Stock> Get_Stock_By_STOCK_ID_List(Params_Get_Stock_By_STOCK_ID_List i_Params_Get_Stock_By_STOCK_ID_List)
{
Stock oStock = null;
List<Stock> oList = new List<Stock>();
Params_Get_Stock_By_STOCK_ID_List_SP oParams_Get_Stock_By_STOCK_ID_List_SP = new Params_Get_Stock_By_STOCK_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_STOCK_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_STOCK_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Stock> oList_DBEntries = _AppContext.Get_Stock_By_STOCK_ID_List(i_Params_Get_Stock_By_STOCK_ID_List.STOCK_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_STOCK_ID_List");}
return oList;
}
public List<Supplier> Get_Supplier_By_SUPPLIER_ID_List(Params_Get_Supplier_By_SUPPLIER_ID_List i_Params_Get_Supplier_By_SUPPLIER_ID_List)
{
Supplier oSupplier = null;
List<Supplier> oList = new List<Supplier>();
Params_Get_Supplier_By_SUPPLIER_ID_List_SP oParams_Get_Supplier_By_SUPPLIER_ID_List_SP = new Params_Get_Supplier_By_SUPPLIER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_SUPPLIER_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_SUPPLIER_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_SUPPLIER_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_SUPPLIER_ID_List(i_Params_Get_Supplier_By_SUPPLIER_ID_List.SUPPLIER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_SUPPLIER_ID_List");}
return oList;
}
public List<Transaction> Get_Transaction_By_TRANSACTION_ID_List(Params_Get_Transaction_By_TRANSACTION_ID_List i_Params_Get_Transaction_By_TRANSACTION_ID_List)
{
Transaction oTransaction = null;
List<Transaction> oList = new List<Transaction>();
Params_Get_Transaction_By_TRANSACTION_ID_List_SP oParams_Get_Transaction_By_TRANSACTION_ID_List_SP = new Params_Get_Transaction_By_TRANSACTION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_TRANSACTION_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_TRANSACTION_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_TRANSACTION_ID_List));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_TRANSACTION_ID_List(i_Params_Get_Transaction_By_TRANSACTION_ID_List.TRANSACTION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_TRANSACTION_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USER_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List");}
return oList;
}
public List<Workshop> Get_Workshop_By_WORKSHOP_ID_List(Params_Get_Workshop_By_WORKSHOP_ID_List i_Params_Get_Workshop_By_WORKSHOP_ID_List)
{
Workshop oWorkshop = null;
List<Workshop> oList = new List<Workshop>();
Params_Get_Workshop_By_WORKSHOP_ID_List_SP oParams_Get_Workshop_By_WORKSHOP_ID_List_SP = new Params_Get_Workshop_By_WORKSHOP_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_WORKSHOP_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_WORKSHOP_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_WORKSHOP_ID_List));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_WORKSHOP_ID_List(i_Params_Get_Workshop_By_WORKSHOP_ID_List.WORKSHOP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_WORKSHOP_ID_List");}
return oList;
}
public List<Workshops> Get_Workshops_By_WORKSHOPS_ID_List(Params_Get_Workshops_By_WORKSHOPS_ID_List i_Params_Get_Workshops_By_WORKSHOPS_ID_List)
{
Workshops oWorkshops = null;
List<Workshops> oList = new List<Workshops>();
Params_Get_Workshops_By_WORKSHOPS_ID_List_SP oParams_Get_Workshops_By_WORKSHOPS_ID_List_SP = new Params_Get_Workshops_By_WORKSHOPS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_WORKSHOPS_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_WORKSHOPS_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_WORKSHOPS_ID_List));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_WORKSHOPS_ID_List(i_Params_Get_Workshops_By_WORKSHOPS_ID_List.WORKSHOPS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_WORKSHOPS_ID_List");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID(Params_Get_Address_By_PERSON_ID i_Params_Get_Address_By_PERSON_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID(i_Params_Get_Address_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID(Params_Get_Address_By_LOC_L1_ID i_Params_Get_Address_By_LOC_L1_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L1_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID(i_Params_Get_Address_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID(Params_Get_Address_By_LOC_L2_ID i_Params_Get_Address_By_LOC_L2_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L2_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID(i_Params_Get_Address_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID(Params_Get_Address_By_LOC_L3_ID i_Params_Get_Address_By_LOC_L3_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L3_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID(i_Params_Get_Address_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID");}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_OWNER_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_OWNER_ID(i_Params_Get_Address_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_OWNER_ID");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID(Params_Get_Address_By_LOC_L4_ID i_Params_Get_Address_By_LOC_L4_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L4_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L4_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID(i_Params_Get_Address_By_LOC_L4_ID.LOC_L4_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID(Params_Get_Contact_By_PERSON_ID i_Params_Get_Contact_By_PERSON_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID(i_Params_Get_Contact_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID(Params_Get_Contact_By_OWNER_ID i_Params_Get_Contact_By_OWNER_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_OWNER_ID));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_OWNER_ID(i_Params_Get_Contact_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_OWNER_ID");}
return oList;
}
public List<Conversions> Get_Conversions_By_OWNER_ID(Params_Get_Conversions_By_OWNER_ID i_Params_Get_Conversions_By_OWNER_ID)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_OWNER_ID));}
#region Body Section.
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_OWNER_ID(i_Params_Get_Conversions_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_OWNER_ID");}
return oList;
}
public List<Conversions> Get_Conversions_By_CURRENCY_ID(Params_Get_Conversions_By_CURRENCY_ID i_Params_Get_Conversions_By_CURRENCY_ID)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_CURRENCY_ID(i_Params_Get_Conversions_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_CURRENCY_ID");}
return oList;
}
public List<Coupons> Get_Coupons_By_OWNER_ID(Params_Get_Coupons_By_OWNER_ID i_Params_Get_Coupons_By_OWNER_ID)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_OWNER_ID));}
#region Body Section.
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_OWNER_ID(i_Params_Get_Coupons_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_OWNER_ID");}
return oList;
}
public List<Coupons> Get_Coupons_By_CURRENCY_ID(Params_Get_Coupons_By_CURRENCY_ID i_Params_Get_Coupons_By_CURRENCY_ID)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_CURRENCY_ID(i_Params_Get_Coupons_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_CURRENCY_ID");}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID(Params_Get_Currency_By_OWNER_ID i_Params_Get_Currency_By_OWNER_ID)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_OWNER_ID));}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_OWNER_ID(i_Params_Get_Currency_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_OWNER_ID");}
return oList;
}
public List<Fees> Get_Fees_By_OWNER_ID(Params_Get_Fees_By_OWNER_ID i_Params_Get_Fees_By_OWNER_ID)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_OWNER_ID(i_Params_Get_Fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_OWNER_ID");}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID(Params_Get_Fees_By_CURRENCY_ID i_Params_Get_Fees_By_CURRENCY_ID)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_CURRENCY_ID(i_Params_Get_Fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_CURRENCY_ID");}
return oList;
}
public List<Industry> Get_Industry_By_OWNER_ID(Params_Get_Industry_By_OWNER_ID i_Params_Get_Industry_By_OWNER_ID)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_OWNER_ID));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_OWNER_ID(i_Params_Get_Industry_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_OWNER_ID");}
return oList;
}
public List<Industry> Get_Industry_By_COUPONS_ID(Params_Get_Industry_By_COUPONS_ID i_Params_Get_Industry_By_COUPONS_ID)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_COUPONS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_COUPONS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_COUPONS_ID));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_COUPONS_ID(i_Params_Get_Industry_By_COUPONS_ID.COUPONS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_COUPONS_ID");}
return oList;
}
public List<Industry> Get_Industry_By_STOCK_ID(Params_Get_Industry_By_STOCK_ID i_Params_Get_Industry_By_STOCK_ID)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_STOCK_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_STOCK_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_STOCK_ID));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_STOCK_ID(i_Params_Get_Industry_By_STOCK_ID.STOCK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_STOCK_ID");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE(Params_Get_Loc_l1_By_CODE i_Params_Get_Loc_l1_By_CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_CODE));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_CODE(i_Params_Get_Loc_l1_By_CODE.CODE);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_CODE");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID(Params_Get_Loc_l1_By_OWNER_ID i_Params_Get_Loc_l1_By_OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_OWNER_ID(i_Params_Get_Loc_l1_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_OWNER_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE(Params_Get_Loc_l2_By_LOC_L1_ID_CODE i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID(Params_Get_Loc_l2_By_LOC_L1_ID i_Params_Get_Loc_l2_By_LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID(i_Params_Get_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID(Params_Get_Loc_l2_By_OWNER_ID i_Params_Get_Loc_l2_By_OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_OWNER_ID(i_Params_Get_Loc_l2_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_OWNER_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE(Params_Get_Loc_l3_By_LOC_L2_ID_CODE i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID(Params_Get_Loc_l3_By_LOC_L2_ID i_Params_Get_Loc_l3_By_LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID(i_Params_Get_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID(Params_Get_Loc_l3_By_OWNER_ID i_Params_Get_Loc_l3_By_OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_OWNER_ID(i_Params_Get_Loc_l3_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_OWNER_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE(Params_Get_Loc_l4_By_LOC_L3_ID_CODE i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID(Params_Get_Loc_l4_By_LOC_L3_ID i_Params_Get_Loc_l4_By_LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID(i_Params_Get_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID(Params_Get_Loc_l4_By_OWNER_ID i_Params_Get_Loc_l4_By_OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_OWNER_ID(i_Params_Get_Loc_l4_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_OWNER_ID");}
return oList;
}
public List<Machine> Get_Machine_By_OWNER_ID(Params_Get_Machine_By_OWNER_ID i_Params_Get_Machine_By_OWNER_ID)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_OWNER_ID));}
#region Body Section.
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_OWNER_ID(i_Params_Get_Machine_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_OWNER_ID");}
return oList;
}
public List<Machine> Get_Machine_By_WORKSHOP_ID(Params_Get_Machine_By_WORKSHOP_ID i_Params_Get_Machine_By_WORKSHOP_ID)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_WORKSHOP_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_WORKSHOP_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_WORKSHOP_ID));}
#region Body Section.
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_WORKSHOP_ID(i_Params_Get_Machine_By_WORKSHOP_ID.WORKSHOP_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_WORKSHOP_ID");}
return oList;
}
public List<Method_run> Get_Method_run_By_OWNER_ID(Params_Get_Method_run_By_OWNER_ID i_Params_Get_Method_run_By_OWNER_ID)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_OWNER_ID));}
#region Body Section.
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_OWNER_ID(i_Params_Get_Method_run_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_OWNER_ID");}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID(Params_Get_Person_By_OWNER_ID i_Params_Get_Person_By_OWNER_ID)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_OWNER_ID));}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_OWNER_ID(i_Params_Get_Person_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_OWNER_ID");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_OWNER_ID(Params_Get_Productdistribution_By_OWNER_ID i_Params_Get_Productdistribution_By_OWNER_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_OWNER_ID));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_OWNER_ID(i_Params_Get_Productdistribution_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_OWNER_ID");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_STAFF_ID(Params_Get_Productdistribution_By_STAFF_ID i_Params_Get_Productdistribution_By_STAFF_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_STAFF_ID));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_STAFF_ID(i_Params_Get_Productdistribution_By_STAFF_ID.STAFF_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_STAFF_ID");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID(Params_Get_Productdistribution_By_SUPPLIER_ID i_Params_Get_Productdistribution_By_SUPPLIER_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_SUPPLIER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_SUPPLIER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_SUPPLIER_ID));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_SUPPLIER_ID(i_Params_Get_Productdistribution_By_SUPPLIER_ID.SUPPLIER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_SUPPLIER_ID");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_COUPONS_ID(Params_Get_Productdistribution_By_COUPONS_ID i_Params_Get_Productdistribution_By_COUPONS_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_COUPONS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_COUPONS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_COUPONS_ID));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_COUPONS_ID(i_Params_Get_Productdistribution_By_COUPONS_ID.COUPONS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_COUPONS_ID");}
return oList;
}
public List<Salary> Get_Salary_By_OWNER_ID(Params_Get_Salary_By_OWNER_ID i_Params_Get_Salary_By_OWNER_ID)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_OWNER_ID));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_OWNER_ID(i_Params_Get_Salary_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_OWNER_ID");}
return oList;
}
public List<Salary> Get_Salary_By_STAFF_ID(Params_Get_Salary_By_STAFF_ID i_Params_Get_Salary_By_STAFF_ID)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_STAFF_ID));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_STAFF_ID(i_Params_Get_Salary_By_STAFF_ID.STAFF_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_STAFF_ID");}
return oList;
}
public List<Salary> Get_Salary_By_CURRENCY_ID(Params_Get_Salary_By_CURRENCY_ID i_Params_Get_Salary_By_CURRENCY_ID)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_CURRENCY_ID(i_Params_Get_Salary_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_CURRENCY_ID");}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID(Params_Get_Staff_By_OWNER_ID i_Params_Get_Staff_By_OWNER_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_OWNER_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_OWNER_ID(i_Params_Get_Staff_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_OWNER_ID");}
return oList;
}
public List<Staff> Get_Staff_By_WORKSHOP_ID(Params_Get_Staff_By_WORKSHOP_ID i_Params_Get_Staff_By_WORKSHOP_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_WORKSHOP_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_WORKSHOP_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_WORKSHOP_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_WORKSHOP_ID(i_Params_Get_Staff_By_WORKSHOP_ID.WORKSHOP_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_WORKSHOP_ID");}
return oList;
}
public List<Staff> Get_Staff_By_CURRENCY_ID(Params_Get_Staff_By_CURRENCY_ID i_Params_Get_Staff_By_CURRENCY_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_CURRENCY_ID(i_Params_Get_Staff_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_CURRENCY_ID");}
return oList;
}
public List<Stock> Get_Stock_By_OWNER_ID(Params_Get_Stock_By_OWNER_ID i_Params_Get_Stock_By_OWNER_ID)
{
List<Stock> oList = new List<Stock>();
Stock oStock = new Stock();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_OWNER_ID));}
#region Body Section.
List<DALC.Stock> oList_DBEntries = _AppContext.Get_Stock_By_OWNER_ID(i_Params_Get_Stock_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_OWNER_ID");}
return oList;
}
public List<Supplier> Get_Supplier_By_OWNER_ID(Params_Get_Supplier_By_OWNER_ID i_Params_Get_Supplier_By_OWNER_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_OWNER_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_OWNER_ID(i_Params_Get_Supplier_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_OWNER_ID");}
return oList;
}
public List<Supplier> Get_Supplier_By_COUPONS_ID(Params_Get_Supplier_By_COUPONS_ID i_Params_Get_Supplier_By_COUPONS_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_COUPONS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_COUPONS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_COUPONS_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_COUPONS_ID(i_Params_Get_Supplier_By_COUPONS_ID.COUPONS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_COUPONS_ID");}
return oList;
}
public List<Supplier> Get_Supplier_By_CURRENCY_ID(Params_Get_Supplier_By_CURRENCY_ID i_Params_Get_Supplier_By_CURRENCY_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_CURRENCY_ID(i_Params_Get_Supplier_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_CURRENCY_ID");}
return oList;
}
public List<Supplier> Get_Supplier_By_STOCK_ID(Params_Get_Supplier_By_STOCK_ID i_Params_Get_Supplier_By_STOCK_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_STOCK_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_STOCK_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_STOCK_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_STOCK_ID(i_Params_Get_Supplier_By_STOCK_ID.STOCK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_STOCK_ID");}
return oList;
}
public List<Transaction> Get_Transaction_By_OWNER_ID(Params_Get_Transaction_By_OWNER_ID i_Params_Get_Transaction_By_OWNER_ID)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_OWNER_ID));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_OWNER_ID(i_Params_Get_Transaction_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_OWNER_ID");}
return oList;
}
public List<Transaction> Get_Transaction_By_CURRENCY_ID(Params_Get_Transaction_By_CURRENCY_ID i_Params_Get_Transaction_By_CURRENCY_ID)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_CURRENCY_ID(i_Params_Get_Transaction_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_CURRENCY_ID");}
return oList;
}
public List<Transaction> Get_Transaction_By_STAFF_ID(Params_Get_Transaction_By_STAFF_ID i_Params_Get_Transaction_By_STAFF_ID)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_STAFF_ID));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_STAFF_ID(i_Params_Get_Transaction_By_STAFF_ID.STAFF_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_STAFF_ID");}
return oList;
}
public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID");}
return oList;
}
public List<User> Get_User_By_USERNAME(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USERNAME",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USERNAME));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME(i_Params_Get_User_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME");}
return oList;
}
public List<Workshop> Get_Workshop_By_OWNER_ID(Params_Get_Workshop_By_OWNER_ID i_Params_Get_Workshop_By_OWNER_ID)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_OWNER_ID));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_OWNER_ID(i_Params_Get_Workshop_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_OWNER_ID");}
return oList;
}
public List<Workshop> Get_Workshop_By_CURRENCY_ID(Params_Get_Workshop_By_CURRENCY_ID i_Params_Get_Workshop_By_CURRENCY_ID)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_CURRENCY_ID(i_Params_Get_Workshop_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_CURRENCY_ID");}
return oList;
}
public List<Workshop> Get_Workshop_By_STOCK_ID(Params_Get_Workshop_By_STOCK_ID i_Params_Get_Workshop_By_STOCK_ID)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_STOCK_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_STOCK_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_STOCK_ID));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_STOCK_ID(i_Params_Get_Workshop_By_STOCK_ID.STOCK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_STOCK_ID");}
return oList;
}
public List<Workshop> Get_Workshop_By_MACHINE_ID(Params_Get_Workshop_By_MACHINE_ID i_Params_Get_Workshop_By_MACHINE_ID)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_MACHINE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_MACHINE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_MACHINE_ID));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_MACHINE_ID(i_Params_Get_Workshop_By_MACHINE_ID.MACHINE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_MACHINE_ID");}
return oList;
}
public List<Workshops> Get_Workshops_By_OWNER_ID(Params_Get_Workshops_By_OWNER_ID i_Params_Get_Workshops_By_OWNER_ID)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_OWNER_ID));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_OWNER_ID(i_Params_Get_Workshops_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_OWNER_ID");}
return oList;
}
public List<Workshops> Get_Workshops_By_CURRENCY_ID(Params_Get_Workshops_By_CURRENCY_ID i_Params_Get_Workshops_By_CURRENCY_ID)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_CURRENCY_ID(i_Params_Get_Workshops_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_CURRENCY_ID");}
return oList;
}
public List<Workshops> Get_Workshops_By_STOCK_ID(Params_Get_Workshops_By_STOCK_ID i_Params_Get_Workshops_By_STOCK_ID)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_STOCK_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_STOCK_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_STOCK_ID));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_STOCK_ID(i_Params_Get_Workshops_By_STOCK_ID.STOCK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_STOCK_ID");}
return oList;
}
public List<Workshops> Get_Workshops_By_MACHINE_ID(Params_Get_Workshops_By_MACHINE_ID i_Params_Get_Workshops_By_MACHINE_ID)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_MACHINE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_MACHINE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_MACHINE_ID));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_MACHINE_ID(i_Params_Get_Workshops_By_MACHINE_ID.MACHINE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_MACHINE_ID");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List(Params_Get_Address_By_PERSON_ID_List i_Params_Get_Address_By_PERSON_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_List(i_Params_Get_Address_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List(Params_Get_Address_By_LOC_L1_ID_List i_Params_Get_Address_By_LOC_L1_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L1_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_List(i_Params_Get_Address_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List(Params_Get_Address_By_LOC_L2_ID_List i_Params_Get_Address_By_LOC_L2_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L2_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_List(i_Params_Get_Address_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List(Params_Get_Address_By_LOC_L3_ID_List i_Params_Get_Address_By_LOC_L3_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L3_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_List(i_Params_Get_Address_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List(Params_Get_Address_By_LOC_L4_ID_List i_Params_Get_Address_By_LOC_L4_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L4_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L4_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_List(i_Params_Get_Address_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List(Params_Get_Contact_By_PERSON_ID_List i_Params_Get_Contact_By_PERSON_ID_List)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_List(i_Params_Get_Contact_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_List");}
return oList;
}
public List<Conversions> Get_Conversions_By_CURRENCY_ID_List(Params_Get_Conversions_By_CURRENCY_ID_List i_Params_Get_Conversions_By_CURRENCY_ID_List)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_CURRENCY_ID_List(i_Params_Get_Conversions_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_CURRENCY_ID_List");}
return oList;
}
public List<Coupons> Get_Coupons_By_CURRENCY_ID_List(Params_Get_Coupons_By_CURRENCY_ID_List i_Params_Get_Coupons_By_CURRENCY_ID_List)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_CURRENCY_ID_List(i_Params_Get_Coupons_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_CURRENCY_ID_List");}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_List(Params_Get_Fees_By_CURRENCY_ID_List i_Params_Get_Fees_By_CURRENCY_ID_List)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_CURRENCY_ID_List(i_Params_Get_Fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_CURRENCY_ID_List");}
return oList;
}
public List<Industry> Get_Industry_By_COUPONS_ID_List(Params_Get_Industry_By_COUPONS_ID_List i_Params_Get_Industry_By_COUPONS_ID_List)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_COUPONS_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_COUPONS_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_COUPONS_ID_List));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_COUPONS_ID_List(i_Params_Get_Industry_By_COUPONS_ID_List.COUPONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_COUPONS_ID_List");}
return oList;
}
public List<Industry> Get_Industry_By_STOCK_ID_List(Params_Get_Industry_By_STOCK_ID_List i_Params_Get_Industry_By_STOCK_ID_List)
{
List<Industry> oList = new List<Industry>();
Industry oIndustry = new Industry();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Industry_By_STOCK_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Industry_By_STOCK_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Industry_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Industry> oList_DBEntries = _AppContext.Get_Industry_By_STOCK_ID_List(i_Params_Get_Industry_By_STOCK_ID_List.STOCK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oIndustry = new Industry();
oTools.CopyPropValues(oDBEntry, oIndustry);
oList.Add(oIndustry);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Industry_By_STOCK_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List(Params_Get_Loc_l2_By_LOC_L1_ID_List i_Params_Get_Loc_l2_By_LOC_L1_ID_List)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_List(i_Params_Get_Loc_l2_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List(Params_Get_Loc_l3_By_LOC_L2_ID_List i_Params_Get_Loc_l3_By_LOC_L2_ID_List)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_List(i_Params_Get_Loc_l3_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List(Params_Get_Loc_l4_By_LOC_L3_ID_List i_Params_Get_Loc_l4_By_LOC_L3_ID_List)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_List(i_Params_Get_Loc_l4_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
return oList;
}
public List<Machine> Get_Machine_By_WORKSHOP_ID_List(Params_Get_Machine_By_WORKSHOP_ID_List i_Params_Get_Machine_By_WORKSHOP_ID_List)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_WORKSHOP_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_WORKSHOP_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_WORKSHOP_ID_List));}
#region Body Section.
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_WORKSHOP_ID_List(i_Params_Get_Machine_By_WORKSHOP_ID_List.WORKSHOP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_WORKSHOP_ID_List");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_STAFF_ID_List(Params_Get_Productdistribution_By_STAFF_ID_List i_Params_Get_Productdistribution_By_STAFF_ID_List)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_STAFF_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_STAFF_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_STAFF_ID_List(i_Params_Get_Productdistribution_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_STAFF_ID_List");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID_List(Params_Get_Productdistribution_By_SUPPLIER_ID_List i_Params_Get_Productdistribution_By_SUPPLIER_ID_List)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_SUPPLIER_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_SUPPLIER_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_SUPPLIER_ID_List));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_SUPPLIER_ID_List(i_Params_Get_Productdistribution_By_SUPPLIER_ID_List.SUPPLIER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_SUPPLIER_ID_List");}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_COUPONS_ID_List(Params_Get_Productdistribution_By_COUPONS_ID_List i_Params_Get_Productdistribution_By_COUPONS_ID_List)
{
List<Productdistribution> oList = new List<Productdistribution>();
Productdistribution oProductdistribution = new Productdistribution();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Productdistribution_By_COUPONS_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Productdistribution_By_COUPONS_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Productdistribution_By_COUPONS_ID_List));}
#region Body Section.
List<DALC.Productdistribution> oList_DBEntries = _AppContext.Get_Productdistribution_By_COUPONS_ID_List(i_Params_Get_Productdistribution_By_COUPONS_ID_List.COUPONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oProductdistribution = new Productdistribution();
oTools.CopyPropValues(oDBEntry, oProductdistribution);
oList.Add(oProductdistribution);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Productdistribution_By_COUPONS_ID_List");}
return oList;
}
public List<Salary> Get_Salary_By_STAFF_ID_List(Params_Get_Salary_By_STAFF_ID_List i_Params_Get_Salary_By_STAFF_ID_List)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_STAFF_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_STAFF_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_STAFF_ID_List(i_Params_Get_Salary_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_STAFF_ID_List");}
return oList;
}
public List<Salary> Get_Salary_By_CURRENCY_ID_List(Params_Get_Salary_By_CURRENCY_ID_List i_Params_Get_Salary_By_CURRENCY_ID_List)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_CURRENCY_ID_List(i_Params_Get_Salary_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_CURRENCY_ID_List");}
return oList;
}
public List<Staff> Get_Staff_By_WORKSHOP_ID_List(Params_Get_Staff_By_WORKSHOP_ID_List i_Params_Get_Staff_By_WORKSHOP_ID_List)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_WORKSHOP_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_WORKSHOP_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_WORKSHOP_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_WORKSHOP_ID_List(i_Params_Get_Staff_By_WORKSHOP_ID_List.WORKSHOP_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_WORKSHOP_ID_List");}
return oList;
}
public List<Staff> Get_Staff_By_CURRENCY_ID_List(Params_Get_Staff_By_CURRENCY_ID_List i_Params_Get_Staff_By_CURRENCY_ID_List)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_CURRENCY_ID_List(i_Params_Get_Staff_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_CURRENCY_ID_List");}
return oList;
}
public List<Supplier> Get_Supplier_By_COUPONS_ID_List(Params_Get_Supplier_By_COUPONS_ID_List i_Params_Get_Supplier_By_COUPONS_ID_List)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_COUPONS_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_COUPONS_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_COUPONS_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_COUPONS_ID_List(i_Params_Get_Supplier_By_COUPONS_ID_List.COUPONS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_COUPONS_ID_List");}
return oList;
}
public List<Supplier> Get_Supplier_By_CURRENCY_ID_List(Params_Get_Supplier_By_CURRENCY_ID_List i_Params_Get_Supplier_By_CURRENCY_ID_List)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_CURRENCY_ID_List(i_Params_Get_Supplier_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_CURRENCY_ID_List");}
return oList;
}
public List<Supplier> Get_Supplier_By_STOCK_ID_List(Params_Get_Supplier_By_STOCK_ID_List i_Params_Get_Supplier_By_STOCK_ID_List)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_STOCK_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_STOCK_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_STOCK_ID_List(i_Params_Get_Supplier_By_STOCK_ID_List.STOCK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_STOCK_ID_List");}
return oList;
}
public List<Transaction> Get_Transaction_By_CURRENCY_ID_List(Params_Get_Transaction_By_CURRENCY_ID_List i_Params_Get_Transaction_By_CURRENCY_ID_List)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_CURRENCY_ID_List(i_Params_Get_Transaction_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_CURRENCY_ID_List");}
return oList;
}
public List<Transaction> Get_Transaction_By_STAFF_ID_List(Params_Get_Transaction_By_STAFF_ID_List i_Params_Get_Transaction_By_STAFF_ID_List)
{
List<Transaction> oList = new List<Transaction>();
Transaction oTransaction = new Transaction();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Transaction_By_STAFF_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Transaction_By_STAFF_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Transaction_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Transaction> oList_DBEntries = _AppContext.Get_Transaction_By_STAFF_ID_List(i_Params_Get_Transaction_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oTransaction = new Transaction();
oTools.CopyPropValues(oDBEntry, oTransaction);
oList.Add(oTransaction);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Transaction_By_STAFF_ID_List");}
return oList;
}
public List<Workshop> Get_Workshop_By_CURRENCY_ID_List(Params_Get_Workshop_By_CURRENCY_ID_List i_Params_Get_Workshop_By_CURRENCY_ID_List)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_CURRENCY_ID_List(i_Params_Get_Workshop_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_CURRENCY_ID_List");}
return oList;
}
public List<Workshop> Get_Workshop_By_STOCK_ID_List(Params_Get_Workshop_By_STOCK_ID_List i_Params_Get_Workshop_By_STOCK_ID_List)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_STOCK_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_STOCK_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_STOCK_ID_List(i_Params_Get_Workshop_By_STOCK_ID_List.STOCK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_STOCK_ID_List");}
return oList;
}
public List<Workshop> Get_Workshop_By_MACHINE_ID_List(Params_Get_Workshop_By_MACHINE_ID_List i_Params_Get_Workshop_By_MACHINE_ID_List)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_MACHINE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_MACHINE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_MACHINE_ID_List));}
#region Body Section.
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_MACHINE_ID_List(i_Params_Get_Workshop_By_MACHINE_ID_List.MACHINE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_MACHINE_ID_List");}
return oList;
}
public List<Workshops> Get_Workshops_By_CURRENCY_ID_List(Params_Get_Workshops_By_CURRENCY_ID_List i_Params_Get_Workshops_By_CURRENCY_ID_List)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_CURRENCY_ID_List(i_Params_Get_Workshops_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_CURRENCY_ID_List");}
return oList;
}
public List<Workshops> Get_Workshops_By_STOCK_ID_List(Params_Get_Workshops_By_STOCK_ID_List i_Params_Get_Workshops_By_STOCK_ID_List)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_STOCK_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_STOCK_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_STOCK_ID_List));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_STOCK_ID_List(i_Params_Get_Workshops_By_STOCK_ID_List.STOCK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_STOCK_ID_List");}
return oList;
}
public List<Workshops> Get_Workshops_By_MACHINE_ID_List(Params_Get_Workshops_By_MACHINE_ID_List i_Params_Get_Workshops_By_MACHINE_ID_List)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_MACHINE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_MACHINE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_MACHINE_ID_List));}
#region Body Section.
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_MACHINE_ID_List(i_Params_Get_Workshops_By_MACHINE_ID_List.MACHINE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_MACHINE_ID_List");}
return oList;
}
public List<Address> Get_Address_By_Criteria(Params_Get_Address_By_Criteria i_Params_Get_Address_By_Criteria)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria.START_ROW == null) { i_Params_Get_Address_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria.END_ROW == null) || (i_Params_Get_Address_By_Criteria.END_ROW == 0)) { i_Params_Get_Address_By_Criteria.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria(i_Params_Get_Address_By_Criteria.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria.STREET,i_Params_Get_Address_By_Criteria.BUILDING,i_Params_Get_Address_By_Criteria.FLOOR,i_Params_Get_Address_By_Criteria.POBOX,i_Params_Get_Address_By_Criteria.OWNER_ID,i_Params_Get_Address_By_Criteria.START_ROW,i_Params_Get_Address_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria");}
return oList;
}
public List<Address> Get_Address_By_Where(Params_Get_Address_By_Where i_Params_Get_Address_By_Where)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where));}
#region Body Section.
if ((i_Params_Get_Address_By_Where.OWNER_ID == null) || (i_Params_Get_Address_By_Where.OWNER_ID == 0)) { i_Params_Get_Address_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where.START_ROW == null) { i_Params_Get_Address_By_Where.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where.END_ROW == null) || (i_Params_Get_Address_By_Where.END_ROW == 0)) { i_Params_Get_Address_By_Where.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where(i_Params_Get_Address_By_Where.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where.STREET,i_Params_Get_Address_By_Where.BUILDING,i_Params_Get_Address_By_Where.FLOOR,i_Params_Get_Address_By_Where.POBOX,i_Params_Get_Address_By_Where.OWNER_ID,i_Params_Get_Address_By_Where.START_ROW,i_Params_Get_Address_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where");}
return oList;
}
public List<Address> Get_Address_By_Criteria_V2(Params_Get_Address_By_Criteria_V2 i_Params_Get_Address_By_Criteria_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_V2(i_Params_Get_Address_By_Criteria_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_V2.STREET,i_Params_Get_Address_By_Criteria_V2.BUILDING,i_Params_Get_Address_By_Criteria_V2.FLOOR,i_Params_Get_Address_By_Criteria_V2.POBOX,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_V2.START_ROW,i_Params_Get_Address_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_V2(Params_Get_Address_By_Where_V2 i_Params_Get_Address_By_Where_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_V2.START_ROW == null) { i_Params_Get_Address_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_V2(i_Params_Get_Address_By_Where_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_V2.STREET,i_Params_Get_Address_By_Where_V2.BUILDING,i_Params_Get_Address_By_Where_V2.FLOOR,i_Params_Get_Address_By_Where_V2.POBOX,i_Params_Get_Address_By_Where_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_V2.OWNER_ID,i_Params_Get_Address_By_Where_V2.START_ROW,i_Params_Get_Address_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_V2");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria(Params_Get_Contact_By_Criteria i_Params_Get_Contact_By_Criteria)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria.START_ROW == null) { i_Params_Get_Contact_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria.END_ROW == null) || (i_Params_Get_Contact_By_Criteria.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria(i_Params_Get_Contact_By_Criteria.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria.CONTACT,i_Params_Get_Contact_By_Criteria.DESCRIPTION,i_Params_Get_Contact_By_Criteria.OWNER_ID,i_Params_Get_Contact_By_Criteria.START_ROW,i_Params_Get_Contact_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria");}
return oList;
}
public List<Contact> Get_Contact_By_Where(Params_Get_Contact_By_Where i_Params_Get_Contact_By_Where)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Where));}
#region Body Section.
if ((i_Params_Get_Contact_By_Where.OWNER_ID == null) || (i_Params_Get_Contact_By_Where.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where.START_ROW == null) { i_Params_Get_Contact_By_Where.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where.END_ROW == null) || (i_Params_Get_Contact_By_Where.END_ROW == 0)) { i_Params_Get_Contact_By_Where.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where(i_Params_Get_Contact_By_Where.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where.CONTACT,i_Params_Get_Contact_By_Where.DESCRIPTION,i_Params_Get_Contact_By_Where.OWNER_ID,i_Params_Get_Contact_By_Where.START_ROW,i_Params_Get_Contact_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where");}
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria(Params_Get_Conversions_By_Criteria i_Params_Get_Conversions_By_Criteria)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Criteria.OWNER_ID == null) || (i_Params_Get_Conversions_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Criteria.START_ROW == null) { i_Params_Get_Conversions_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Criteria.END_ROW == null) || (i_Params_Get_Conversions_By_Criteria.END_ROW == 0)) { i_Params_Get_Conversions_By_Criteria.END_ROW = 1000000; }
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Criteria(i_Params_Get_Conversions_By_Criteria.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Criteria.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Criteria.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Criteria.OWNER_ID,i_Params_Get_Conversions_By_Criteria.START_ROW,i_Params_Get_Conversions_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Criteria");}
return oList;
}
public List<Conversions> Get_Conversions_By_Where(Params_Get_Conversions_By_Where i_Params_Get_Conversions_By_Where)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Where));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Where.OWNER_ID == null) || (i_Params_Get_Conversions_By_Where.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Where.START_ROW == null) { i_Params_Get_Conversions_By_Where.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Where.END_ROW == null) || (i_Params_Get_Conversions_By_Where.END_ROW == 0)) { i_Params_Get_Conversions_By_Where.END_ROW = 1000000; }
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Where(i_Params_Get_Conversions_By_Where.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Where.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Where.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Where.OWNER_ID,i_Params_Get_Conversions_By_Where.START_ROW,i_Params_Get_Conversions_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Where");}
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_V2(Params_Get_Conversions_By_Criteria_V2 i_Params_Get_Conversions_By_Criteria_V2)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Conversions_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Criteria_V2.START_ROW == null) { i_Params_Get_Conversions_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Conversions_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Conversions_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Criteria_V2(i_Params_Get_Conversions_By_Criteria_V2.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Criteria_V2.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Criteria_V2.CONVERSIONS_DATE,i_Params_Get_Conversions_By_Criteria_V2.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Criteria_V2.OWNER_ID,i_Params_Get_Conversions_By_Criteria_V2.START_ROW,i_Params_Get_Conversions_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Criteria_V2");}
return oList;
}
public List<Conversions> Get_Conversions_By_Where_V2(Params_Get_Conversions_By_Where_V2 i_Params_Get_Conversions_By_Where_V2)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Conversions_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Conversions_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Conversions_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Conversions_By_Where_V2.START_ROW == null) { i_Params_Get_Conversions_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Conversions_By_Where_V2.END_ROW == null) || (i_Params_Get_Conversions_By_Where_V2.END_ROW == 0)) { i_Params_Get_Conversions_By_Where_V2.END_ROW = 1000000; }
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Where_V2(i_Params_Get_Conversions_By_Where_V2.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Where_V2.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Where_V2.CONVERSIONS_DATE,i_Params_Get_Conversions_By_Where_V2.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Where_V2.OWNER_ID,i_Params_Get_Conversions_By_Where_V2.START_ROW,i_Params_Get_Conversions_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Where_V2");}
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria(Params_Get_Coupons_By_Criteria i_Params_Get_Coupons_By_Criteria)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Criteria.OWNER_ID == null) || (i_Params_Get_Coupons_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Criteria.START_ROW == null) { i_Params_Get_Coupons_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Criteria.END_ROW == null) || (i_Params_Get_Coupons_By_Criteria.END_ROW == 0)) { i_Params_Get_Coupons_By_Criteria.END_ROW = 1000000; }
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Criteria(i_Params_Get_Coupons_By_Criteria.COUPONS_TYPE,i_Params_Get_Coupons_By_Criteria.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Criteria.COUPONS_STORE,i_Params_Get_Coupons_By_Criteria.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Criteria.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Criteria.COUPONS_FOR,i_Params_Get_Coupons_By_Criteria.COUPONS_NOTE,i_Params_Get_Coupons_By_Criteria.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Criteria.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Criteria.COUPONS_MACHINE,i_Params_Get_Coupons_By_Criteria.OWNER_ID,i_Params_Get_Coupons_By_Criteria.START_ROW,i_Params_Get_Coupons_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Criteria");}
return oList;
}
public List<Coupons> Get_Coupons_By_Where(Params_Get_Coupons_By_Where i_Params_Get_Coupons_By_Where)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Where));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Where.OWNER_ID == null) || (i_Params_Get_Coupons_By_Where.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Where.START_ROW == null) { i_Params_Get_Coupons_By_Where.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Where.END_ROW == null) || (i_Params_Get_Coupons_By_Where.END_ROW == 0)) { i_Params_Get_Coupons_By_Where.END_ROW = 1000000; }
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Where(i_Params_Get_Coupons_By_Where.COUPONS_TYPE,i_Params_Get_Coupons_By_Where.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Where.COUPONS_STORE,i_Params_Get_Coupons_By_Where.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Where.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Where.COUPONS_FOR,i_Params_Get_Coupons_By_Where.COUPONS_NOTE,i_Params_Get_Coupons_By_Where.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Where.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Where.COUPONS_MACHINE,i_Params_Get_Coupons_By_Where.OWNER_ID,i_Params_Get_Coupons_By_Where.START_ROW,i_Params_Get_Coupons_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Where");}
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_V2(Params_Get_Coupons_By_Criteria_V2 i_Params_Get_Coupons_By_Criteria_V2)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Coupons_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Criteria_V2.START_ROW == null) { i_Params_Get_Coupons_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Coupons_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Coupons_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Criteria_V2(i_Params_Get_Coupons_By_Criteria_V2.COUPONS_TYPE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_STORE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_DATE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_FOR,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_NOTE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Criteria_V2.COUPONS_MACHINE,i_Params_Get_Coupons_By_Criteria_V2.OWNER_ID,i_Params_Get_Coupons_By_Criteria_V2.START_ROW,i_Params_Get_Coupons_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Criteria_V2");}
return oList;
}
public List<Coupons> Get_Coupons_By_Where_V2(Params_Get_Coupons_By_Where_V2 i_Params_Get_Coupons_By_Where_V2)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Coupons_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Coupons_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Coupons_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coupons_By_Where_V2.START_ROW == null) { i_Params_Get_Coupons_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Coupons_By_Where_V2.END_ROW == null) || (i_Params_Get_Coupons_By_Where_V2.END_ROW == 0)) { i_Params_Get_Coupons_By_Where_V2.END_ROW = 1000000; }
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Where_V2(i_Params_Get_Coupons_By_Where_V2.COUPONS_TYPE,i_Params_Get_Coupons_By_Where_V2.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Where_V2.COUPONS_STORE,i_Params_Get_Coupons_By_Where_V2.COUPONS_DATE,i_Params_Get_Coupons_By_Where_V2.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Where_V2.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Where_V2.COUPONS_FOR,i_Params_Get_Coupons_By_Where_V2.COUPONS_NOTE,i_Params_Get_Coupons_By_Where_V2.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Where_V2.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Where_V2.COUPONS_MACHINE,i_Params_Get_Coupons_By_Where_V2.OWNER_ID,i_Params_Get_Coupons_By_Where_V2.START_ROW,i_Params_Get_Coupons_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Where_V2");}
return oList;
}
public List<Currency> Get_Currency_By_Criteria(Params_Get_Currency_By_Criteria i_Params_Get_Currency_By_Criteria)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Currency_By_Criteria.OWNER_ID == null) || (i_Params_Get_Currency_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Currency_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Criteria.START_ROW == null) { i_Params_Get_Currency_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Criteria.END_ROW == null) || (i_Params_Get_Currency_By_Criteria.END_ROW == 0)) { i_Params_Get_Currency_By_Criteria.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Criteria(i_Params_Get_Currency_By_Criteria.CURRENCY_TYPE,i_Params_Get_Currency_By_Criteria.CURRENCY_SYMBOL,i_Params_Get_Currency_By_Criteria.OWNER_ID,i_Params_Get_Currency_By_Criteria.START_ROW,i_Params_Get_Currency_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Criteria");}
return oList;
}
public List<Currency> Get_Currency_By_Where(Params_Get_Currency_By_Where i_Params_Get_Currency_By_Where)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_Where));}
#region Body Section.
if ((i_Params_Get_Currency_By_Where.OWNER_ID == null) || (i_Params_Get_Currency_By_Where.OWNER_ID == 0)) { i_Params_Get_Currency_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Where.START_ROW == null) { i_Params_Get_Currency_By_Where.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Where.END_ROW == null) || (i_Params_Get_Currency_By_Where.END_ROW == 0)) { i_Params_Get_Currency_By_Where.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Where(i_Params_Get_Currency_By_Where.CURRENCY_TYPE,i_Params_Get_Currency_By_Where.CURRENCY_SYMBOL,i_Params_Get_Currency_By_Where.OWNER_ID,i_Params_Get_Currency_By_Where.START_ROW,i_Params_Get_Currency_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Where");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria(Params_Get_Fees_By_Criteria i_Params_Get_Fees_By_Criteria)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria.START_ROW == null) { i_Params_Get_Fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria.END_ROW == null) || (i_Params_Get_Fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria(i_Params_Get_Fees_By_Criteria.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Criteria.FEES_STATUS,i_Params_Get_Fees_By_Criteria.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Criteria.FEES_STORE,i_Params_Get_Fees_By_Criteria.FEES_TYPE,i_Params_Get_Fees_By_Criteria.OWNER_ID,i_Params_Get_Fees_By_Criteria.START_ROW,i_Params_Get_Fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria");}
return oList;
}
public List<Fees> Get_Fees_By_Where(Params_Get_Fees_By_Where i_Params_Get_Fees_By_Where)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where.OWNER_ID == null) || (i_Params_Get_Fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where.START_ROW == null) { i_Params_Get_Fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where.END_ROW == null) || (i_Params_Get_Fees_By_Where.END_ROW == 0)) { i_Params_Get_Fees_By_Where.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where(i_Params_Get_Fees_By_Where.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Where.FEES_STATUS,i_Params_Get_Fees_By_Where.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Where.FEES_STORE,i_Params_Get_Fees_By_Where.FEES_TYPE,i_Params_Get_Fees_By_Where.OWNER_ID,i_Params_Get_Fees_By_Where.START_ROW,i_Params_Get_Fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_V2(Params_Get_Fees_By_Criteria_V2 i_Params_Get_Fees_By_Criteria_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria_V2.START_ROW == null) { i_Params_Get_Fees_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Fees_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_V2(i_Params_Get_Fees_By_Criteria_V2.FEES_DATE,i_Params_Get_Fees_By_Criteria_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_V2.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Criteria_V2.FEES_STATUS,i_Params_Get_Fees_By_Criteria_V2.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Criteria_V2.FEES_STORE,i_Params_Get_Fees_By_Criteria_V2.FEES_TYPE,i_Params_Get_Fees_By_Criteria_V2.OWNER_ID,i_Params_Get_Fees_By_Criteria_V2.START_ROW,i_Params_Get_Fees_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Where_V2(Params_Get_Fees_By_Where_V2 i_Params_Get_Fees_By_Where_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where_V2.START_ROW == null) { i_Params_Get_Fees_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where_V2.END_ROW == null) || (i_Params_Get_Fees_By_Where_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Where_V2.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_V2(i_Params_Get_Fees_By_Where_V2.FEES_DATE,i_Params_Get_Fees_By_Where_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_V2.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Where_V2.FEES_STATUS,i_Params_Get_Fees_By_Where_V2.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Where_V2.FEES_STORE,i_Params_Get_Fees_By_Where_V2.FEES_TYPE,i_Params_Get_Fees_By_Where_V2.OWNER_ID,i_Params_Get_Fees_By_Where_V2.START_ROW,i_Params_Get_Fees_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_V2");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria(Params_Get_Loc_l1_By_Criteria i_Params_Get_Loc_l1_By_Criteria)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l1_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l1_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Criteria(i_Params_Get_Loc_l1_By_Criteria.CODE,i_Params_Get_Loc_l1_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l1_By_Criteria.OWNER_ID,i_Params_Get_Loc_l1_By_Criteria.START_ROW,i_Params_Get_Loc_l1_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Criteria");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where(Params_Get_Loc_l1_By_Where i_Params_Get_Loc_l1_By_Where)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Where.START_ROW == null) { i_Params_Get_Loc_l1_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Where.END_ROW == null) || (i_Params_Get_Loc_l1_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Where(i_Params_Get_Loc_l1_By_Where.CODE,i_Params_Get_Loc_l1_By_Where.DESCRIPTION,i_Params_Get_Loc_l1_By_Where.OWNER_ID,i_Params_Get_Loc_l1_By_Where.START_ROW,i_Params_Get_Loc_l1_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Where");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria(Params_Get_Loc_l2_By_Criteria i_Params_Get_Loc_l2_By_Criteria)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria(i_Params_Get_Loc_l2_By_Criteria.CODE,i_Params_Get_Loc_l2_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria.START_ROW,i_Params_Get_Loc_l2_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where(Params_Get_Loc_l2_By_Where i_Params_Get_Loc_l2_By_Where)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where.START_ROW == null) { i_Params_Get_Loc_l2_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where(i_Params_Get_Loc_l2_By_Where.CODE,i_Params_Get_Loc_l2_By_Where.DESCRIPTION,i_Params_Get_Loc_l2_By_Where.OWNER_ID,i_Params_Get_Loc_l2_By_Where.START_ROW,i_Params_Get_Loc_l2_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria(Params_Get_Loc_l3_By_Criteria i_Params_Get_Loc_l3_By_Criteria)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria(i_Params_Get_Loc_l3_By_Criteria.CODE,i_Params_Get_Loc_l3_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria.START_ROW,i_Params_Get_Loc_l3_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where(Params_Get_Loc_l3_By_Where i_Params_Get_Loc_l3_By_Where)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where.START_ROW == null) { i_Params_Get_Loc_l3_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where(i_Params_Get_Loc_l3_By_Where.CODE,i_Params_Get_Loc_l3_By_Where.DESCRIPTION,i_Params_Get_Loc_l3_By_Where.OWNER_ID,i_Params_Get_Loc_l3_By_Where.START_ROW,i_Params_Get_Loc_l3_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria(Params_Get_Loc_l4_By_Criteria i_Params_Get_Loc_l4_By_Criteria)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria(i_Params_Get_Loc_l4_By_Criteria.CODE,i_Params_Get_Loc_l4_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria.START_ROW,i_Params_Get_Loc_l4_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where(Params_Get_Loc_l4_By_Where i_Params_Get_Loc_l4_By_Where)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where.START_ROW == null) { i_Params_Get_Loc_l4_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where(i_Params_Get_Loc_l4_By_Where.CODE,i_Params_Get_Loc_l4_By_Where.DESCRIPTION,i_Params_Get_Loc_l4_By_Where.OWNER_ID,i_Params_Get_Loc_l4_By_Where.START_ROW,i_Params_Get_Loc_l4_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where");}
return oList;
}
public List<Machine> Get_Machine_By_Criteria(Params_Get_Machine_By_Criteria i_Params_Get_Machine_By_Criteria)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Machine_By_Criteria.OWNER_ID == null) || (i_Params_Get_Machine_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Machine_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Criteria.START_ROW == null) { i_Params_Get_Machine_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Criteria.END_ROW == null) || (i_Params_Get_Machine_By_Criteria.END_ROW == 0)) { i_Params_Get_Machine_By_Criteria.END_ROW = 1000000; }
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Criteria(i_Params_Get_Machine_By_Criteria.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Criteria.MACHINE_NOTES,i_Params_Get_Machine_By_Criteria.OWNER_ID,i_Params_Get_Machine_By_Criteria.START_ROW,i_Params_Get_Machine_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Criteria");}
return oList;
}
public List<Machine> Get_Machine_By_Where(Params_Get_Machine_By_Where i_Params_Get_Machine_By_Where)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Where));}
#region Body Section.
if ((i_Params_Get_Machine_By_Where.OWNER_ID == null) || (i_Params_Get_Machine_By_Where.OWNER_ID == 0)) { i_Params_Get_Machine_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Where.START_ROW == null) { i_Params_Get_Machine_By_Where.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Where.END_ROW == null) || (i_Params_Get_Machine_By_Where.END_ROW == 0)) { i_Params_Get_Machine_By_Where.END_ROW = 1000000; }
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Where(i_Params_Get_Machine_By_Where.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Where.MACHINE_NOTES,i_Params_Get_Machine_By_Where.OWNER_ID,i_Params_Get_Machine_By_Where.START_ROW,i_Params_Get_Machine_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Where");}
return oList;
}
public List<Machine> Get_Machine_By_Criteria_V2(Params_Get_Machine_By_Criteria_V2 i_Params_Get_Machine_By_Criteria_V2)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Machine_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Machine_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Machine_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Criteria_V2.START_ROW == null) { i_Params_Get_Machine_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Machine_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Machine_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Criteria_V2(i_Params_Get_Machine_By_Criteria_V2.MACHINE_DATE,i_Params_Get_Machine_By_Criteria_V2.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Criteria_V2.MACHINE_NOTES,i_Params_Get_Machine_By_Criteria_V2.OWNER_ID,i_Params_Get_Machine_By_Criteria_V2.START_ROW,i_Params_Get_Machine_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Criteria_V2");}
return oList;
}
public List<Machine> Get_Machine_By_Where_V2(Params_Get_Machine_By_Where_V2 i_Params_Get_Machine_By_Where_V2)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Machine_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Machine_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Machine_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Machine_By_Where_V2.START_ROW == null) { i_Params_Get_Machine_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Machine_By_Where_V2.END_ROW == null) || (i_Params_Get_Machine_By_Where_V2.END_ROW == 0)) { i_Params_Get_Machine_By_Where_V2.END_ROW = 1000000; }
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Where_V2(i_Params_Get_Machine_By_Where_V2.MACHINE_DATE,i_Params_Get_Machine_By_Where_V2.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Where_V2.MACHINE_NOTES,i_Params_Get_Machine_By_Where_V2.OWNER_ID,i_Params_Get_Machine_By_Where_V2.START_ROW,i_Params_Get_Machine_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Where_V2");}
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria(Params_Get_Method_run_By_Criteria i_Params_Get_Method_run_By_Criteria)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Criteria.OWNER_ID == null) || (i_Params_Get_Method_run_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Criteria.START_ROW == null) { i_Params_Get_Method_run_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Criteria.END_ROW == null) || (i_Params_Get_Method_run_By_Criteria.END_ROW == 0)) { i_Params_Get_Method_run_By_Criteria.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Criteria(i_Params_Get_Method_run_By_Criteria.METHOD_NAME,i_Params_Get_Method_run_By_Criteria.INPUT_PARAM,i_Params_Get_Method_run_By_Criteria.OWNER_ID,i_Params_Get_Method_run_By_Criteria.START_ROW,i_Params_Get_Method_run_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Criteria");}
return oList;
}
public List<Method_run> Get_Method_run_By_Where(Params_Get_Method_run_By_Where i_Params_Get_Method_run_By_Where)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Where.OWNER_ID == null) || (i_Params_Get_Method_run_By_Where.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Where.START_ROW == null) { i_Params_Get_Method_run_By_Where.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Where.END_ROW == null) || (i_Params_Get_Method_run_By_Where.END_ROW == 0)) { i_Params_Get_Method_run_By_Where.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Where(i_Params_Get_Method_run_By_Where.METHOD_NAME,i_Params_Get_Method_run_By_Where.INPUT_PARAM,i_Params_Get_Method_run_By_Where.OWNER_ID,i_Params_Get_Method_run_By_Where.START_ROW,i_Params_Get_Method_run_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Where");}
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_V2(Params_Get_Method_run_By_Criteria_V2 i_Params_Get_Method_run_By_Criteria_V2)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Criteria_V2.START_ROW == null) { i_Params_Get_Method_run_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Method_run_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Method_run_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Criteria_V2(i_Params_Get_Method_run_By_Criteria_V2.METHOD_NAME,i_Params_Get_Method_run_By_Criteria_V2.RUN_DATE,i_Params_Get_Method_run_By_Criteria_V2.INPUT_PARAM,i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID,i_Params_Get_Method_run_By_Criteria_V2.START_ROW,i_Params_Get_Method_run_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Criteria_V2");}
return oList;
}
public List<Method_run> Get_Method_run_By_Where_V2(Params_Get_Method_run_By_Where_V2 i_Params_Get_Method_run_By_Where_V2)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Method_run_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Where_V2.START_ROW == null) { i_Params_Get_Method_run_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Where_V2.END_ROW == null) || (i_Params_Get_Method_run_By_Where_V2.END_ROW == 0)) { i_Params_Get_Method_run_By_Where_V2.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Where_V2(i_Params_Get_Method_run_By_Where_V2.METHOD_NAME,i_Params_Get_Method_run_By_Where_V2.RUN_DATE,i_Params_Get_Method_run_By_Where_V2.INPUT_PARAM,i_Params_Get_Method_run_By_Where_V2.OWNER_ID,i_Params_Get_Method_run_By_Where_V2.START_ROW,i_Params_Get_Method_run_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Where_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria(Params_Get_Owner_By_Criteria i_Params_Get_Owner_By_Criteria)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria.START_ROW == null) { i_Params_Get_Owner_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria.END_ROW == null) || (i_Params_Get_Owner_By_Criteria.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria(i_Params_Get_Owner_By_Criteria.CODE,i_Params_Get_Owner_By_Criteria.DESCRIPTION,i_Params_Get_Owner_By_Criteria.OWNER_ID,i_Params_Get_Owner_By_Criteria.START_ROW,i_Params_Get_Owner_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria");}
return oList;
}
public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_Where));}
#region Body Section.
if ((i_Params_Get_Owner_By_Where.OWNER_ID == null) || (i_Params_Get_Owner_By_Where.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where.START_ROW == null) { i_Params_Get_Owner_By_Where.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where.END_ROW == null) || (i_Params_Get_Owner_By_Where.END_ROW == 0)) { i_Params_Get_Owner_By_Where.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE,i_Params_Get_Owner_By_Where.DESCRIPTION,i_Params_Get_Owner_By_Where.OWNER_ID,i_Params_Get_Owner_By_Where.START_ROW,i_Params_Get_Owner_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2(Params_Get_Owner_By_Criteria_V2 i_Params_Get_Owner_By_Criteria_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria_V2.START_ROW == null) { i_Params_Get_Owner_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Owner_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria_V2(i_Params_Get_Owner_By_Criteria_V2.CODE,i_Params_Get_Owner_By_Criteria_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Criteria_V2.DESCRIPTION,i_Params_Get_Owner_By_Criteria_V2.OWNER_ID,i_Params_Get_Owner_By_Criteria_V2.START_ROW,i_Params_Get_Owner_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Where_V2(Params_Get_Owner_By_Where_V2 i_Params_Get_Owner_By_Where_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Owner_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where_V2.START_ROW == null) { i_Params_Get_Owner_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where_V2.END_ROW == null) || (i_Params_Get_Owner_By_Where_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Where_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where_V2(i_Params_Get_Owner_By_Where_V2.CODE,i_Params_Get_Owner_By_Where_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Where_V2.DESCRIPTION,i_Params_Get_Owner_By_Where_V2.OWNER_ID,i_Params_Get_Owner_By_Where_V2.START_ROW,i_Params_Get_Owner_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where_V2");}
return oList;
}
public List<Person> Get_Person_By_Criteria(Params_Get_Person_By_Criteria i_Params_Get_Person_By_Criteria)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria.START_ROW == null) { i_Params_Get_Person_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria.END_ROW == null) || (i_Params_Get_Person_By_Criteria.END_ROW == 0)) { i_Params_Get_Person_By_Criteria.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria(i_Params_Get_Person_By_Criteria.FIRST_NAME,i_Params_Get_Person_By_Criteria.LAST_NAME,i_Params_Get_Person_By_Criteria.FATHER_NAME,i_Params_Get_Person_By_Criteria.MOTHER_NAME,i_Params_Get_Person_By_Criteria.TITLE_CODE,i_Params_Get_Person_By_Criteria.GENDER_CODE,i_Params_Get_Person_By_Criteria.RELIGION_CODE,i_Params_Get_Person_By_Criteria.DESCRIPTION,i_Params_Get_Person_By_Criteria.OWNER_ID,i_Params_Get_Person_By_Criteria.START_ROW,i_Params_Get_Person_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria");}
return oList;
}
public List<Person> Get_Person_By_Where(Params_Get_Person_By_Where i_Params_Get_Person_By_Where)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Where));}
#region Body Section.
if ((i_Params_Get_Person_By_Where.OWNER_ID == null) || (i_Params_Get_Person_By_Where.OWNER_ID == 0)) { i_Params_Get_Person_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where.START_ROW == null) { i_Params_Get_Person_By_Where.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where.END_ROW == null) || (i_Params_Get_Person_By_Where.END_ROW == 0)) { i_Params_Get_Person_By_Where.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where(i_Params_Get_Person_By_Where.FIRST_NAME,i_Params_Get_Person_By_Where.LAST_NAME,i_Params_Get_Person_By_Where.FATHER_NAME,i_Params_Get_Person_By_Where.MOTHER_NAME,i_Params_Get_Person_By_Where.TITLE_CODE,i_Params_Get_Person_By_Where.GENDER_CODE,i_Params_Get_Person_By_Where.RELIGION_CODE,i_Params_Get_Person_By_Where.DESCRIPTION,i_Params_Get_Person_By_Where.OWNER_ID,i_Params_Get_Person_By_Where.START_ROW,i_Params_Get_Person_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where");}
return oList;
}
public List<Person> Get_Person_By_Criteria_V2(Params_Get_Person_By_Criteria_V2 i_Params_Get_Person_By_Criteria_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria_V2.START_ROW == null) { i_Params_Get_Person_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Person_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Person_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_V2(i_Params_Get_Person_By_Criteria_V2.FIRST_NAME,i_Params_Get_Person_By_Criteria_V2.LAST_NAME,i_Params_Get_Person_By_Criteria_V2.FATHER_NAME,i_Params_Get_Person_By_Criteria_V2.MOTHER_NAME,i_Params_Get_Person_By_Criteria_V2.TITLE_CODE,i_Params_Get_Person_By_Criteria_V2.GENDER_CODE,i_Params_Get_Person_By_Criteria_V2.RELIGION_CODE,i_Params_Get_Person_By_Criteria_V2.BIRTH_DATE,i_Params_Get_Person_By_Criteria_V2.DESCRIPTION,i_Params_Get_Person_By_Criteria_V2.OWNER_ID,i_Params_Get_Person_By_Criteria_V2.START_ROW,i_Params_Get_Person_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_V2");}
return oList;
}
public List<Person> Get_Person_By_Where_V2(Params_Get_Person_By_Where_V2 i_Params_Get_Person_By_Where_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Person_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where_V2.START_ROW == null) { i_Params_Get_Person_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where_V2.END_ROW == null) || (i_Params_Get_Person_By_Where_V2.END_ROW == 0)) { i_Params_Get_Person_By_Where_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_V2(i_Params_Get_Person_By_Where_V2.FIRST_NAME,i_Params_Get_Person_By_Where_V2.LAST_NAME,i_Params_Get_Person_By_Where_V2.FATHER_NAME,i_Params_Get_Person_By_Where_V2.MOTHER_NAME,i_Params_Get_Person_By_Where_V2.TITLE_CODE,i_Params_Get_Person_By_Where_V2.GENDER_CODE,i_Params_Get_Person_By_Where_V2.RELIGION_CODE,i_Params_Get_Person_By_Where_V2.BIRTH_DATE,i_Params_Get_Person_By_Where_V2.DESCRIPTION,i_Params_Get_Person_By_Where_V2.OWNER_ID,i_Params_Get_Person_By_Where_V2.START_ROW,i_Params_Get_Person_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_V2");}
return oList;
}
public List<Salary> Get_Salary_By_Criteria(Params_Get_Salary_By_Criteria i_Params_Get_Salary_By_Criteria)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Salary_By_Criteria.OWNER_ID == null) || (i_Params_Get_Salary_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Salary_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Criteria.START_ROW == null) { i_Params_Get_Salary_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Criteria.END_ROW == null) || (i_Params_Get_Salary_By_Criteria.END_ROW == 0)) { i_Params_Get_Salary_By_Criteria.END_ROW = 1000000; }
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Criteria(i_Params_Get_Salary_By_Criteria.DESCRIPTION,i_Params_Get_Salary_By_Criteria.OWNER_ID,i_Params_Get_Salary_By_Criteria.START_ROW,i_Params_Get_Salary_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Criteria");}
return oList;
}
public List<Salary> Get_Salary_By_Where(Params_Get_Salary_By_Where i_Params_Get_Salary_By_Where)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Where));}
#region Body Section.
if ((i_Params_Get_Salary_By_Where.OWNER_ID == null) || (i_Params_Get_Salary_By_Where.OWNER_ID == 0)) { i_Params_Get_Salary_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Where.START_ROW == null) { i_Params_Get_Salary_By_Where.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Where.END_ROW == null) || (i_Params_Get_Salary_By_Where.END_ROW == 0)) { i_Params_Get_Salary_By_Where.END_ROW = 1000000; }
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Where(i_Params_Get_Salary_By_Where.DESCRIPTION,i_Params_Get_Salary_By_Where.OWNER_ID,i_Params_Get_Salary_By_Where.START_ROW,i_Params_Get_Salary_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Where");}
return oList;
}
public List<Salary> Get_Salary_By_Criteria_V2(Params_Get_Salary_By_Criteria_V2 i_Params_Get_Salary_By_Criteria_V2)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Salary_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Salary_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Salary_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Criteria_V2.START_ROW == null) { i_Params_Get_Salary_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Salary_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Salary_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Criteria_V2(i_Params_Get_Salary_By_Criteria_V2.SALARY_DATE,i_Params_Get_Salary_By_Criteria_V2.DESCRIPTION,i_Params_Get_Salary_By_Criteria_V2.OWNER_ID,i_Params_Get_Salary_By_Criteria_V2.START_ROW,i_Params_Get_Salary_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Criteria_V2");}
return oList;
}
public List<Salary> Get_Salary_By_Where_V2(Params_Get_Salary_By_Where_V2 i_Params_Get_Salary_By_Where_V2)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Salary_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Salary_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Salary_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Salary_By_Where_V2.START_ROW == null) { i_Params_Get_Salary_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Salary_By_Where_V2.END_ROW == null) || (i_Params_Get_Salary_By_Where_V2.END_ROW == 0)) { i_Params_Get_Salary_By_Where_V2.END_ROW = 1000000; }
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Where_V2(i_Params_Get_Salary_By_Where_V2.SALARY_DATE,i_Params_Get_Salary_By_Where_V2.DESCRIPTION,i_Params_Get_Salary_By_Where_V2.OWNER_ID,i_Params_Get_Salary_By_Where_V2.START_ROW,i_Params_Get_Salary_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Where_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria(Params_Get_Staff_By_Criteria i_Params_Get_Staff_By_Criteria)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria.START_ROW == null) { i_Params_Get_Staff_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria.END_ROW == null) || (i_Params_Get_Staff_By_Criteria.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria(i_Params_Get_Staff_By_Criteria.STAFF_NAME,i_Params_Get_Staff_By_Criteria.STAFF_PAYMENT_DESCRIPTION,i_Params_Get_Staff_By_Criteria.STAFF_REFERENCE,i_Params_Get_Staff_By_Criteria.OWNER_ID,i_Params_Get_Staff_By_Criteria.START_ROW,i_Params_Get_Staff_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria");}
return oList;
}
public List<Staff> Get_Staff_By_Where(Params_Get_Staff_By_Where i_Params_Get_Staff_By_Where)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where.OWNER_ID == null) || (i_Params_Get_Staff_By_Where.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where.START_ROW == null) { i_Params_Get_Staff_By_Where.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where.END_ROW == null) || (i_Params_Get_Staff_By_Where.END_ROW == 0)) { i_Params_Get_Staff_By_Where.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where(i_Params_Get_Staff_By_Where.STAFF_NAME,i_Params_Get_Staff_By_Where.STAFF_PAYMENT_DESCRIPTION,i_Params_Get_Staff_By_Where.STAFF_REFERENCE,i_Params_Get_Staff_By_Where.OWNER_ID,i_Params_Get_Staff_By_Where.START_ROW,i_Params_Get_Staff_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where");}
return oList;
}
public List<Stock> Get_Stock_By_Criteria(Params_Get_Stock_By_Criteria i_Params_Get_Stock_By_Criteria)
{
List<Stock> oList = new List<Stock>();
Stock oStock = new Stock();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Stock_By_Criteria.OWNER_ID == null) || (i_Params_Get_Stock_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Stock_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Stock_By_Criteria.START_ROW == null) { i_Params_Get_Stock_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Stock_By_Criteria.END_ROW == null) || (i_Params_Get_Stock_By_Criteria.END_ROW == 0)) { i_Params_Get_Stock_By_Criteria.END_ROW = 1000000; }
List<DALC.Stock> oList_DBEntries = _AppContext.Get_Stock_By_Criteria(i_Params_Get_Stock_By_Criteria.STOCK_DESCRIPTION,i_Params_Get_Stock_By_Criteria.STOCK_CATEGORY,i_Params_Get_Stock_By_Criteria.STOCK_SCALE,i_Params_Get_Stock_By_Criteria.STOCK_MAIN_PERSON,i_Params_Get_Stock_By_Criteria.STOCK_NOTE,i_Params_Get_Stock_By_Criteria.OWNER_ID,i_Params_Get_Stock_By_Criteria.START_ROW,i_Params_Get_Stock_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_Criteria");}
return oList;
}
public List<Stock> Get_Stock_By_Where(Params_Get_Stock_By_Where i_Params_Get_Stock_By_Where)
{
List<Stock> oList = new List<Stock>();
Stock oStock = new Stock();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Stock_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Stock_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Stock_By_Where));}
#region Body Section.
if ((i_Params_Get_Stock_By_Where.OWNER_ID == null) || (i_Params_Get_Stock_By_Where.OWNER_ID == 0)) { i_Params_Get_Stock_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Stock_By_Where.START_ROW == null) { i_Params_Get_Stock_By_Where.START_ROW = 0; }
if ((i_Params_Get_Stock_By_Where.END_ROW == null) || (i_Params_Get_Stock_By_Where.END_ROW == 0)) { i_Params_Get_Stock_By_Where.END_ROW = 1000000; }
List<DALC.Stock> oList_DBEntries = _AppContext.Get_Stock_By_Where(i_Params_Get_Stock_By_Where.STOCK_DESCRIPTION,i_Params_Get_Stock_By_Where.STOCK_CATEGORY,i_Params_Get_Stock_By_Where.STOCK_SCALE,i_Params_Get_Stock_By_Where.STOCK_MAIN_PERSON,i_Params_Get_Stock_By_Where.STOCK_NOTE,i_Params_Get_Stock_By_Where.OWNER_ID,i_Params_Get_Stock_By_Where.START_ROW,i_Params_Get_Stock_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Stock_By_Where");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria(Params_Get_Supplier_By_Criteria i_Params_Get_Supplier_By_Criteria)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria.START_ROW == null) { i_Params_Get_Supplier_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria(i_Params_Get_Supplier_By_Criteria.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Criteria.OWNER_ID,i_Params_Get_Supplier_By_Criteria.START_ROW,i_Params_Get_Supplier_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where(Params_Get_Supplier_By_Where i_Params_Get_Supplier_By_Where)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where.START_ROW == null) { i_Params_Get_Supplier_By_Where.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where.END_ROW == null) || (i_Params_Get_Supplier_By_Where.END_ROW == 0)) { i_Params_Get_Supplier_By_Where.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where(i_Params_Get_Supplier_By_Where.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Where.OWNER_ID,i_Params_Get_Supplier_By_Where.START_ROW,i_Params_Get_Supplier_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_V2(Params_Get_Supplier_By_Criteria_V2 i_Params_Get_Supplier_By_Criteria_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_V2.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_V2(i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_PAYMENT_DATE,i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID,i_Params_Get_Supplier_By_Criteria_V2.START_ROW,i_Params_Get_Supplier_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_V2");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_V2(Params_Get_Supplier_By_Where_V2 i_Params_Get_Supplier_By_Where_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_V2.START_ROW == null) { i_Params_Get_Supplier_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Where_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_V2.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_V2(i_Params_Get_Supplier_By_Where_V2.SUPPLIER_PAYMENT_DATE,i_Params_Get_Supplier_By_Where_V2.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Where_V2.OWNER_ID,i_Params_Get_Supplier_By_Where_V2.START_ROW,i_Params_Get_Supplier_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_V2");}
return oList;
}
public List<User> Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_Criteria));}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria");}
return oList;
}
public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_Where));}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where");}
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria(Params_Get_Workshop_By_Criteria i_Params_Get_Workshop_By_Criteria)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Criteria.OWNER_ID == null) || (i_Params_Get_Workshop_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Criteria.START_ROW == null) { i_Params_Get_Workshop_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Criteria.END_ROW == null) || (i_Params_Get_Workshop_By_Criteria.END_ROW == 0)) { i_Params_Get_Workshop_By_Criteria.END_ROW = 1000000; }
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Criteria(i_Params_Get_Workshop_By_Criteria.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Criteria.OWNER_ID,i_Params_Get_Workshop_By_Criteria.START_ROW,i_Params_Get_Workshop_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Criteria");}
return oList;
}
public List<Workshop> Get_Workshop_By_Where(Params_Get_Workshop_By_Where i_Params_Get_Workshop_By_Where)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Where));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Where.OWNER_ID == null) || (i_Params_Get_Workshop_By_Where.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Where.START_ROW == null) { i_Params_Get_Workshop_By_Where.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Where.END_ROW == null) || (i_Params_Get_Workshop_By_Where.END_ROW == 0)) { i_Params_Get_Workshop_By_Where.END_ROW = 1000000; }
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Where(i_Params_Get_Workshop_By_Where.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Where.OWNER_ID,i_Params_Get_Workshop_By_Where.START_ROW,i_Params_Get_Workshop_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Where");}
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_V2(Params_Get_Workshop_By_Criteria_V2 i_Params_Get_Workshop_By_Criteria_V2)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Workshop_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Criteria_V2.START_ROW == null) { i_Params_Get_Workshop_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Workshop_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Workshop_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Criteria_V2(i_Params_Get_Workshop_By_Criteria_V2.WORKSHOP_BEGINNING_DATE,i_Params_Get_Workshop_By_Criteria_V2.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Criteria_V2.OWNER_ID,i_Params_Get_Workshop_By_Criteria_V2.START_ROW,i_Params_Get_Workshop_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Criteria_V2");}
return oList;
}
public List<Workshop> Get_Workshop_By_Where_V2(Params_Get_Workshop_By_Where_V2 i_Params_Get_Workshop_By_Where_V2)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Workshop_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Workshop_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Workshop_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshop_By_Where_V2.START_ROW == null) { i_Params_Get_Workshop_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Workshop_By_Where_V2.END_ROW == null) || (i_Params_Get_Workshop_By_Where_V2.END_ROW == 0)) { i_Params_Get_Workshop_By_Where_V2.END_ROW = 1000000; }
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Where_V2(i_Params_Get_Workshop_By_Where_V2.WORKSHOP_BEGINNING_DATE,i_Params_Get_Workshop_By_Where_V2.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Where_V2.OWNER_ID,i_Params_Get_Workshop_By_Where_V2.START_ROW,i_Params_Get_Workshop_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Where_V2");}
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria(Params_Get_Workshops_By_Criteria i_Params_Get_Workshops_By_Criteria)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Criteria.OWNER_ID == null) || (i_Params_Get_Workshops_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Criteria.START_ROW == null) { i_Params_Get_Workshops_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Criteria.END_ROW == null) || (i_Params_Get_Workshops_By_Criteria.END_ROW == 0)) { i_Params_Get_Workshops_By_Criteria.END_ROW = 1000000; }
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Criteria(i_Params_Get_Workshops_By_Criteria.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Criteria.OWNER_ID,i_Params_Get_Workshops_By_Criteria.START_ROW,i_Params_Get_Workshops_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Criteria");}
return oList;
}
public List<Workshops> Get_Workshops_By_Where(Params_Get_Workshops_By_Where i_Params_Get_Workshops_By_Where)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Where));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Where.OWNER_ID == null) || (i_Params_Get_Workshops_By_Where.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Where.START_ROW == null) { i_Params_Get_Workshops_By_Where.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Where.END_ROW == null) || (i_Params_Get_Workshops_By_Where.END_ROW == 0)) { i_Params_Get_Workshops_By_Where.END_ROW = 1000000; }
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Where(i_Params_Get_Workshops_By_Where.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Where.OWNER_ID,i_Params_Get_Workshops_By_Where.START_ROW,i_Params_Get_Workshops_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Where");}
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_V2(Params_Get_Workshops_By_Criteria_V2 i_Params_Get_Workshops_By_Criteria_V2)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Workshops_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Criteria_V2.START_ROW == null) { i_Params_Get_Workshops_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Workshops_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Workshops_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Criteria_V2(i_Params_Get_Workshops_By_Criteria_V2.WORKSHOPS_BEGINNING_DATE,i_Params_Get_Workshops_By_Criteria_V2.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Criteria_V2.OWNER_ID,i_Params_Get_Workshops_By_Criteria_V2.START_ROW,i_Params_Get_Workshops_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Criteria_V2");}
return oList;
}
public List<Workshops> Get_Workshops_By_Where_V2(Params_Get_Workshops_By_Where_V2 i_Params_Get_Workshops_By_Where_V2)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Workshops_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Workshops_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Workshops_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Workshops_By_Where_V2.START_ROW == null) { i_Params_Get_Workshops_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Workshops_By_Where_V2.END_ROW == null) || (i_Params_Get_Workshops_By_Where_V2.END_ROW == 0)) { i_Params_Get_Workshops_By_Where_V2.END_ROW = 1000000; }
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Where_V2(i_Params_Get_Workshops_By_Where_V2.WORKSHOPS_BEGINNING_DATE,i_Params_Get_Workshops_By_Where_V2.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Where_V2.OWNER_ID,i_Params_Get_Workshops_By_Where_V2.START_ROW,i_Params_Get_Workshops_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Where_V2");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList(Params_Get_Address_By_Criteria_InList i_Params_Get_Address_By_Criteria_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP oParams_Get_Address_By_Criteria_InList_SP = new Params_Get_Address_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_InList));}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList(i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList.STREET,i_Params_Get_Address_By_Criteria_InList.BUILDING,i_Params_Get_Address_By_Criteria_InList.FLOOR,i_Params_Get_Address_By_Criteria_InList.POBOX,i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList.OWNER_ID,i_Params_Get_Address_By_Criteria_InList.START_ROW,i_Params_Get_Address_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList");}
return oList;
}
public List<Address> Get_Address_By_Where_InList(Params_Get_Address_By_Where_InList i_Params_Get_Address_By_Where_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP oParams_Get_Address_By_Where_InList_SP = new Params_Get_Address_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_InList));}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList(i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList.STREET,i_Params_Get_Address_By_Where_InList.BUILDING,i_Params_Get_Address_By_Where_InList.FLOOR,i_Params_Get_Address_By_Where_InList.POBOX,i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList.OWNER_ID,i_Params_Get_Address_By_Where_InList.START_ROW,i_Params_Get_Address_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2(Params_Get_Address_By_Criteria_InList_V2 i_Params_Get_Address_By_Criteria_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP_V2 oParams_Get_Address_By_Criteria_InList_SP_V2 = new Params_Get_Address_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_InList_V2));}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_V2(i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList_V2.STREET,i_Params_Get_Address_By_Criteria_InList_V2.BUILDING,i_Params_Get_Address_By_Criteria_InList_V2.FLOOR,i_Params_Get_Address_By_Criteria_InList_V2.POBOX,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_InList_V2.START_ROW,i_Params_Get_Address_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2(Params_Get_Address_By_Where_InList_V2 i_Params_Get_Address_By_Where_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP_V2 oParams_Get_Address_By_Where_InList_SP_V2 = new Params_Get_Address_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_InList_V2));}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_V2(i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList_V2.STREET,i_Params_Get_Address_By_Where_InList_V2.BUILDING,i_Params_Get_Address_By_Where_InList_V2.FLOOR,i_Params_Get_Address_By_Where_InList_V2.POBOX,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.OWNER_ID,i_Params_Get_Address_By_Where_InList_V2.START_ROW,i_Params_Get_Address_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_V2");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList(Params_Get_Contact_By_Criteria_InList i_Params_Get_Contact_By_Criteria_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Criteria_InList_SP oParams_Get_Contact_By_Criteria_InList_SP = new Params_Get_Contact_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Criteria_InList));}
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
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_InList(i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria_InList.CONTACT,i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION,i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Criteria_InList.OWNER_ID,i_Params_Get_Contact_By_Criteria_InList.START_ROW,i_Params_Get_Contact_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_InList");}
return oList;
}
public List<Contact> Get_Contact_By_Where_InList(Params_Get_Contact_By_Where_InList i_Params_Get_Contact_By_Where_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Where_InList_SP oParams_Get_Contact_By_Where_InList_SP = new Params_Get_Contact_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Where_InList));}
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
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_InList(i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where_InList.CONTACT,i_Params_Get_Contact_By_Where_InList.DESCRIPTION,i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Where_InList.OWNER_ID,i_Params_Get_Contact_By_Where_InList.START_ROW,i_Params_Get_Contact_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_InList");}
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_InList(Params_Get_Conversions_By_Criteria_InList i_Params_Get_Conversions_By_Criteria_InList)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Conversions_By_Criteria_InList_SP oParams_Get_Conversions_By_Criteria_InList_SP = new Params_Get_Conversions_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Criteria_InList));}
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
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Criteria_InList(i_Params_Get_Conversions_By_Criteria_InList.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Criteria_InList.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Criteria_InList.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Conversions_By_Criteria_InList.OWNER_ID,i_Params_Get_Conversions_By_Criteria_InList.START_ROW,i_Params_Get_Conversions_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Conversions_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Conversions_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Criteria_InList");}
return oList;
}
public List<Conversions> Get_Conversions_By_Where_InList(Params_Get_Conversions_By_Where_InList i_Params_Get_Conversions_By_Where_InList)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Conversions_By_Where_InList_SP oParams_Get_Conversions_By_Where_InList_SP = new Params_Get_Conversions_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Where_InList));}
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
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Where_InList(i_Params_Get_Conversions_By_Where_InList.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Where_InList.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Where_InList.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Conversions_By_Where_InList.OWNER_ID,i_Params_Get_Conversions_By_Where_InList.START_ROW,i_Params_Get_Conversions_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Where_InList.TOTAL_COUNT = oParams_Get_Conversions_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Conversions_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Where_InList");}
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_InList_V2(Params_Get_Conversions_By_Criteria_InList_V2 i_Params_Get_Conversions_By_Criteria_InList_V2)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Conversions_By_Criteria_InList_SP_V2 oParams_Get_Conversions_By_Criteria_InList_SP_V2 = new Params_Get_Conversions_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Criteria_InList_V2));}
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
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Criteria_InList_V2(i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_DATE,i_Params_Get_Conversions_By_Criteria_InList_V2.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Conversions_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Conversions_By_Criteria_InList_V2.START_ROW,i_Params_Get_Conversions_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Conversions_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Conversions_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Criteria_InList_V2");}
return oList;
}
public List<Conversions> Get_Conversions_By_Where_InList_V2(Params_Get_Conversions_By_Where_InList_V2 i_Params_Get_Conversions_By_Where_InList_V2)
{
List<Conversions> oList = new List<Conversions>();
Conversions oConversions = new Conversions();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Conversions_By_Where_InList_SP_V2 oParams_Get_Conversions_By_Where_InList_SP_V2 = new Params_Get_Conversions_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Conversions_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Conversions_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Conversions_By_Where_InList_V2));}
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
List<DALC.Conversions> oList_DBEntries = _AppContext.Get_Conversions_By_Where_InList_V2(i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_FROM,i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_FOR,i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_DATE,i_Params_Get_Conversions_By_Where_InList_V2.CONVERSIONS_DESCRIPTION,i_Params_Get_Conversions_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Conversions_By_Where_InList_V2.OWNER_ID,i_Params_Get_Conversions_By_Where_InList_V2.START_ROW,i_Params_Get_Conversions_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oConversions = new Conversions();
oTools.CopyPropValues(oDBEntry, oConversions);
oList.Add(oConversions);
}
}
i_Params_Get_Conversions_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Conversions_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Conversions_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Conversions_By_Where_InList_V2");}
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_InList(Params_Get_Coupons_By_Criteria_InList i_Params_Get_Coupons_By_Criteria_InList)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Coupons_By_Criteria_InList_SP oParams_Get_Coupons_By_Criteria_InList_SP = new Params_Get_Coupons_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Criteria_InList));}
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
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Criteria_InList(i_Params_Get_Coupons_By_Criteria_InList.COUPONS_TYPE,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_STORE,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_FOR,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_NOTE,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Criteria_InList.COUPONS_MACHINE,i_Params_Get_Coupons_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Coupons_By_Criteria_InList.OWNER_ID,i_Params_Get_Coupons_By_Criteria_InList.START_ROW,i_Params_Get_Coupons_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Coupons_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Coupons_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Criteria_InList");}
return oList;
}
public List<Coupons> Get_Coupons_By_Where_InList(Params_Get_Coupons_By_Where_InList i_Params_Get_Coupons_By_Where_InList)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Coupons_By_Where_InList_SP oParams_Get_Coupons_By_Where_InList_SP = new Params_Get_Coupons_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Where_InList));}
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
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Where_InList(i_Params_Get_Coupons_By_Where_InList.COUPONS_TYPE,i_Params_Get_Coupons_By_Where_InList.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Where_InList.COUPONS_STORE,i_Params_Get_Coupons_By_Where_InList.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Where_InList.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Where_InList.COUPONS_FOR,i_Params_Get_Coupons_By_Where_InList.COUPONS_NOTE,i_Params_Get_Coupons_By_Where_InList.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Where_InList.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Where_InList.COUPONS_MACHINE,i_Params_Get_Coupons_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Coupons_By_Where_InList.OWNER_ID,i_Params_Get_Coupons_By_Where_InList.START_ROW,i_Params_Get_Coupons_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Where_InList.TOTAL_COUNT = oParams_Get_Coupons_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Coupons_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Where_InList");}
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_InList_V2(Params_Get_Coupons_By_Criteria_InList_V2 i_Params_Get_Coupons_By_Criteria_InList_V2)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Coupons_By_Criteria_InList_SP_V2 oParams_Get_Coupons_By_Criteria_InList_SP_V2 = new Params_Get_Coupons_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Criteria_InList_V2));}
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
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Criteria_InList_V2(i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_TYPE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_STORE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_DATE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_FOR,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_NOTE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Criteria_InList_V2.COUPONS_MACHINE,i_Params_Get_Coupons_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Coupons_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Coupons_By_Criteria_InList_V2.START_ROW,i_Params_Get_Coupons_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Coupons_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Coupons_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Criteria_InList_V2");}
return oList;
}
public List<Coupons> Get_Coupons_By_Where_InList_V2(Params_Get_Coupons_By_Where_InList_V2 i_Params_Get_Coupons_By_Where_InList_V2)
{
List<Coupons> oList = new List<Coupons>();
Coupons oCoupons = new Coupons();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Coupons_By_Where_InList_SP_V2 oParams_Get_Coupons_By_Where_InList_SP_V2 = new Params_Get_Coupons_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coupons_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Coupons_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Coupons_By_Where_InList_V2));}
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
List<DALC.Coupons> oList_DBEntries = _AppContext.Get_Coupons_By_Where_InList_V2(i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_TYPE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_DESCRIPTION,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_STORE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_DATE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_PAYMENT_WAITED,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_PAYMENT_DELIVERED,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_FOR,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_NOTE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_ITEM_TYPE,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_ITEM_QUANTITY,i_Params_Get_Coupons_By_Where_InList_V2.COUPONS_MACHINE,i_Params_Get_Coupons_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Coupons_By_Where_InList_V2.OWNER_ID,i_Params_Get_Coupons_By_Where_InList_V2.START_ROW,i_Params_Get_Coupons_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoupons = new Coupons();
oTools.CopyPropValues(oDBEntry, oCoupons);
oList.Add(oCoupons);
}
}
i_Params_Get_Coupons_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Coupons_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Coupons_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coupons_By_Where_InList_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList(Params_Get_Fees_By_Criteria_InList i_Params_Get_Fees_By_Criteria_InList)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Fees_By_Criteria_InList_SP oParams_Get_Fees_By_Criteria_InList_SP = new Params_Get_Fees_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_InList));}
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
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_InList(i_Params_Get_Fees_By_Criteria_InList.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList.FEES_STATUS,i_Params_Get_Fees_By_Criteria_InList.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Criteria_InList.FEES_STORE,i_Params_Get_Fees_By_Criteria_InList.FEES_TYPE,i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Fees_By_Criteria_InList.START_ROW,i_Params_Get_Fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_InList");}
return oList;
}
public List<Fees> Get_Fees_By_Where_InList(Params_Get_Fees_By_Where_InList i_Params_Get_Fees_By_Where_InList)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Fees_By_Where_InList_SP oParams_Get_Fees_By_Where_InList_SP = new Params_Get_Fees_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_InList));}
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
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_InList(i_Params_Get_Fees_By_Where_InList.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_InList.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Where_InList.FEES_STATUS,i_Params_Get_Fees_By_Where_InList.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Where_InList.FEES_STORE,i_Params_Get_Fees_By_Where_InList.FEES_TYPE,i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Where_InList.OWNER_ID,i_Params_Get_Fees_By_Where_InList.START_ROW,i_Params_Get_Fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_InList");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_V2(Params_Get_Fees_By_Criteria_InList_V2 i_Params_Get_Fees_By_Criteria_InList_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Fees_By_Criteria_InList_SP_V2 oParams_Get_Fees_By_Criteria_InList_SP_V2 = new Params_Get_Fees_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_InList_V2));}
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
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_InList_V2(i_Params_Get_Fees_By_Criteria_InList_V2.FEES_DATE,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList_V2.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_STATUS,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_STORE,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_TYPE,i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW,i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Fees_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_InList_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_V2(Params_Get_Fees_By_Where_InList_V2 i_Params_Get_Fees_By_Where_InList_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Fees_By_Where_InList_SP_V2 oParams_Get_Fees_By_Where_InList_SP_V2 = new Params_Get_Fees_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_InList_V2));}
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
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_InList_V2(i_Params_Get_Fees_By_Where_InList_V2.FEES_DATE,i_Params_Get_Fees_By_Where_InList_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_InList_V2.WORKSHOP_PAYMENT_DESCRIPTION,i_Params_Get_Fees_By_Where_InList_V2.FEES_STATUS,i_Params_Get_Fees_By_Where_InList_V2.FEES_PAYMENT_GATEWAY,i_Params_Get_Fees_By_Where_InList_V2.FEES_STORE,i_Params_Get_Fees_By_Where_InList_V2.FEES_TYPE,i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID,i_Params_Get_Fees_By_Where_InList_V2.START_ROW,i_Params_Get_Fees_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Fees_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_InList_V2");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList(Params_Get_Loc_l2_By_Criteria_InList i_Params_Get_Loc_l2_By_Criteria_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Criteria_InList_SP oParams_Get_Loc_l2_By_Criteria_InList_SP = new Params_Get_Loc_l2_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Criteria_InList));}
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
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_InList(i_Params_Get_Loc_l2_By_Criteria_InList.CODE,i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_InList");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList(Params_Get_Loc_l2_By_Where_InList i_Params_Get_Loc_l2_By_Where_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Where_InList_SP oParams_Get_Loc_l2_By_Where_InList_SP = new Params_Get_Loc_l2_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Where_InList));}
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
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_InList(i_Params_Get_Loc_l2_By_Where_InList.CODE,i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Where_InList.START_ROW,i_Params_Get_Loc_l2_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_InList");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList(Params_Get_Loc_l3_By_Criteria_InList i_Params_Get_Loc_l3_By_Criteria_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Criteria_InList_SP oParams_Get_Loc_l3_By_Criteria_InList_SP = new Params_Get_Loc_l3_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Criteria_InList));}
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
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_InList(i_Params_Get_Loc_l3_By_Criteria_InList.CODE,i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_InList");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList(Params_Get_Loc_l3_By_Where_InList i_Params_Get_Loc_l3_By_Where_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Where_InList_SP oParams_Get_Loc_l3_By_Where_InList_SP = new Params_Get_Loc_l3_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Where_InList));}
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
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_InList(i_Params_Get_Loc_l3_By_Where_InList.CODE,i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Where_InList.START_ROW,i_Params_Get_Loc_l3_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList(Params_Get_Loc_l4_By_Criteria_InList i_Params_Get_Loc_l4_By_Criteria_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Criteria_InList_SP oParams_Get_Loc_l4_By_Criteria_InList_SP = new Params_Get_Loc_l4_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Criteria_InList));}
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
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_InList(i_Params_Get_Loc_l4_By_Criteria_InList.CODE,i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList(Params_Get_Loc_l4_By_Where_InList i_Params_Get_Loc_l4_By_Where_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Where_InList_SP oParams_Get_Loc_l4_By_Where_InList_SP = new Params_Get_Loc_l4_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Where_InList));}
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
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_InList(i_Params_Get_Loc_l4_By_Where_InList.CODE,i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Where_InList.START_ROW,i_Params_Get_Loc_l4_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_InList");}
return oList;
}
public List<Machine> Get_Machine_By_Criteria_InList(Params_Get_Machine_By_Criteria_InList i_Params_Get_Machine_By_Criteria_InList)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Machine_By_Criteria_InList_SP oParams_Get_Machine_By_Criteria_InList_SP = new Params_Get_Machine_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Criteria_InList));}
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
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Criteria_InList(i_Params_Get_Machine_By_Criteria_InList.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Criteria_InList.MACHINE_NOTES,i_Params_Get_Machine_By_Criteria_InList.WORKSHOP_ID_LIST,i_Params_Get_Machine_By_Criteria_InList.OWNER_ID,i_Params_Get_Machine_By_Criteria_InList.START_ROW,i_Params_Get_Machine_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Machine_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Machine_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Criteria_InList");}
return oList;
}
public List<Machine> Get_Machine_By_Where_InList(Params_Get_Machine_By_Where_InList i_Params_Get_Machine_By_Where_InList)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Machine_By_Where_InList_SP oParams_Get_Machine_By_Where_InList_SP = new Params_Get_Machine_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Where_InList));}
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
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Where_InList(i_Params_Get_Machine_By_Where_InList.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Where_InList.MACHINE_NOTES,i_Params_Get_Machine_By_Where_InList.WORKSHOP_ID_LIST,i_Params_Get_Machine_By_Where_InList.OWNER_ID,i_Params_Get_Machine_By_Where_InList.START_ROW,i_Params_Get_Machine_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Where_InList.TOTAL_COUNT = oParams_Get_Machine_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Machine_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Where_InList");}
return oList;
}
public List<Machine> Get_Machine_By_Criteria_InList_V2(Params_Get_Machine_By_Criteria_InList_V2 i_Params_Get_Machine_By_Criteria_InList_V2)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Machine_By_Criteria_InList_SP_V2 oParams_Get_Machine_By_Criteria_InList_SP_V2 = new Params_Get_Machine_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Criteria_InList_V2));}
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
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Criteria_InList_V2(i_Params_Get_Machine_By_Criteria_InList_V2.MACHINE_DATE,i_Params_Get_Machine_By_Criteria_InList_V2.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Criteria_InList_V2.MACHINE_NOTES,i_Params_Get_Machine_By_Criteria_InList_V2.WORKSHOP_ID_LIST,i_Params_Get_Machine_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Machine_By_Criteria_InList_V2.START_ROW,i_Params_Get_Machine_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Machine_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Machine_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Criteria_InList_V2");}
return oList;
}
public List<Machine> Get_Machine_By_Where_InList_V2(Params_Get_Machine_By_Where_InList_V2 i_Params_Get_Machine_By_Where_InList_V2)
{
List<Machine> oList = new List<Machine>();
Machine oMachine = new Machine();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Machine_By_Where_InList_SP_V2 oParams_Get_Machine_By_Where_InList_SP_V2 = new Params_Get_Machine_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Machine_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Machine_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Machine_By_Where_InList_V2));}
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
List<DALC.Machine> oList_DBEntries = _AppContext.Get_Machine_By_Where_InList_V2(i_Params_Get_Machine_By_Where_InList_V2.MACHINE_DATE,i_Params_Get_Machine_By_Where_InList_V2.MACHINE_DESCRIPTION,i_Params_Get_Machine_By_Where_InList_V2.MACHINE_NOTES,i_Params_Get_Machine_By_Where_InList_V2.WORKSHOP_ID_LIST,i_Params_Get_Machine_By_Where_InList_V2.OWNER_ID,i_Params_Get_Machine_By_Where_InList_V2.START_ROW,i_Params_Get_Machine_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMachine = new Machine();
oTools.CopyPropValues(oDBEntry, oMachine);
oList.Add(oMachine);
}
}
i_Params_Get_Machine_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Machine_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Machine_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Machine_By_Where_InList_V2");}
return oList;
}
public List<Salary> Get_Salary_By_Criteria_InList(Params_Get_Salary_By_Criteria_InList i_Params_Get_Salary_By_Criteria_InList)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Salary_By_Criteria_InList_SP oParams_Get_Salary_By_Criteria_InList_SP = new Params_Get_Salary_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Criteria_InList));}
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
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Criteria_InList(i_Params_Get_Salary_By_Criteria_InList.DESCRIPTION,i_Params_Get_Salary_By_Criteria_InList.STAFF_ID_LIST,i_Params_Get_Salary_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Salary_By_Criteria_InList.OWNER_ID,i_Params_Get_Salary_By_Criteria_InList.START_ROW,i_Params_Get_Salary_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Salary_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Salary_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Criteria_InList");}
return oList;
}
public List<Salary> Get_Salary_By_Where_InList(Params_Get_Salary_By_Where_InList i_Params_Get_Salary_By_Where_InList)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Salary_By_Where_InList_SP oParams_Get_Salary_By_Where_InList_SP = new Params_Get_Salary_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Where_InList));}
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
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Where_InList(i_Params_Get_Salary_By_Where_InList.DESCRIPTION,i_Params_Get_Salary_By_Where_InList.STAFF_ID_LIST,i_Params_Get_Salary_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Salary_By_Where_InList.OWNER_ID,i_Params_Get_Salary_By_Where_InList.START_ROW,i_Params_Get_Salary_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Where_InList.TOTAL_COUNT = oParams_Get_Salary_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Salary_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Where_InList");}
return oList;
}
public List<Salary> Get_Salary_By_Criteria_InList_V2(Params_Get_Salary_By_Criteria_InList_V2 i_Params_Get_Salary_By_Criteria_InList_V2)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Salary_By_Criteria_InList_SP_V2 oParams_Get_Salary_By_Criteria_InList_SP_V2 = new Params_Get_Salary_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Criteria_InList_V2));}
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
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Criteria_InList_V2(i_Params_Get_Salary_By_Criteria_InList_V2.SALARY_DATE,i_Params_Get_Salary_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Salary_By_Criteria_InList_V2.STAFF_ID_LIST,i_Params_Get_Salary_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Salary_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Salary_By_Criteria_InList_V2.START_ROW,i_Params_Get_Salary_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Salary_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Salary_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Criteria_InList_V2");}
return oList;
}
public List<Salary> Get_Salary_By_Where_InList_V2(Params_Get_Salary_By_Where_InList_V2 i_Params_Get_Salary_By_Where_InList_V2)
{
List<Salary> oList = new List<Salary>();
Salary oSalary = new Salary();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Salary_By_Where_InList_SP_V2 oParams_Get_Salary_By_Where_InList_SP_V2 = new Params_Get_Salary_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Salary_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Salary_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Salary_By_Where_InList_V2));}
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
List<DALC.Salary> oList_DBEntries = _AppContext.Get_Salary_By_Where_InList_V2(i_Params_Get_Salary_By_Where_InList_V2.SALARY_DATE,i_Params_Get_Salary_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Salary_By_Where_InList_V2.STAFF_ID_LIST,i_Params_Get_Salary_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Salary_By_Where_InList_V2.OWNER_ID,i_Params_Get_Salary_By_Where_InList_V2.START_ROW,i_Params_Get_Salary_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSalary = new Salary();
oTools.CopyPropValues(oDBEntry, oSalary);
oList.Add(oSalary);
}
}
i_Params_Get_Salary_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Salary_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Salary_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Salary_By_Where_InList_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList(Params_Get_Staff_By_Criteria_InList i_Params_Get_Staff_By_Criteria_InList)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Staff_By_Criteria_InList_SP oParams_Get_Staff_By_Criteria_InList_SP = new Params_Get_Staff_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria_InList));}
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
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_InList(i_Params_Get_Staff_By_Criteria_InList.STAFF_NAME,i_Params_Get_Staff_By_Criteria_InList.STAFF_PAYMENT_DESCRIPTION,i_Params_Get_Staff_By_Criteria_InList.STAFF_REFERENCE,i_Params_Get_Staff_By_Criteria_InList.WORKSHOP_ID_LIST,i_Params_Get_Staff_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Staff_By_Criteria_InList.OWNER_ID,i_Params_Get_Staff_By_Criteria_InList.START_ROW,i_Params_Get_Staff_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Staff_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_InList");}
return oList;
}
public List<Staff> Get_Staff_By_Where_InList(Params_Get_Staff_By_Where_InList i_Params_Get_Staff_By_Where_InList)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Staff_By_Where_InList_SP oParams_Get_Staff_By_Where_InList_SP = new Params_Get_Staff_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where_InList));}
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
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_InList(i_Params_Get_Staff_By_Where_InList.STAFF_NAME,i_Params_Get_Staff_By_Where_InList.STAFF_PAYMENT_DESCRIPTION,i_Params_Get_Staff_By_Where_InList.STAFF_REFERENCE,i_Params_Get_Staff_By_Where_InList.WORKSHOP_ID_LIST,i_Params_Get_Staff_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Staff_By_Where_InList.OWNER_ID,i_Params_Get_Staff_By_Where_InList.START_ROW,i_Params_Get_Staff_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT = oParams_Get_Staff_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_InList");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList(Params_Get_Supplier_By_Criteria_InList i_Params_Get_Supplier_By_Criteria_InList)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_By_Criteria_InList_SP oParams_Get_Supplier_By_Criteria_InList_SP = new Params_Get_Supplier_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_InList));}
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
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_InList(i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Criteria_InList.COUPONS_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList.STOCK_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID,i_Params_Get_Supplier_By_Criteria_InList.START_ROW,i_Params_Get_Supplier_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Supplier_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_InList");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList(Params_Get_Supplier_By_Where_InList i_Params_Get_Supplier_By_Where_InList)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_By_Where_InList_SP oParams_Get_Supplier_By_Where_InList_SP = new Params_Get_Supplier_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_InList));}
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
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_InList(i_Params_Get_Supplier_By_Where_InList.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Where_InList.COUPONS_ID_LIST,i_Params_Get_Supplier_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Supplier_By_Where_InList.STOCK_ID_LIST,i_Params_Get_Supplier_By_Where_InList.OWNER_ID,i_Params_Get_Supplier_By_Where_InList.START_ROW,i_Params_Get_Supplier_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT = oParams_Get_Supplier_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_InList");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_V2(Params_Get_Supplier_By_Criteria_InList_V2 i_Params_Get_Supplier_By_Criteria_InList_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_By_Criteria_InList_SP_V2 oParams_Get_Supplier_By_Criteria_InList_SP_V2 = new Params_Get_Supplier_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_InList_V2));}
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
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_InList_V2(i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PAYMENT_DATE,i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Criteria_InList_V2.COUPONS_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList_V2.STOCK_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW,i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Supplier_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_InList_V2");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_V2(Params_Get_Supplier_By_Where_InList_V2 i_Params_Get_Supplier_By_Where_InList_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_By_Where_InList_SP_V2 oParams_Get_Supplier_By_Where_InList_SP_V2 = new Params_Get_Supplier_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_InList_V2));}
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
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_InList_V2(i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PAYMENT_DATE,i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PAYMENT_CAUSE,i_Params_Get_Supplier_By_Where_InList_V2.COUPONS_ID_LIST,i_Params_Get_Supplier_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Supplier_By_Where_InList_V2.STOCK_ID_LIST,i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID,i_Params_Get_Supplier_By_Where_InList_V2.START_ROW,i_Params_Get_Supplier_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Supplier_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_InList_V2");}
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_InList(Params_Get_Workshop_By_Criteria_InList i_Params_Get_Workshop_By_Criteria_InList)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Workshop_By_Criteria_InList_SP oParams_Get_Workshop_By_Criteria_InList_SP = new Params_Get_Workshop_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Criteria_InList));}
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
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Criteria_InList(i_Params_Get_Workshop_By_Criteria_InList.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList.STOCK_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList.MACHINE_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList.OWNER_ID,i_Params_Get_Workshop_By_Criteria_InList.START_ROW,i_Params_Get_Workshop_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Workshop_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Workshop_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Criteria_InList");}
return oList;
}
public List<Workshop> Get_Workshop_By_Where_InList(Params_Get_Workshop_By_Where_InList i_Params_Get_Workshop_By_Where_InList)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Workshop_By_Where_InList_SP oParams_Get_Workshop_By_Where_InList_SP = new Params_Get_Workshop_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Where_InList));}
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
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Where_InList(i_Params_Get_Workshop_By_Where_InList.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Workshop_By_Where_InList.STOCK_ID_LIST,i_Params_Get_Workshop_By_Where_InList.MACHINE_ID_LIST,i_Params_Get_Workshop_By_Where_InList.OWNER_ID,i_Params_Get_Workshop_By_Where_InList.START_ROW,i_Params_Get_Workshop_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Where_InList.TOTAL_COUNT = oParams_Get_Workshop_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Workshop_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Where_InList");}
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_InList_V2(Params_Get_Workshop_By_Criteria_InList_V2 i_Params_Get_Workshop_By_Criteria_InList_V2)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Workshop_By_Criteria_InList_SP_V2 oParams_Get_Workshop_By_Criteria_InList_SP_V2 = new Params_Get_Workshop_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Criteria_InList_V2));}
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
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Criteria_InList_V2(i_Params_Get_Workshop_By_Criteria_InList_V2.WORKSHOP_BEGINNING_DATE,i_Params_Get_Workshop_By_Criteria_InList_V2.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList_V2.STOCK_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList_V2.MACHINE_ID_LIST,i_Params_Get_Workshop_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Workshop_By_Criteria_InList_V2.START_ROW,i_Params_Get_Workshop_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Workshop_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Workshop_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Criteria_InList_V2");}
return oList;
}
public List<Workshop> Get_Workshop_By_Where_InList_V2(Params_Get_Workshop_By_Where_InList_V2 i_Params_Get_Workshop_By_Where_InList_V2)
{
List<Workshop> oList = new List<Workshop>();
Workshop oWorkshop = new Workshop();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Workshop_By_Where_InList_SP_V2 oParams_Get_Workshop_By_Where_InList_SP_V2 = new Params_Get_Workshop_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshop_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshop_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshop_By_Where_InList_V2));}
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
List<DALC.Workshop> oList_DBEntries = _AppContext.Get_Workshop_By_Where_InList_V2(i_Params_Get_Workshop_By_Where_InList_V2.WORKSHOP_BEGINNING_DATE,i_Params_Get_Workshop_By_Where_InList_V2.WORKSHOP_FEES_DESCRIPTION,i_Params_Get_Workshop_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Workshop_By_Where_InList_V2.STOCK_ID_LIST,i_Params_Get_Workshop_By_Where_InList_V2.MACHINE_ID_LIST,i_Params_Get_Workshop_By_Where_InList_V2.OWNER_ID,i_Params_Get_Workshop_By_Where_InList_V2.START_ROW,i_Params_Get_Workshop_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshop = new Workshop();
oTools.CopyPropValues(oDBEntry, oWorkshop);
oList.Add(oWorkshop);
}
}
i_Params_Get_Workshop_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Workshop_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Workshop_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshop_By_Where_InList_V2");}
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_InList(Params_Get_Workshops_By_Criteria_InList i_Params_Get_Workshops_By_Criteria_InList)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Workshops_By_Criteria_InList_SP oParams_Get_Workshops_By_Criteria_InList_SP = new Params_Get_Workshops_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Criteria_InList));}
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
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Criteria_InList(i_Params_Get_Workshops_By_Criteria_InList.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList.STOCK_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList.MACHINE_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList.OWNER_ID,i_Params_Get_Workshops_By_Criteria_InList.START_ROW,i_Params_Get_Workshops_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Workshops_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Workshops_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Criteria_InList");}
return oList;
}
public List<Workshops> Get_Workshops_By_Where_InList(Params_Get_Workshops_By_Where_InList i_Params_Get_Workshops_By_Where_InList)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Workshops_By_Where_InList_SP oParams_Get_Workshops_By_Where_InList_SP = new Params_Get_Workshops_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Where_InList));}
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
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Where_InList(i_Params_Get_Workshops_By_Where_InList.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Workshops_By_Where_InList.STOCK_ID_LIST,i_Params_Get_Workshops_By_Where_InList.MACHINE_ID_LIST,i_Params_Get_Workshops_By_Where_InList.OWNER_ID,i_Params_Get_Workshops_By_Where_InList.START_ROW,i_Params_Get_Workshops_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Where_InList.TOTAL_COUNT = oParams_Get_Workshops_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Workshops_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Where_InList");}
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_InList_V2(Params_Get_Workshops_By_Criteria_InList_V2 i_Params_Get_Workshops_By_Criteria_InList_V2)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Workshops_By_Criteria_InList_SP_V2 oParams_Get_Workshops_By_Criteria_InList_SP_V2 = new Params_Get_Workshops_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Criteria_InList_V2));}
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
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Criteria_InList_V2(i_Params_Get_Workshops_By_Criteria_InList_V2.WORKSHOPS_BEGINNING_DATE,i_Params_Get_Workshops_By_Criteria_InList_V2.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList_V2.STOCK_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList_V2.MACHINE_ID_LIST,i_Params_Get_Workshops_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Workshops_By_Criteria_InList_V2.START_ROW,i_Params_Get_Workshops_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Workshops_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Workshops_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Criteria_InList_V2");}
return oList;
}
public List<Workshops> Get_Workshops_By_Where_InList_V2(Params_Get_Workshops_By_Where_InList_V2 i_Params_Get_Workshops_By_Where_InList_V2)
{
List<Workshops> oList = new List<Workshops>();
Workshops oWorkshops = new Workshops();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Workshops_By_Where_InList_SP_V2 oParams_Get_Workshops_By_Where_InList_SP_V2 = new Params_Get_Workshops_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Workshops_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Workshops_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Workshops_By_Where_InList_V2));}
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
List<DALC.Workshops> oList_DBEntries = _AppContext.Get_Workshops_By_Where_InList_V2(i_Params_Get_Workshops_By_Where_InList_V2.WORKSHOPS_BEGINNING_DATE,i_Params_Get_Workshops_By_Where_InList_V2.WORKSHOPS_FEES_DESCRIPTION,i_Params_Get_Workshops_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Workshops_By_Where_InList_V2.STOCK_ID_LIST,i_Params_Get_Workshops_By_Where_InList_V2.MACHINE_ID_LIST,i_Params_Get_Workshops_By_Where_InList_V2.OWNER_ID,i_Params_Get_Workshops_By_Where_InList_V2.START_ROW,i_Params_Get_Workshops_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWorkshops = new Workshops();
oTools.CopyPropValues(oDBEntry, oWorkshops);
oList.Add(oWorkshops);
}
}
i_Params_Get_Workshops_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Workshops_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Workshops_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Workshops_By_Where_InList_V2");}
return oList;
}
public void Delete_Address(Params_Delete_Address i_Params_Delete_Address)
{
Params_Get_Address_By_ADDRESS_ID oParams_Get_Address_By_ADDRESS_ID = new Params_Get_Address_By_ADDRESS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address));}
#region Body Section.
try
{
oParams_Get_Address_By_ADDRESS_ID.ADDRESS_ID = i_Params_Delete_Address.ADDRESS_ID;
_Address = Get_Address_By_ADDRESS_ID_Adv(oParams_Get_Address_By_ADDRESS_ID);
if (_Address != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address(i_Params_Delete_Address.ADDRESS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address");}
}
public void Delete_Contact(Params_Delete_Contact i_Params_Delete_Contact)
{
Params_Get_Contact_By_CONTACT_ID oParams_Get_Contact_By_CONTACT_ID = new Params_Get_Contact_By_CONTACT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Contact",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Contact));}
#region Body Section.
try
{
oParams_Get_Contact_By_CONTACT_ID.CONTACT_ID = i_Params_Delete_Contact.CONTACT_ID;
_Contact = Get_Contact_By_CONTACT_ID_Adv(oParams_Get_Contact_By_CONTACT_ID);
if (_Contact != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact(i_Params_Delete_Contact.CONTACT_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact");}
}
public void Delete_Conversions(Params_Delete_Conversions i_Params_Delete_Conversions)
{
Params_Get_Conversions_By_CONVERSIONS_ID oParams_Get_Conversions_By_CONVERSIONS_ID = new Params_Get_Conversions_By_CONVERSIONS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Conversions");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Conversions",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Conversions));}
#region Body Section.
try
{
oParams_Get_Conversions_By_CONVERSIONS_ID.CONVERSIONS_ID = i_Params_Delete_Conversions.CONVERSIONS_ID;
_Conversions = Get_Conversions_By_CONVERSIONS_ID_Adv(oParams_Get_Conversions_By_CONVERSIONS_ID);
if (_Conversions != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Conversions_Execution)
{
_Stop_Delete_Conversions_Execution = false;
return;
}
_AppContext.Delete_Conversions(i_Params_Delete_Conversions.CONVERSIONS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Conversions");}
}
public void Delete_Coupons(Params_Delete_Coupons i_Params_Delete_Coupons)
{
Params_Get_Coupons_By_COUPONS_ID oParams_Get_Coupons_By_COUPONS_ID = new Params_Get_Coupons_By_COUPONS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Coupons");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Coupons",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Coupons));}
#region Body Section.
try
{
oParams_Get_Coupons_By_COUPONS_ID.COUPONS_ID = i_Params_Delete_Coupons.COUPONS_ID;
_Coupons = Get_Coupons_By_COUPONS_ID_Adv(oParams_Get_Coupons_By_COUPONS_ID);
if (_Coupons != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Coupons_Execution)
{
_Stop_Delete_Coupons_Execution = false;
return;
}
_AppContext.Delete_Coupons(i_Params_Delete_Coupons.COUPONS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Coupons");}
}
public void Delete_Currency(Params_Delete_Currency i_Params_Delete_Currency)
{
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Currency");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Currency",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Currency));}
#region Body Section.
try
{
oParams_Get_Currency_By_CURRENCY_ID.CURRENCY_ID = i_Params_Delete_Currency.CURRENCY_ID;
_Currency = Get_Currency_By_CURRENCY_ID_Adv(oParams_Get_Currency_By_CURRENCY_ID);
if (_Currency != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Currency_Execution)
{
_Stop_Delete_Currency_Execution = false;
return;
}
_AppContext.Delete_Currency(i_Params_Delete_Currency.CURRENCY_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Currency");}
}
public void Delete_Fees(Params_Delete_Fees i_Params_Delete_Fees)
{
Params_Get_Fees_By_FEES_ID oParams_Get_Fees_By_FEES_ID = new Params_Get_Fees_By_FEES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Fees));}
#region Body Section.
try
{
oParams_Get_Fees_By_FEES_ID.FEES_ID = i_Params_Delete_Fees.FEES_ID;
_Fees = Get_Fees_By_FEES_ID_Adv(oParams_Get_Fees_By_FEES_ID);
if (_Fees != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Fees_Execution)
{
_Stop_Delete_Fees_Execution = false;
return;
}
_AppContext.Delete_Fees(i_Params_Delete_Fees.FEES_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Fees");}
}
public void Delete_Industry(Params_Delete_Industry i_Params_Delete_Industry)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Industry");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Industry",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Industry));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Industry_Execution)
{
_Stop_Delete_Industry_Execution = false;
return;
}
_AppContext.Delete_Industry(i_Params_Delete_Industry.INDUSTRY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Industry");}
}
public void Delete_Loc_l1(Params_Delete_Loc_l1 i_Params_Delete_Loc_l1)
{
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l1",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l1));}
#region Body Section.
try
{
oParams_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID = i_Params_Delete_Loc_l1.LOC_L1_ID;
_Loc_l1 = Get_Loc_l1_By_LOC_L1_ID_Adv(oParams_Get_Loc_l1_By_LOC_L1_ID);
if (_Loc_l1 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1(i_Params_Delete_Loc_l1.LOC_L1_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1");}
}
public void Delete_Loc_l2(Params_Delete_Loc_l2 i_Params_Delete_Loc_l2)
{
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l2));}
#region Body Section.
try
{
oParams_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID = i_Params_Delete_Loc_l2.LOC_L2_ID;
_Loc_l2 = Get_Loc_l2_By_LOC_L2_ID_Adv(oParams_Get_Loc_l2_By_LOC_L2_ID);
if (_Loc_l2 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2(i_Params_Delete_Loc_l2.LOC_L2_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2");}
}
public void Delete_Loc_l3(Params_Delete_Loc_l3 i_Params_Delete_Loc_l3)
{
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l3",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l3));}
#region Body Section.
try
{
oParams_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID = i_Params_Delete_Loc_l3.LOC_L3_ID;
_Loc_l3 = Get_Loc_l3_By_LOC_L3_ID_Adv(oParams_Get_Loc_l3_By_LOC_L3_ID);
if (_Loc_l3 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3(i_Params_Delete_Loc_l3.LOC_L3_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3");}
}
public void Delete_Loc_l4(Params_Delete_Loc_l4 i_Params_Delete_Loc_l4)
{
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l4",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l4));}
#region Body Section.
try
{
oParams_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID = i_Params_Delete_Loc_l4.LOC_L4_ID;
_Loc_l4 = Get_Loc_l4_By_LOC_L4_ID_Adv(oParams_Get_Loc_l4_By_LOC_L4_ID);
if (_Loc_l4 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4(i_Params_Delete_Loc_l4.LOC_L4_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4");}
}
public void Delete_Machine(Params_Delete_Machine i_Params_Delete_Machine)
{
Params_Get_Machine_By_MACHINE_ID oParams_Get_Machine_By_MACHINE_ID = new Params_Get_Machine_By_MACHINE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Machine");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Machine",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Machine));}
#region Body Section.
try
{
oParams_Get_Machine_By_MACHINE_ID.MACHINE_ID = i_Params_Delete_Machine.MACHINE_ID;
_Machine = Get_Machine_By_MACHINE_ID_Adv(oParams_Get_Machine_By_MACHINE_ID);
if (_Machine != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Machine_Execution)
{
_Stop_Delete_Machine_Execution = false;
return;
}
_AppContext.Delete_Machine(i_Params_Delete_Machine.MACHINE_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Machine");}
}
public void Delete_Method_run(Params_Delete_Method_run i_Params_Delete_Method_run)
{
Params_Get_Method_run_By_METHOD_RUN_ID oParams_Get_Method_run_By_METHOD_RUN_ID = new Params_Get_Method_run_By_METHOD_RUN_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Method_run");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Method_run",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Method_run));}
#region Body Section.
try
{
oParams_Get_Method_run_By_METHOD_RUN_ID.METHOD_RUN_ID = i_Params_Delete_Method_run.METHOD_RUN_ID;
_Method_run = Get_Method_run_By_METHOD_RUN_ID_Adv(oParams_Get_Method_run_By_METHOD_RUN_ID);
if (_Method_run != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Method_run_Execution)
{
_Stop_Delete_Method_run_Execution = false;
return;
}
_AppContext.Delete_Method_run(i_Params_Delete_Method_run.METHOD_RUN_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Method_run");}
}
public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Owner");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Owner",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Owner));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Owner_Execution)
{
_Stop_Delete_Owner_Execution = false;
return;
}
_AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Owner");}
}
public void Delete_Person(Params_Delete_Person i_Params_Delete_Person)
{
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Person",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Person));}
#region Body Section.
try
{
oParams_Get_Person_By_PERSON_ID.PERSON_ID = i_Params_Delete_Person.PERSON_ID;
_Person = Get_Person_By_PERSON_ID_Adv(oParams_Get_Person_By_PERSON_ID);
if (_Person != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person(i_Params_Delete_Person.PERSON_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person");}
}
public void Delete_Productdistribution(Params_Delete_Productdistribution i_Params_Delete_Productdistribution)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Productdistribution");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Productdistribution",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Productdistribution));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Productdistribution_Execution)
{
_Stop_Delete_Productdistribution_Execution = false;
return;
}
_AppContext.Delete_Productdistribution(i_Params_Delete_Productdistribution.PRODUCTDISTRIBUTION_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Productdistribution");}
}
public void Delete_Salary(Params_Delete_Salary i_Params_Delete_Salary)
{
Params_Get_Salary_By_SALARY_ID oParams_Get_Salary_By_SALARY_ID = new Params_Get_Salary_By_SALARY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Salary");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Salary",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Salary));}
#region Body Section.
try
{
oParams_Get_Salary_By_SALARY_ID.SALARY_ID = i_Params_Delete_Salary.SALARY_ID;
_Salary = Get_Salary_By_SALARY_ID_Adv(oParams_Get_Salary_By_SALARY_ID);
if (_Salary != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Salary_Execution)
{
_Stop_Delete_Salary_Execution = false;
return;
}
_AppContext.Delete_Salary(i_Params_Delete_Salary.SALARY_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Salary");}
}
public void Delete_Staff(Params_Delete_Staff i_Params_Delete_Staff)
{
Params_Get_Staff_By_STAFF_ID oParams_Get_Staff_By_STAFF_ID = new Params_Get_Staff_By_STAFF_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff));}
#region Body Section.
try
{
oParams_Get_Staff_By_STAFF_ID.STAFF_ID = i_Params_Delete_Staff.STAFF_ID;
_Staff = Get_Staff_By_STAFF_ID_Adv(oParams_Get_Staff_By_STAFF_ID);
if (_Staff != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_Execution)
{
_Stop_Delete_Staff_Execution = false;
return;
}
_AppContext.Delete_Staff(i_Params_Delete_Staff.STAFF_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff");}
}
public void Delete_Stock(Params_Delete_Stock i_Params_Delete_Stock)
{
Params_Get_Stock_By_STOCK_ID oParams_Get_Stock_By_STOCK_ID = new Params_Get_Stock_By_STOCK_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Stock");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Stock",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Stock));}
#region Body Section.
try
{
oParams_Get_Stock_By_STOCK_ID.STOCK_ID = i_Params_Delete_Stock.STOCK_ID;
_Stock = Get_Stock_By_STOCK_ID_Adv(oParams_Get_Stock_By_STOCK_ID);
if (_Stock != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Stock_Execution)
{
_Stop_Delete_Stock_Execution = false;
return;
}
_AppContext.Delete_Stock(i_Params_Delete_Stock.STOCK_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Stock");}
}
public void Delete_Supplier(Params_Delete_Supplier i_Params_Delete_Supplier)
{
Params_Get_Supplier_By_SUPPLIER_ID oParams_Get_Supplier_By_SUPPLIER_ID = new Params_Get_Supplier_By_SUPPLIER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier));}
#region Body Section.
try
{
oParams_Get_Supplier_By_SUPPLIER_ID.SUPPLIER_ID = i_Params_Delete_Supplier.SUPPLIER_ID;
_Supplier = Get_Supplier_By_SUPPLIER_ID_Adv(oParams_Get_Supplier_By_SUPPLIER_ID);
if (_Supplier != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_Execution)
{
_Stop_Delete_Supplier_Execution = false;
return;
}
_AppContext.Delete_Supplier(i_Params_Delete_Supplier.SUPPLIER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier");}
}
public void Delete_Transaction(Params_Delete_Transaction i_Params_Delete_Transaction)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Transaction");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Transaction",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Transaction));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Transaction_Execution)
{
_Stop_Delete_Transaction_Execution = false;
return;
}
_AppContext.Delete_Transaction(i_Params_Delete_Transaction.TRANSACTION_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Transaction");}
}
public void Delete_User(Params_Delete_User i_Params_Delete_User)
{
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_User",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_User));}
#region Body Section.
try
{
oParams_Get_User_By_USER_ID.USER_ID = i_Params_Delete_User.USER_ID;
_User = Get_User_By_USER_ID_Adv(oParams_Get_User_By_USER_ID);
if (_User != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User(i_Params_Delete_User.USER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User");}
}
public void Delete_Workshop(Params_Delete_Workshop i_Params_Delete_Workshop)
{
Params_Get_Workshop_By_WORKSHOP_ID oParams_Get_Workshop_By_WORKSHOP_ID = new Params_Get_Workshop_By_WORKSHOP_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshop");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshop",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshop));}
#region Body Section.
try
{
oParams_Get_Workshop_By_WORKSHOP_ID.WORKSHOP_ID = i_Params_Delete_Workshop.WORKSHOP_ID;
_Workshop = Get_Workshop_By_WORKSHOP_ID_Adv(oParams_Get_Workshop_By_WORKSHOP_ID);
if (_Workshop != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshop_Execution)
{
_Stop_Delete_Workshop_Execution = false;
return;
}
_AppContext.Delete_Workshop(i_Params_Delete_Workshop.WORKSHOP_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshop");}
}
public void Delete_Workshops(Params_Delete_Workshops i_Params_Delete_Workshops)
{
Params_Get_Workshops_By_WORKSHOPS_ID oParams_Get_Workshops_By_WORKSHOPS_ID = new Params_Get_Workshops_By_WORKSHOPS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshops");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshops",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshops));}
#region Body Section.
try
{
oParams_Get_Workshops_By_WORKSHOPS_ID.WORKSHOPS_ID = i_Params_Delete_Workshops.WORKSHOPS_ID;
_Workshops = Get_Workshops_By_WORKSHOPS_ID_Adv(oParams_Get_Workshops_By_WORKSHOPS_ID);
if (_Workshops != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshops_Execution)
{
_Stop_Delete_Workshops_Execution = false;
return;
}
_AppContext.Delete_Workshops(i_Params_Delete_Workshops.WORKSHOPS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshops");}
}
public void Delete_Address_By_PERSON_ID(Params_Delete_Address_By_PERSON_ID i_Params_Delete_Address_By_PERSON_ID)
{
Params_Get_Address_By_PERSON_ID oParams_Get_Address_By_PERSON_ID = new Params_Get_Address_By_PERSON_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_PERSON_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID(i_Params_Delete_Address_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID");}
}
public void Delete_Address_By_LOC_L1_ID(Params_Delete_Address_By_LOC_L1_ID i_Params_Delete_Address_By_LOC_L1_ID)
{
Params_Get_Address_By_LOC_L1_ID oParams_Get_Address_By_LOC_L1_ID = new Params_Get_Address_By_LOC_L1_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_LOC_L1_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L1_ID(i_Params_Delete_Address_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L1_ID");}
}
public void Delete_Address_By_LOC_L2_ID(Params_Delete_Address_By_LOC_L2_ID i_Params_Delete_Address_By_LOC_L2_ID)
{
Params_Get_Address_By_LOC_L2_ID oParams_Get_Address_By_LOC_L2_ID = new Params_Get_Address_By_LOC_L2_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_LOC_L2_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L2_ID(i_Params_Delete_Address_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L2_ID");}
}
public void Delete_Address_By_LOC_L3_ID(Params_Delete_Address_By_LOC_L3_ID i_Params_Delete_Address_By_LOC_L3_ID)
{
Params_Get_Address_By_LOC_L3_ID oParams_Get_Address_By_LOC_L3_ID = new Params_Get_Address_By_LOC_L3_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_LOC_L3_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L3_ID(i_Params_Delete_Address_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L3_ID");}
}
public void Delete_Address_By_OWNER_ID(Params_Delete_Address_By_OWNER_ID i_Params_Delete_Address_By_OWNER_ID)
{
Params_Get_Address_By_OWNER_ID oParams_Get_Address_By_OWNER_ID = new Params_Get_Address_By_OWNER_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_OWNER_ID(i_Params_Delete_Address_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_OWNER_ID");}
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE oParams_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE = new Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
}
public void Delete_Address_By_LOC_L4_ID(Params_Delete_Address_By_LOC_L4_ID i_Params_Delete_Address_By_LOC_L4_ID)
{
Params_Get_Address_By_LOC_L4_ID oParams_Get_Address_By_LOC_L4_ID = new Params_Get_Address_By_LOC_L4_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L4_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_LOC_L4_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_LOC_L4_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L4_ID(i_Params_Delete_Address_By_LOC_L4_ID.LOC_L4_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L4_ID");}
}
public void Delete_Contact_By_PERSON_ID(Params_Delete_Contact_By_PERSON_ID i_Params_Delete_Contact_By_PERSON_ID)
{
Params_Get_Contact_By_PERSON_ID oParams_Get_Contact_By_PERSON_ID = new Params_Get_Contact_By_PERSON_ID();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Contact_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Contact_By_PERSON_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID(i_Params_Delete_Contact_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID");}
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT oParams_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT = new Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
}
public void Delete_Contact_By_OWNER_ID(Params_Delete_Contact_By_OWNER_ID i_Params_Delete_Contact_By_OWNER_ID)
{
Params_Get_Contact_By_OWNER_ID oParams_Get_Contact_By_OWNER_ID = new Params_Get_Contact_By_OWNER_ID();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Contact_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Contact_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_OWNER_ID(i_Params_Delete_Contact_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_OWNER_ID");}
}
public void Delete_Conversions_By_OWNER_ID(Params_Delete_Conversions_By_OWNER_ID i_Params_Delete_Conversions_By_OWNER_ID)
{
Params_Get_Conversions_By_OWNER_ID oParams_Get_Conversions_By_OWNER_ID = new Params_Get_Conversions_By_OWNER_ID();
List<Conversions> _List_Conversions = new List<Conversions>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Conversions_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Conversions_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Conversions_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Conversions_Execution)
{
_Stop_Delete_Conversions_Execution = false;
return;
}
_AppContext.Delete_Conversions_By_OWNER_ID(i_Params_Delete_Conversions_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Conversions_By_OWNER_ID");}
}
public void Delete_Conversions_By_CURRENCY_ID(Params_Delete_Conversions_By_CURRENCY_ID i_Params_Delete_Conversions_By_CURRENCY_ID)
{
Params_Get_Conversions_By_CURRENCY_ID oParams_Get_Conversions_By_CURRENCY_ID = new Params_Get_Conversions_By_CURRENCY_ID();
List<Conversions> _List_Conversions = new List<Conversions>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Conversions_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Conversions_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Conversions_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Conversions_Execution)
{
_Stop_Delete_Conversions_Execution = false;
return;
}
_AppContext.Delete_Conversions_By_CURRENCY_ID(i_Params_Delete_Conversions_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Conversions_By_CURRENCY_ID");}
}
public void Delete_Coupons_By_OWNER_ID(Params_Delete_Coupons_By_OWNER_ID i_Params_Delete_Coupons_By_OWNER_ID)
{
Params_Get_Coupons_By_OWNER_ID oParams_Get_Coupons_By_OWNER_ID = new Params_Get_Coupons_By_OWNER_ID();
List<Coupons> _List_Coupons = new List<Coupons>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Coupons_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Coupons_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Coupons_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Coupons_Execution)
{
_Stop_Delete_Coupons_Execution = false;
return;
}
_AppContext.Delete_Coupons_By_OWNER_ID(i_Params_Delete_Coupons_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Coupons_By_OWNER_ID");}
}
public void Delete_Coupons_By_CURRENCY_ID(Params_Delete_Coupons_By_CURRENCY_ID i_Params_Delete_Coupons_By_CURRENCY_ID)
{
Params_Get_Coupons_By_CURRENCY_ID oParams_Get_Coupons_By_CURRENCY_ID = new Params_Get_Coupons_By_CURRENCY_ID();
List<Coupons> _List_Coupons = new List<Coupons>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Coupons_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Coupons_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Coupons_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Coupons_Execution)
{
_Stop_Delete_Coupons_Execution = false;
return;
}
_AppContext.Delete_Coupons_By_CURRENCY_ID(i_Params_Delete_Coupons_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Coupons_By_CURRENCY_ID");}
}
public void Delete_Currency_By_OWNER_ID(Params_Delete_Currency_By_OWNER_ID i_Params_Delete_Currency_By_OWNER_ID)
{
Params_Get_Currency_By_OWNER_ID oParams_Get_Currency_By_OWNER_ID = new Params_Get_Currency_By_OWNER_ID();
List<Currency> _List_Currency = new List<Currency>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Currency_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Currency_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Currency_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Currency_Execution)
{
_Stop_Delete_Currency_Execution = false;
return;
}
_AppContext.Delete_Currency_By_OWNER_ID(i_Params_Delete_Currency_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Currency_By_OWNER_ID");}
}
public void Delete_Fees_By_OWNER_ID(Params_Delete_Fees_By_OWNER_ID i_Params_Delete_Fees_By_OWNER_ID)
{
Params_Get_Fees_By_OWNER_ID oParams_Get_Fees_By_OWNER_ID = new Params_Get_Fees_By_OWNER_ID();
List<Fees> _List_Fees = new List<Fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Fees_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Fees_Execution)
{
_Stop_Delete_Fees_Execution = false;
return;
}
_AppContext.Delete_Fees_By_OWNER_ID(i_Params_Delete_Fees_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Fees_By_OWNER_ID");}
}
public void Delete_Fees_By_CURRENCY_ID(Params_Delete_Fees_By_CURRENCY_ID i_Params_Delete_Fees_By_CURRENCY_ID)
{
Params_Get_Fees_By_CURRENCY_ID oParams_Get_Fees_By_CURRENCY_ID = new Params_Get_Fees_By_CURRENCY_ID();
List<Fees> _List_Fees = new List<Fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Fees_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Fees_Execution)
{
_Stop_Delete_Fees_Execution = false;
return;
}
_AppContext.Delete_Fees_By_CURRENCY_ID(i_Params_Delete_Fees_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Fees_By_CURRENCY_ID");}
}
public void Delete_Industry_By_OWNER_ID(Params_Delete_Industry_By_OWNER_ID i_Params_Delete_Industry_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Industry_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Industry_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Industry_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Industry_Execution)
{
_Stop_Delete_Industry_Execution = false;
return;
}
_AppContext.Delete_Industry_By_OWNER_ID(i_Params_Delete_Industry_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Industry_By_OWNER_ID");}
}
public void Delete_Industry_By_COUPONS_ID(Params_Delete_Industry_By_COUPONS_ID i_Params_Delete_Industry_By_COUPONS_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Industry_By_COUPONS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Industry_By_COUPONS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Industry_By_COUPONS_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Industry_Execution)
{
_Stop_Delete_Industry_Execution = false;
return;
}
_AppContext.Delete_Industry_By_COUPONS_ID(i_Params_Delete_Industry_By_COUPONS_ID.COUPONS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Industry_By_COUPONS_ID");}
}
public void Delete_Industry_By_STOCK_ID(Params_Delete_Industry_By_STOCK_ID i_Params_Delete_Industry_By_STOCK_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Industry_By_STOCK_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Industry_By_STOCK_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Industry_By_STOCK_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Industry_Execution)
{
_Stop_Delete_Industry_Execution = false;
return;
}
_AppContext.Delete_Industry_By_STOCK_ID(i_Params_Delete_Industry_By_STOCK_ID.STOCK_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Industry_By_STOCK_ID");}
}
public void Delete_Loc_l1_By_CODE(Params_Delete_Loc_l1_By_CODE i_Params_Delete_Loc_l1_By_CODE)
{
Params_Get_Loc_l1_By_CODE oParams_Get_Loc_l1_By_CODE = new Params_Get_Loc_l1_By_CODE();
List<Loc_l1> _List_Loc_l1 = new List<Loc_l1>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l1_By_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l1_By_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_CODE(i_Params_Delete_Loc_l1_By_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_CODE");}
}
public void Delete_Loc_l1_By_OWNER_ID(Params_Delete_Loc_l1_By_OWNER_ID i_Params_Delete_Loc_l1_By_OWNER_ID)
{
Params_Get_Loc_l1_By_OWNER_ID oParams_Get_Loc_l1_By_OWNER_ID = new Params_Get_Loc_l1_By_OWNER_ID();
List<Loc_l1> _List_Loc_l1 = new List<Loc_l1>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l1_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l1_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_OWNER_ID(i_Params_Delete_Loc_l1_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_OWNER_ID");}
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE(Params_Delete_Loc_l2_By_LOC_L1_ID_CODE i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE)
{
Params_Get_Loc_l2_By_LOC_L1_ID_CODE oParams_Get_Loc_l2_By_LOC_L1_ID_CODE = new Params_Get_Loc_l2_By_LOC_L1_ID_CODE();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l2_By_LOC_L1_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
}
public void Delete_Loc_l2_By_LOC_L1_ID(Params_Delete_Loc_l2_By_LOC_L1_ID i_Params_Delete_Loc_l2_By_LOC_L1_ID)
{
Params_Get_Loc_l2_By_LOC_L1_ID oParams_Get_Loc_l2_By_LOC_L1_ID = new Params_Get_Loc_l2_By_LOC_L1_ID();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l2_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l2_By_LOC_L1_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID(i_Params_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
}
public void Delete_Loc_l2_By_OWNER_ID(Params_Delete_Loc_l2_By_OWNER_ID i_Params_Delete_Loc_l2_By_OWNER_ID)
{
Params_Get_Loc_l2_By_OWNER_ID oParams_Get_Loc_l2_By_OWNER_ID = new Params_Get_Loc_l2_By_OWNER_ID();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l2_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l2_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_OWNER_ID(i_Params_Delete_Loc_l2_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_OWNER_ID");}
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE(Params_Delete_Loc_l3_By_LOC_L2_ID_CODE i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE)
{
Params_Get_Loc_l3_By_LOC_L2_ID_CODE oParams_Get_Loc_l3_By_LOC_L2_ID_CODE = new Params_Get_Loc_l3_By_LOC_L2_ID_CODE();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l3_By_LOC_L2_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
}
public void Delete_Loc_l3_By_LOC_L2_ID(Params_Delete_Loc_l3_By_LOC_L2_ID i_Params_Delete_Loc_l3_By_LOC_L2_ID)
{
Params_Get_Loc_l3_By_LOC_L2_ID oParams_Get_Loc_l3_By_LOC_L2_ID = new Params_Get_Loc_l3_By_LOC_L2_ID();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l3_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l3_By_LOC_L2_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID(i_Params_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
}
public void Delete_Loc_l3_By_OWNER_ID(Params_Delete_Loc_l3_By_OWNER_ID i_Params_Delete_Loc_l3_By_OWNER_ID)
{
Params_Get_Loc_l3_By_OWNER_ID oParams_Get_Loc_l3_By_OWNER_ID = new Params_Get_Loc_l3_By_OWNER_ID();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l3_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l3_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_OWNER_ID(i_Params_Delete_Loc_l3_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_OWNER_ID");}
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE(Params_Delete_Loc_l4_By_LOC_L3_ID_CODE i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE)
{
Params_Get_Loc_l4_By_LOC_L3_ID_CODE oParams_Get_Loc_l4_By_LOC_L3_ID_CODE = new Params_Get_Loc_l4_By_LOC_L3_ID_CODE();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l4_By_LOC_L3_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
}
public void Delete_Loc_l4_By_LOC_L3_ID(Params_Delete_Loc_l4_By_LOC_L3_ID i_Params_Delete_Loc_l4_By_LOC_L3_ID)
{
Params_Get_Loc_l4_By_LOC_L3_ID oParams_Get_Loc_l4_By_LOC_L3_ID = new Params_Get_Loc_l4_By_LOC_L3_ID();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l4_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l4_By_LOC_L3_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID(i_Params_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
}
public void Delete_Loc_l4_By_OWNER_ID(Params_Delete_Loc_l4_By_OWNER_ID i_Params_Delete_Loc_l4_By_OWNER_ID)
{
Params_Get_Loc_l4_By_OWNER_ID oParams_Get_Loc_l4_By_OWNER_ID = new Params_Get_Loc_l4_By_OWNER_ID();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l4_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l4_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_OWNER_ID(i_Params_Delete_Loc_l4_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_OWNER_ID");}
}
public void Delete_Machine_By_OWNER_ID(Params_Delete_Machine_By_OWNER_ID i_Params_Delete_Machine_By_OWNER_ID)
{
Params_Get_Machine_By_OWNER_ID oParams_Get_Machine_By_OWNER_ID = new Params_Get_Machine_By_OWNER_ID();
List<Machine> _List_Machine = new List<Machine>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Machine_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Machine_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Machine_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Machine_Execution)
{
_Stop_Delete_Machine_Execution = false;
return;
}
_AppContext.Delete_Machine_By_OWNER_ID(i_Params_Delete_Machine_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Machine_By_OWNER_ID");}
}
public void Delete_Machine_By_WORKSHOP_ID(Params_Delete_Machine_By_WORKSHOP_ID i_Params_Delete_Machine_By_WORKSHOP_ID)
{
Params_Get_Machine_By_WORKSHOP_ID oParams_Get_Machine_By_WORKSHOP_ID = new Params_Get_Machine_By_WORKSHOP_ID();
List<Machine> _List_Machine = new List<Machine>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Machine_By_WORKSHOP_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Machine_By_WORKSHOP_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Machine_By_WORKSHOP_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Machine_Execution)
{
_Stop_Delete_Machine_Execution = false;
return;
}
_AppContext.Delete_Machine_By_WORKSHOP_ID(i_Params_Delete_Machine_By_WORKSHOP_ID.WORKSHOP_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Machine_By_WORKSHOP_ID");}
}
public void Delete_Method_run_By_OWNER_ID(Params_Delete_Method_run_By_OWNER_ID i_Params_Delete_Method_run_By_OWNER_ID)
{
Params_Get_Method_run_By_OWNER_ID oParams_Get_Method_run_By_OWNER_ID = new Params_Get_Method_run_By_OWNER_ID();
List<Method_run> _List_Method_run = new List<Method_run>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Method_run_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Method_run_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Method_run_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Method_run_Execution)
{
_Stop_Delete_Method_run_Execution = false;
return;
}
_AppContext.Delete_Method_run_By_OWNER_ID(i_Params_Delete_Method_run_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Method_run_By_OWNER_ID");}
}
public void Delete_Person_By_OWNER_ID(Params_Delete_Person_By_OWNER_ID i_Params_Delete_Person_By_OWNER_ID)
{
Params_Get_Person_By_OWNER_ID oParams_Get_Person_By_OWNER_ID = new Params_Get_Person_By_OWNER_ID();
List<Person> _List_Person = new List<Person>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Person_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Person_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person_By_OWNER_ID(i_Params_Delete_Person_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_By_OWNER_ID");}
}
public void Delete_Productdistribution_By_OWNER_ID(Params_Delete_Productdistribution_By_OWNER_ID i_Params_Delete_Productdistribution_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Productdistribution_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Productdistribution_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Productdistribution_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Productdistribution_Execution)
{
_Stop_Delete_Productdistribution_Execution = false;
return;
}
_AppContext.Delete_Productdistribution_By_OWNER_ID(i_Params_Delete_Productdistribution_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Productdistribution_By_OWNER_ID");}
}
public void Delete_Productdistribution_By_STAFF_ID(Params_Delete_Productdistribution_By_STAFF_ID i_Params_Delete_Productdistribution_By_STAFF_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Productdistribution_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Productdistribution_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Productdistribution_By_STAFF_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Productdistribution_Execution)
{
_Stop_Delete_Productdistribution_Execution = false;
return;
}
_AppContext.Delete_Productdistribution_By_STAFF_ID(i_Params_Delete_Productdistribution_By_STAFF_ID.STAFF_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Productdistribution_By_STAFF_ID");}
}
public void Delete_Productdistribution_By_SUPPLIER_ID(Params_Delete_Productdistribution_By_SUPPLIER_ID i_Params_Delete_Productdistribution_By_SUPPLIER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Productdistribution_By_SUPPLIER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Productdistribution_By_SUPPLIER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Productdistribution_By_SUPPLIER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Productdistribution_Execution)
{
_Stop_Delete_Productdistribution_Execution = false;
return;
}
_AppContext.Delete_Productdistribution_By_SUPPLIER_ID(i_Params_Delete_Productdistribution_By_SUPPLIER_ID.SUPPLIER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Productdistribution_By_SUPPLIER_ID");}
}
public void Delete_Productdistribution_By_COUPONS_ID(Params_Delete_Productdistribution_By_COUPONS_ID i_Params_Delete_Productdistribution_By_COUPONS_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Productdistribution_By_COUPONS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Productdistribution_By_COUPONS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Productdistribution_By_COUPONS_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Productdistribution_Execution)
{
_Stop_Delete_Productdistribution_Execution = false;
return;
}
_AppContext.Delete_Productdistribution_By_COUPONS_ID(i_Params_Delete_Productdistribution_By_COUPONS_ID.COUPONS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Productdistribution_By_COUPONS_ID");}
}
public void Delete_Salary_By_OWNER_ID(Params_Delete_Salary_By_OWNER_ID i_Params_Delete_Salary_By_OWNER_ID)
{
Params_Get_Salary_By_OWNER_ID oParams_Get_Salary_By_OWNER_ID = new Params_Get_Salary_By_OWNER_ID();
List<Salary> _List_Salary = new List<Salary>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Salary_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Salary_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Salary_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Salary_Execution)
{
_Stop_Delete_Salary_Execution = false;
return;
}
_AppContext.Delete_Salary_By_OWNER_ID(i_Params_Delete_Salary_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Salary_By_OWNER_ID");}
}
public void Delete_Salary_By_STAFF_ID(Params_Delete_Salary_By_STAFF_ID i_Params_Delete_Salary_By_STAFF_ID)
{
Params_Get_Salary_By_STAFF_ID oParams_Get_Salary_By_STAFF_ID = new Params_Get_Salary_By_STAFF_ID();
List<Salary> _List_Salary = new List<Salary>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Salary_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Salary_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Salary_By_STAFF_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Salary_Execution)
{
_Stop_Delete_Salary_Execution = false;
return;
}
_AppContext.Delete_Salary_By_STAFF_ID(i_Params_Delete_Salary_By_STAFF_ID.STAFF_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Salary_By_STAFF_ID");}
}
public void Delete_Salary_By_CURRENCY_ID(Params_Delete_Salary_By_CURRENCY_ID i_Params_Delete_Salary_By_CURRENCY_ID)
{
Params_Get_Salary_By_CURRENCY_ID oParams_Get_Salary_By_CURRENCY_ID = new Params_Get_Salary_By_CURRENCY_ID();
List<Salary> _List_Salary = new List<Salary>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Salary_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Salary_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Salary_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Salary_Execution)
{
_Stop_Delete_Salary_Execution = false;
return;
}
_AppContext.Delete_Salary_By_CURRENCY_ID(i_Params_Delete_Salary_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Salary_By_CURRENCY_ID");}
}
public void Delete_Staff_By_OWNER_ID(Params_Delete_Staff_By_OWNER_ID i_Params_Delete_Staff_By_OWNER_ID)
{
Params_Get_Staff_By_OWNER_ID oParams_Get_Staff_By_OWNER_ID = new Params_Get_Staff_By_OWNER_ID();
List<Staff> _List_Staff = new List<Staff>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_Execution)
{
_Stop_Delete_Staff_Execution = false;
return;
}
_AppContext.Delete_Staff_By_OWNER_ID(i_Params_Delete_Staff_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_By_OWNER_ID");}
}
public void Delete_Staff_By_WORKSHOP_ID(Params_Delete_Staff_By_WORKSHOP_ID i_Params_Delete_Staff_By_WORKSHOP_ID)
{
Params_Get_Staff_By_WORKSHOP_ID oParams_Get_Staff_By_WORKSHOP_ID = new Params_Get_Staff_By_WORKSHOP_ID();
List<Staff> _List_Staff = new List<Staff>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_By_WORKSHOP_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff_By_WORKSHOP_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff_By_WORKSHOP_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_Execution)
{
_Stop_Delete_Staff_Execution = false;
return;
}
_AppContext.Delete_Staff_By_WORKSHOP_ID(i_Params_Delete_Staff_By_WORKSHOP_ID.WORKSHOP_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_By_WORKSHOP_ID");}
}
public void Delete_Staff_By_CURRENCY_ID(Params_Delete_Staff_By_CURRENCY_ID i_Params_Delete_Staff_By_CURRENCY_ID)
{
Params_Get_Staff_By_CURRENCY_ID oParams_Get_Staff_By_CURRENCY_ID = new Params_Get_Staff_By_CURRENCY_ID();
List<Staff> _List_Staff = new List<Staff>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_Execution)
{
_Stop_Delete_Staff_Execution = false;
return;
}
_AppContext.Delete_Staff_By_CURRENCY_ID(i_Params_Delete_Staff_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_By_CURRENCY_ID");}
}
public void Delete_Stock_By_OWNER_ID(Params_Delete_Stock_By_OWNER_ID i_Params_Delete_Stock_By_OWNER_ID)
{
Params_Get_Stock_By_OWNER_ID oParams_Get_Stock_By_OWNER_ID = new Params_Get_Stock_By_OWNER_ID();
List<Stock> _List_Stock = new List<Stock>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Stock_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Stock_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Stock_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Stock_Execution)
{
_Stop_Delete_Stock_Execution = false;
return;
}
_AppContext.Delete_Stock_By_OWNER_ID(i_Params_Delete_Stock_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Stock_By_OWNER_ID");}
}
public void Delete_Supplier_By_OWNER_ID(Params_Delete_Supplier_By_OWNER_ID i_Params_Delete_Supplier_By_OWNER_ID)
{
Params_Get_Supplier_By_OWNER_ID oParams_Get_Supplier_By_OWNER_ID = new Params_Get_Supplier_By_OWNER_ID();
List<Supplier> _List_Supplier = new List<Supplier>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_Execution)
{
_Stop_Delete_Supplier_Execution = false;
return;
}
_AppContext.Delete_Supplier_By_OWNER_ID(i_Params_Delete_Supplier_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_By_OWNER_ID");}
}
public void Delete_Supplier_By_COUPONS_ID(Params_Delete_Supplier_By_COUPONS_ID i_Params_Delete_Supplier_By_COUPONS_ID)
{
Params_Get_Supplier_By_COUPONS_ID oParams_Get_Supplier_By_COUPONS_ID = new Params_Get_Supplier_By_COUPONS_ID();
List<Supplier> _List_Supplier = new List<Supplier>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_By_COUPONS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_By_COUPONS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_By_COUPONS_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_Execution)
{
_Stop_Delete_Supplier_Execution = false;
return;
}
_AppContext.Delete_Supplier_By_COUPONS_ID(i_Params_Delete_Supplier_By_COUPONS_ID.COUPONS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_By_COUPONS_ID");}
}
public void Delete_Supplier_By_CURRENCY_ID(Params_Delete_Supplier_By_CURRENCY_ID i_Params_Delete_Supplier_By_CURRENCY_ID)
{
Params_Get_Supplier_By_CURRENCY_ID oParams_Get_Supplier_By_CURRENCY_ID = new Params_Get_Supplier_By_CURRENCY_ID();
List<Supplier> _List_Supplier = new List<Supplier>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_Execution)
{
_Stop_Delete_Supplier_Execution = false;
return;
}
_AppContext.Delete_Supplier_By_CURRENCY_ID(i_Params_Delete_Supplier_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_By_CURRENCY_ID");}
}
public void Delete_Supplier_By_STOCK_ID(Params_Delete_Supplier_By_STOCK_ID i_Params_Delete_Supplier_By_STOCK_ID)
{
Params_Get_Supplier_By_STOCK_ID oParams_Get_Supplier_By_STOCK_ID = new Params_Get_Supplier_By_STOCK_ID();
List<Supplier> _List_Supplier = new List<Supplier>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_By_STOCK_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_By_STOCK_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_By_STOCK_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_Execution)
{
_Stop_Delete_Supplier_Execution = false;
return;
}
_AppContext.Delete_Supplier_By_STOCK_ID(i_Params_Delete_Supplier_By_STOCK_ID.STOCK_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_By_STOCK_ID");}
}
public void Delete_Transaction_By_OWNER_ID(Params_Delete_Transaction_By_OWNER_ID i_Params_Delete_Transaction_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Transaction_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Transaction_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Transaction_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Transaction_Execution)
{
_Stop_Delete_Transaction_Execution = false;
return;
}
_AppContext.Delete_Transaction_By_OWNER_ID(i_Params_Delete_Transaction_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Transaction_By_OWNER_ID");}
}
public void Delete_Transaction_By_CURRENCY_ID(Params_Delete_Transaction_By_CURRENCY_ID i_Params_Delete_Transaction_By_CURRENCY_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Transaction_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Transaction_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Transaction_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Transaction_Execution)
{
_Stop_Delete_Transaction_Execution = false;
return;
}
_AppContext.Delete_Transaction_By_CURRENCY_ID(i_Params_Delete_Transaction_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Transaction_By_CURRENCY_ID");}
}
public void Delete_Transaction_By_STAFF_ID(Params_Delete_Transaction_By_STAFF_ID i_Params_Delete_Transaction_By_STAFF_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Transaction_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Transaction_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Transaction_By_STAFF_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Transaction_Execution)
{
_Stop_Delete_Transaction_Execution = false;
return;
}
_AppContext.Delete_Transaction_By_STAFF_ID(i_Params_Delete_Transaction_By_STAFF_ID.STAFF_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Transaction_By_STAFF_ID");}
}
public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
{
Params_Get_User_By_OWNER_ID oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_User_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_User_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_OWNER_ID");}
}
public void Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
Params_Get_User_By_USERNAME oParams_Get_User_By_USERNAME = new Params_Get_User_By_USERNAME();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USERNAME");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_User_By_USERNAME",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_User_By_USERNAME));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USERNAME");}
}
public void Delete_Workshop_By_OWNER_ID(Params_Delete_Workshop_By_OWNER_ID i_Params_Delete_Workshop_By_OWNER_ID)
{
Params_Get_Workshop_By_OWNER_ID oParams_Get_Workshop_By_OWNER_ID = new Params_Get_Workshop_By_OWNER_ID();
List<Workshop> _List_Workshop = new List<Workshop>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshop_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshop_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshop_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshop_Execution)
{
_Stop_Delete_Workshop_Execution = false;
return;
}
_AppContext.Delete_Workshop_By_OWNER_ID(i_Params_Delete_Workshop_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshop_By_OWNER_ID");}
}
public void Delete_Workshop_By_CURRENCY_ID(Params_Delete_Workshop_By_CURRENCY_ID i_Params_Delete_Workshop_By_CURRENCY_ID)
{
Params_Get_Workshop_By_CURRENCY_ID oParams_Get_Workshop_By_CURRENCY_ID = new Params_Get_Workshop_By_CURRENCY_ID();
List<Workshop> _List_Workshop = new List<Workshop>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshop_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshop_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshop_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshop_Execution)
{
_Stop_Delete_Workshop_Execution = false;
return;
}
_AppContext.Delete_Workshop_By_CURRENCY_ID(i_Params_Delete_Workshop_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshop_By_CURRENCY_ID");}
}
public void Delete_Workshop_By_STOCK_ID(Params_Delete_Workshop_By_STOCK_ID i_Params_Delete_Workshop_By_STOCK_ID)
{
Params_Get_Workshop_By_STOCK_ID oParams_Get_Workshop_By_STOCK_ID = new Params_Get_Workshop_By_STOCK_ID();
List<Workshop> _List_Workshop = new List<Workshop>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshop_By_STOCK_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshop_By_STOCK_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshop_By_STOCK_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshop_Execution)
{
_Stop_Delete_Workshop_Execution = false;
return;
}
_AppContext.Delete_Workshop_By_STOCK_ID(i_Params_Delete_Workshop_By_STOCK_ID.STOCK_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshop_By_STOCK_ID");}
}
public void Delete_Workshop_By_MACHINE_ID(Params_Delete_Workshop_By_MACHINE_ID i_Params_Delete_Workshop_By_MACHINE_ID)
{
Params_Get_Workshop_By_MACHINE_ID oParams_Get_Workshop_By_MACHINE_ID = new Params_Get_Workshop_By_MACHINE_ID();
List<Workshop> _List_Workshop = new List<Workshop>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshop_By_MACHINE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshop_By_MACHINE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshop_By_MACHINE_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshop_Execution)
{
_Stop_Delete_Workshop_Execution = false;
return;
}
_AppContext.Delete_Workshop_By_MACHINE_ID(i_Params_Delete_Workshop_By_MACHINE_ID.MACHINE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshop_By_MACHINE_ID");}
}
public void Delete_Workshops_By_OWNER_ID(Params_Delete_Workshops_By_OWNER_ID i_Params_Delete_Workshops_By_OWNER_ID)
{
Params_Get_Workshops_By_OWNER_ID oParams_Get_Workshops_By_OWNER_ID = new Params_Get_Workshops_By_OWNER_ID();
List<Workshops> _List_Workshops = new List<Workshops>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshops_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshops_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshops_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshops_Execution)
{
_Stop_Delete_Workshops_Execution = false;
return;
}
_AppContext.Delete_Workshops_By_OWNER_ID(i_Params_Delete_Workshops_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshops_By_OWNER_ID");}
}
public void Delete_Workshops_By_CURRENCY_ID(Params_Delete_Workshops_By_CURRENCY_ID i_Params_Delete_Workshops_By_CURRENCY_ID)
{
Params_Get_Workshops_By_CURRENCY_ID oParams_Get_Workshops_By_CURRENCY_ID = new Params_Get_Workshops_By_CURRENCY_ID();
List<Workshops> _List_Workshops = new List<Workshops>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshops_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshops_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshops_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshops_Execution)
{
_Stop_Delete_Workshops_Execution = false;
return;
}
_AppContext.Delete_Workshops_By_CURRENCY_ID(i_Params_Delete_Workshops_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshops_By_CURRENCY_ID");}
}
public void Delete_Workshops_By_STOCK_ID(Params_Delete_Workshops_By_STOCK_ID i_Params_Delete_Workshops_By_STOCK_ID)
{
Params_Get_Workshops_By_STOCK_ID oParams_Get_Workshops_By_STOCK_ID = new Params_Get_Workshops_By_STOCK_ID();
List<Workshops> _List_Workshops = new List<Workshops>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshops_By_STOCK_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshops_By_STOCK_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshops_By_STOCK_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshops_Execution)
{
_Stop_Delete_Workshops_Execution = false;
return;
}
_AppContext.Delete_Workshops_By_STOCK_ID(i_Params_Delete_Workshops_By_STOCK_ID.STOCK_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshops_By_STOCK_ID");}
}
public void Delete_Workshops_By_MACHINE_ID(Params_Delete_Workshops_By_MACHINE_ID i_Params_Delete_Workshops_By_MACHINE_ID)
{
Params_Get_Workshops_By_MACHINE_ID oParams_Get_Workshops_By_MACHINE_ID = new Params_Get_Workshops_By_MACHINE_ID();
List<Workshops> _List_Workshops = new List<Workshops>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Workshops_By_MACHINE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Workshops_By_MACHINE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Workshops_By_MACHINE_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Workshops_Execution)
{
_Stop_Delete_Workshops_Execution = false;
return;
}
_AppContext.Delete_Workshops_By_MACHINE_ID(i_Params_Delete_Workshops_By_MACHINE_ID.MACHINE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Workshops_By_MACHINE_ID");}
}
public void Edit_Address(Address i_Address) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Address.ADDRESS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Address",Newtonsoft.Json.JsonConvert.SerializeObject(i_Address));}
#region Body Section.
if ((i_Address.ADDRESS_ID == null) || (i_Address.ADDRESS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Address"); }
i_Address.ENTRY_USER_ID = this.UserID;
i_Address.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Address.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Address_Execution)
{
_Stop_Edit_Address_Execution = false;
return;
}
i_Address.ADDRESS_ID = _AppContext.Edit_Address
(
i_Address.ADDRESS_ID
,i_Address.PERSON_ID
,i_Address.ADDRESS_TYPE_CODE
,i_Address.LOC_L1_ID
,i_Address.LOC_L2_ID
,i_Address.LOC_L3_ID
,i_Address.LOC_L4_ID
,i_Address.STREET
,i_Address.BUILDING
,i_Address.FLOOR
,i_Address.POBOX
,i_Address.VALID_DATE_START
,i_Address.VALID_DATE_END
,i_Address.NOTES
,i_Address.ENTRY_DATE
,i_Address.ENTRY_USER_ID
,i_Address.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address");}
}
public void Edit_Contact(Contact i_Contact) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Contact.CONTACT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Contact",Newtonsoft.Json.JsonConvert.SerializeObject(i_Contact));}
#region Body Section.
if ((i_Contact.CONTACT_ID == null) || (i_Contact.CONTACT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Contact"); }
i_Contact.ENTRY_USER_ID = this.UserID;
i_Contact.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Contact.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Contact_Execution)
{
_Stop_Edit_Contact_Execution = false;
return;
}
i_Contact.CONTACT_ID = _AppContext.Edit_Contact
(
i_Contact.CONTACT_ID
,i_Contact.PERSON_ID
,i_Contact.CONTACT_TYPE_CODE
,i_Contact.CONTACT
,i_Contact.DESCRIPTION
,i_Contact.ENTRY_USER_ID
,i_Contact.ENTRY_DATE
,i_Contact.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact");}
}
public void Edit_Conversions(Conversions i_Conversions) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Conversions.CONVERSIONS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Conversions");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Conversions",Newtonsoft.Json.JsonConvert.SerializeObject(i_Conversions));}
#region Body Section.
if ((i_Conversions.CONVERSIONS_ID == null) || (i_Conversions.CONVERSIONS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Conversions"); }
i_Conversions.ENTRY_USER_ID = this.UserID;
i_Conversions.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Conversions.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Conversions_Execution)
{
_Stop_Edit_Conversions_Execution = false;
return;
}
i_Conversions.CONVERSIONS_ID = _AppContext.Edit_Conversions
(
i_Conversions.CONVERSIONS_ID
,i_Conversions.CONVERSIONS_FROM
,i_Conversions.CONVERSIONS_FOR
,i_Conversions.CONVERSIONS_DATE
,i_Conversions.CURRENCY_ID
,i_Conversions.CONVERSIONS_DESCRIPTION
,i_Conversions.ENTRY_USER_ID
,i_Conversions.ENTRY_DATE
,i_Conversions.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Conversions");}
}
public void Edit_Coupons(Coupons i_Coupons) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Coupons.COUPONS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coupons");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Coupons",Newtonsoft.Json.JsonConvert.SerializeObject(i_Coupons));}
#region Body Section.
if ((i_Coupons.COUPONS_ID == null) || (i_Coupons.COUPONS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Coupons"); }
i_Coupons.ENTRY_USER_ID = this.UserID;
i_Coupons.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Coupons.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Coupons_Execution)
{
_Stop_Edit_Coupons_Execution = false;
return;
}
i_Coupons.COUPONS_ID = _AppContext.Edit_Coupons
(
i_Coupons.COUPONS_ID
,i_Coupons.COUPONS_TYPE
,i_Coupons.COUPONS_DESCRIPTION
,i_Coupons.COUPONS_QUANTITY
,i_Coupons.COUPONS_STORE
,i_Coupons.COUPONS_DATE
,i_Coupons.CURRENCY_ID
,i_Coupons.COUPONS_PAYMENT_WAITED
,i_Coupons.COUPONS_PAYMENT_DELIVERED
,i_Coupons.COUPONS_FOR
,i_Coupons.COUPONS_NOTE
,i_Coupons.COUPONS_ITEM_TYPE
,i_Coupons.COUPONS_ITEM_QUANTITY
,i_Coupons.COUPONS_MACHINE
,i_Coupons.ENTRY_USER_ID
,i_Coupons.ENTRY_DATE
,i_Coupons.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coupons");}
}
public void Edit_Currency(Currency i_Currency) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Currency.CURRENCY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Currency",Newtonsoft.Json.JsonConvert.SerializeObject(i_Currency));}
#region Body Section.
if ((i_Currency.CURRENCY_ID == null) || (i_Currency.CURRENCY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Currency"); }
i_Currency.ENTRY_USER_ID = this.UserID;
i_Currency.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Currency.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Currency_Execution)
{
_Stop_Edit_Currency_Execution = false;
return;
}
i_Currency.CURRENCY_ID = _AppContext.Edit_Currency
(
i_Currency.CURRENCY_ID
,i_Currency.CURRENCY_TYPE
,i_Currency.CURRENCY_SYMBOL
,i_Currency.ENTRY_USER_ID
,i_Currency.ENTRY_DATE
,i_Currency.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency");}
}
public void Edit_Fees(Fees i_Fees) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Fees.FEES_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Fees));}
#region Body Section.
if ((i_Fees.FEES_ID == null) || (i_Fees.FEES_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Fees"); }
i_Fees.ENTRY_USER_ID = this.UserID;
i_Fees.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Fees.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Fees_Execution)
{
_Stop_Edit_Fees_Execution = false;
return;
}
i_Fees.FEES_ID = _AppContext.Edit_Fees
(
i_Fees.FEES_ID
,i_Fees.FEES_DATE
,i_Fees.FEES_DESCRIPTION
,i_Fees.CURRENCY_ID
,i_Fees.WORKSHOP_PAYMENT
,i_Fees.WORKSHOP_PAYMENT_DESCRIPTION
,i_Fees.FEES_STATUS
,i_Fees.FEES_PAYMENT_GATEWAY
,i_Fees.FEES_VALUE_DOLLAR
,i_Fees.FEES_FUEL
,i_Fees.FEES_STORE
,i_Fees.FEES_TOTAL_DOLLAR
,i_Fees.FEES_TOTAL_LBP
,i_Fees.FEES_TYPE
,i_Fees.FEES_DOLLAR_RATE
,i_Fees.ENTRY_USER_ID
,i_Fees.ENTRY_DATE
,i_Fees.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Fees");}
}
public void Edit_Industry(Industry i_Industry) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Industry.INDUSTRY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Industry");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Industry",Newtonsoft.Json.JsonConvert.SerializeObject(i_Industry));}
#region Body Section.
if ((i_Industry.INDUSTRY_ID == null) || (i_Industry.INDUSTRY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Industry"); }
i_Industry.ENTRY_USER_ID = this.UserID;
i_Industry.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Industry.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Industry_Execution)
{
_Stop_Edit_Industry_Execution = false;
return;
}
i_Industry.INDUSTRY_ID = _AppContext.Edit_Industry
(
i_Industry.INDUSTRY_ID
,i_Industry.INDUSTRY_PRODUCT_NAME
,i_Industry.INDUSTRY_PRODUCT_QUANTITY
,i_Industry.INDUSTRY_PRODUCT_DATE
,i_Industry.COUPONS_ID
,i_Industry.STOCK_ID
,i_Industry.ENTRY_USER_ID
,i_Industry.ENTRY_DATE
,i_Industry.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Industry");}
}
public void Edit_Loc_l1(Loc_l1 i_Loc_l1) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l1.LOC_L1_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Loc_l1",Newtonsoft.Json.JsonConvert.SerializeObject(i_Loc_l1));}
#region Body Section.
if ((i_Loc_l1.LOC_L1_ID == null) || (i_Loc_l1.LOC_L1_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l1"); }
i_Loc_l1.ENTRY_USER_ID = this.UserID;
i_Loc_l1.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l1.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l1_Execution)
{
_Stop_Edit_Loc_l1_Execution = false;
return;
}
i_Loc_l1.LOC_L1_ID = _AppContext.Edit_Loc_l1
(
i_Loc_l1.LOC_L1_ID
,i_Loc_l1.CODE
,i_Loc_l1.DESCRIPTION
,i_Loc_l1.NOTES
,i_Loc_l1.ENTRY_DATE
,i_Loc_l1.ENTRY_USER_ID
,i_Loc_l1.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1");}
}
public void Edit_Loc_l2(Loc_l2 i_Loc_l2) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l2.LOC_L2_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Loc_l2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Loc_l2));}
#region Body Section.
if ((i_Loc_l2.LOC_L2_ID == null) || (i_Loc_l2.LOC_L2_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l2"); }
i_Loc_l2.ENTRY_USER_ID = this.UserID;
i_Loc_l2.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l2.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l2_Execution)
{
_Stop_Edit_Loc_l2_Execution = false;
return;
}
i_Loc_l2.LOC_L2_ID = _AppContext.Edit_Loc_l2
(
i_Loc_l2.LOC_L2_ID
,i_Loc_l2.CODE
,i_Loc_l2.DESCRIPTION
,i_Loc_l2.LOC_L1_ID
,i_Loc_l2.NOTES
,i_Loc_l2.ENTRY_DATE
,i_Loc_l2.ENTRY_USER_ID
,i_Loc_l2.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2");}
}
public void Edit_Loc_l3(Loc_l3 i_Loc_l3) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l3.LOC_L3_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Loc_l3",Newtonsoft.Json.JsonConvert.SerializeObject(i_Loc_l3));}
#region Body Section.
if ((i_Loc_l3.LOC_L3_ID == null) || (i_Loc_l3.LOC_L3_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l3"); }
i_Loc_l3.ENTRY_USER_ID = this.UserID;
i_Loc_l3.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l3.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l3_Execution)
{
_Stop_Edit_Loc_l3_Execution = false;
return;
}
i_Loc_l3.LOC_L3_ID = _AppContext.Edit_Loc_l3
(
i_Loc_l3.LOC_L3_ID
,i_Loc_l3.CODE
,i_Loc_l3.DESCRIPTION
,i_Loc_l3.LOC_L2_ID
,i_Loc_l3.NOTES
,i_Loc_l3.ENTRY_DATE
,i_Loc_l3.ENTRY_USER_ID
,i_Loc_l3.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3");}
}
public void Edit_Loc_l4(Loc_l4 i_Loc_l4) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l4.LOC_L4_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Loc_l4",Newtonsoft.Json.JsonConvert.SerializeObject(i_Loc_l4));}
#region Body Section.
if ((i_Loc_l4.LOC_L4_ID == null) || (i_Loc_l4.LOC_L4_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l4"); }
i_Loc_l4.ENTRY_USER_ID = this.UserID;
i_Loc_l4.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l4.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l4_Execution)
{
_Stop_Edit_Loc_l4_Execution = false;
return;
}
i_Loc_l4.LOC_L4_ID = _AppContext.Edit_Loc_l4
(
i_Loc_l4.LOC_L4_ID
,i_Loc_l4.CODE
,i_Loc_l4.DESCRIPTION
,i_Loc_l4.LOC_L3_ID
,i_Loc_l4.NOTES
,i_Loc_l4.ENTRY_DATE
,i_Loc_l4.ENTRY_USER_ID
,i_Loc_l4.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4");}
}
public void Edit_Machine(Machine i_Machine) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Machine.MACHINE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Machine");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Machine",Newtonsoft.Json.JsonConvert.SerializeObject(i_Machine));}
#region Body Section.
if ((i_Machine.MACHINE_ID == null) || (i_Machine.MACHINE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Machine"); }
i_Machine.ENTRY_USER_ID = this.UserID;
i_Machine.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Machine.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Machine_Execution)
{
_Stop_Edit_Machine_Execution = false;
return;
}
i_Machine.MACHINE_ID = _AppContext.Edit_Machine
(
i_Machine.MACHINE_ID
,i_Machine.MACHINE_DATE
,i_Machine.MACHINE_DESCRIPTION
,i_Machine.MACHINE_HOURS
,i_Machine.WORKSHOP_ID
,i_Machine.MACHINE_NOTES
,i_Machine.ENTRY_USER_ID
,i_Machine.ENTRY_DATE
,i_Machine.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Machine");}
}
public void Edit_Method_run(Method_run i_Method_run) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Method_run.METHOD_RUN_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
#region Body Section.
if ((i_Method_run.METHOD_RUN_ID == null) || (i_Method_run.METHOD_RUN_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Method_run"); }
i_Method_run.ENTRY_USER_ID = this.UserID;
i_Method_run.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Method_run.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Method_run_Execution)
{
_Stop_Edit_Method_run_Execution = false;
return;
}
i_Method_run.METHOD_RUN_ID = _AppContext.Edit_Method_run
(
i_Method_run.METHOD_RUN_ID
,i_Method_run.METHOD_NAME
,i_Method_run.RUN_DATE
,i_Method_run.RUN_HOUR
,i_Method_run.RUN_MINUTE
,i_Method_run.RUN_SECOND
,i_Method_run.IS_CACHED
,i_Method_run.EXECUTION_TIME
,i_Method_run.INPUT_PARAM
,i_Method_run.ENTRY_USER_ID
,i_Method_run.ENTRY_DATE
,i_Method_run.OWNER_ID
);
oScope.Complete();
}
#endregion
}
public void Edit_Owner(Owner i_Owner) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Owner.OWNER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Owner",Newtonsoft.Json.JsonConvert.SerializeObject(i_Owner));}
#region Body Section.
if ((i_Owner.OWNER_ID == null) || (i_Owner.OWNER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Owner"); }
i_Owner.ENTRY_DATE    = oTools.GetDateTimeString(DateTime.Now);
i_Owner.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Owner_Execution)
{
_Stop_Edit_Owner_Execution = false;
return;
}
i_Owner.OWNER_ID = _AppContext.Edit_Owner
(
i_Owner.OWNER_ID
,i_Owner.CODE
,i_Owner.MAINTENANCE_DUE_DATE
,i_Owner.DESCRIPTION
,i_Owner.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner");}
}
public void Edit_Person(Person i_Person) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Person.PERSON_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Person",Newtonsoft.Json.JsonConvert.SerializeObject(i_Person));}
#region Body Section.
if ((i_Person.PERSON_ID == null) || (i_Person.PERSON_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Person"); }
i_Person.ENTRY_USER_ID = this.UserID;
i_Person.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Person.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Person_Execution)
{
_Stop_Edit_Person_Execution = false;
return;
}
i_Person.PERSON_ID = _AppContext.Edit_Person
(
i_Person.PERSON_ID
,i_Person.FIRST_NAME
,i_Person.LAST_NAME
,i_Person.FATHER_NAME
,i_Person.MOTHER_NAME
,i_Person.TITLE_CODE
,i_Person.GENDER_CODE
,i_Person.RELIGION_CODE
,i_Person.BIRTH_DATE
,i_Person.IS_BLOCKED
,i_Person.DESCRIPTION
,i_Person.OWNER_ID
,i_Person.ENTRY_USER_ID
,i_Person.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person");}
}
public void Edit_Productdistribution(Productdistribution i_Productdistribution) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Productdistribution.PRODUCTDISTRIBUTION_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Productdistribution");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Productdistribution",Newtonsoft.Json.JsonConvert.SerializeObject(i_Productdistribution));}
#region Body Section.
if ((i_Productdistribution.PRODUCTDISTRIBUTION_ID == null) || (i_Productdistribution.PRODUCTDISTRIBUTION_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Productdistribution"); }
i_Productdistribution.ENTRY_USER_ID = this.UserID;
i_Productdistribution.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Productdistribution.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Productdistribution_Execution)
{
_Stop_Edit_Productdistribution_Execution = false;
return;
}
i_Productdistribution.PRODUCTDISTRIBUTION_ID = _AppContext.Edit_Productdistribution
(
i_Productdistribution.PRODUCTDISTRIBUTION_ID
,i_Productdistribution.PRODUCTDISTRIBUTION_TYPE
,i_Productdistribution.PRODUCTDISTRIBUTION_QTY
,i_Productdistribution.PRODUCTDISTRIBUTION_DATE
,i_Productdistribution.STAFF_ID
,i_Productdistribution.SUPPLIER_ID
,i_Productdistribution.COUPONS_ID
,i_Productdistribution.ENTRY_USER_ID
,i_Productdistribution.ENTRY_DATE
,i_Productdistribution.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Productdistribution");}
}
public void Edit_Salary(Salary i_Salary) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Salary.SALARY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Salary");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Salary",Newtonsoft.Json.JsonConvert.SerializeObject(i_Salary));}
#region Body Section.
if ((i_Salary.SALARY_ID == null) || (i_Salary.SALARY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Salary"); }
i_Salary.ENTRY_USER_ID = this.UserID;
i_Salary.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Salary.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Salary_Execution)
{
_Stop_Edit_Salary_Execution = false;
return;
}
i_Salary.SALARY_ID = _AppContext.Edit_Salary
(
i_Salary.SALARY_ID
,i_Salary.STAFF_ID
,i_Salary.SALARY_DATE
,i_Salary.SALARY_PAYMENT_VALUE
,i_Salary.CURRENCY_ID
,i_Salary.ENTRY_USER_ID
,i_Salary.ENTRY_DATE
,i_Salary.OWNER_ID
,i_Salary.DESCRIPTION
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Salary");}
}
public void Edit_Staff(Staff i_Staff) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Staff.STAFF_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Staff",Newtonsoft.Json.JsonConvert.SerializeObject(i_Staff));}
#region Body Section.
if ((i_Staff.STAFF_ID == null) || (i_Staff.STAFF_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Staff"); }
i_Staff.ENTRY_USER_ID = this.UserID;
i_Staff.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Staff.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Staff_Execution)
{
_Stop_Edit_Staff_Execution = false;
return;
}
i_Staff.STAFF_ID = _AppContext.Edit_Staff
(
i_Staff.STAFF_ID
,i_Staff.STAFF_NAME
,i_Staff.STAFF_PAYMENT
,i_Staff.STAFF_PAYMENT_DESCRIPTION
,i_Staff.WORKSHOP_ID
,i_Staff.CURRENCY_ID
,i_Staff.ENTRY_USER_ID
,i_Staff.ENTRY_DATE
,i_Staff.OWNER_ID
,i_Staff.STAFF_IS_ACTIVE
,i_Staff.STAFF_WORKING_DAYS
,i_Staff.STAFF_EXTRA_HOURS
,i_Staff.STAFF_LOAN
,i_Staff.STAFF_REFERENCE
,i_Staff.STAFF_EXCHANGE_RATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff");}
}
public void Edit_Stock(Stock i_Stock) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Stock.STOCK_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Stock");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Stock",Newtonsoft.Json.JsonConvert.SerializeObject(i_Stock));}
#region Body Section.
if ((i_Stock.STOCK_ID == null) || (i_Stock.STOCK_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Stock"); }
i_Stock.ENTRY_USER_ID = this.UserID;
i_Stock.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Stock.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Stock_Execution)
{
_Stop_Edit_Stock_Execution = false;
return;
}
i_Stock.STOCK_ID = _AppContext.Edit_Stock
(
i_Stock.STOCK_ID
,i_Stock.STOCK_DESCRIPTION
,i_Stock.STOCK_CATEGORY
,i_Stock.STOCK_SCALE
,i_Stock.STOCK_QUANTITY
,i_Stock.STOCK_MAIN_PERSON
,i_Stock.STOCK_NOTE
,i_Stock.STOCK_PRICE
,i_Stock.ENTRY_USER_ID
,i_Stock.ENTRY_DATE
,i_Stock.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Stock");}
}
public void Edit_Supplier(Supplier i_Supplier) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Supplier.SUPPLIER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Supplier",Newtonsoft.Json.JsonConvert.SerializeObject(i_Supplier));}
#region Body Section.
if ((i_Supplier.SUPPLIER_ID == null) || (i_Supplier.SUPPLIER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Supplier"); }
i_Supplier.ENTRY_USER_ID = this.UserID;
i_Supplier.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Supplier.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Supplier_Execution)
{
_Stop_Edit_Supplier_Execution = false;
return;
}
i_Supplier.SUPPLIER_ID = _AppContext.Edit_Supplier
(
i_Supplier.SUPPLIER_ID
,i_Supplier.COUPONS_ID
,i_Supplier.SUPPLIER_PAYMENT_COST
,i_Supplier.SUPPLIER_PAYMENT_DATE
,i_Supplier.CURRENCY_ID
,i_Supplier.SUPPLIER_PAYMENT_CAUSE
,i_Supplier.STOCK_ID
,i_Supplier.ENTRY_USER_ID
,i_Supplier.ENTRY_DATE
,i_Supplier.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier");}
}
public void Edit_Transaction(Transaction i_Transaction) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Transaction.TRANSACTION_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Transaction");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Transaction",Newtonsoft.Json.JsonConvert.SerializeObject(i_Transaction));}
#region Body Section.
if ((i_Transaction.TRANSACTION_ID == null) || (i_Transaction.TRANSACTION_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Transaction"); }
i_Transaction.ENTRY_USER_ID = this.UserID;
i_Transaction.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Transaction.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Transaction_Execution)
{
_Stop_Edit_Transaction_Execution = false;
return;
}
i_Transaction.TRANSACTION_ID = _AppContext.Edit_Transaction
(
i_Transaction.TRANSACTION_ID
,i_Transaction.TRANSACTION_AMOUNT
,i_Transaction.TRANSACTION_FROM
,i_Transaction.TRANSACTION_TO
,i_Transaction.TRANSACTION_DATE
,i_Transaction.CURRENCY_ID
,i_Transaction.TRANSACTION_NOTES
,i_Transaction.STAFF_ID
,i_Transaction.ENTRY_USER_ID
,i_Transaction.ENTRY_DATE
,i_Transaction.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Transaction");}
}
public void Edit_User(User i_User) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User.USER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_User",Newtonsoft.Json.JsonConvert.SerializeObject(i_User));}
#region Body Section.
if ((i_User.USER_ID == null) || (i_User.USER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User"); }
i_User.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_Execution)
{
_Stop_Edit_User_Execution = false;
return;
}
i_User.USER_ID = _AppContext.Edit_User
(
i_User.USER_ID
,i_User.OWNER_ID
,i_User.USERNAME
,i_User.PASSWORD
,i_User.USER_TYPE_CODE
,i_User.IS_ACTIVE
,i_User.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User");}
}
public void Edit_Workshop(Workshop i_Workshop) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Workshop.WORKSHOP_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Workshop");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Workshop",Newtonsoft.Json.JsonConvert.SerializeObject(i_Workshop));}
#region Body Section.
if ((i_Workshop.WORKSHOP_ID == null) || (i_Workshop.WORKSHOP_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Workshop"); }
i_Workshop.ENTRY_USER_ID = this.UserID;
i_Workshop.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Workshop.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Workshop_Execution)
{
_Stop_Edit_Workshop_Execution = false;
return;
}
i_Workshop.WORKSHOP_ID = _AppContext.Edit_Workshop
(
i_Workshop.WORKSHOP_ID
,i_Workshop.WORKSHOP_BEGINNING_DATE
,i_Workshop.WORKSHOP_FEES_DESCRIPTION
,i_Workshop.WORKSHOP_TOTAL_M_TONN
,i_Workshop.WORKSHOP_SINGLE_PRICE
,i_Workshop.CURRENCY_ID
,i_Workshop.STOCK_ID
,i_Workshop.MACHINE_ID
,i_Workshop.ENTRY_USER_ID
,i_Workshop.ENTRY_DATE
,i_Workshop.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Workshop");}
}
public void Edit_Workshops(Workshops i_Workshops) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Workshops.WORKSHOPS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Workshops");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Workshops",Newtonsoft.Json.JsonConvert.SerializeObject(i_Workshops));}
#region Body Section.
if ((i_Workshops.WORKSHOPS_ID == null) || (i_Workshops.WORKSHOPS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Workshops"); }
i_Workshops.ENTRY_USER_ID = this.UserID;
i_Workshops.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Workshops.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Workshops_Execution)
{
_Stop_Edit_Workshops_Execution = false;
return;
}
i_Workshops.WORKSHOPS_ID = _AppContext.Edit_Workshops
(
i_Workshops.WORKSHOPS_ID
,i_Workshops.WORKSHOPS_BEGINNING_DATE
,i_Workshops.WORKSHOPS_FEES_DESCRIPTION
,i_Workshops.WORKSHOPS_TOTAL_M_TONN
,i_Workshops.WORKSHOPS_SINGLE_PRICE
,i_Workshops.CURRENCY_ID
,i_Workshops.STOCK_ID
,i_Workshops.MACHINE_ID
,i_Workshops.ENTRY_USER_ID
,i_Workshops.ENTRY_DATE
,i_Workshops.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Workshops");}
}
public void Edit_Address_List(List<Address> i_List_Address)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Address != null)
{
foreach (var oRow in i_List_Address)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Address_List(Params_Edit_Address_List i_Params_Edit_Address_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Address_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Delete)
{
Delete_Address(new Params_Delete_Address() { ADDRESS_ID = oRow.ADDRESS_ID });
}
}
if (i_Params_Edit_Address_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Edit)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Contact_List(List<Contact> i_List_Contact)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Contact != null)
{
foreach (var oRow in i_List_Contact)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Contact_List(Params_Edit_Contact_List i_Params_Edit_Contact_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Contact_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Delete)
{
Delete_Contact(new Params_Delete_Contact() { CONTACT_ID = oRow.CONTACT_ID });
}
}
if (i_Params_Edit_Contact_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Edit)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Conversions_List(List<Conversions> i_List_Conversions)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Conversions_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Conversions != null)
{
foreach (var oRow in i_List_Conversions)
{
Edit_Conversions(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Conversions_List");}
}
public void Edit_Conversions_List(Params_Edit_Conversions_List i_Params_Edit_Conversions_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Conversions_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Conversions_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Conversions_List.My_List_To_Delete)
{
Delete_Conversions(new Params_Delete_Conversions() { CONVERSIONS_ID = oRow.CONVERSIONS_ID });
}
}
if (i_Params_Edit_Conversions_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Conversions_List.My_List_To_Edit)
{
Edit_Conversions(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Conversions_List");}
}
public void Edit_Coupons_List(List<Coupons> i_List_Coupons)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coupons_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Coupons != null)
{
foreach (var oRow in i_List_Coupons)
{
Edit_Coupons(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coupons_List");}
}
public void Edit_Coupons_List(Params_Edit_Coupons_List i_Params_Edit_Coupons_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coupons_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Coupons_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Coupons_List.My_List_To_Delete)
{
Delete_Coupons(new Params_Delete_Coupons() { COUPONS_ID = oRow.COUPONS_ID });
}
}
if (i_Params_Edit_Coupons_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Coupons_List.My_List_To_Edit)
{
Edit_Coupons(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coupons_List");}
}
public void Edit_Currency_List(List<Currency> i_List_Currency)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Currency != null)
{
foreach (var oRow in i_List_Currency)
{
Edit_Currency(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_List");}
}
public void Edit_Currency_List(Params_Edit_Currency_List i_Params_Edit_Currency_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Currency_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Currency_List.My_List_To_Delete)
{
Delete_Currency(new Params_Delete_Currency() { CURRENCY_ID = oRow.CURRENCY_ID });
}
}
if (i_Params_Edit_Currency_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Currency_List.My_List_To_Edit)
{
Edit_Currency(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_List");}
}
public void Edit_Fees_List(List<Fees> i_List_Fees)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Fees != null)
{
foreach (var oRow in i_List_Fees)
{
Edit_Fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Fees_List");}
}
public void Edit_Fees_List(Params_Edit_Fees_List i_Params_Edit_Fees_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Fees_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Fees_List.My_List_To_Delete)
{
Delete_Fees(new Params_Delete_Fees() { FEES_ID = oRow.FEES_ID });
}
}
if (i_Params_Edit_Fees_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Fees_List.My_List_To_Edit)
{
Edit_Fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Fees_List");}
}
public void Edit_Industry_List(List<Industry> i_List_Industry)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Industry_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Industry != null)
{
foreach (var oRow in i_List_Industry)
{
Edit_Industry(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Industry_List");}
}
public void Edit_Industry_List(Params_Edit_Industry_List i_Params_Edit_Industry_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Industry_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Industry_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Industry_List.My_List_To_Delete)
{
Delete_Industry(new Params_Delete_Industry() { INDUSTRY_ID = oRow.INDUSTRY_ID });
}
}
if (i_Params_Edit_Industry_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Industry_List.My_List_To_Edit)
{
Edit_Industry(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Industry_List");}
}
public void Edit_Loc_l1_List(List<Loc_l1> i_List_Loc_l1)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l1 != null)
{
foreach (var oRow in i_List_Loc_l1)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l1_List(Params_Edit_Loc_l1_List i_Params_Edit_Loc_l1_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l1_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Delete)
{
Delete_Loc_l1(new Params_Delete_Loc_l1() { LOC_L1_ID = oRow.LOC_L1_ID });
}
}
if (i_Params_Edit_Loc_l1_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Edit)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l2_List(List<Loc_l2> i_List_Loc_l2)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l2 != null)
{
foreach (var oRow in i_List_Loc_l2)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
public void Edit_Loc_l2_List(Params_Edit_Loc_l2_List i_Params_Edit_Loc_l2_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l2_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Delete)
{
Delete_Loc_l2(new Params_Delete_Loc_l2() { LOC_L2_ID = oRow.LOC_L2_ID });
}
}
if (i_Params_Edit_Loc_l2_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Edit)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
public void Edit_Loc_l3_List(List<Loc_l3> i_List_Loc_l3)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l3 != null)
{
foreach (var oRow in i_List_Loc_l3)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Loc_l3_List(Params_Edit_Loc_l3_List i_Params_Edit_Loc_l3_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l3_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Delete)
{
Delete_Loc_l3(new Params_Delete_Loc_l3() { LOC_L3_ID = oRow.LOC_L3_ID });
}
}
if (i_Params_Edit_Loc_l3_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Edit)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Loc_l4_List(List<Loc_l4> i_List_Loc_l4)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l4 != null)
{
foreach (var oRow in i_List_Loc_l4)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Loc_l4_List(Params_Edit_Loc_l4_List i_Params_Edit_Loc_l4_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l4_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Delete)
{
Delete_Loc_l4(new Params_Delete_Loc_l4() { LOC_L4_ID = oRow.LOC_L4_ID });
}
}
if (i_Params_Edit_Loc_l4_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Edit)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Machine_List(List<Machine> i_List_Machine)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Machine_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Machine != null)
{
foreach (var oRow in i_List_Machine)
{
Edit_Machine(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Machine_List");}
}
public void Edit_Machine_List(Params_Edit_Machine_List i_Params_Edit_Machine_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Machine_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Machine_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Machine_List.My_List_To_Delete)
{
Delete_Machine(new Params_Delete_Machine() { MACHINE_ID = oRow.MACHINE_ID });
}
}
if (i_Params_Edit_Machine_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Machine_List.My_List_To_Edit)
{
Edit_Machine(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Machine_List");}
}
public void Edit_Method_run_List(List<Method_run> i_List_Method_run)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Method_run_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Method_run != null)
{
foreach (var oRow in i_List_Method_run)
{
Edit_Method_run(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Method_run_List");}
}
public void Edit_Method_run_List(Params_Edit_Method_run_List i_Params_Edit_Method_run_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Method_run_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Method_run_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Method_run_List.My_List_To_Delete)
{
Delete_Method_run(new Params_Delete_Method_run() { METHOD_RUN_ID = oRow.METHOD_RUN_ID });
}
}
if (i_Params_Edit_Method_run_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Method_run_List.My_List_To_Edit)
{
Edit_Method_run(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Method_run_List");}
}
public void Edit_Owner_List(List<Owner> i_List_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Owner != null)
{
foreach (var oRow in i_List_Owner)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Owner_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Delete)
{
Delete_Owner(new Params_Delete_Owner() { OWNER_ID = oRow.OWNER_ID });
}
}
if (i_Params_Edit_Owner_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Edit)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Person_List(List<Person> i_List_Person)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Person != null)
{
foreach (var oRow in i_List_Person)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Person_List(Params_Edit_Person_List i_Params_Edit_Person_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Person_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Delete)
{
Delete_Person(new Params_Delete_Person() { PERSON_ID = oRow.PERSON_ID });
}
}
if (i_Params_Edit_Person_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Edit)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Productdistribution_List(List<Productdistribution> i_List_Productdistribution)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Productdistribution_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Productdistribution != null)
{
foreach (var oRow in i_List_Productdistribution)
{
Edit_Productdistribution(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Productdistribution_List");}
}
public void Edit_Productdistribution_List(Params_Edit_Productdistribution_List i_Params_Edit_Productdistribution_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Productdistribution_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Productdistribution_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Productdistribution_List.My_List_To_Delete)
{
Delete_Productdistribution(new Params_Delete_Productdistribution() { PRODUCTDISTRIBUTION_ID = oRow.PRODUCTDISTRIBUTION_ID });
}
}
if (i_Params_Edit_Productdistribution_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Productdistribution_List.My_List_To_Edit)
{
Edit_Productdistribution(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Productdistribution_List");}
}
public void Edit_Salary_List(List<Salary> i_List_Salary)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Salary_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Salary != null)
{
foreach (var oRow in i_List_Salary)
{
Edit_Salary(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Salary_List");}
}
public void Edit_Salary_List(Params_Edit_Salary_List i_Params_Edit_Salary_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Salary_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Salary_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Salary_List.My_List_To_Delete)
{
Delete_Salary(new Params_Delete_Salary() { SALARY_ID = oRow.SALARY_ID });
}
}
if (i_Params_Edit_Salary_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Salary_List.My_List_To_Edit)
{
Edit_Salary(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Salary_List");}
}
public void Edit_Staff_List(List<Staff> i_List_Staff)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Staff != null)
{
foreach (var oRow in i_List_Staff)
{
Edit_Staff(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_List");}
}
public void Edit_Staff_List(Params_Edit_Staff_List i_Params_Edit_Staff_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Staff_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Staff_List.My_List_To_Delete)
{
Delete_Staff(new Params_Delete_Staff() { STAFF_ID = oRow.STAFF_ID });
}
}
if (i_Params_Edit_Staff_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Staff_List.My_List_To_Edit)
{
Edit_Staff(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_List");}
}
public void Edit_Stock_List(List<Stock> i_List_Stock)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Stock_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Stock != null)
{
foreach (var oRow in i_List_Stock)
{
Edit_Stock(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Stock_List");}
}
public void Edit_Stock_List(Params_Edit_Stock_List i_Params_Edit_Stock_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Stock_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Stock_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Stock_List.My_List_To_Delete)
{
Delete_Stock(new Params_Delete_Stock() { STOCK_ID = oRow.STOCK_ID });
}
}
if (i_Params_Edit_Stock_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Stock_List.My_List_To_Edit)
{
Edit_Stock(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Stock_List");}
}
public void Edit_Supplier_List(List<Supplier> i_List_Supplier)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Supplier != null)
{
foreach (var oRow in i_List_Supplier)
{
Edit_Supplier(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_List");}
}
public void Edit_Supplier_List(Params_Edit_Supplier_List i_Params_Edit_Supplier_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Supplier_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Supplier_List.My_List_To_Delete)
{
Delete_Supplier(new Params_Delete_Supplier() { SUPPLIER_ID = oRow.SUPPLIER_ID });
}
}
if (i_Params_Edit_Supplier_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Supplier_List.My_List_To_Edit)
{
Edit_Supplier(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_List");}
}
public void Edit_Transaction_List(List<Transaction> i_List_Transaction)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Transaction_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Transaction != null)
{
foreach (var oRow in i_List_Transaction)
{
Edit_Transaction(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Transaction_List");}
}
public void Edit_Transaction_List(Params_Edit_Transaction_List i_Params_Edit_Transaction_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Transaction_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Transaction_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Transaction_List.My_List_To_Delete)
{
Delete_Transaction(new Params_Delete_Transaction() { TRANSACTION_ID = oRow.TRANSACTION_ID });
}
}
if (i_Params_Edit_Transaction_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Transaction_List.My_List_To_Edit)
{
Edit_Transaction(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Transaction_List");}
}
public void Edit_User_List(List<User> i_List_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User != null)
{
foreach (var oRow in i_List_User)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Delete)
{
Delete_User(new Params_Delete_User() { USER_ID = oRow.USER_ID });
}
}
if (i_Params_Edit_User_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Edit)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_Workshop_List(List<Workshop> i_List_Workshop)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Workshop_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Workshop != null)
{
foreach (var oRow in i_List_Workshop)
{
Edit_Workshop(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Workshop_List");}
}
public void Edit_Workshop_List(Params_Edit_Workshop_List i_Params_Edit_Workshop_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Workshop_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Workshop_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Workshop_List.My_List_To_Delete)
{
Delete_Workshop(new Params_Delete_Workshop() { WORKSHOP_ID = oRow.WORKSHOP_ID });
}
}
if (i_Params_Edit_Workshop_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Workshop_List.My_List_To_Edit)
{
Edit_Workshop(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Workshop_List");}
}
public void Edit_Workshops_List(List<Workshops> i_List_Workshops)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Workshops_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Workshops != null)
{
foreach (var oRow in i_List_Workshops)
{
Edit_Workshops(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Workshops_List");}
}
public void Edit_Workshops_List(Params_Edit_Workshops_List i_Params_Edit_Workshops_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Workshops_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Workshops_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Workshops_List.My_List_To_Delete)
{
Delete_Workshops(new Params_Delete_Workshops() { WORKSHOPS_ID = oRow.WORKSHOPS_ID });
}
}
if (i_Params_Edit_Workshops_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Workshops_List.My_List_To_Edit)
{
Edit_Workshops(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Workshops_List");}
}
}
}
