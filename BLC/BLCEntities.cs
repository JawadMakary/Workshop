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
#region Params_Get_Address_By_ADDRESS_ID
public partial class Params_Get_Address_By_ADDRESS_ID
{
#region Properties
public long? ADDRESS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Contact_By_CONTACT_ID
public partial class Params_Get_Contact_By_CONTACT_ID
{
#region Properties
public Int32? CONTACT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Conversions_By_CONVERSIONS_ID
public partial class Params_Get_Conversions_By_CONVERSIONS_ID
{
#region Properties
public Int32? CONVERSIONS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Coupons_By_COUPONS_ID
public partial class Params_Get_Coupons_By_COUPONS_ID
{
#region Properties
public Int32? COUPONS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Currency_By_CURRENCY_ID
public partial class Params_Get_Currency_By_CURRENCY_ID
{
#region Properties
public Int32? CURRENCY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Fees_By_FEES_ID
public partial class Params_Get_Fees_By_FEES_ID
{
#region Properties
public Int32? FEES_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Industry_By_INDUSTRY_ID
public partial class Params_Get_Industry_By_INDUSTRY_ID
{
#region Properties
public Int32? INDUSTRY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l1_By_LOC_L1_ID
public partial class Params_Get_Loc_l1_By_LOC_L1_ID
{
#region Properties
public long? LOC_L1_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l2_By_LOC_L2_ID
public partial class Params_Get_Loc_l2_By_LOC_L2_ID
{
#region Properties
public long? LOC_L2_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l3_By_LOC_L3_ID
public partial class Params_Get_Loc_l3_By_LOC_L3_ID
{
#region Properties
public long? LOC_L3_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l4_By_LOC_L4_ID
public partial class Params_Get_Loc_l4_By_LOC_L4_ID
{
#region Properties
public long? LOC_L4_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Machine_By_MACHINE_ID
public partial class Params_Get_Machine_By_MACHINE_ID
{
#region Properties
public Int32? MACHINE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Method_run_By_METHOD_RUN_ID
public partial class Params_Get_Method_run_By_METHOD_RUN_ID
{
#region Properties
public long? METHOD_RUN_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Owner_By_OWNER_ID
public partial class Params_Get_Owner_By_OWNER_ID
{
#region Properties
public Int32? OWNER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Person_By_PERSON_ID
public partial class Params_Get_Person_By_PERSON_ID
{
#region Properties
public long? PERSON_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID
public partial class Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID
{
#region Properties
public Int32? PRODUCTDISTRIBUTION_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Salary_By_SALARY_ID
public partial class Params_Get_Salary_By_SALARY_ID
{
#region Properties
public Int32? SALARY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Staff_By_STAFF_ID
public partial class Params_Get_Staff_By_STAFF_ID
{
#region Properties
public Int32? STAFF_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Stock_By_STOCK_ID
public partial class Params_Get_Stock_By_STOCK_ID
{
#region Properties
public Int32? STOCK_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Supplier_By_SUPPLIER_ID
public partial class Params_Get_Supplier_By_SUPPLIER_ID
{
#region Properties
public Int32? SUPPLIER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Transaction_By_TRANSACTION_ID
public partial class Params_Get_Transaction_By_TRANSACTION_ID
{
#region Properties
public Int32? TRANSACTION_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_By_USER_ID
public partial class Params_Get_User_By_USER_ID
{
#region Properties
public long? USER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Workshop_By_WORKSHOP_ID
public partial class Params_Get_Workshop_By_WORKSHOP_ID
{
#region Properties
public Int32? WORKSHOP_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Workshops_By_WORKSHOPS_ID
public partial class Params_Get_Workshops_By_WORKSHOPS_ID
{
#region Properties
public Int32? WORKSHOPS_ID {get;set;}

#endregion
}
#endregion
public partial class Params_Get_Address_By_ADDRESS_ID_List
{
public List<long?> ADDRESS_ID_LIST {get;set;}
}
public partial class Params_Get_Address_By_ADDRESS_ID_List_SP
{
public string ADDRESS_ID_LIST {get;set;}

}
public partial class Params_Get_Contact_By_CONTACT_ID_List
{
public List<Int32?> CONTACT_ID_LIST {get;set;}
}
public partial class Params_Get_Contact_By_CONTACT_ID_List_SP
{
public string CONTACT_ID_LIST {get;set;}

}
public partial class Params_Get_Conversions_By_CONVERSIONS_ID_List
{
public List<Int32?> CONVERSIONS_ID_LIST {get;set;}
}
public partial class Params_Get_Conversions_By_CONVERSIONS_ID_List_SP
{
public string CONVERSIONS_ID_LIST {get;set;}

}
public partial class Params_Get_Coupons_By_COUPONS_ID_List
{
public List<Int32?> COUPONS_ID_LIST {get;set;}
}
public partial class Params_Get_Coupons_By_COUPONS_ID_List_SP
{
public string COUPONS_ID_LIST {get;set;}

}
public partial class Params_Get_Currency_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}
}
public partial class Params_Get_Currency_By_CURRENCY_ID_List_SP
{
public string CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Fees_By_FEES_ID_List
{
public List<Int32?> FEES_ID_LIST {get;set;}
}
public partial class Params_Get_Fees_By_FEES_ID_List_SP
{
public string FEES_ID_LIST {get;set;}

}
public partial class Params_Get_Industry_By_INDUSTRY_ID_List
{
public List<Int32?> INDUSTRY_ID_LIST {get;set;}
}
public partial class Params_Get_Industry_By_INDUSTRY_ID_List_SP
{
public string INDUSTRY_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List_SP
{
public string LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List_SP
{
public string LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List_SP
{
public string LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List_SP
{
public string LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Machine_By_MACHINE_ID_List
{
public List<Int32?> MACHINE_ID_LIST {get;set;}
}
public partial class Params_Get_Machine_By_MACHINE_ID_List_SP
{
public string MACHINE_ID_LIST {get;set;}

}
public partial class Params_Get_Method_run_By_METHOD_RUN_ID_List
{
public List<long?> METHOD_RUN_ID_LIST {get;set;}
}
public partial class Params_Get_Method_run_By_METHOD_RUN_ID_List_SP
{
public string METHOD_RUN_ID_LIST {get;set;}

}
public partial class Params_Get_Owner_By_OWNER_ID_List
{
public List<Int32?> OWNER_ID_LIST {get;set;}
}
public partial class Params_Get_Owner_By_OWNER_ID_List_SP
{
public string OWNER_ID_LIST {get;set;}

}
public partial class Params_Get_Person_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}
}
public partial class Params_Get_Person_By_PERSON_ID_List_SP
{
public string PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List
{
public List<Int32?> PRODUCTDISTRIBUTION_ID_LIST {get;set;}
}
public partial class Params_Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_SP
{
public string PRODUCTDISTRIBUTION_ID_LIST {get;set;}

}
public partial class Params_Get_Salary_By_SALARY_ID_List
{
public List<Int32?> SALARY_ID_LIST {get;set;}
}
public partial class Params_Get_Salary_By_SALARY_ID_List_SP
{
public string SALARY_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_By_STAFF_ID_List
{
public List<Int32?> STAFF_ID_LIST {get;set;}
}
public partial class Params_Get_Staff_By_STAFF_ID_List_SP
{
public string STAFF_ID_LIST {get;set;}

}
public partial class Params_Get_Stock_By_STOCK_ID_List
{
public List<Int32?> STOCK_ID_LIST {get;set;}
}
public partial class Params_Get_Stock_By_STOCK_ID_List_SP
{
public string STOCK_ID_LIST {get;set;}

}
public partial class Params_Get_Supplier_By_SUPPLIER_ID_List
{
public List<Int32?> SUPPLIER_ID_LIST {get;set;}
}
public partial class Params_Get_Supplier_By_SUPPLIER_ID_List_SP
{
public string SUPPLIER_ID_LIST {get;set;}

}
public partial class Params_Get_Transaction_By_TRANSACTION_ID_List
{
public List<Int32?> TRANSACTION_ID_LIST {get;set;}
}
public partial class Params_Get_Transaction_By_TRANSACTION_ID_List_SP
{
public string TRANSACTION_ID_LIST {get;set;}

}
public partial class Params_Get_User_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}
}
public partial class Params_Get_User_By_USER_ID_List_SP
{
public string USER_ID_LIST {get;set;}

}
public partial class Params_Get_Workshop_By_WORKSHOP_ID_List
{
public List<Int32?> WORKSHOP_ID_LIST {get;set;}
}
public partial class Params_Get_Workshop_By_WORKSHOP_ID_List_SP
{
public string WORKSHOP_ID_LIST {get;set;}

}
public partial class Params_Get_Workshops_By_WORKSHOPS_ID_List
{
public List<Int32?> WORKSHOPS_ID_LIST {get;set;}
}
public partial class Params_Get_Workshops_By_WORKSHOPS_ID_List_SP
{
public string WORKSHOPS_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}

}
public partial class Params_Get_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Conversions_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Conversions_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Coupons_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Coupons_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Currency_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Industry_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Industry_By_COUPONS_ID
{
public Int32? COUPONS_ID {get;set;}

}
public partial class Params_Get_Industry_By_STOCK_ID
{
public Int32? STOCK_ID {get;set;}

}
public partial class Params_Get_Loc_l1_By_CODE
{
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Machine_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Machine_By_WORKSHOP_ID
{
public Int32? WORKSHOP_ID {get;set;}

}
public partial class Params_Get_Method_run_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Productdistribution_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Productdistribution_By_STAFF_ID
{
public Int32? STAFF_ID {get;set;}

}
public partial class Params_Get_Productdistribution_By_SUPPLIER_ID
{
public Int32? SUPPLIER_ID {get;set;}

}
public partial class Params_Get_Productdistribution_By_COUPONS_ID
{
public Int32? COUPONS_ID {get;set;}

}
public partial class Params_Get_Salary_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Salary_By_STAFF_ID
{
public Int32? STAFF_ID {get;set;}

}
public partial class Params_Get_Salary_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Staff_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Staff_By_WORKSHOP_ID
{
public Int32? WORKSHOP_ID {get;set;}

}
public partial class Params_Get_Staff_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Stock_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Supplier_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Supplier_By_COUPONS_ID
{
public Int32? COUPONS_ID {get;set;}

}
public partial class Params_Get_Supplier_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Supplier_By_STOCK_ID
{
public Int32? STOCK_ID {get;set;}

}
public partial class Params_Get_Transaction_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Transaction_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Transaction_By_STAFF_ID
{
public Int32? STAFF_ID {get;set;}

}
public partial class Params_Get_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_User_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_Workshop_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Workshop_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Workshop_By_STOCK_ID
{
public Int32? STOCK_ID {get;set;}

}
public partial class Params_Get_Workshop_By_MACHINE_ID
{
public Int32? MACHINE_ID {get;set;}

}
public partial class Params_Get_Workshops_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Workshops_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Workshops_By_STOCK_ID
{
public Int32? STOCK_ID {get;set;}

}
public partial class Params_Get_Workshops_By_MACHINE_ID
{
public Int32? MACHINE_ID {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Conversions_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Coupons_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Fees_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Industry_By_COUPONS_ID_List
{
public List<Int32?> COUPONS_ID_LIST {get;set;}

}
public partial class Params_Get_Industry_By_STOCK_ID_List
{
public List<Int32?> STOCK_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Machine_By_WORKSHOP_ID_List
{
public List<Int32?> WORKSHOP_ID_LIST {get;set;}

}
public partial class Params_Get_Productdistribution_By_STAFF_ID_List
{
public List<Int32?> STAFF_ID_LIST {get;set;}

}
public partial class Params_Get_Productdistribution_By_SUPPLIER_ID_List
{
public List<Int32?> SUPPLIER_ID_LIST {get;set;}

}
public partial class Params_Get_Productdistribution_By_COUPONS_ID_List
{
public List<Int32?> COUPONS_ID_LIST {get;set;}

}
public partial class Params_Get_Salary_By_STAFF_ID_List
{
public List<Int32?> STAFF_ID_LIST {get;set;}

}
public partial class Params_Get_Salary_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_By_WORKSHOP_ID_List
{
public List<Int32?> WORKSHOP_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Supplier_By_COUPONS_ID_List
{
public List<Int32?> COUPONS_ID_LIST {get;set;}

}
public partial class Params_Get_Supplier_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Supplier_By_STOCK_ID_List
{
public List<Int32?> STOCK_ID_LIST {get;set;}

}
public partial class Params_Get_Transaction_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Transaction_By_STAFF_ID_List
{
public List<Int32?> STAFF_ID_LIST {get;set;}

}
public partial class Params_Get_Workshop_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Workshop_By_STOCK_ID_List
{
public List<Int32?> STOCK_ID_LIST {get;set;}

}
public partial class Params_Get_Workshop_By_MACHINE_ID_List
{
public List<Int32?> MACHINE_ID_LIST {get;set;}

}
public partial class Params_Get_Workshops_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Workshops_By_STOCK_ID_List
{
public List<Int32?> STOCK_ID_LIST {get;set;}

}
public partial class Params_Get_Workshops_By_MACHINE_ID_List
{
public List<Int32?> MACHINE_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DATE {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DATE {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Where
{

public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_DATE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_DATE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Currency_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CURRENCY_TYPE {get;set;}
public string CURRENCY_SYMBOL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Currency_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CURRENCY_TYPE {get;set;}
public string CURRENCY_SYMBOL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string FEES_DATE {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string FEES_DATE {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Where
{

public Int32? OWNER_ID {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string MACHINE_DATE {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string MACHINE_DATE {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Method_run_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string METHOD_NAME {get;set;}
public string INPUT_PARAM {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Method_run_By_Where
{

public Int32? OWNER_ID {get;set;}
public string METHOD_NAME {get;set;}
public string INPUT_PARAM {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Method_run_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string METHOD_NAME {get;set;}
public string RUN_DATE {get;set;}
public string INPUT_PARAM {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Method_run_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string METHOD_NAME {get;set;}
public string RUN_DATE {get;set;}
public string INPUT_PARAM {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string SALARY_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string SALARY_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PAYMENT_DESCRIPTION {get;set;}
public string STAFF_REFERENCE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PAYMENT_DESCRIPTION {get;set;}
public string STAFF_REFERENCE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Stock_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string STOCK_DESCRIPTION {get;set;}
public string STOCK_CATEGORY {get;set;}
public string STOCK_SCALE {get;set;}
public string STOCK_MAIN_PERSON {get;set;}
public string STOCK_NOTE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Stock_By_Where
{

public Int32? OWNER_ID {get;set;}
public string STOCK_DESCRIPTION {get;set;}
public string STOCK_CATEGORY {get;set;}
public string STOCK_SCALE {get;set;}
public string STOCK_MAIN_PERSON {get;set;}
public string STOCK_NOTE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Where
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_DATE {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_DATE {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Where
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOP_BEGINNING_DATE {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOP_BEGINNING_DATE {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Where
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_BEGINNING_DATE {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_BEGINNING_DATE {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DATE {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DATE {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DATE {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Conversions_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DATE {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_DATE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_DATE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_DATE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coupons_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_DATE {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string FEES_DATE {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string FEES_DATE {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string FEES_DATE {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string FEES_DATE {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public string FEES_STORE {get;set;}
public string FEES_TYPE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public List<Int32?> WORKSHOP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public string WORKSHOP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public List<Int32?> WORKSHOP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public string WORKSHOP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string MACHINE_DATE {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public List<Int32?> WORKSHOP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string MACHINE_DATE {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public string WORKSHOP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string MACHINE_DATE {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public List<Int32?> WORKSHOP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Machine_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string MACHINE_DATE {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public string MACHINE_NOTES {get;set;}
public string WORKSHOP_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STAFF_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STAFF_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STAFF_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string STAFF_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string SALARY_DATE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STAFF_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string SALARY_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string STAFF_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string SALARY_DATE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> STAFF_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Salary_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string SALARY_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string STAFF_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PAYMENT_DESCRIPTION {get;set;}
public string STAFF_REFERENCE {get;set;}
public List<Int32?> WORKSHOP_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PAYMENT_DESCRIPTION {get;set;}
public string STAFF_REFERENCE {get;set;}
public string WORKSHOP_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PAYMENT_DESCRIPTION {get;set;}
public string STAFF_REFERENCE {get;set;}
public List<Int32?> WORKSHOP_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PAYMENT_DESCRIPTION {get;set;}
public string STAFF_REFERENCE {get;set;}
public string WORKSHOP_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public List<Int32?> COUPONS_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public string COUPONS_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public List<Int32?> COUPONS_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public string COUPONS_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_DATE {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public List<Int32?> COUPONS_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_DATE {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public string COUPONS_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_DATE {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public List<Int32?> COUPONS_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string SUPPLIER_PAYMENT_DATE {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public string COUPONS_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public List<Int32?> MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public string MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public List<Int32?> MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public string MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOP_BEGINNING_DATE {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public List<Int32?> MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string WORKSHOP_BEGINNING_DATE {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public string MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOP_BEGINNING_DATE {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public List<Int32?> MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshop_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string WORKSHOP_BEGINNING_DATE {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public string MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public List<Int32?> MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public string MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public List<Int32?> MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public string MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_BEGINNING_DATE {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public List<Int32?> MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_BEGINNING_DATE {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public string MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_BEGINNING_DATE {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> STOCK_ID_LIST {get;set;}
public List<Int32?> MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Workshops_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string WORKSHOPS_BEGINNING_DATE {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string STOCK_ID_LIST {get;set;}
public string MACHINE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
#region Params_Delete_Address
public partial class Params_Delete_Address
{
#region Properties
public long? ADDRESS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Contact
public partial class Params_Delete_Contact
{
#region Properties
public Int32? CONTACT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Conversions
public partial class Params_Delete_Conversions
{
#region Properties
public Int32? CONVERSIONS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Coupons
public partial class Params_Delete_Coupons
{
#region Properties
public Int32? COUPONS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Currency
public partial class Params_Delete_Currency
{
#region Properties
public Int32? CURRENCY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Fees
public partial class Params_Delete_Fees
{
#region Properties
public Int32? FEES_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Industry
public partial class Params_Delete_Industry
{
#region Properties
public Int32? INDUSTRY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l1
public partial class Params_Delete_Loc_l1
{
#region Properties
public long? LOC_L1_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l2
public partial class Params_Delete_Loc_l2
{
#region Properties
public long? LOC_L2_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l3
public partial class Params_Delete_Loc_l3
{
#region Properties
public long? LOC_L3_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l4
public partial class Params_Delete_Loc_l4
{
#region Properties
public long? LOC_L4_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Machine
public partial class Params_Delete_Machine
{
#region Properties
public Int32? MACHINE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Method_run
public partial class Params_Delete_Method_run
{
#region Properties
public long? METHOD_RUN_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Owner
public partial class Params_Delete_Owner
{
#region Properties
public Int32? OWNER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Person
public partial class Params_Delete_Person
{
#region Properties
public long? PERSON_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Productdistribution
public partial class Params_Delete_Productdistribution
{
#region Properties
public Int32? PRODUCTDISTRIBUTION_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Salary
public partial class Params_Delete_Salary
{
#region Properties
public Int32? SALARY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Staff
public partial class Params_Delete_Staff
{
#region Properties
public Int32? STAFF_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Stock
public partial class Params_Delete_Stock
{
#region Properties
public Int32? STOCK_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Supplier
public partial class Params_Delete_Supplier
{
#region Properties
public Int32? SUPPLIER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Transaction
public partial class Params_Delete_Transaction
{
#region Properties
public Int32? TRANSACTION_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User
public partial class Params_Delete_User
{
#region Properties
public long? USER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Workshop
public partial class Params_Delete_Workshop
{
#region Properties
public Int32? WORKSHOP_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Workshops
public partial class Params_Delete_Workshops
{
#region Properties
public Int32? WORKSHOPS_ID {get;set;}
#endregion
}
#endregion
public partial class Params_Delete_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
}
public partial class Params_Delete_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Conversions_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Conversions_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Coupons_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Coupons_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Currency_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Industry_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Industry_By_COUPONS_ID
{
public Int32? COUPONS_ID {get;set;}
}
public partial class Params_Delete_Industry_By_STOCK_ID
{
public Int32? STOCK_ID {get;set;}
}
public partial class Params_Delete_Loc_l1_By_CODE
{
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Machine_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Machine_By_WORKSHOP_ID
{
public Int32? WORKSHOP_ID {get;set;}
}
public partial class Params_Delete_Method_run_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Productdistribution_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Productdistribution_By_STAFF_ID
{
public Int32? STAFF_ID {get;set;}
}
public partial class Params_Delete_Productdistribution_By_SUPPLIER_ID
{
public Int32? SUPPLIER_ID {get;set;}
}
public partial class Params_Delete_Productdistribution_By_COUPONS_ID
{
public Int32? COUPONS_ID {get;set;}
}
public partial class Params_Delete_Salary_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Salary_By_STAFF_ID
{
public Int32? STAFF_ID {get;set;}
}
public partial class Params_Delete_Salary_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Staff_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Staff_By_WORKSHOP_ID
{
public Int32? WORKSHOP_ID {get;set;}
}
public partial class Params_Delete_Staff_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Stock_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Supplier_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Supplier_By_COUPONS_ID
{
public Int32? COUPONS_ID {get;set;}
}
public partial class Params_Delete_Supplier_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Supplier_By_STOCK_ID
{
public Int32? STOCK_ID {get;set;}
}
public partial class Params_Delete_Transaction_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Transaction_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Transaction_By_STAFF_ID
{
public Int32? STAFF_ID {get;set;}
}
public partial class Params_Delete_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_User_By_USERNAME
{
public string USERNAME {get;set;}
}
public partial class Params_Delete_Workshop_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Workshop_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Workshop_By_STOCK_ID
{
public Int32? STOCK_ID {get;set;}
}
public partial class Params_Delete_Workshop_By_MACHINE_ID
{
public Int32? MACHINE_ID {get;set;}
}
public partial class Params_Delete_Workshops_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Workshops_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Workshops_By_STOCK_ID
{
public Int32? STOCK_ID {get;set;}
}
public partial class Params_Delete_Workshops_By_MACHINE_ID
{
public Int32? MACHINE_ID {get;set;}
}
public partial class Address
{
public long? ADDRESS_ID {get;set;}
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public long? LOC_L1_ID {get;set;}
public long? LOC_L2_ID {get;set;}
public long? LOC_L3_ID {get;set;}
public long? LOC_L4_ID {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Contact
{
public Int32? CONTACT_ID {get;set;}
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Conversions
{
public Int32? CONVERSIONS_ID {get;set;}
public string CONVERSIONS_FROM {get;set;}
public string CONVERSIONS_FOR {get;set;}
public string CONVERSIONS_DATE {get;set;}
public Int32? CURRENCY_ID {get;set;}
public string CONVERSIONS_DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Coupons
{
public Int32? COUPONS_ID {get;set;}
public string COUPONS_TYPE {get;set;}
public string COUPONS_DESCRIPTION {get;set;}
public Int32? COUPONS_QUANTITY {get;set;}
public string COUPONS_STORE {get;set;}
public string COUPONS_DATE {get;set;}
public Int32? CURRENCY_ID {get;set;}
public string COUPONS_PAYMENT_WAITED {get;set;}
public string COUPONS_PAYMENT_DELIVERED {get;set;}
public string COUPONS_FOR {get;set;}
public string COUPONS_NOTE {get;set;}
public string COUPONS_ITEM_TYPE {get;set;}
public string COUPONS_ITEM_QUANTITY {get;set;}
public string COUPONS_MACHINE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Currency
{
public Int32? CURRENCY_ID {get;set;}
public string CURRENCY_TYPE {get;set;}
public string CURRENCY_SYMBOL {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Fees
{
public Int32? FEES_ID {get;set;}
public string FEES_DATE {get;set;}
public string FEES_DESCRIPTION {get;set;}
public Int32? CURRENCY_ID {get;set;}
public Int32? WORKSHOP_PAYMENT {get;set;}
public string WORKSHOP_PAYMENT_DESCRIPTION {get;set;}
public string FEES_STATUS {get;set;}
public string FEES_PAYMENT_GATEWAY {get;set;}
public Int32? FEES_VALUE_DOLLAR {get;set;}
public Int32? FEES_FUEL {get;set;}
public string FEES_STORE {get;set;}
public Int32? FEES_TOTAL_DOLLAR {get;set;}
public Int32? FEES_TOTAL_LBP {get;set;}
public string FEES_TYPE {get;set;}
public Int32? FEES_DOLLAR_RATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Industry
{
public Int32? INDUSTRY_ID {get;set;}
public string INDUSTRY_PRODUCT_NAME {get;set;}
public Int32? INDUSTRY_PRODUCT_QUANTITY {get;set;}
public string INDUSTRY_PRODUCT_DATE {get;set;}
public Int32? COUPONS_ID {get;set;}
public Int32? STOCK_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l1
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l2
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L1_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l3
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L2_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l4
{
public long? LOC_L4_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L3_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Machine
{
public Int32? MACHINE_ID {get;set;}
public string MACHINE_DATE {get;set;}
public string MACHINE_DESCRIPTION {get;set;}
public Int32? MACHINE_HOURS {get;set;}
public Int32? WORKSHOP_ID {get;set;}
public string MACHINE_NOTES {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Method_run
{
public long? METHOD_RUN_ID {get;set;}
public string METHOD_NAME {get;set;}
public string RUN_DATE {get;set;}
public Int32? RUN_HOUR {get;set;}
public Int32? RUN_MINUTE {get;set;}
public Int32? RUN_SECOND {get;set;}
public bool? IS_CACHED {get;set;}
public Int32? EXECUTION_TIME {get;set;}
public string INPUT_PARAM {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Person
{
public long? PERSON_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public bool? IS_BLOCKED {get;set;}
public string DESCRIPTION {get;set;}
public Int32? OWNER_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Productdistribution
{
public Int32? PRODUCTDISTRIBUTION_ID {get;set;}
public string PRODUCTDISTRIBUTION_TYPE {get;set;}
public Int32? PRODUCTDISTRIBUTION_QTY {get;set;}
public string PRODUCTDISTRIBUTION_DATE {get;set;}
public Int32? STAFF_ID {get;set;}
public Int32? SUPPLIER_ID {get;set;}
public Int32? COUPONS_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Salary
{
public Int32? SALARY_ID {get;set;}
public Int32? STAFF_ID {get;set;}
public string SALARY_DATE {get;set;}
public Int32? SALARY_PAYMENT_VALUE {get;set;}
public Int32? CURRENCY_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
}
public partial class Staff
{
public Int32? STAFF_ID {get;set;}
public string STAFF_NAME {get;set;}
public Int32? STAFF_PAYMENT {get;set;}
public string STAFF_PAYMENT_DESCRIPTION {get;set;}
public Int32? WORKSHOP_ID {get;set;}
public Int32? CURRENCY_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Int32? STAFF_IS_ACTIVE {get;set;}
public Int32? STAFF_WORKING_DAYS {get;set;}
public Int32? STAFF_EXTRA_HOURS {get;set;}
public Int32? STAFF_LOAN {get;set;}
public string STAFF_REFERENCE {get;set;}
public decimal? STAFF_EXCHANGE_RATE {get;set;}
}
public partial class Stock
{
public Int32? STOCK_ID {get;set;}
public string STOCK_DESCRIPTION {get;set;}
public string STOCK_CATEGORY {get;set;}
public string STOCK_SCALE {get;set;}
public Int32? STOCK_QUANTITY {get;set;}
public string STOCK_MAIN_PERSON {get;set;}
public string STOCK_NOTE {get;set;}
public Int32? STOCK_PRICE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Supplier
{
public Int32? SUPPLIER_ID {get;set;}
public Int32? COUPONS_ID {get;set;}
public Int32? SUPPLIER_PAYMENT_COST {get;set;}
public string SUPPLIER_PAYMENT_DATE {get;set;}
public Int32? CURRENCY_ID {get;set;}
public string SUPPLIER_PAYMENT_CAUSE {get;set;}
public Int32? STOCK_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Transaction
{
public Int32? TRANSACTION_ID {get;set;}
public Int32? TRANSACTION_AMOUNT {get;set;}
public string TRANSACTION_FROM {get;set;}
public string TRANSACTION_TO {get;set;}
public string TRANSACTION_DATE {get;set;}
public Int32? CURRENCY_ID {get;set;}
public string TRANSACTION_NOTES {get;set;}
public Int32? STAFF_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class User
{
public long? USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Workshop
{
public Int32? WORKSHOP_ID {get;set;}
public string WORKSHOP_BEGINNING_DATE {get;set;}
public string WORKSHOP_FEES_DESCRIPTION {get;set;}
public Int32? WORKSHOP_TOTAL_M_TONN {get;set;}
public Int32? WORKSHOP_SINGLE_PRICE {get;set;}
public Int32? CURRENCY_ID {get;set;}
public Int32? STOCK_ID {get;set;}
public Int32? MACHINE_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Workshops
{
public Int32? WORKSHOPS_ID {get;set;}
public string WORKSHOPS_BEGINNING_DATE {get;set;}
public string WORKSHOPS_FEES_DESCRIPTION {get;set;}
public Int32? WORKSHOPS_TOTAL_M_TONN {get;set;}
public Int32? WORKSHOPS_SINGLE_PRICE {get;set;}
public Int32? CURRENCY_ID {get;set;}
public Int32? STOCK_ID {get;set;}
public Int32? MACHINE_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
#region Params_Edit_Address_List
public partial class Params_Edit_Address_List
{
#region Properties
public List<Address> My_List_To_Edit { get; set; }
public List<Address> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Contact_List
public partial class Params_Edit_Contact_List
{
#region Properties
public List<Contact> My_List_To_Edit { get; set; }
public List<Contact> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Conversions_List
public partial class Params_Edit_Conversions_List
{
#region Properties
public List<Conversions> My_List_To_Edit { get; set; }
public List<Conversions> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Coupons_List
public partial class Params_Edit_Coupons_List
{
#region Properties
public List<Coupons> My_List_To_Edit { get; set; }
public List<Coupons> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Currency_List
public partial class Params_Edit_Currency_List
{
#region Properties
public List<Currency> My_List_To_Edit { get; set; }
public List<Currency> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Fees_List
public partial class Params_Edit_Fees_List
{
#region Properties
public List<Fees> My_List_To_Edit { get; set; }
public List<Fees> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Industry_List
public partial class Params_Edit_Industry_List
{
#region Properties
public List<Industry> My_List_To_Edit { get; set; }
public List<Industry> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l1_List
public partial class Params_Edit_Loc_l1_List
{
#region Properties
public List<Loc_l1> My_List_To_Edit { get; set; }
public List<Loc_l1> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l2_List
public partial class Params_Edit_Loc_l2_List
{
#region Properties
public List<Loc_l2> My_List_To_Edit { get; set; }
public List<Loc_l2> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l3_List
public partial class Params_Edit_Loc_l3_List
{
#region Properties
public List<Loc_l3> My_List_To_Edit { get; set; }
public List<Loc_l3> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l4_List
public partial class Params_Edit_Loc_l4_List
{
#region Properties
public List<Loc_l4> My_List_To_Edit { get; set; }
public List<Loc_l4> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Machine_List
public partial class Params_Edit_Machine_List
{
#region Properties
public List<Machine> My_List_To_Edit { get; set; }
public List<Machine> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Method_run_List
public partial class Params_Edit_Method_run_List
{
#region Properties
public List<Method_run> My_List_To_Edit { get; set; }
public List<Method_run> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Owner_List
public partial class Params_Edit_Owner_List
{
#region Properties
public List<Owner> My_List_To_Edit { get; set; }
public List<Owner> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Person_List
public partial class Params_Edit_Person_List
{
#region Properties
public List<Person> My_List_To_Edit { get; set; }
public List<Person> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Productdistribution_List
public partial class Params_Edit_Productdistribution_List
{
#region Properties
public List<Productdistribution> My_List_To_Edit { get; set; }
public List<Productdistribution> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Salary_List
public partial class Params_Edit_Salary_List
{
#region Properties
public List<Salary> My_List_To_Edit { get; set; }
public List<Salary> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Staff_List
public partial class Params_Edit_Staff_List
{
#region Properties
public List<Staff> My_List_To_Edit { get; set; }
public List<Staff> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Stock_List
public partial class Params_Edit_Stock_List
{
#region Properties
public List<Stock> My_List_To_Edit { get; set; }
public List<Stock> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Supplier_List
public partial class Params_Edit_Supplier_List
{
#region Properties
public List<Supplier> My_List_To_Edit { get; set; }
public List<Supplier> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Transaction_List
public partial class Params_Edit_Transaction_List
{
#region Properties
public List<Transaction> My_List_To_Edit { get; set; }
public List<Transaction> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_List
public partial class Params_Edit_User_List
{
#region Properties
public List<User> My_List_To_Edit { get; set; }
public List<User> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Workshop_List
public partial class Params_Edit_Workshop_List
{
#region Properties
public List<Workshop> My_List_To_Edit { get; set; }
public List<Workshop> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Workshops_List
public partial class Params_Edit_Workshops_List
{
#region Properties
public List<Workshops> My_List_To_Edit { get; set; }
public List<Workshops> My_List_To_Delete { get; set; }
#endregion
}
#endregion
}
