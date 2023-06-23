using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
namespace DALC
{
public partial class MSSQL_DALC : IDALC
{
public Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Conversions Get_Conversions_By_CONVERSIONS_ID ( Int32? CONVERSIONS_ID)
{
Conversions o = new Conversions();
dynamic p = new ExpandoObject();
p.CONVERSIONS_ID = CONVERSIONS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CONVERSIONS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Coupons Get_Coupons_By_COUPONS_ID ( Int32? COUPONS_ID)
{
Coupons o = new Coupons();
dynamic p = new ExpandoObject();
p.COUPONS_ID = COUPONS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_COUPONS_BY_COUPONS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Currency Get_Currency_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
Currency o = new Currency();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Fees Get_Fees_By_FEES_ID ( Int32? FEES_ID)
{
Fees o = new Fees();
dynamic p = new ExpandoObject();
p.FEES_ID = FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FEES_BY_FEES_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Industry Get_Industry_By_INDUSTRY_ID ( Int32? INDUSTRY_ID)
{
Industry o = new Industry();
dynamic p = new ExpandoObject();
p.INDUSTRY_ID = INDUSTRY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_INDUSTRY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Machine Get_Machine_By_MACHINE_ID ( Int32? MACHINE_ID)
{
Machine o = new Machine();
dynamic p = new ExpandoObject();
p.MACHINE_ID = MACHINE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_MACHINE_BY_MACHINE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Method_run Get_Method_run_By_METHOD_RUN_ID ( long? METHOD_RUN_ID)
{
Method_run o = new Method_run();
dynamic p = new ExpandoObject();
p.METHOD_RUN_ID = METHOD_RUN_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID)
{
Owner o = new Owner();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Person Get_Person_By_PERSON_ID ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Productdistribution Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID ( Int32? PRODUCTDISTRIBUTION_ID)
{
Productdistribution o = new Productdistribution();
dynamic p = new ExpandoObject();
p.PRODUCTDISTRIBUTION_ID = PRODUCTDISTRIBUTION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_PRODUCTDISTRIBUTION_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Salary Get_Salary_By_SALARY_ID ( Int32? SALARY_ID)
{
Salary o = new Salary();
dynamic p = new ExpandoObject();
p.SALARY_ID = SALARY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SALARY_BY_SALARY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Staff Get_Staff_By_STAFF_ID ( Int32? STAFF_ID)
{
Staff o = new Staff();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Stock Get_Stock_By_STOCK_ID ( Int32? STOCK_ID)
{
Stock o = new Stock();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STOCK_BY_STOCK_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Supplier Get_Supplier_By_SUPPLIER_ID ( Int32? SUPPLIER_ID)
{
Supplier o = new Supplier();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_SUPPLIER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Transaction Get_Transaction_By_TRANSACTION_ID ( Int32? TRANSACTION_ID)
{
Transaction o = new Transaction();
dynamic p = new ExpandoObject();
p.TRANSACTION_ID = TRANSACTION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_TRANSACTION_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Workshop Get_Workshop_By_WORKSHOP_ID ( Int32? WORKSHOP_ID)
{
Workshop o = new Workshop();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID = WORKSHOP_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WORKSHOP_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Workshops Get_Workshops_By_WORKSHOPS_ID ( Int32? WORKSHOPS_ID)
{
Workshops o = new Workshops();
dynamic p = new ExpandoObject();
p.WORKSHOPS_ID = WORKSHOPS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WORKSHOPS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(R["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(R["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(R["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(R["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(R["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(R["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(R["T_LOC_L4_OWNER_ID"]);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
}
return o;
}
public Conversions Get_Conversions_By_CONVERSIONS_ID_Adv ( Int32? CONVERSIONS_ID)
{
Conversions o = new Conversions();
dynamic p = new ExpandoObject();
p.CONVERSIONS_ID = CONVERSIONS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CONVERSIONS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Coupons Get_Coupons_By_COUPONS_ID_Adv ( Int32? COUPONS_ID)
{
Coupons o = new Coupons();
dynamic p = new ExpandoObject();
p.COUPONS_ID = COUPONS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_COUPONS_BY_COUPONS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Currency Get_Currency_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
Currency o = new Currency();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Fees Get_Fees_By_FEES_ID_Adv ( Int32? FEES_ID)
{
Fees o = new Fees();
dynamic p = new ExpandoObject();
p.FEES_ID = FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FEES_BY_FEES_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Industry Get_Industry_By_INDUSTRY_ID_Adv ( Int32? INDUSTRY_ID)
{
Industry o = new Industry();
dynamic p = new ExpandoObject();
p.INDUSTRY_ID = INDUSTRY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_INDUSTRY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(R["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(R["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(R["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(R["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(R["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(R["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(R["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(R["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(R["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(R["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(R["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(R["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(R["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(R["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(R["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(R["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(R["T_COUPONS_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(R["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(R["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(R["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(R["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(R["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(R["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(R["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(R["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(R["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(R["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(R["T_STOCK_OWNER_ID"]);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
}
return o;
}
public Machine Get_Machine_By_MACHINE_ID_Adv ( Int32? MACHINE_ID)
{
Machine o = new Machine();
dynamic p = new ExpandoObject();
p.MACHINE_ID = MACHINE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_MACHINE_BY_MACHINE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(R["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(R["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(R["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(R["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(R["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(R["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(R["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(R["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(R["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(R["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(R["T_WORKSHOP_OWNER_ID"]);
}
return o;
}
public Method_run Get_Method_run_By_METHOD_RUN_ID_Adv ( long? METHOD_RUN_ID)
{
Method_run o = new Method_run();
dynamic p = new ExpandoObject();
p.METHOD_RUN_ID = METHOD_RUN_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Productdistribution Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_Adv ( Int32? PRODUCTDISTRIBUTION_ID)
{
Productdistribution o = new Productdistribution();
dynamic p = new ExpandoObject();
p.PRODUCTDISTRIBUTION_ID = PRODUCTDISTRIBUTION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_PRODUCTDISTRIBUTION_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(R["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(R["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(R["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(R["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(R["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(R["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(R["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(R["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(R["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(R["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(R["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(R["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(R["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(R["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(R["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(R["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.COUPONS_ID = GV<Int32>(R["T_SUPPLIER_COUPONS_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_COST = GV<Int32>(R["T_SUPPLIER_SUPPLIER_PAYMENT_COST"]);o.My_Supplier.SUPPLIER_PAYMENT_DATE = GV<String>(R["T_SUPPLIER_SUPPLIER_PAYMENT_DATE"]);o.My_Supplier.CURRENCY_ID = GV<Int32>(R["T_SUPPLIER_CURRENCY_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_CAUSE = GV<String>(R["T_SUPPLIER_SUPPLIER_PAYMENT_CAUSE"]);o.My_Supplier.STOCK_ID = GV<Int32>(R["T_SUPPLIER_STOCK_ID"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(R["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(R["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(R["T_SUPPLIER_OWNER_ID"]);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(R["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(R["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(R["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(R["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(R["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(R["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(R["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(R["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(R["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(R["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(R["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(R["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(R["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(R["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(R["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(R["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(R["T_COUPONS_OWNER_ID"]);
}
return o;
}
public Salary Get_Salary_By_SALARY_ID_Adv ( Int32? SALARY_ID)
{
Salary o = new Salary();
dynamic p = new ExpandoObject();
p.SALARY_ID = SALARY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SALARY_BY_SALARY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(R["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(R["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(R["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(R["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(R["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(R["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(R["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(R["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(R["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(R["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(R["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(R["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(R["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(R["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(R["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Staff Get_Staff_By_STAFF_ID_Adv ( Int32? STAFF_ID)
{
Staff o = new Staff();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(R["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(R["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(R["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(R["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(R["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(R["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(R["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(R["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(R["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(R["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(R["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Stock Get_Stock_By_STOCK_ID_Adv ( Int32? STOCK_ID)
{
Stock o = new Stock();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STOCK_BY_STOCK_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Supplier Get_Supplier_By_SUPPLIER_ID_Adv ( Int32? SUPPLIER_ID)
{
Supplier o = new Supplier();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_SUPPLIER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(R["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(R["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(R["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(R["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(R["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(R["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(R["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(R["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(R["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(R["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(R["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(R["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(R["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(R["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(R["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(R["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(R["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(R["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(R["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(R["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(R["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(R["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(R["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(R["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(R["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(R["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(R["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(R["T_STOCK_OWNER_ID"]);
}
return o;
}
public Transaction Get_Transaction_By_TRANSACTION_ID_Adv ( Int32? TRANSACTION_ID)
{
Transaction o = new Transaction();
dynamic p = new ExpandoObject();
p.TRANSACTION_ID = TRANSACTION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_TRANSACTION_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(R["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(R["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(R["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(R["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(R["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(R["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(R["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(R["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(R["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(R["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(R["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(R["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(R["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(R["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(R["T_STAFF_STAFF_EXCHANGE_RATE"]);
}
return o;
}
public User Get_User_By_USER_ID_Adv ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Workshop Get_Workshop_By_WORKSHOP_ID_Adv ( Int32? WORKSHOP_ID)
{
Workshop o = new Workshop();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID = WORKSHOP_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WORKSHOP_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(R["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(R["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(R["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(R["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(R["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(R["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(R["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(R["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(R["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(R["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(R["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(R["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(R["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(R["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(R["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(R["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(R["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(R["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(R["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(R["T_MACHINE_OWNER_ID"]);
}
return o;
}
public Workshops Get_Workshops_By_WORKSHOPS_ID_Adv ( Int32? WORKSHOPS_ID)
{
Workshops o = new Workshops();
dynamic p = new ExpandoObject();
p.WORKSHOPS_ID = WORKSHOPS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WORKSHOPS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(R["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(R["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(R["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(R["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(R["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(R["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(R["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(R["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(R["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(R["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(R["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(R["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(R["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(R["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(R["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(R["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(R["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(R["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(R["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(R["T_MACHINE_OWNER_ID"]);
}
return o;
}
public List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Conversions> Get_Conversions_By_CONVERSIONS_ID_List ( List<Int32?> CONVERSIONS_ID_LIST)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_ID_LIST = string.Join(",", CONVERSIONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CONVERSIONS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Coupons> Get_Coupons_By_COUPONS_ID_List ( List<Int32?> COUPONS_ID_LIST)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_COUPONS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_FEES_ID_List ( List<Int32?> FEES_ID_LIST)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_ID_LIST = string.Join(",", FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_FEES_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_INDUSTRY_ID_List ( List<Int32?> INDUSTRY_ID_LIST)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.INDUSTRY_ID_LIST = string.Join(",", INDUSTRY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_INDUSTRY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Machine> Get_Machine_By_MACHINE_ID_List ( List<Int32?> MACHINE_ID_LIST)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_MACHINE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List ( List<long?> METHOD_RUN_ID_LIST)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_RUN_ID_LIST = string.Join(",", METHOD_RUN_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List ( List<Int32?> PRODUCTDISTRIBUTION_ID_LIST)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.PRODUCTDISTRIBUTION_ID_LIST = string.Join(",", PRODUCTDISTRIBUTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_PRODUCTDISTRIBUTION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_SALARY_ID_List ( List<Int32?> SALARY_ID_LIST)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_ID_LIST = string.Join(",", SALARY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_SALARY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Stock> Get_Stock_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST)
{
List<Stock> oList = new List<Stock>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STOCK_BY_STOCK_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Stock o = new Stock();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_SUPPLIER_ID_List ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_SUPPLIER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_TRANSACTION_ID_List ( List<Int32?> TRANSACTION_ID_LIST)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.TRANSACTION_ID_LIST = string.Join(",", TRANSACTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_TRANSACTION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_WORKSHOP_ID_List ( List<Int32?> WORKSHOP_ID_LIST)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WORKSHOP_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_WORKSHOPS_ID_List ( List<Int32?> WORKSHOPS_ID_LIST)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_ID_LIST = string.Join(",", WORKSHOPS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WORKSHOPS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Conversions> Get_Conversions_By_CONVERSIONS_ID_List_Adv ( List<Int32?> CONVERSIONS_ID_LIST)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_ID_LIST = string.Join(",", CONVERSIONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CONVERSIONS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Coupons> Get_Coupons_By_COUPONS_ID_List_Adv ( List<Int32?> COUPONS_ID_LIST)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_COUPONS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_FEES_ID_List_Adv ( List<Int32?> FEES_ID_LIST)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_ID_LIST = string.Join(",", FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_FEES_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_INDUSTRY_ID_List_Adv ( List<Int32?> INDUSTRY_ID_LIST)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.INDUSTRY_ID_LIST = string.Join(",", INDUSTRY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_INDUSTRY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Machine> Get_Machine_By_MACHINE_ID_List_Adv ( List<Int32?> MACHINE_ID_LIST)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_MACHINE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List_Adv ( List<long?> METHOD_RUN_ID_LIST)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_RUN_ID_LIST = string.Join(",", METHOD_RUN_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_Adv ( List<Int32?> PRODUCTDISTRIBUTION_ID_LIST)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.PRODUCTDISTRIBUTION_ID_LIST = string.Join(",", PRODUCTDISTRIBUTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_PRODUCTDISTRIBUTION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.COUPONS_ID = GV<Int32>(X["T_SUPPLIER_COUPONS_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_COST = GV<Int32>(X["T_SUPPLIER_SUPPLIER_PAYMENT_COST"]);o.My_Supplier.SUPPLIER_PAYMENT_DATE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_DATE"]);o.My_Supplier.CURRENCY_ID = GV<Int32>(X["T_SUPPLIER_CURRENCY_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_CAUSE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_CAUSE"]);o.My_Supplier.STOCK_ID = GV<Int32>(X["T_SUPPLIER_STOCK_ID"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_SALARY_ID_List_Adv ( List<Int32?> SALARY_ID_LIST)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_ID_LIST = string.Join(",", SALARY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_SALARY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Stock> Get_Stock_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST)
{
List<Stock> oList = new List<Stock>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STOCK_BY_STOCK_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Stock o = new Stock();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_SUPPLIER_ID_List_Adv ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_SUPPLIER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_TRANSACTION_ID_List_Adv ( List<Int32?> TRANSACTION_ID_LIST)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.TRANSACTION_ID_LIST = string.Join(",", TRANSACTION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_TRANSACTION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_WORKSHOP_ID_List_Adv ( List<Int32?> WORKSHOP_ID_LIST)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WORKSHOP_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_WORKSHOPS_ID_List_Adv ( List<Int32?> WORKSHOPS_ID_LIST)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_ID_LIST = string.Join(",", WORKSHOPS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WORKSHOPS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Conversions> Get_Conversions_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Conversions> Get_Conversions_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Coupons> Get_Coupons_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Coupons> Get_Coupons_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_COUPONS_ID ( Int32? COUPONS_ID)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.COUPONS_ID = COUPONS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_COUPONS_ID", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_STOCK_ID ( Int32? STOCK_ID)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_STOCK_ID", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Machine> Get_Machine_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Machine> Get_Machine_By_WORKSHOP_ID ( Int32? WORKSHOP_ID)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID = WORKSHOP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WORKSHOP_ID", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Method_run> Get_Method_run_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_STAFF_ID ( Int32? STAFF_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_STAFF_ID", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID ( Int32? SUPPLIER_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_SUPPLIER_ID", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_COUPONS_ID ( Int32? COUPONS_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.COUPONS_ID = COUPONS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_COUPONS_ID", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_STAFF_ID ( Int32? STAFF_ID)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_STAFF_ID", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_WORKSHOP_ID ( Int32? WORKSHOP_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID = WORKSHOP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WORKSHOP_ID", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Stock> Get_Stock_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Stock> oList = new List<Stock>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STOCK_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Stock o = new Stock();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_COUPONS_ID ( Int32? COUPONS_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.COUPONS_ID = COUPONS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_COUPONS_ID", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_STOCK_ID ( Int32? STOCK_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_STOCK_ID", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_STAFF_ID ( Int32? STAFF_ID)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_STAFF_ID", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_STOCK_ID ( Int32? STOCK_ID)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_STOCK_ID", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_MACHINE_ID ( Int32? MACHINE_ID)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.MACHINE_ID = MACHINE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_MACHINE_ID", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_STOCK_ID ( Int32? STOCK_ID)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_STOCK_ID", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_MACHINE_ID ( Int32? MACHINE_ID)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.MACHINE_ID = MACHINE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_MACHINE_ID", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Conversions> Get_Conversions_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Conversions> Get_Conversions_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Coupons> Get_Coupons_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Coupons> Get_Coupons_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_COUPONS_ID_Adv ( Int32? COUPONS_ID)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.COUPONS_ID = COUPONS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_COUPONS_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_STOCK_ID_Adv ( Int32? STOCK_ID)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_STOCK_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Machine> Get_Machine_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Machine> Get_Machine_By_WORKSHOP_ID_Adv ( Int32? WORKSHOP_ID)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID = WORKSHOP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WORKSHOP_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Method_run> Get_Method_run_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.COUPONS_ID = GV<Int32>(X["T_SUPPLIER_COUPONS_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_COST = GV<Int32>(X["T_SUPPLIER_SUPPLIER_PAYMENT_COST"]);o.My_Supplier.SUPPLIER_PAYMENT_DATE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_DATE"]);o.My_Supplier.CURRENCY_ID = GV<Int32>(X["T_SUPPLIER_CURRENCY_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_CAUSE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_CAUSE"]);o.My_Supplier.STOCK_ID = GV<Int32>(X["T_SUPPLIER_STOCK_ID"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_STAFF_ID_Adv ( Int32? STAFF_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_STAFF_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.COUPONS_ID = GV<Int32>(X["T_SUPPLIER_COUPONS_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_COST = GV<Int32>(X["T_SUPPLIER_SUPPLIER_PAYMENT_COST"]);o.My_Supplier.SUPPLIER_PAYMENT_DATE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_DATE"]);o.My_Supplier.CURRENCY_ID = GV<Int32>(X["T_SUPPLIER_CURRENCY_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_CAUSE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_CAUSE"]);o.My_Supplier.STOCK_ID = GV<Int32>(X["T_SUPPLIER_STOCK_ID"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID_Adv ( Int32? SUPPLIER_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_SUPPLIER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.COUPONS_ID = GV<Int32>(X["T_SUPPLIER_COUPONS_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_COST = GV<Int32>(X["T_SUPPLIER_SUPPLIER_PAYMENT_COST"]);o.My_Supplier.SUPPLIER_PAYMENT_DATE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_DATE"]);o.My_Supplier.CURRENCY_ID = GV<Int32>(X["T_SUPPLIER_CURRENCY_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_CAUSE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_CAUSE"]);o.My_Supplier.STOCK_ID = GV<Int32>(X["T_SUPPLIER_STOCK_ID"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_COUPONS_ID_Adv ( Int32? COUPONS_ID)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.COUPONS_ID = COUPONS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_COUPONS_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.COUPONS_ID = GV<Int32>(X["T_SUPPLIER_COUPONS_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_COST = GV<Int32>(X["T_SUPPLIER_SUPPLIER_PAYMENT_COST"]);o.My_Supplier.SUPPLIER_PAYMENT_DATE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_DATE"]);o.My_Supplier.CURRENCY_ID = GV<Int32>(X["T_SUPPLIER_CURRENCY_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_CAUSE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_CAUSE"]);o.My_Supplier.STOCK_ID = GV<Int32>(X["T_SUPPLIER_STOCK_ID"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_STAFF_ID_Adv ( Int32? STAFF_ID)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_STAFF_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_WORKSHOP_ID_Adv ( Int32? WORKSHOP_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID = WORKSHOP_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WORKSHOP_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Stock> Get_Stock_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Stock> oList = new List<Stock>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STOCK_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Stock o = new Stock();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_COUPONS_ID_Adv ( Int32? COUPONS_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.COUPONS_ID = COUPONS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_COUPONS_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_STOCK_ID_Adv ( Int32? STOCK_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_STOCK_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_STAFF_ID_Adv ( Int32? STAFF_ID)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_STAFF_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_STOCK_ID_Adv ( Int32? STOCK_ID)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_STOCK_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_MACHINE_ID_Adv ( Int32? MACHINE_ID)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.MACHINE_ID = MACHINE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_MACHINE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_STOCK_ID_Adv ( Int32? STOCK_ID)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.STOCK_ID = STOCK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_STOCK_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_MACHINE_ID_Adv ( Int32? MACHINE_ID)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.MACHINE_ID = MACHINE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_MACHINE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Conversions> Get_Conversions_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Coupons> Get_Coupons_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_COUPONS_ID_List ( List<Int32?> COUPONS_ID_LIST)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_COUPONS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_STOCK_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Machine> Get_Machine_By_WORKSHOP_ID_List ( List<Int32?> WORKSHOP_ID_LIST)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WORKSHOP_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_STAFF_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID_List ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_SUPPLIER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_COUPONS_ID_List ( List<Int32?> COUPONS_ID_LIST)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_COUPONS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_STAFF_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_WORKSHOP_ID_List ( List<Int32?> WORKSHOP_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WORKSHOP_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_COUPONS_ID_List ( List<Int32?> COUPONS_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_COUPONS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_STOCK_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_STAFF_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_STOCK_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_MACHINE_ID_List ( List<Int32?> MACHINE_ID_LIST)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_MACHINE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_STOCK_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_MACHINE_ID_List ( List<Int32?> MACHINE_ID_LIST)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_MACHINE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Conversions> Get_Conversions_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Coupons> Get_Coupons_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_COUPONS_ID_List_Adv ( List<Int32?> COUPONS_ID_LIST)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_COUPONS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Industry> Get_Industry_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST)
{
List<Industry> oList = new List<Industry>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_INDUSTRY_BY_STOCK_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Industry o = new Industry();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Machine> Get_Machine_By_WORKSHOP_ID_List_Adv ( List<Int32?> WORKSHOP_ID_LIST)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WORKSHOP_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_STAFF_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.COUPONS_ID = GV<Int32>(X["T_SUPPLIER_COUPONS_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_COST = GV<Int32>(X["T_SUPPLIER_SUPPLIER_PAYMENT_COST"]);o.My_Supplier.SUPPLIER_PAYMENT_DATE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_DATE"]);o.My_Supplier.CURRENCY_ID = GV<Int32>(X["T_SUPPLIER_CURRENCY_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_CAUSE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_CAUSE"]);o.My_Supplier.STOCK_ID = GV<Int32>(X["T_SUPPLIER_STOCK_ID"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID_List_Adv ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_SUPPLIER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.COUPONS_ID = GV<Int32>(X["T_SUPPLIER_COUPONS_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_COST = GV<Int32>(X["T_SUPPLIER_SUPPLIER_PAYMENT_COST"]);o.My_Supplier.SUPPLIER_PAYMENT_DATE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_DATE"]);o.My_Supplier.CURRENCY_ID = GV<Int32>(X["T_SUPPLIER_CURRENCY_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_CAUSE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_CAUSE"]);o.My_Supplier.STOCK_ID = GV<Int32>(X["T_SUPPLIER_STOCK_ID"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Productdistribution> Get_Productdistribution_By_COUPONS_ID_List_Adv ( List<Int32?> COUPONS_ID_LIST)
{
List<Productdistribution> oList = new List<Productdistribution>();
dynamic p = new ExpandoObject();
p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PRODUCTDISTRIBUTION_BY_COUPONS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Productdistribution o = new Productdistribution();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.COUPONS_ID = GV<Int32>(X["T_SUPPLIER_COUPONS_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_COST = GV<Int32>(X["T_SUPPLIER_SUPPLIER_PAYMENT_COST"]);o.My_Supplier.SUPPLIER_PAYMENT_DATE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_DATE"]);o.My_Supplier.CURRENCY_ID = GV<Int32>(X["T_SUPPLIER_CURRENCY_ID"]);o.My_Supplier.SUPPLIER_PAYMENT_CAUSE = GV<String>(X["T_SUPPLIER_SUPPLIER_PAYMENT_CAUSE"]);o.My_Supplier.STOCK_ID = GV<Int32>(X["T_SUPPLIER_STOCK_ID"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_STAFF_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Salary> Get_Salary_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_WORKSHOP_ID_List_Adv ( List<Int32?> WORKSHOP_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WORKSHOP_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_COUPONS_ID_List_Adv ( List<Int32?> COUPONS_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_COUPONS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_STOCK_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Transaction> Get_Transaction_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST)
{
List<Transaction> oList = new List<Transaction>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_TRANSACTION_BY_STAFF_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Transaction o = new Transaction();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_STOCK_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshop> Get_Workshop_By_MACHINE_ID_List_Adv ( List<Int32?> MACHINE_ID_LIST)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_MACHINE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_STOCK_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Workshops> Get_Workshops_By_MACHINE_ID_List_Adv ( List<Int32?> MACHINE_ID_LIST)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_MACHINE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Where ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DATE = CONVERSIONS_DATE; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Where_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DATE = CONVERSIONS_DATE; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Where ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_DATE = COUPONS_DATE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Where_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_DATE = COUPONS_DATE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Criteria ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_TYPE = CURRENCY_TYPE; p.CURRENCY_SYMBOL = CURRENCY_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Where ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_TYPE = CURRENCY_TYPE; p.CURRENCY_SYMBOL = CURRENCY_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DATE = FEES_DATE; p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DATE = FEES_DATE; p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Criteria ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Where ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Criteria_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DATE = MACHINE_DATE; p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Where_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DATE = MACHINE_DATE; p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Where ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.RUN_DATE = RUN_DATE; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Where_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.RUN_DATE = RUN_DATE; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Criteria_V2 ( string SALARY_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_DATE = SALARY_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Where_V2 ( string SALARY_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_DATE = SALARY_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PAYMENT_DESCRIPTION = STAFF_PAYMENT_DESCRIPTION; p.STAFF_REFERENCE = STAFF_REFERENCE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PAYMENT_DESCRIPTION = STAFF_PAYMENT_DESCRIPTION; p.STAFF_REFERENCE = STAFF_REFERENCE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Stock> Get_Stock_By_Criteria ( string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Stock> oList = new List<Stock>();
dynamic p = new ExpandoObject();
p.STOCK_DESCRIPTION = STOCK_DESCRIPTION; p.STOCK_CATEGORY = STOCK_CATEGORY; p.STOCK_SCALE = STOCK_SCALE; p.STOCK_MAIN_PERSON = STOCK_MAIN_PERSON; p.STOCK_NOTE = STOCK_NOTE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STOCK_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Stock o = new Stock();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Stock> Get_Stock_By_Where ( string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Stock> oList = new List<Stock>();
dynamic p = new ExpandoObject();
p.STOCK_DESCRIPTION = STOCK_DESCRIPTION; p.STOCK_CATEGORY = STOCK_CATEGORY; p.STOCK_SCALE = STOCK_SCALE; p.STOCK_MAIN_PERSON = STOCK_MAIN_PERSON; p.STOCK_NOTE = STOCK_NOTE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STOCK_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Stock o = new Stock();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria ( string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where ( string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_DATE = SUPPLIER_PAYMENT_DATE; p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_DATE = SUPPLIER_PAYMENT_DATE; p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria ( string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Where ( string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_BEGINNING_DATE = WORKSHOP_BEGINNING_DATE; p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Where_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_BEGINNING_DATE = WORKSHOP_BEGINNING_DATE; p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria ( string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Where ( string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_BEGINNING_DATE = WORKSHOPS_BEGINNING_DATE; p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Where_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_BEGINNING_DATE = WORKSHOPS_BEGINNING_DATE; p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_Adv ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Where_Adv ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_Adv_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DATE = CONVERSIONS_DATE; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Where_Adv_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DATE = CONVERSIONS_DATE; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_Adv ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Where_Adv ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_Adv_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_DATE = COUPONS_DATE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Where_Adv_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_DATE = COUPONS_DATE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Criteria_Adv ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_TYPE = CURRENCY_TYPE; p.CURRENCY_SYMBOL = CURRENCY_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Where_Adv ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_TYPE = CURRENCY_TYPE; p.CURRENCY_SYMBOL = CURRENCY_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_Adv ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_Adv ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_Adv_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DATE = FEES_DATE; p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_Adv_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DATE = FEES_DATE; p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Criteria_Adv ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Where_Adv ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Criteria_Adv_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DATE = MACHINE_DATE; p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Where_Adv_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DATE = MACHINE_DATE; p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_Adv ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Where_Adv ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_Adv_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.RUN_DATE = RUN_DATE; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Where_Adv_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.RUN_DATE = RUN_DATE; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Criteria_Adv_V2 ( string SALARY_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_DATE = SALARY_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Where_Adv_V2 ( string SALARY_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_DATE = SALARY_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_Adv ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PAYMENT_DESCRIPTION = STAFF_PAYMENT_DESCRIPTION; p.STAFF_REFERENCE = STAFF_REFERENCE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_Adv ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PAYMENT_DESCRIPTION = STAFF_PAYMENT_DESCRIPTION; p.STAFF_REFERENCE = STAFF_REFERENCE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Stock> Get_Stock_By_Criteria_Adv ( string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Stock> oList = new List<Stock>();
dynamic p = new ExpandoObject();
p.STOCK_DESCRIPTION = STOCK_DESCRIPTION; p.STOCK_CATEGORY = STOCK_CATEGORY; p.STOCK_SCALE = STOCK_SCALE; p.STOCK_MAIN_PERSON = STOCK_MAIN_PERSON; p.STOCK_NOTE = STOCK_NOTE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STOCK_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Stock o = new Stock();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Stock> Get_Stock_By_Where_Adv ( string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Stock> oList = new List<Stock>();
dynamic p = new ExpandoObject();
p.STOCK_DESCRIPTION = STOCK_DESCRIPTION; p.STOCK_CATEGORY = STOCK_CATEGORY; p.STOCK_SCALE = STOCK_SCALE; p.STOCK_MAIN_PERSON = STOCK_MAIN_PERSON; p.STOCK_NOTE = STOCK_NOTE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STOCK_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Stock o = new Stock();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_Adv ( string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_Adv ( string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_Adv_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_DATE = SUPPLIER_PAYMENT_DATE; p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_Adv_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_DATE = SUPPLIER_PAYMENT_DATE; p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_Adv ( string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Where_Adv ( string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_Adv_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_BEGINNING_DATE = WORKSHOP_BEGINNING_DATE; p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Where_Adv_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_BEGINNING_DATE = WORKSHOP_BEGINNING_DATE; p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_Adv ( string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Where_Adv ( string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_Adv_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_BEGINNING_DATE = WORKSHOPS_BEGINNING_DATE; p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Where_Adv_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_BEGINNING_DATE = WORKSHOPS_BEGINNING_DATE; p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_InList ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Where_InList ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_InList_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DATE = CONVERSIONS_DATE; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Where_InList_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DATE = CONVERSIONS_DATE; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_InList ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Where_InList ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_InList_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_DATE = COUPONS_DATE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Where_InList_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_DATE = COUPONS_DATE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_InList ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DATE = FEES_DATE; p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DATE = FEES_DATE; p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Criteria_InList ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Where_InList ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Criteria_InList_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DATE = MACHINE_DATE; p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Where_InList_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DATE = MACHINE_DATE; p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Where_InList ( string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Criteria_InList_V2 ( string SALARY_DATE, string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_DATE = SALARY_DATE; p.DESCRIPTION = DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Where_InList_V2 ( string SALARY_DATE, string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_DATE = SALARY_DATE; p.DESCRIPTION = DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, List<Int32?> WORKSHOP_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PAYMENT_DESCRIPTION = STAFF_PAYMENT_DESCRIPTION; p.STAFF_REFERENCE = STAFF_REFERENCE; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_InList ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, List<Int32?> WORKSHOP_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PAYMENT_DESCRIPTION = STAFF_PAYMENT_DESCRIPTION; p.STAFF_REFERENCE = STAFF_REFERENCE; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList ( string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList ( string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_DATE = SUPPLIER_PAYMENT_DATE; p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_DATE = SUPPLIER_PAYMENT_DATE; p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_InList ( string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Where_InList ( string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_InList_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_BEGINNING_DATE = WORKSHOP_BEGINNING_DATE; p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Where_InList_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_BEGINNING_DATE = WORKSHOP_BEGINNING_DATE; p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_InList ( string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Where_InList ( string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_InList_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_BEGINNING_DATE = WORKSHOPS_BEGINNING_DATE; p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Where_InList_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_BEGINNING_DATE = WORKSHOPS_BEGINNING_DATE; p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_InList_Adv ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Where_InList_Adv ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Criteria_InList_Adv_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DATE = CONVERSIONS_DATE; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Conversions> Get_Conversions_By_Where_InList_Adv_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Conversions> oList = new List<Conversions>();
dynamic p = new ExpandoObject();
p.CONVERSIONS_FROM = CONVERSIONS_FROM; p.CONVERSIONS_FOR = CONVERSIONS_FOR; p.CONVERSIONS_DATE = CONVERSIONS_DATE; p.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONVERSIONS_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Conversions o = new Conversions();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_InList_Adv ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Where_InList_Adv ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Criteria_InList_Adv_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_DATE = COUPONS_DATE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coupons> Get_Coupons_By_Where_InList_Adv_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coupons> oList = new List<Coupons>();
dynamic p = new ExpandoObject();
p.COUPONS_TYPE = COUPONS_TYPE; p.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION; p.COUPONS_STORE = COUPONS_STORE; p.COUPONS_DATE = COUPONS_DATE; p.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED; p.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED; p.COUPONS_FOR = COUPONS_FOR; p.COUPONS_NOTE = COUPONS_NOTE; p.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE; p.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY; p.COUPONS_MACHINE = COUPONS_MACHINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COUPONS_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Coupons o = new Coupons();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_Adv ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_Adv ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_Adv_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DATE = FEES_DATE; p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_Adv_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DATE = FEES_DATE; p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION; p.FEES_STATUS = FEES_STATUS; p.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY; p.FEES_STORE = FEES_STORE; p.FEES_TYPE = FEES_TYPE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Criteria_InList_Adv ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Where_InList_Adv ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Criteria_InList_Adv_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DATE = MACHINE_DATE; p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Machine> Get_Machine_By_Where_InList_Adv_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Machine> oList = new List<Machine>();
dynamic p = new ExpandoObject();
p.MACHINE_DATE = MACHINE_DATE; p.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION; p.MACHINE_NOTES = MACHINE_NOTES; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_MACHINE_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Machine o = new Machine();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PAYMENT = GV<Int32>(X["T_STAFF_STAFF_PAYMENT"]);o.My_Staff.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["T_STAFF_STAFF_PAYMENT_DESCRIPTION"]);o.My_Staff.WORKSHOP_ID = GV<Int32>(X["T_STAFF_WORKSHOP_ID"]);o.My_Staff.CURRENCY_ID = GV<Int32>(X["T_STAFF_CURRENCY_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_IS_ACTIVE = GV<Int32>(X["T_STAFF_STAFF_IS_ACTIVE"]);o.My_Staff.STAFF_WORKING_DAYS = GV<Int32>(X["T_STAFF_STAFF_WORKING_DAYS"]);o.My_Staff.STAFF_EXTRA_HOURS = GV<Int32>(X["T_STAFF_STAFF_EXTRA_HOURS"]);o.My_Staff.STAFF_LOAN = GV<Int32>(X["T_STAFF_STAFF_LOAN"]);o.My_Staff.STAFF_REFERENCE = GV<String>(X["T_STAFF_STAFF_REFERENCE"]);o.My_Staff.STAFF_EXCHANGE_RATE = GV<Decimal>(X["T_STAFF_STAFF_EXCHANGE_RATE"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Criteria_InList_Adv_V2 ( string SALARY_DATE, string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_DATE = SALARY_DATE; p.DESCRIPTION = DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Salary> Get_Salary_By_Where_InList_Adv_V2 ( string SALARY_DATE, string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Salary> oList = new List<Salary>();
dynamic p = new ExpandoObject();
p.SALARY_DATE = SALARY_DATE; p.DESCRIPTION = DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SALARY_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Salary o = new Salary();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList_Adv ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, List<Int32?> WORKSHOP_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PAYMENT_DESCRIPTION = STAFF_PAYMENT_DESCRIPTION; p.STAFF_REFERENCE = STAFF_REFERENCE; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_InList_Adv ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, List<Int32?> WORKSHOP_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PAYMENT_DESCRIPTION = STAFF_PAYMENT_DESCRIPTION; p.STAFF_REFERENCE = STAFF_REFERENCE; p.WORKSHOP_ID_LIST = string.Join(",", WORKSHOP_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Workshop = new Workshop();
o.My_Workshop.WORKSHOP_ID = GV<Int32>(X["T_WORKSHOP_WORKSHOP_ID"]);o.My_Workshop.WORKSHOP_BEGINNING_DATE = GV<String>(X["T_WORKSHOP_WORKSHOP_BEGINNING_DATE"]);o.My_Workshop.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["T_WORKSHOP_WORKSHOP_FEES_DESCRIPTION"]);o.My_Workshop.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["T_WORKSHOP_WORKSHOP_TOTAL_M_TONN"]);o.My_Workshop.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["T_WORKSHOP_WORKSHOP_SINGLE_PRICE"]);o.My_Workshop.CURRENCY_ID = GV<Int32>(X["T_WORKSHOP_CURRENCY_ID"]);o.My_Workshop.STOCK_ID = GV<Int32>(X["T_WORKSHOP_STOCK_ID"]);o.My_Workshop.MACHINE_ID = GV<Int32>(X["T_WORKSHOP_MACHINE_ID"]);o.My_Workshop.ENTRY_USER_ID = GV<Int64>(X["T_WORKSHOP_ENTRY_USER_ID"]);o.My_Workshop.ENTRY_DATE = GV<String>(X["T_WORKSHOP_ENTRY_DATE"]);o.My_Workshop.OWNER_ID = GV<Int32>(X["T_WORKSHOP_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_Adv ( string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_Adv ( string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Coupons = new Coupons();
o.My_Coupons.COUPONS_ID = GV<Int32>(X["T_COUPONS_COUPONS_ID"]);o.My_Coupons.COUPONS_TYPE = GV<String>(X["T_COUPONS_COUPONS_TYPE"]);o.My_Coupons.COUPONS_DESCRIPTION = GV<String>(X["T_COUPONS_COUPONS_DESCRIPTION"]);o.My_Coupons.COUPONS_QUANTITY = GV<Int32>(X["T_COUPONS_COUPONS_QUANTITY"]);o.My_Coupons.COUPONS_STORE = GV<String>(X["T_COUPONS_COUPONS_STORE"]);o.My_Coupons.COUPONS_DATE = GV<String>(X["T_COUPONS_COUPONS_DATE"]);o.My_Coupons.CURRENCY_ID = GV<Int32>(X["T_COUPONS_CURRENCY_ID"]);o.My_Coupons.COUPONS_PAYMENT_WAITED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_WAITED"]);o.My_Coupons.COUPONS_PAYMENT_DELIVERED = GV<String>(X["T_COUPONS_COUPONS_PAYMENT_DELIVERED"]);o.My_Coupons.COUPONS_FOR = GV<String>(X["T_COUPONS_COUPONS_FOR"]);o.My_Coupons.COUPONS_NOTE = GV<String>(X["T_COUPONS_COUPONS_NOTE"]);o.My_Coupons.COUPONS_ITEM_TYPE = GV<String>(X["T_COUPONS_COUPONS_ITEM_TYPE"]);o.My_Coupons.COUPONS_ITEM_QUANTITY = GV<String>(X["T_COUPONS_COUPONS_ITEM_QUANTITY"]);o.My_Coupons.COUPONS_MACHINE = GV<String>(X["T_COUPONS_COUPONS_MACHINE"]);o.My_Coupons.ENTRY_USER_ID = GV<Int64>(X["T_COUPONS_ENTRY_USER_ID"]);o.My_Coupons.ENTRY_DATE = GV<String>(X["T_COUPONS_ENTRY_DATE"]);o.My_Coupons.OWNER_ID = GV<Int32>(X["T_COUPONS_OWNER_ID"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_Adv_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_DATE = SUPPLIER_PAYMENT_DATE; p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_Adv_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_PAYMENT_DATE = SUPPLIER_PAYMENT_DATE; p.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE; p.COUPONS_ID_LIST = string.Join(",", COUPONS_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_InList_Adv ( string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Where_InList_Adv ( string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Criteria_InList_Adv_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_BEGINNING_DATE = WORKSHOP_BEGINNING_DATE; p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshop> Get_Workshop_By_Where_InList_Adv_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshop> oList = new List<Workshop>();
dynamic p = new ExpandoObject();
p.WORKSHOP_BEGINNING_DATE = WORKSHOP_BEGINNING_DATE; p.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOP_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Workshop o = new Workshop();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_InList_Adv ( string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Where_InList_Adv ( string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Stock = new Stock();
o.My_Stock.STOCK_ID = GV<Int32>(X["T_STOCK_STOCK_ID"]);o.My_Stock.STOCK_DESCRIPTION = GV<String>(X["T_STOCK_STOCK_DESCRIPTION"]);o.My_Stock.STOCK_CATEGORY = GV<String>(X["T_STOCK_STOCK_CATEGORY"]);o.My_Stock.STOCK_SCALE = GV<String>(X["T_STOCK_STOCK_SCALE"]);o.My_Stock.STOCK_QUANTITY = GV<Int32>(X["T_STOCK_STOCK_QUANTITY"]);o.My_Stock.STOCK_MAIN_PERSON = GV<String>(X["T_STOCK_STOCK_MAIN_PERSON"]);o.My_Stock.STOCK_NOTE = GV<String>(X["T_STOCK_STOCK_NOTE"]);o.My_Stock.STOCK_PRICE = GV<Int32>(X["T_STOCK_STOCK_PRICE"]);o.My_Stock.ENTRY_USER_ID = GV<Int64>(X["T_STOCK_ENTRY_USER_ID"]);o.My_Stock.ENTRY_DATE = GV<String>(X["T_STOCK_ENTRY_DATE"]);o.My_Stock.OWNER_ID = GV<Int32>(X["T_STOCK_OWNER_ID"]);
o.My_Machine = new Machine();
o.My_Machine.MACHINE_ID = GV<Int32>(X["T_MACHINE_MACHINE_ID"]);o.My_Machine.MACHINE_DATE = GV<String>(X["T_MACHINE_MACHINE_DATE"]);o.My_Machine.MACHINE_DESCRIPTION = GV<String>(X["T_MACHINE_MACHINE_DESCRIPTION"]);o.My_Machine.MACHINE_HOURS = GV<Int32>(X["T_MACHINE_MACHINE_HOURS"]);o.My_Machine.WORKSHOP_ID = GV<Int32>(X["T_MACHINE_WORKSHOP_ID"]);o.My_Machine.MACHINE_NOTES = GV<String>(X["T_MACHINE_MACHINE_NOTES"]);o.My_Machine.ENTRY_USER_ID = GV<Int64>(X["T_MACHINE_ENTRY_USER_ID"]);o.My_Machine.ENTRY_DATE = GV<String>(X["T_MACHINE_ENTRY_DATE"]);o.My_Machine.OWNER_ID = GV<Int32>(X["T_MACHINE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Criteria_InList_Adv_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_BEGINNING_DATE = WORKSHOPS_BEGINNING_DATE; p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Workshops> Get_Workshops_By_Where_InList_Adv_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Workshops> oList = new List<Workshops>();
dynamic p = new ExpandoObject();
p.WORKSHOPS_BEGINNING_DATE = WORKSHOPS_BEGINNING_DATE; p.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.STOCK_ID_LIST = string.Join(",", STOCK_ID_LIST.ToArray()); p.MACHINE_ID_LIST = string.Join(",", MACHINE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORKSHOPS_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Workshops o = new Workshops();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public void Delete_Address ( long? ADDRESS_ID)
{
var p = new { ADDRESS_ID = ADDRESS_ID };
ExecuteDelete("UPG_DELETE_ADDRESS", p);
}
public void Delete_Contact ( Int32? CONTACT_ID)
{
var p = new { CONTACT_ID = CONTACT_ID };
ExecuteDelete("UPG_DELETE_CONTACT", p);
}
public void Delete_Conversions ( Int32? CONVERSIONS_ID)
{
var p = new { CONVERSIONS_ID = CONVERSIONS_ID };
ExecuteDelete("UPG_DELETE_CONVERSIONS", p);
}
public void Delete_Coupons ( Int32? COUPONS_ID)
{
var p = new { COUPONS_ID = COUPONS_ID };
ExecuteDelete("UPG_DELETE_COUPONS", p);
}
public void Delete_Currency ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_CURRENCY", p);
}
public void Delete_Fees ( Int32? FEES_ID)
{
var p = new { FEES_ID = FEES_ID };
ExecuteDelete("UPG_DELETE_FEES", p);
}
public void Delete_Industry ( Int32? INDUSTRY_ID)
{
var p = new { INDUSTRY_ID = INDUSTRY_ID };
ExecuteDelete("UPG_DELETE_INDUSTRY", p);
}
public void Delete_Loc_l1 ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L1", p);
}
public void Delete_Loc_l2 ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L2", p);
}
public void Delete_Loc_l3 ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L3", p);
}
public void Delete_Loc_l4 ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_LOC_L4", p);
}
public void Delete_Machine ( Int32? MACHINE_ID)
{
var p = new { MACHINE_ID = MACHINE_ID };
ExecuteDelete("UPG_DELETE_MACHINE", p);
}
public void Delete_Method_run ( long? METHOD_RUN_ID)
{
var p = new { METHOD_RUN_ID = METHOD_RUN_ID };
ExecuteDelete("UPG_DELETE_METHOD_RUN", p);
}
public void Delete_Owner ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OWNER", p);
}
public void Delete_Person ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_PERSON", p);
}
public void Delete_Productdistribution ( Int32? PRODUCTDISTRIBUTION_ID)
{
var p = new { PRODUCTDISTRIBUTION_ID = PRODUCTDISTRIBUTION_ID };
ExecuteDelete("UPG_DELETE_PRODUCTDISTRIBUTION", p);
}
public void Delete_Salary ( Int32? SALARY_ID)
{
var p = new { SALARY_ID = SALARY_ID };
ExecuteDelete("UPG_DELETE_SALARY", p);
}
public void Delete_Staff ( Int32? STAFF_ID)
{
var p = new { STAFF_ID = STAFF_ID };
ExecuteDelete("UPG_DELETE_STAFF", p);
}
public void Delete_Stock ( Int32? STOCK_ID)
{
var p = new { STOCK_ID = STOCK_ID };
ExecuteDelete("UPG_DELETE_STOCK", p);
}
public void Delete_Supplier ( Int32? SUPPLIER_ID)
{
var p = new { SUPPLIER_ID = SUPPLIER_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER", p);
}
public void Delete_Transaction ( Int32? TRANSACTION_ID)
{
var p = new { TRANSACTION_ID = TRANSACTION_ID };
ExecuteDelete("UPG_DELETE_TRANSACTION", p);
}
public void Delete_User ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_USER", p);
}
public void Delete_Workshop ( Int32? WORKSHOP_ID)
{
var p = new { WORKSHOP_ID = WORKSHOP_ID };
ExecuteDelete("UPG_DELETE_WORKSHOP", p);
}
public void Delete_Workshops ( Int32? WORKSHOPS_ID)
{
var p = new { WORKSHOPS_ID = WORKSHOPS_ID };
ExecuteDelete("UPG_DELETE_WORKSHOPS", p);
}
public void Delete_Address_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID", p);
}
public void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L1_ID", p);
}
public void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L2_ID", p);
}
public void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L3_ID", p);
}
public void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_OWNER_ID", p);
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
var p = new { PERSON_ID = PERSON_ID,ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
}
public void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L4_ID", p);
}
public void Delete_Contact_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID", p);
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
var p = new { PERSON_ID = PERSON_ID,CONTACT_TYPE_CODE = CONTACT_TYPE_CODE,CONTACT = CONTACT };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
}
public void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_OWNER_ID", p);
}
public void Delete_Conversions_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CONVERSIONS_BY_OWNER_ID", p);
}
public void Delete_Conversions_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_CONVERSIONS_BY_CURRENCY_ID", p);
}
public void Delete_Coupons_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_COUPONS_BY_OWNER_ID", p);
}
public void Delete_Coupons_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_COUPONS_BY_CURRENCY_ID", p);
}
public void Delete_Currency_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CURRENCY_BY_OWNER_ID", p);
}
public void Delete_Fees_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_FEES_BY_OWNER_ID", p);
}
public void Delete_Fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_FEES_BY_CURRENCY_ID", p);
}
public void Delete_Industry_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_INDUSTRY_BY_OWNER_ID", p);
}
public void Delete_Industry_By_COUPONS_ID ( Int32? COUPONS_ID)
{
var p = new { COUPONS_ID = COUPONS_ID };
ExecuteDelete("UPG_DELETE_INDUSTRY_BY_COUPONS_ID", p);
}
public void Delete_Industry_By_STOCK_ID ( Int32? STOCK_ID)
{
var p = new { STOCK_ID = STOCK_ID };
ExecuteDelete("UPG_DELETE_INDUSTRY_BY_STOCK_ID", p);
}
public void Delete_Loc_l1_By_CODE ( string CODE)
{
var p = new { CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_CODE", p);
}
public void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_OWNER_ID", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
var p = new { LOC_L1_ID = LOC_L1_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID_CODE", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID", p);
}
public void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_OWNER_ID", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
var p = new { LOC_L2_ID = LOC_L2_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID_CODE", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID", p);
}
public void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_OWNER_ID", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
var p = new { LOC_L3_ID = LOC_L3_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID_CODE", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID", p);
}
public void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_OWNER_ID", p);
}
public void Delete_Machine_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_MACHINE_BY_OWNER_ID", p);
}
public void Delete_Machine_By_WORKSHOP_ID ( Int32? WORKSHOP_ID)
{
var p = new { WORKSHOP_ID = WORKSHOP_ID };
ExecuteDelete("UPG_DELETE_MACHINE_BY_WORKSHOP_ID", p);
}
public void Delete_Method_run_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_METHOD_RUN_BY_OWNER_ID", p);
}
public void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PERSON_BY_OWNER_ID", p);
}
public void Delete_Productdistribution_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PRODUCTDISTRIBUTION_BY_OWNER_ID", p);
}
public void Delete_Productdistribution_By_STAFF_ID ( Int32? STAFF_ID)
{
var p = new { STAFF_ID = STAFF_ID };
ExecuteDelete("UPG_DELETE_PRODUCTDISTRIBUTION_BY_STAFF_ID", p);
}
public void Delete_Productdistribution_By_SUPPLIER_ID ( Int32? SUPPLIER_ID)
{
var p = new { SUPPLIER_ID = SUPPLIER_ID };
ExecuteDelete("UPG_DELETE_PRODUCTDISTRIBUTION_BY_SUPPLIER_ID", p);
}
public void Delete_Productdistribution_By_COUPONS_ID ( Int32? COUPONS_ID)
{
var p = new { COUPONS_ID = COUPONS_ID };
ExecuteDelete("UPG_DELETE_PRODUCTDISTRIBUTION_BY_COUPONS_ID", p);
}
public void Delete_Salary_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SALARY_BY_OWNER_ID", p);
}
public void Delete_Salary_By_STAFF_ID ( Int32? STAFF_ID)
{
var p = new { STAFF_ID = STAFF_ID };
ExecuteDelete("UPG_DELETE_SALARY_BY_STAFF_ID", p);
}
public void Delete_Salary_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_SALARY_BY_CURRENCY_ID", p);
}
public void Delete_Staff_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_STAFF_BY_OWNER_ID", p);
}
public void Delete_Staff_By_WORKSHOP_ID ( Int32? WORKSHOP_ID)
{
var p = new { WORKSHOP_ID = WORKSHOP_ID };
ExecuteDelete("UPG_DELETE_STAFF_BY_WORKSHOP_ID", p);
}
public void Delete_Staff_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_STAFF_BY_CURRENCY_ID", p);
}
public void Delete_Stock_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_STOCK_BY_OWNER_ID", p);
}
public void Delete_Supplier_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_BY_OWNER_ID", p);
}
public void Delete_Supplier_By_COUPONS_ID ( Int32? COUPONS_ID)
{
var p = new { COUPONS_ID = COUPONS_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_BY_COUPONS_ID", p);
}
public void Delete_Supplier_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_BY_CURRENCY_ID", p);
}
public void Delete_Supplier_By_STOCK_ID ( Int32? STOCK_ID)
{
var p = new { STOCK_ID = STOCK_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_BY_STOCK_ID", p);
}
public void Delete_Transaction_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_TRANSACTION_BY_OWNER_ID", p);
}
public void Delete_Transaction_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_TRANSACTION_BY_CURRENCY_ID", p);
}
public void Delete_Transaction_By_STAFF_ID ( Int32? STAFF_ID)
{
var p = new { STAFF_ID = STAFF_ID };
ExecuteDelete("UPG_DELETE_TRANSACTION_BY_STAFF_ID", p);
}
public void Delete_User_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", p);
}
public void Delete_User_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_USER_BY_USERNAME", p);
}
public void Delete_Workshop_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_WORKSHOP_BY_OWNER_ID", p);
}
public void Delete_Workshop_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_WORKSHOP_BY_CURRENCY_ID", p);
}
public void Delete_Workshop_By_STOCK_ID ( Int32? STOCK_ID)
{
var p = new { STOCK_ID = STOCK_ID };
ExecuteDelete("UPG_DELETE_WORKSHOP_BY_STOCK_ID", p);
}
public void Delete_Workshop_By_MACHINE_ID ( Int32? MACHINE_ID)
{
var p = new { MACHINE_ID = MACHINE_ID };
ExecuteDelete("UPG_DELETE_WORKSHOP_BY_MACHINE_ID", p);
}
public void Delete_Workshops_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_WORKSHOPS_BY_OWNER_ID", p);
}
public void Delete_Workshops_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_WORKSHOPS_BY_CURRENCY_ID", p);
}
public void Delete_Workshops_By_STOCK_ID ( Int32? STOCK_ID)
{
var p = new { STOCK_ID = STOCK_ID };
ExecuteDelete("UPG_DELETE_WORKSHOPS_BY_STOCK_ID", p);
}
public void Delete_Workshops_By_MACHINE_ID ( Int32? MACHINE_ID)
{
var p = new { MACHINE_ID = MACHINE_ID };
ExecuteDelete("UPG_DELETE_WORKSHOPS_BY_MACHINE_ID", p);
}
public long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Address oAddress = new Address();
oAddress.ADDRESS_ID = ADDRESS_ID;oAddress.PERSON_ID = PERSON_ID;oAddress.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;oAddress.LOC_L1_ID = LOC_L1_ID;oAddress.LOC_L2_ID = LOC_L2_ID;oAddress.LOC_L3_ID = LOC_L3_ID;oAddress.LOC_L4_ID = LOC_L4_ID;oAddress.STREET = STREET;oAddress.BUILDING = BUILDING;oAddress.FLOOR = FLOOR;oAddress.POBOX = POBOX;oAddress.VALID_DATE_START = VALID_DATE_START;oAddress.VALID_DATE_END = VALID_DATE_END;oAddress.NOTES = NOTES;oAddress.ENTRY_DATE = ENTRY_DATE;oAddress.ENTRY_USER_ID = ENTRY_USER_ID;oAddress.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_ADDRESS", oAddress, "ADDRESS_ID");
return oAddress.ADDRESS_ID;
}
public Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Contact oContact = new Contact();
oContact.CONTACT_ID = CONTACT_ID;oContact.PERSON_ID = PERSON_ID;oContact.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE;oContact.CONTACT = CONTACT;oContact.DESCRIPTION = DESCRIPTION;oContact.ENTRY_USER_ID = ENTRY_USER_ID;oContact.ENTRY_DATE = ENTRY_DATE;oContact.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CONTACT", oContact, "CONTACT_ID");
return oContact.CONTACT_ID;
}
public Int32? Edit_Conversions ( Int32? CONVERSIONS_ID, string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, Int32? CURRENCY_ID, string CONVERSIONS_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Conversions oConversions = new Conversions();
oConversions.CONVERSIONS_ID = CONVERSIONS_ID;oConversions.CONVERSIONS_FROM = CONVERSIONS_FROM;oConversions.CONVERSIONS_FOR = CONVERSIONS_FOR;oConversions.CONVERSIONS_DATE = CONVERSIONS_DATE;oConversions.CURRENCY_ID = CURRENCY_ID;oConversions.CONVERSIONS_DESCRIPTION = CONVERSIONS_DESCRIPTION;oConversions.ENTRY_USER_ID = ENTRY_USER_ID;oConversions.ENTRY_DATE = ENTRY_DATE;oConversions.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CONVERSIONS", oConversions, "CONVERSIONS_ID");
return oConversions.CONVERSIONS_ID;
}
public Int32? Edit_Coupons ( Int32? COUPONS_ID, string COUPONS_TYPE, string COUPONS_DESCRIPTION, Int32? COUPONS_QUANTITY, string COUPONS_STORE, string COUPONS_DATE, Int32? CURRENCY_ID, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Coupons oCoupons = new Coupons();
oCoupons.COUPONS_ID = COUPONS_ID;oCoupons.COUPONS_TYPE = COUPONS_TYPE;oCoupons.COUPONS_DESCRIPTION = COUPONS_DESCRIPTION;oCoupons.COUPONS_QUANTITY = COUPONS_QUANTITY;oCoupons.COUPONS_STORE = COUPONS_STORE;oCoupons.COUPONS_DATE = COUPONS_DATE;oCoupons.CURRENCY_ID = CURRENCY_ID;oCoupons.COUPONS_PAYMENT_WAITED = COUPONS_PAYMENT_WAITED;oCoupons.COUPONS_PAYMENT_DELIVERED = COUPONS_PAYMENT_DELIVERED;oCoupons.COUPONS_FOR = COUPONS_FOR;oCoupons.COUPONS_NOTE = COUPONS_NOTE;oCoupons.COUPONS_ITEM_TYPE = COUPONS_ITEM_TYPE;oCoupons.COUPONS_ITEM_QUANTITY = COUPONS_ITEM_QUANTITY;oCoupons.COUPONS_MACHINE = COUPONS_MACHINE;oCoupons.ENTRY_USER_ID = ENTRY_USER_ID;oCoupons.ENTRY_DATE = ENTRY_DATE;oCoupons.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_COUPONS", oCoupons, "COUPONS_ID");
return oCoupons.COUPONS_ID;
}
public Int32? Edit_Currency ( Int32? CURRENCY_ID, string CURRENCY_TYPE, string CURRENCY_SYMBOL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Currency oCurrency = new Currency();
oCurrency.CURRENCY_ID = CURRENCY_ID;oCurrency.CURRENCY_TYPE = CURRENCY_TYPE;oCurrency.CURRENCY_SYMBOL = CURRENCY_SYMBOL;oCurrency.ENTRY_USER_ID = ENTRY_USER_ID;oCurrency.ENTRY_DATE = ENTRY_DATE;oCurrency.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CURRENCY", oCurrency, "CURRENCY_ID");
return oCurrency.CURRENCY_ID;
}
public Int32? Edit_Fees ( Int32? FEES_ID, string FEES_DATE, string FEES_DESCRIPTION, Int32? CURRENCY_ID, Int32? WORKSHOP_PAYMENT, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, Int32? FEES_VALUE_DOLLAR, Int32? FEES_FUEL, string FEES_STORE, Int32? FEES_TOTAL_DOLLAR, Int32? FEES_TOTAL_LBP, string FEES_TYPE, Int32? FEES_DOLLAR_RATE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Fees oFees = new Fees();
oFees.FEES_ID = FEES_ID;oFees.FEES_DATE = FEES_DATE;oFees.FEES_DESCRIPTION = FEES_DESCRIPTION;oFees.CURRENCY_ID = CURRENCY_ID;oFees.WORKSHOP_PAYMENT = WORKSHOP_PAYMENT;oFees.WORKSHOP_PAYMENT_DESCRIPTION = WORKSHOP_PAYMENT_DESCRIPTION;oFees.FEES_STATUS = FEES_STATUS;oFees.FEES_PAYMENT_GATEWAY = FEES_PAYMENT_GATEWAY;oFees.FEES_VALUE_DOLLAR = FEES_VALUE_DOLLAR;oFees.FEES_FUEL = FEES_FUEL;oFees.FEES_STORE = FEES_STORE;oFees.FEES_TOTAL_DOLLAR = FEES_TOTAL_DOLLAR;oFees.FEES_TOTAL_LBP = FEES_TOTAL_LBP;oFees.FEES_TYPE = FEES_TYPE;oFees.FEES_DOLLAR_RATE = FEES_DOLLAR_RATE;oFees.ENTRY_USER_ID = ENTRY_USER_ID;oFees.ENTRY_DATE = ENTRY_DATE;oFees.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_FEES", oFees, "FEES_ID");
return oFees.FEES_ID;
}
public Int32? Edit_Industry ( Int32? INDUSTRY_ID, string INDUSTRY_PRODUCT_NAME, Int32? INDUSTRY_PRODUCT_QUANTITY, string INDUSTRY_PRODUCT_DATE, Int32? COUPONS_ID, Int32? STOCK_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Industry oIndustry = new Industry();
oIndustry.INDUSTRY_ID = INDUSTRY_ID;oIndustry.INDUSTRY_PRODUCT_NAME = INDUSTRY_PRODUCT_NAME;oIndustry.INDUSTRY_PRODUCT_QUANTITY = INDUSTRY_PRODUCT_QUANTITY;oIndustry.INDUSTRY_PRODUCT_DATE = INDUSTRY_PRODUCT_DATE;oIndustry.COUPONS_ID = COUPONS_ID;oIndustry.STOCK_ID = STOCK_ID;oIndustry.ENTRY_USER_ID = ENTRY_USER_ID;oIndustry.ENTRY_DATE = ENTRY_DATE;oIndustry.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_INDUSTRY", oIndustry, "INDUSTRY_ID");
return oIndustry.INDUSTRY_ID;
}
public long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l1 oLoc_l1 = new Loc_l1();
oLoc_l1.LOC_L1_ID = LOC_L1_ID;oLoc_l1.CODE = CODE;oLoc_l1.DESCRIPTION = DESCRIPTION;oLoc_l1.NOTES = NOTES;oLoc_l1.ENTRY_DATE = ENTRY_DATE;oLoc_l1.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l1.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L1", oLoc_l1, "LOC_L1_ID");
return oLoc_l1.LOC_L1_ID;
}
public long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l2 oLoc_l2 = new Loc_l2();
oLoc_l2.LOC_L2_ID = LOC_L2_ID;oLoc_l2.CODE = CODE;oLoc_l2.DESCRIPTION = DESCRIPTION;oLoc_l2.LOC_L1_ID = LOC_L1_ID;oLoc_l2.NOTES = NOTES;oLoc_l2.ENTRY_DATE = ENTRY_DATE;oLoc_l2.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l2.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L2", oLoc_l2, "LOC_L2_ID");
return oLoc_l2.LOC_L2_ID;
}
public long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l3 oLoc_l3 = new Loc_l3();
oLoc_l3.LOC_L3_ID = LOC_L3_ID;oLoc_l3.CODE = CODE;oLoc_l3.DESCRIPTION = DESCRIPTION;oLoc_l3.LOC_L2_ID = LOC_L2_ID;oLoc_l3.NOTES = NOTES;oLoc_l3.ENTRY_DATE = ENTRY_DATE;oLoc_l3.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l3.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L3", oLoc_l3, "LOC_L3_ID");
return oLoc_l3.LOC_L3_ID;
}
public long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l4 oLoc_l4 = new Loc_l4();
oLoc_l4.LOC_L4_ID = LOC_L4_ID;oLoc_l4.CODE = CODE;oLoc_l4.DESCRIPTION = DESCRIPTION;oLoc_l4.LOC_L3_ID = LOC_L3_ID;oLoc_l4.NOTES = NOTES;oLoc_l4.ENTRY_DATE = ENTRY_DATE;oLoc_l4.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l4.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L4", oLoc_l4, "LOC_L4_ID");
return oLoc_l4.LOC_L4_ID;
}
public Int32? Edit_Machine ( Int32? MACHINE_ID, string MACHINE_DATE, string MACHINE_DESCRIPTION, Int32? MACHINE_HOURS, Int32? WORKSHOP_ID, string MACHINE_NOTES, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Machine oMachine = new Machine();
oMachine.MACHINE_ID = MACHINE_ID;oMachine.MACHINE_DATE = MACHINE_DATE;oMachine.MACHINE_DESCRIPTION = MACHINE_DESCRIPTION;oMachine.MACHINE_HOURS = MACHINE_HOURS;oMachine.WORKSHOP_ID = WORKSHOP_ID;oMachine.MACHINE_NOTES = MACHINE_NOTES;oMachine.ENTRY_USER_ID = ENTRY_USER_ID;oMachine.ENTRY_DATE = ENTRY_DATE;oMachine.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_MACHINE", oMachine, "MACHINE_ID");
return oMachine.MACHINE_ID;
}
public long? Edit_Method_run ( long? METHOD_RUN_ID, string METHOD_NAME, string RUN_DATE, Int32? RUN_HOUR, Int32? RUN_MINUTE, Int32? RUN_SECOND, bool? IS_CACHED, Int32? EXECUTION_TIME, string INPUT_PARAM, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Method_run oMethod_run = new Method_run();
oMethod_run.METHOD_RUN_ID = METHOD_RUN_ID;oMethod_run.METHOD_NAME = METHOD_NAME;oMethod_run.RUN_DATE = RUN_DATE;oMethod_run.RUN_HOUR = RUN_HOUR;oMethod_run.RUN_MINUTE = RUN_MINUTE;oMethod_run.RUN_SECOND = RUN_SECOND;oMethod_run.IS_CACHED = IS_CACHED;oMethod_run.EXECUTION_TIME = EXECUTION_TIME;oMethod_run.INPUT_PARAM = INPUT_PARAM;oMethod_run.ENTRY_USER_ID = ENTRY_USER_ID;oMethod_run.ENTRY_DATE = ENTRY_DATE;oMethod_run.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_METHOD_RUN", oMethod_run, "METHOD_RUN_ID");
return oMethod_run.METHOD_RUN_ID;
}
public Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE)
{
Owner oOwner = new Owner();
oOwner.OWNER_ID = OWNER_ID;oOwner.CODE = CODE;oOwner.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE;oOwner.DESCRIPTION = DESCRIPTION;oOwner.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
return oOwner.OWNER_ID;
}
public long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE)
{
Person oPerson = new Person();
oPerson.PERSON_ID = PERSON_ID;oPerson.FIRST_NAME = FIRST_NAME;oPerson.LAST_NAME = LAST_NAME;oPerson.FATHER_NAME = FATHER_NAME;oPerson.MOTHER_NAME = MOTHER_NAME;oPerson.TITLE_CODE = TITLE_CODE;oPerson.GENDER_CODE = GENDER_CODE;oPerson.RELIGION_CODE = RELIGION_CODE;oPerson.BIRTH_DATE = BIRTH_DATE;oPerson.IS_BLOCKED = IS_BLOCKED;oPerson.DESCRIPTION = DESCRIPTION;oPerson.OWNER_ID = OWNER_ID;oPerson.ENTRY_USER_ID = ENTRY_USER_ID;oPerson.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_PERSON", oPerson, "PERSON_ID");
return oPerson.PERSON_ID;
}
public Int32? Edit_Productdistribution ( Int32? PRODUCTDISTRIBUTION_ID, string PRODUCTDISTRIBUTION_TYPE, Int32? PRODUCTDISTRIBUTION_QTY, string PRODUCTDISTRIBUTION_DATE, Int32? STAFF_ID, Int32? SUPPLIER_ID, Int32? COUPONS_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Productdistribution oProductdistribution = new Productdistribution();
oProductdistribution.PRODUCTDISTRIBUTION_ID = PRODUCTDISTRIBUTION_ID;oProductdistribution.PRODUCTDISTRIBUTION_TYPE = PRODUCTDISTRIBUTION_TYPE;oProductdistribution.PRODUCTDISTRIBUTION_QTY = PRODUCTDISTRIBUTION_QTY;oProductdistribution.PRODUCTDISTRIBUTION_DATE = PRODUCTDISTRIBUTION_DATE;oProductdistribution.STAFF_ID = STAFF_ID;oProductdistribution.SUPPLIER_ID = SUPPLIER_ID;oProductdistribution.COUPONS_ID = COUPONS_ID;oProductdistribution.ENTRY_USER_ID = ENTRY_USER_ID;oProductdistribution.ENTRY_DATE = ENTRY_DATE;oProductdistribution.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_PRODUCTDISTRIBUTION", oProductdistribution, "PRODUCTDISTRIBUTION_ID");
return oProductdistribution.PRODUCTDISTRIBUTION_ID;
}
public Int32? Edit_Salary ( Int32? SALARY_ID, Int32? STAFF_ID, string SALARY_DATE, Int32? SALARY_PAYMENT_VALUE, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Salary oSalary = new Salary();
oSalary.SALARY_ID = SALARY_ID;oSalary.STAFF_ID = STAFF_ID;oSalary.SALARY_DATE = SALARY_DATE;oSalary.SALARY_PAYMENT_VALUE = SALARY_PAYMENT_VALUE;oSalary.CURRENCY_ID = CURRENCY_ID;oSalary.ENTRY_USER_ID = ENTRY_USER_ID;oSalary.ENTRY_DATE = ENTRY_DATE;oSalary.OWNER_ID = OWNER_ID;oSalary.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_SALARY", oSalary, "SALARY_ID");
return oSalary.SALARY_ID;
}
public Int32? Edit_Staff ( Int32? STAFF_ID, string STAFF_NAME, Int32? STAFF_PAYMENT, string STAFF_PAYMENT_DESCRIPTION, Int32? WORKSHOP_ID, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? STAFF_IS_ACTIVE, Int32? STAFF_WORKING_DAYS, Int32? STAFF_EXTRA_HOURS, Int32? STAFF_LOAN, string STAFF_REFERENCE, decimal? STAFF_EXCHANGE_RATE)
{
Staff oStaff = new Staff();
oStaff.STAFF_ID = STAFF_ID;oStaff.STAFF_NAME = STAFF_NAME;oStaff.STAFF_PAYMENT = STAFF_PAYMENT;oStaff.STAFF_PAYMENT_DESCRIPTION = STAFF_PAYMENT_DESCRIPTION;oStaff.WORKSHOP_ID = WORKSHOP_ID;oStaff.CURRENCY_ID = CURRENCY_ID;oStaff.ENTRY_USER_ID = ENTRY_USER_ID;oStaff.ENTRY_DATE = ENTRY_DATE;oStaff.OWNER_ID = OWNER_ID;oStaff.STAFF_IS_ACTIVE = STAFF_IS_ACTIVE;oStaff.STAFF_WORKING_DAYS = STAFF_WORKING_DAYS;oStaff.STAFF_EXTRA_HOURS = STAFF_EXTRA_HOURS;oStaff.STAFF_LOAN = STAFF_LOAN;oStaff.STAFF_REFERENCE = STAFF_REFERENCE;oStaff.STAFF_EXCHANGE_RATE = STAFF_EXCHANGE_RATE;
ExecuteEdit("UPG_EDIT_STAFF", oStaff, "STAFF_ID");
return oStaff.STAFF_ID;
}
public Int32? Edit_Stock ( Int32? STOCK_ID, string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, Int32? STOCK_QUANTITY, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? STOCK_PRICE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Stock oStock = new Stock();
oStock.STOCK_ID = STOCK_ID;oStock.STOCK_DESCRIPTION = STOCK_DESCRIPTION;oStock.STOCK_CATEGORY = STOCK_CATEGORY;oStock.STOCK_SCALE = STOCK_SCALE;oStock.STOCK_QUANTITY = STOCK_QUANTITY;oStock.STOCK_MAIN_PERSON = STOCK_MAIN_PERSON;oStock.STOCK_NOTE = STOCK_NOTE;oStock.STOCK_PRICE = STOCK_PRICE;oStock.ENTRY_USER_ID = ENTRY_USER_ID;oStock.ENTRY_DATE = ENTRY_DATE;oStock.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_STOCK", oStock, "STOCK_ID");
return oStock.STOCK_ID;
}
public Int32? Edit_Supplier ( Int32? SUPPLIER_ID, Int32? COUPONS_ID, Int32? SUPPLIER_PAYMENT_COST, string SUPPLIER_PAYMENT_DATE, Int32? CURRENCY_ID, string SUPPLIER_PAYMENT_CAUSE, Int32? STOCK_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Supplier oSupplier = new Supplier();
oSupplier.SUPPLIER_ID = SUPPLIER_ID;oSupplier.COUPONS_ID = COUPONS_ID;oSupplier.SUPPLIER_PAYMENT_COST = SUPPLIER_PAYMENT_COST;oSupplier.SUPPLIER_PAYMENT_DATE = SUPPLIER_PAYMENT_DATE;oSupplier.CURRENCY_ID = CURRENCY_ID;oSupplier.SUPPLIER_PAYMENT_CAUSE = SUPPLIER_PAYMENT_CAUSE;oSupplier.STOCK_ID = STOCK_ID;oSupplier.ENTRY_USER_ID = ENTRY_USER_ID;oSupplier.ENTRY_DATE = ENTRY_DATE;oSupplier.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_SUPPLIER", oSupplier, "SUPPLIER_ID");
return oSupplier.SUPPLIER_ID;
}
public Int32? Edit_Transaction ( Int32? TRANSACTION_ID, Int32? TRANSACTION_AMOUNT, string TRANSACTION_FROM, string TRANSACTION_TO, string TRANSACTION_DATE, Int32? CURRENCY_ID, string TRANSACTION_NOTES, Int32? STAFF_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Transaction oTransaction = new Transaction();
oTransaction.TRANSACTION_ID = TRANSACTION_ID;oTransaction.TRANSACTION_AMOUNT = TRANSACTION_AMOUNT;oTransaction.TRANSACTION_FROM = TRANSACTION_FROM;oTransaction.TRANSACTION_TO = TRANSACTION_TO;oTransaction.TRANSACTION_DATE = TRANSACTION_DATE;oTransaction.CURRENCY_ID = CURRENCY_ID;oTransaction.TRANSACTION_NOTES = TRANSACTION_NOTES;oTransaction.STAFF_ID = STAFF_ID;oTransaction.ENTRY_USER_ID = ENTRY_USER_ID;oTransaction.ENTRY_DATE = ENTRY_DATE;oTransaction.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_TRANSACTION", oTransaction, "TRANSACTION_ID");
return oTransaction.TRANSACTION_ID;
}
public long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE)
{
User oUser = new User();
oUser.USER_ID = USER_ID;oUser.OWNER_ID = OWNER_ID;oUser.USERNAME = USERNAME;oUser.PASSWORD = PASSWORD;oUser.USER_TYPE_CODE = USER_TYPE_CODE;oUser.IS_ACTIVE = IS_ACTIVE;oUser.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
return oUser.USER_ID;
}
public Int32? Edit_Workshop ( Int32? WORKSHOP_ID, string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? WORKSHOP_TOTAL_M_TONN, Int32? WORKSHOP_SINGLE_PRICE, Int32? CURRENCY_ID, Int32? STOCK_ID, Int32? MACHINE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Workshop oWorkshop = new Workshop();
oWorkshop.WORKSHOP_ID = WORKSHOP_ID;oWorkshop.WORKSHOP_BEGINNING_DATE = WORKSHOP_BEGINNING_DATE;oWorkshop.WORKSHOP_FEES_DESCRIPTION = WORKSHOP_FEES_DESCRIPTION;oWorkshop.WORKSHOP_TOTAL_M_TONN = WORKSHOP_TOTAL_M_TONN;oWorkshop.WORKSHOP_SINGLE_PRICE = WORKSHOP_SINGLE_PRICE;oWorkshop.CURRENCY_ID = CURRENCY_ID;oWorkshop.STOCK_ID = STOCK_ID;oWorkshop.MACHINE_ID = MACHINE_ID;oWorkshop.ENTRY_USER_ID = ENTRY_USER_ID;oWorkshop.ENTRY_DATE = ENTRY_DATE;oWorkshop.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_WORKSHOP", oWorkshop, "WORKSHOP_ID");
return oWorkshop.WORKSHOP_ID;
}
public Int32? Edit_Workshops ( Int32? WORKSHOPS_ID, string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? WORKSHOPS_TOTAL_M_TONN, Int32? WORKSHOPS_SINGLE_PRICE, Int32? CURRENCY_ID, Int32? STOCK_ID, Int32? MACHINE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Workshops oWorkshops = new Workshops();
oWorkshops.WORKSHOPS_ID = WORKSHOPS_ID;oWorkshops.WORKSHOPS_BEGINNING_DATE = WORKSHOPS_BEGINNING_DATE;oWorkshops.WORKSHOPS_FEES_DESCRIPTION = WORKSHOPS_FEES_DESCRIPTION;oWorkshops.WORKSHOPS_TOTAL_M_TONN = WORKSHOPS_TOTAL_M_TONN;oWorkshops.WORKSHOPS_SINGLE_PRICE = WORKSHOPS_SINGLE_PRICE;oWorkshops.CURRENCY_ID = CURRENCY_ID;oWorkshops.STOCK_ID = STOCK_ID;oWorkshops.MACHINE_ID = MACHINE_ID;oWorkshops.ENTRY_USER_ID = ENTRY_USER_ID;oWorkshops.ENTRY_DATE = ENTRY_DATE;oWorkshops.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_WORKSHOPS", oWorkshops, "WORKSHOPS_ID");
return oWorkshops.WORKSHOPS_ID;
}
public List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_DISTINCT_SETUP_TBL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TBL_NAME = GV<String>(X["TBL_NAME"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LAST_VALUE = GV<Int64>(X["LAST_VALUE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_TBL_SETUP ()
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_TBL_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ADDRESS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ADDRESS_ID = GV<Int64>(X["ADDRESS_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.ADDRESS_TYPE_CODE = GV<String>(X["ADDRESS_TYPE_CODE"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.STREET = GV<String>(X["STREET"]);o.BUILDING = GV<String>(X["BUILDING"]);o.FLOOR = GV<String>(X["FLOOR"]);o.POBOX = GV<String>(X["POBOX"]);o.VALID_DATE_START = GV<String>(X["VALID_DATE_START"]);o.VALID_DATE_END = GV<String>(X["VALID_DATE_END"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CONTACT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CONTACT_ID = GV<Int32>(X["CONTACT_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.CONTACT_TYPE_CODE = GV<String>(X["CONTACT_TYPE_CODE"]);o.CONTACT = GV<String>(X["CONTACT"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CONVERSIONS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CONVERSIONS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CONVERSIONS_ID = GV<Int32>(X["CONVERSIONS_ID"]);o.CONVERSIONS_FROM = GV<String>(X["CONVERSIONS_FROM"]);o.CONVERSIONS_FOR = GV<String>(X["CONVERSIONS_FOR"]);o.CONVERSIONS_DATE = GV<String>(X["CONVERSIONS_DATE"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.CONVERSIONS_DESCRIPTION = GV<String>(X["CONVERSIONS_DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_COUPONS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_COUPONS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.COUPONS_ID = GV<Int32>(X["COUPONS_ID"]);o.COUPONS_TYPE = GV<String>(X["COUPONS_TYPE"]);o.COUPONS_DESCRIPTION = GV<String>(X["COUPONS_DESCRIPTION"]);o.COUPONS_QUANTITY = GV<Int32>(X["COUPONS_QUANTITY"]);o.COUPONS_STORE = GV<String>(X["COUPONS_STORE"]);o.COUPONS_DATE = GV<String>(X["COUPONS_DATE"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.COUPONS_PAYMENT_WAITED = GV<String>(X["COUPONS_PAYMENT_WAITED"]);o.COUPONS_PAYMENT_DELIVERED = GV<String>(X["COUPONS_PAYMENT_DELIVERED"]);o.COUPONS_FOR = GV<String>(X["COUPONS_FOR"]);o.COUPONS_NOTE = GV<String>(X["COUPONS_NOTE"]);o.COUPONS_ITEM_TYPE = GV<String>(X["COUPONS_ITEM_TYPE"]);o.COUPONS_ITEM_QUANTITY = GV<String>(X["COUPONS_ITEM_QUANTITY"]);o.COUPONS_MACHINE = GV<String>(X["COUPONS_MACHINE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CURRENCY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CURRENCY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.CURRENCY_TYPE = GV<String>(X["CURRENCY_TYPE"]);o.CURRENCY_SYMBOL = GV<String>(X["CURRENCY_SYMBOL"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_FEES ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_FEES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.FEES_ID = GV<Int32>(X["FEES_ID"]);o.FEES_DATE = GV<String>(X["FEES_DATE"]);o.FEES_DESCRIPTION = GV<String>(X["FEES_DESCRIPTION"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.WORKSHOP_PAYMENT = GV<Int32>(X["WORKSHOP_PAYMENT"]);o.WORKSHOP_PAYMENT_DESCRIPTION = GV<String>(X["WORKSHOP_PAYMENT_DESCRIPTION"]);o.FEES_STATUS = GV<String>(X["FEES_STATUS"]);o.FEES_PAYMENT_GATEWAY = GV<String>(X["FEES_PAYMENT_GATEWAY"]);o.FEES_VALUE_DOLLAR = GV<Int32>(X["FEES_VALUE_DOLLAR"]);o.FEES_FUEL = GV<Int32>(X["FEES_FUEL"]);o.FEES_STORE = GV<String>(X["FEES_STORE"]);o.FEES_TOTAL_DOLLAR = GV<Int32>(X["FEES_TOTAL_DOLLAR"]);o.FEES_TOTAL_LBP = GV<Int32>(X["FEES_TOTAL_LBP"]);o.FEES_TYPE = GV<String>(X["FEES_TYPE"]);o.FEES_DOLLAR_RATE = GV<Int32>(X["FEES_DOLLAR_RATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L1", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L2", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L3", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L4", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_MACHINE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_MACHINE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.MACHINE_ID = GV<Int32>(X["MACHINE_ID"]);o.MACHINE_DATE = GV<String>(X["MACHINE_DATE"]);o.MACHINE_DESCRIPTION = GV<String>(X["MACHINE_DESCRIPTION"]);o.MACHINE_HOURS = GV<Int32>(X["MACHINE_HOURS"]);o.WORKSHOP_ID = GV<Int32>(X["WORKSHOP_ID"]);o.MACHINE_NOTES = GV<String>(X["MACHINE_NOTES"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_METHOD_RUN ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_METHOD_RUN", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.METHOD_RUN_ID = GV<Int64>(X["METHOD_RUN_ID"]);o.METHOD_NAME = GV<String>(X["METHOD_NAME"]);o.RUN_DATE = GV<String>(X["RUN_DATE"]);o.RUN_HOUR = GV<Int32>(X["RUN_HOUR"]);o.RUN_MINUTE = GV<Int32>(X["RUN_MINUTE"]);o.RUN_SECOND = GV<Int32>(X["RUN_SECOND"]);o.IS_CACHED = GV<Boolean>(X["IS_CACHED"]);o.EXECUTION_TIME = GV<Int32>(X["EXECUTION_TIME"]);o.INPUT_PARAM = GV<String>(X["INPUT_PARAM"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OWNER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CODE = GV<String>(X["CODE"]);o.MAINTENANCE_DUE_DATE = GV<String>(X["MAINTENANCE_DUE_DATE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PERSON", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.FATHER_NAME = GV<String>(X["FATHER_NAME"]);o.MOTHER_NAME = GV<String>(X["MOTHER_NAME"]);o.TITLE_CODE = GV<String>(X["TITLE_CODE"]);o.GENDER_CODE = GV<String>(X["GENDER_CODE"]);o.RELIGION_CODE = GV<String>(X["RELIGION_CODE"]);o.BIRTH_DATE = GV<String>(X["BIRTH_DATE"]);o.IS_BLOCKED = GV<Boolean>(X["IS_BLOCKED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_SALARY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_SALARY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SALARY_ID = GV<Int32>(X["SALARY_ID"]);o.STAFF_ID = GV<Int32>(X["STAFF_ID"]);o.SALARY_DATE = GV<String>(X["SALARY_DATE"]);o.SALARY_PAYMENT_VALUE = GV<Int32>(X["SALARY_PAYMENT_VALUE"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_STAFF ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_STAFF", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.STAFF_ID = GV<Int32>(X["STAFF_ID"]);o.STAFF_NAME = GV<String>(X["STAFF_NAME"]);o.STAFF_PAYMENT = GV<Int32>(X["STAFF_PAYMENT"]);o.STAFF_PAYMENT_DESCRIPTION = GV<String>(X["STAFF_PAYMENT_DESCRIPTION"]);o.WORKSHOP_ID = GV<Int32>(X["WORKSHOP_ID"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.STAFF_IS_ACTIVE = GV<Int32>(X["STAFF_IS_ACTIVE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_STOCK ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_STOCK", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.STOCK_ID = GV<Int32>(X["STOCK_ID"]);o.STOCK_DESCRIPTION = GV<String>(X["STOCK_DESCRIPTION"]);o.STOCK_CATEGORY = GV<String>(X["STOCK_CATEGORY"]);o.STOCK_SCALE = GV<String>(X["STOCK_SCALE"]);o.STOCK_QUANTITY = GV<Int32>(X["STOCK_QUANTITY"]);o.STOCK_MAIN_PERSON = GV<String>(X["STOCK_MAIN_PERSON"]);o.STOCK_NOTE = GV<String>(X["STOCK_NOTE"]);o.STOCK_PRICE = GV<Int32>(X["STOCK_PRICE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_SUPPLIER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_SUPPLIER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SUPPLIER_ID = GV<Int32>(X["SUPPLIER_ID"]);o.COUPONS_ID = GV<Int32>(X["COUPONS_ID"]);o.SUPPLIER_PAYMENT_COST = GV<Int32>(X["SUPPLIER_PAYMENT_COST"]);o.SUPPLIER_PAYMENT_DATE = GV<String>(X["SUPPLIER_PAYMENT_DATE"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.SUPPLIER_PAYMENT_CAUSE = GV<String>(X["SUPPLIER_PAYMENT_CAUSE"]);o.STOCK_ID = GV<Int32>(X["STOCK_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_USER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.USER_TYPE_CODE = GV<String>(X["USER_TYPE_CODE"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_WORKSHOP ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_WORKSHOP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.WORKSHOP_ID = GV<Int32>(X["WORKSHOP_ID"]);o.WORKSHOP_BEGINNING_DATE = GV<String>(X["WORKSHOP_BEGINNING_DATE"]);o.WORKSHOP_FEES_DESCRIPTION = GV<String>(X["WORKSHOP_FEES_DESCRIPTION"]);o.WORKSHOP_TOTAL_M_TONN = GV<Int32>(X["WORKSHOP_TOTAL_M_TONN"]);o.WORKSHOP_SINGLE_PRICE = GV<Int32>(X["WORKSHOP_SINGLE_PRICE"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.STOCK_ID = GV<Int32>(X["STOCK_ID"]);o.MACHINE_ID = GV<Int32>(X["MACHINE_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_WORKSHOPS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_WORKSHOPS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.WORKSHOPS_ID = GV<Int32>(X["WORKSHOPS_ID"]);o.WORKSHOPS_BEGINNING_DATE = GV<String>(X["WORKSHOPS_BEGINNING_DATE"]);o.WORKSHOPS_FEES_DESCRIPTION = GV<String>(X["WORKSHOPS_FEES_DESCRIPTION"]);o.WORKSHOPS_TOTAL_M_TONN = GV<Int32>(X["WORKSHOPS_TOTAL_M_TONN"]);o.WORKSHOPS_SINGLE_PRICE = GV<Int32>(X["WORKSHOPS_SINGLE_PRICE"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.STOCK_ID = GV<Int32>(X["STOCK_ID"]);o.MACHINE_ID = GV<Int32>(X["MACHINE_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.EXISTS = EXISTS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHECK_USER_EXISTENCE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
EXISTS = p.EXISTS;
return oList;
}
public List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME; p.ISSYSTEM = ISSYSTEM; p.ISDELETEABLE = ISDELETEABLE; p.ISUPDATEABLE = ISUPDATEABLE; p.ISVISIBLE = ISVISIBLE; p.ISDELETED = ISDELETED; p.DISPLAY_ORDER = DISPLAY_ORDER; p.CODE_VALUE_EN = CODE_VALUE_EN; p.CODE_VALUE_FR = CODE_VALUE_FR; p.CODE_VALUE_AR = CODE_VALUE_AR; p.ENTRY_DATE = ENTRY_DATE; p.ENTRY_USER_ID = ENTRY_USER_ID; p.NOTES = NOTES;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EDIT_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_PARAMETERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.PARAM_NAME = GV<String>(X["PARAM_NAME"]);o.PARAM_TYPE = GV<String>(X["PARAM_TYPE"]);o.IS_OUTPUT = GV<Boolean>(X["IS_OUTPUT"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_RESULT_SCHEMA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.COLUMN_NAME = GV<String>(X["COLUMN_NAME"]);o.COLUMN_TYPE = GV<String>(X["COLUMN_TYPE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.@tableName = @tableName;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GENERATE_INSERT_STATEMENTS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE; p.VALUE = VALUE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
VALUE = p.VALUE;
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.ISDELETED = ISDELETED; p.ISVISIBLE = ISVISIBLE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_CREDENTIALS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
}
}
