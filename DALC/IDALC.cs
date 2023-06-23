using System;
using System.Collections.Generic;
namespace DALC
{
#region Entities
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
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
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
public Person My_Person {get;set;}
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
public Currency My_Currency {get;set;}
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
public Currency My_Currency {get;set;}
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
public Currency My_Currency {get;set;}
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
public Coupons My_Coupons {get;set;}
public Stock My_Stock {get;set;}
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
public Loc_l1 My_Loc_l1 {get;set;}
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
public Loc_l2 My_Loc_l2 {get;set;}
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
public Loc_l3 My_Loc_l3 {get;set;}
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
public Workshop My_Workshop {get;set;}
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
public Staff My_Staff {get;set;}
public Supplier My_Supplier {get;set;}
public Coupons My_Coupons {get;set;}
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
public Staff My_Staff {get;set;}
public Currency My_Currency {get;set;}
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
public Workshop My_Workshop {get;set;}
public Currency My_Currency {get;set;}
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
public Coupons My_Coupons {get;set;}
public Currency My_Currency {get;set;}
public Stock My_Stock {get;set;}
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
public Currency My_Currency {get;set;}
public Staff My_Staff {get;set;}
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
public Currency My_Currency {get;set;}
public Stock My_Stock {get;set;}
public Machine My_Machine {get;set;}
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
public Currency My_Currency {get;set;}
public Stock My_Stock {get;set;}
public Machine My_Machine {get;set;}
}
#endregion 
public partial interface IDALC
{
Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID);
Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID);
Conversions Get_Conversions_By_CONVERSIONS_ID ( Int32? CONVERSIONS_ID);
Coupons Get_Coupons_By_COUPONS_ID ( Int32? COUPONS_ID);
Currency Get_Currency_By_CURRENCY_ID ( Int32? CURRENCY_ID);
Fees Get_Fees_By_FEES_ID ( Int32? FEES_ID);
Industry Get_Industry_By_INDUSTRY_ID ( Int32? INDUSTRY_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID);
Machine Get_Machine_By_MACHINE_ID ( Int32? MACHINE_ID);
Method_run Get_Method_run_By_METHOD_RUN_ID ( long? METHOD_RUN_ID);
Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID);
Person Get_Person_By_PERSON_ID ( long? PERSON_ID);
Productdistribution Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID ( Int32? PRODUCTDISTRIBUTION_ID);
Salary Get_Salary_By_SALARY_ID ( Int32? SALARY_ID);
Staff Get_Staff_By_STAFF_ID ( Int32? STAFF_ID);
Stock Get_Stock_By_STOCK_ID ( Int32? STOCK_ID);
Supplier Get_Supplier_By_SUPPLIER_ID ( Int32? SUPPLIER_ID);
Transaction Get_Transaction_By_TRANSACTION_ID ( Int32? TRANSACTION_ID);
User Get_User_By_USER_ID ( long? USER_ID);
Workshop Get_Workshop_By_WORKSHOP_ID ( Int32? WORKSHOP_ID);
Workshops Get_Workshops_By_WORKSHOPS_ID ( Int32? WORKSHOPS_ID);
Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID);
Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID);
Conversions Get_Conversions_By_CONVERSIONS_ID_Adv ( Int32? CONVERSIONS_ID);
Coupons Get_Coupons_By_COUPONS_ID_Adv ( Int32? COUPONS_ID);
Currency Get_Currency_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
Fees Get_Fees_By_FEES_ID_Adv ( Int32? FEES_ID);
Industry Get_Industry_By_INDUSTRY_ID_Adv ( Int32? INDUSTRY_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
Machine Get_Machine_By_MACHINE_ID_Adv ( Int32? MACHINE_ID);
Method_run Get_Method_run_By_METHOD_RUN_ID_Adv ( long? METHOD_RUN_ID);
Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID);
Productdistribution Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_Adv ( Int32? PRODUCTDISTRIBUTION_ID);
Salary Get_Salary_By_SALARY_ID_Adv ( Int32? SALARY_ID);
Staff Get_Staff_By_STAFF_ID_Adv ( Int32? STAFF_ID);
Stock Get_Stock_By_STOCK_ID_Adv ( Int32? STOCK_ID);
Supplier Get_Supplier_By_SUPPLIER_ID_Adv ( Int32? SUPPLIER_ID);
Transaction Get_Transaction_By_TRANSACTION_ID_Adv ( Int32? TRANSACTION_ID);
User Get_User_By_USER_ID_Adv ( long? USER_ID);
Workshop Get_Workshop_By_WORKSHOP_ID_Adv ( Int32? WORKSHOP_ID);
Workshops Get_Workshops_By_WORKSHOPS_ID_Adv ( Int32? WORKSHOPS_ID);
List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST);
List<Conversions> Get_Conversions_By_CONVERSIONS_ID_List ( List<Int32?> CONVERSIONS_ID_LIST);
List<Coupons> Get_Coupons_By_COUPONS_ID_List ( List<Int32?> COUPONS_ID_LIST);
List<Currency> Get_Currency_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Fees> Get_Fees_By_FEES_ID_List ( List<Int32?> FEES_ID_LIST);
List<Industry> Get_Industry_By_INDUSTRY_ID_List ( List<Int32?> INDUSTRY_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Machine> Get_Machine_By_MACHINE_ID_List ( List<Int32?> MACHINE_ID_LIST);
List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List ( List<long?> METHOD_RUN_ID_LIST);
List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Productdistribution> Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List ( List<Int32?> PRODUCTDISTRIBUTION_ID_LIST);
List<Salary> Get_Salary_By_SALARY_ID_List ( List<Int32?> SALARY_ID_LIST);
List<Staff> Get_Staff_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST);
List<Stock> Get_Stock_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST);
List<Supplier> Get_Supplier_By_SUPPLIER_ID_List ( List<Int32?> SUPPLIER_ID_LIST);
List<Transaction> Get_Transaction_By_TRANSACTION_ID_List ( List<Int32?> TRANSACTION_ID_LIST);
List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Workshop> Get_Workshop_By_WORKSHOP_ID_List ( List<Int32?> WORKSHOP_ID_LIST);
List<Workshops> Get_Workshops_By_WORKSHOPS_ID_List ( List<Int32?> WORKSHOPS_ID_LIST);
List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST);
List<Conversions> Get_Conversions_By_CONVERSIONS_ID_List_Adv ( List<Int32?> CONVERSIONS_ID_LIST);
List<Coupons> Get_Coupons_By_COUPONS_ID_List_Adv ( List<Int32?> COUPONS_ID_LIST);
List<Currency> Get_Currency_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Fees> Get_Fees_By_FEES_ID_List_Adv ( List<Int32?> FEES_ID_LIST);
List<Industry> Get_Industry_By_INDUSTRY_ID_List_Adv ( List<Int32?> INDUSTRY_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Machine> Get_Machine_By_MACHINE_ID_List_Adv ( List<Int32?> MACHINE_ID_LIST);
List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List_Adv ( List<long?> METHOD_RUN_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Productdistribution> Get_Productdistribution_By_PRODUCTDISTRIBUTION_ID_List_Adv ( List<Int32?> PRODUCTDISTRIBUTION_ID_LIST);
List<Salary> Get_Salary_By_SALARY_ID_List_Adv ( List<Int32?> SALARY_ID_LIST);
List<Staff> Get_Staff_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST);
List<Stock> Get_Stock_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST);
List<Supplier> Get_Supplier_By_SUPPLIER_ID_List_Adv ( List<Int32?> SUPPLIER_ID_LIST);
List<Transaction> Get_Transaction_By_TRANSACTION_ID_List_Adv ( List<Int32?> TRANSACTION_ID_LIST);
List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Workshop> Get_Workshop_By_WORKSHOP_ID_List_Adv ( List<Int32?> WORKSHOP_ID_LIST);
List<Workshops> Get_Workshops_By_WORKSHOPS_ID_List_Adv ( List<Int32?> WORKSHOPS_ID_LIST);
List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID);
List<Conversions> Get_Conversions_By_OWNER_ID ( Int32? OWNER_ID);
List<Conversions> Get_Conversions_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Coupons> Get_Coupons_By_OWNER_ID ( Int32? OWNER_ID);
List<Coupons> Get_Coupons_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Currency> Get_Currency_By_OWNER_ID ( Int32? OWNER_ID);
List<Fees> Get_Fees_By_OWNER_ID ( Int32? OWNER_ID);
List<Fees> Get_Fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Industry> Get_Industry_By_OWNER_ID ( Int32? OWNER_ID);
List<Industry> Get_Industry_By_COUPONS_ID ( Int32? COUPONS_ID);
List<Industry> Get_Industry_By_STOCK_ID ( Int32? STOCK_ID);
List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
List<Machine> Get_Machine_By_OWNER_ID ( Int32? OWNER_ID);
List<Machine> Get_Machine_By_WORKSHOP_ID ( Int32? WORKSHOP_ID);
List<Method_run> Get_Method_run_By_OWNER_ID ( Int32? OWNER_ID);
List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID);
List<Productdistribution> Get_Productdistribution_By_OWNER_ID ( Int32? OWNER_ID);
List<Productdistribution> Get_Productdistribution_By_STAFF_ID ( Int32? STAFF_ID);
List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID ( Int32? SUPPLIER_ID);
List<Productdistribution> Get_Productdistribution_By_COUPONS_ID ( Int32? COUPONS_ID);
List<Salary> Get_Salary_By_OWNER_ID ( Int32? OWNER_ID);
List<Salary> Get_Salary_By_STAFF_ID ( Int32? STAFF_ID);
List<Salary> Get_Salary_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Staff> Get_Staff_By_OWNER_ID ( Int32? OWNER_ID);
List<Staff> Get_Staff_By_WORKSHOP_ID ( Int32? WORKSHOP_ID);
List<Staff> Get_Staff_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Stock> Get_Stock_By_OWNER_ID ( Int32? OWNER_ID);
List<Supplier> Get_Supplier_By_OWNER_ID ( Int32? OWNER_ID);
List<Supplier> Get_Supplier_By_COUPONS_ID ( Int32? COUPONS_ID);
List<Supplier> Get_Supplier_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Supplier> Get_Supplier_By_STOCK_ID ( Int32? STOCK_ID);
List<Transaction> Get_Transaction_By_OWNER_ID ( Int32? OWNER_ID);
List<Transaction> Get_Transaction_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Transaction> Get_Transaction_By_STAFF_ID ( Int32? STAFF_ID);
List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME ( string USERNAME);
List<Workshop> Get_Workshop_By_OWNER_ID ( Int32? OWNER_ID);
List<Workshop> Get_Workshop_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Workshop> Get_Workshop_By_STOCK_ID ( Int32? STOCK_ID);
List<Workshop> Get_Workshop_By_MACHINE_ID ( Int32? MACHINE_ID);
List<Workshops> Get_Workshops_By_OWNER_ID ( Int32? OWNER_ID);
List<Workshops> Get_Workshops_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Workshops> Get_Workshops_By_STOCK_ID ( Int32? STOCK_ID);
List<Workshops> Get_Workshops_By_MACHINE_ID ( Int32? MACHINE_ID);
List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Conversions> Get_Conversions_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Conversions> Get_Conversions_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Coupons> Get_Coupons_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Coupons> Get_Coupons_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Currency> Get_Currency_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Fees> Get_Fees_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Fees> Get_Fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Industry> Get_Industry_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Industry> Get_Industry_By_COUPONS_ID_Adv ( Int32? COUPONS_ID);
List<Industry> Get_Industry_By_STOCK_ID_Adv ( Int32? STOCK_ID);
List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Machine> Get_Machine_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Machine> Get_Machine_By_WORKSHOP_ID_Adv ( Int32? WORKSHOP_ID);
List<Method_run> Get_Method_run_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Productdistribution> Get_Productdistribution_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Productdistribution> Get_Productdistribution_By_STAFF_ID_Adv ( Int32? STAFF_ID);
List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID_Adv ( Int32? SUPPLIER_ID);
List<Productdistribution> Get_Productdistribution_By_COUPONS_ID_Adv ( Int32? COUPONS_ID);
List<Salary> Get_Salary_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Salary> Get_Salary_By_STAFF_ID_Adv ( Int32? STAFF_ID);
List<Salary> Get_Salary_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Staff> Get_Staff_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Staff> Get_Staff_By_WORKSHOP_ID_Adv ( Int32? WORKSHOP_ID);
List<Staff> Get_Staff_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Stock> Get_Stock_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Supplier> Get_Supplier_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Supplier> Get_Supplier_By_COUPONS_ID_Adv ( Int32? COUPONS_ID);
List<Supplier> Get_Supplier_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Supplier> Get_Supplier_By_STOCK_ID_Adv ( Int32? STOCK_ID);
List<Transaction> Get_Transaction_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Transaction> Get_Transaction_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Transaction> Get_Transaction_By_STAFF_ID_Adv ( Int32? STAFF_ID);
List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME_Adv ( string USERNAME);
List<Workshop> Get_Workshop_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Workshop> Get_Workshop_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Workshop> Get_Workshop_By_STOCK_ID_Adv ( Int32? STOCK_ID);
List<Workshop> Get_Workshop_By_MACHINE_ID_Adv ( Int32? MACHINE_ID);
List<Workshops> Get_Workshops_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Workshops> Get_Workshops_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Workshops> Get_Workshops_By_STOCK_ID_Adv ( Int32? STOCK_ID);
List<Workshops> Get_Workshops_By_MACHINE_ID_Adv ( Int32? MACHINE_ID);
List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Conversions> Get_Conversions_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Coupons> Get_Coupons_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Fees> Get_Fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Industry> Get_Industry_By_COUPONS_ID_List ( List<Int32?> COUPONS_ID_LIST);
List<Industry> Get_Industry_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Machine> Get_Machine_By_WORKSHOP_ID_List ( List<Int32?> WORKSHOP_ID_LIST);
List<Productdistribution> Get_Productdistribution_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST);
List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID_List ( List<Int32?> SUPPLIER_ID_LIST);
List<Productdistribution> Get_Productdistribution_By_COUPONS_ID_List ( List<Int32?> COUPONS_ID_LIST);
List<Salary> Get_Salary_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST);
List<Salary> Get_Salary_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Staff> Get_Staff_By_WORKSHOP_ID_List ( List<Int32?> WORKSHOP_ID_LIST);
List<Staff> Get_Staff_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Supplier> Get_Supplier_By_COUPONS_ID_List ( List<Int32?> COUPONS_ID_LIST);
List<Supplier> Get_Supplier_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Supplier> Get_Supplier_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST);
List<Transaction> Get_Transaction_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Transaction> Get_Transaction_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST);
List<Workshop> Get_Workshop_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Workshop> Get_Workshop_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST);
List<Workshop> Get_Workshop_By_MACHINE_ID_List ( List<Int32?> MACHINE_ID_LIST);
List<Workshops> Get_Workshops_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Workshops> Get_Workshops_By_STOCK_ID_List ( List<Int32?> STOCK_ID_LIST);
List<Workshops> Get_Workshops_By_MACHINE_ID_List ( List<Int32?> MACHINE_ID_LIST);
List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Conversions> Get_Conversions_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Coupons> Get_Coupons_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Fees> Get_Fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Industry> Get_Industry_By_COUPONS_ID_List_Adv ( List<Int32?> COUPONS_ID_LIST);
List<Industry> Get_Industry_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Machine> Get_Machine_By_WORKSHOP_ID_List_Adv ( List<Int32?> WORKSHOP_ID_LIST);
List<Productdistribution> Get_Productdistribution_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST);
List<Productdistribution> Get_Productdistribution_By_SUPPLIER_ID_List_Adv ( List<Int32?> SUPPLIER_ID_LIST);
List<Productdistribution> Get_Productdistribution_By_COUPONS_ID_List_Adv ( List<Int32?> COUPONS_ID_LIST);
List<Salary> Get_Salary_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST);
List<Salary> Get_Salary_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Staff> Get_Staff_By_WORKSHOP_ID_List_Adv ( List<Int32?> WORKSHOP_ID_LIST);
List<Staff> Get_Staff_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Supplier> Get_Supplier_By_COUPONS_ID_List_Adv ( List<Int32?> COUPONS_ID_LIST);
List<Supplier> Get_Supplier_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Supplier> Get_Supplier_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST);
List<Transaction> Get_Transaction_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Transaction> Get_Transaction_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST);
List<Workshop> Get_Workshop_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Workshop> Get_Workshop_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST);
List<Workshop> Get_Workshop_By_MACHINE_ID_List_Adv ( List<Int32?> MACHINE_ID_LIST);
List<Workshops> Get_Workshops_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Workshops> Get_Workshops_By_STOCK_ID_List_Adv ( List<Int32?> STOCK_ID_LIST);
List<Workshops> Get_Workshops_By_MACHINE_ID_List_Adv ( List<Int32?> MACHINE_ID_LIST);
List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Criteria ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Where ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Criteria_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Where_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Criteria ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Where ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Criteria_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Where_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Criteria ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Where ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Criteria ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Where ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Criteria_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Where_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Criteria ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Where ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Criteria_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Where_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Criteria_V2 ( string SALARY_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Where_V2 ( string SALARY_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Stock> Get_Stock_By_Criteria ( string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Stock> Get_Stock_By_Where ( string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria ( string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where ( string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Criteria ( string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Where ( string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Criteria_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Where_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Criteria ( string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Where ( string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Criteria_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Where_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Criteria_Adv ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Where_Adv ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Criteria_Adv_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Where_Adv_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Criteria_Adv ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Where_Adv ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Criteria_Adv_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Where_Adv_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Criteria_Adv ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Where_Adv ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_Adv ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_Adv ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_Adv_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_Adv_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Criteria_Adv ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Where_Adv ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Criteria_Adv_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Where_Adv_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Criteria_Adv ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Where_Adv ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Criteria_Adv_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Where_Adv_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Criteria_Adv_V2 ( string SALARY_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Where_Adv_V2 ( string SALARY_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_Adv ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_Adv ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Stock> Get_Stock_By_Criteria_Adv ( string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Stock> Get_Stock_By_Where_Adv ( string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_Adv ( string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_Adv ( string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_Adv_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_Adv_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Criteria_Adv ( string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Where_Adv ( string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Criteria_Adv_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Where_Adv_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Criteria_Adv ( string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Where_Adv ( string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Criteria_Adv_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Where_Adv_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Criteria_InList ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Where_InList ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Criteria_InList_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Where_InList_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Criteria_InList ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Where_InList ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Criteria_InList_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Where_InList_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_InList ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_InList ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_InList_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_InList_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Criteria_InList ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Where_InList ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Criteria_InList_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Where_InList_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Criteria_InList ( string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Where_InList ( string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Criteria_InList_V2 ( string SALARY_DATE, string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Where_InList_V2 ( string SALARY_DATE, string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_InList ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, List<Int32?> WORKSHOP_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_InList ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, List<Int32?> WORKSHOP_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_InList ( string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_InList ( string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_InList_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_InList_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Criteria_InList ( string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Where_InList ( string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Criteria_InList_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Where_InList_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Criteria_InList ( string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Where_InList ( string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Criteria_InList_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Where_InList_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Criteria_InList_Adv ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Where_InList_Adv ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Criteria_InList_Adv_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Conversions> Get_Conversions_By_Where_InList_Adv_V2 ( string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, string CONVERSIONS_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Criteria_InList_Adv ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Where_InList_Adv ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Criteria_InList_Adv_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coupons> Get_Coupons_By_Where_InList_Adv_V2 ( string COUPONS_TYPE, string COUPONS_DESCRIPTION, string COUPONS_STORE, string COUPONS_DATE, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_InList_Adv ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_InList_Adv ( string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_InList_Adv_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_InList_Adv_V2 ( string FEES_DATE, string FEES_DESCRIPTION, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, string FEES_STORE, string FEES_TYPE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Criteria_InList_Adv ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Where_InList_Adv ( string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Criteria_InList_Adv_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Machine> Get_Machine_By_Where_InList_Adv_V2 ( string MACHINE_DATE, string MACHINE_DESCRIPTION, string MACHINE_NOTES, List<Int32?> WORKSHOP_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Criteria_InList_Adv_V2 ( string SALARY_DATE, string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Salary> Get_Salary_By_Where_InList_Adv_V2 ( string SALARY_DATE, string DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_InList_Adv ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, List<Int32?> WORKSHOP_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_InList_Adv ( string STAFF_NAME, string STAFF_PAYMENT_DESCRIPTION, string STAFF_REFERENCE, List<Int32?> WORKSHOP_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_InList_Adv ( string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_InList_Adv ( string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_InList_Adv_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_InList_Adv_V2 ( string SUPPLIER_PAYMENT_DATE, string SUPPLIER_PAYMENT_CAUSE, List<Int32?> COUPONS_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Criteria_InList_Adv ( string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Where_InList_Adv ( string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Criteria_InList_Adv_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshop> Get_Workshop_By_Where_InList_Adv_V2 ( string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Criteria_InList_Adv ( string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Where_InList_Adv ( string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Criteria_InList_Adv_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Workshops> Get_Workshops_By_Where_InList_Adv_V2 ( string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, List<Int32?> STOCK_ID_LIST, List<Int32?> MACHINE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
void Delete_Address ( long? ADDRESS_ID);
void Delete_Contact ( Int32? CONTACT_ID);
void Delete_Conversions ( Int32? CONVERSIONS_ID);
void Delete_Coupons ( Int32? COUPONS_ID);
void Delete_Currency ( Int32? CURRENCY_ID);
void Delete_Fees ( Int32? FEES_ID);
void Delete_Industry ( Int32? INDUSTRY_ID);
void Delete_Loc_l1 ( long? LOC_L1_ID);
void Delete_Loc_l2 ( long? LOC_L2_ID);
void Delete_Loc_l3 ( long? LOC_L3_ID);
void Delete_Loc_l4 ( long? LOC_L4_ID);
void Delete_Machine ( Int32? MACHINE_ID);
void Delete_Method_run ( long? METHOD_RUN_ID);
void Delete_Owner ( Int32? OWNER_ID);
void Delete_Person ( long? PERSON_ID);
void Delete_Productdistribution ( Int32? PRODUCTDISTRIBUTION_ID);
void Delete_Salary ( Int32? SALARY_ID);
void Delete_Staff ( Int32? STAFF_ID);
void Delete_Stock ( Int32? STOCK_ID);
void Delete_Supplier ( Int32? SUPPLIER_ID);
void Delete_Transaction ( Int32? TRANSACTION_ID);
void Delete_User ( long? USER_ID);
void Delete_Workshop ( Int32? WORKSHOP_ID);
void Delete_Workshops ( Int32? WORKSHOPS_ID);
void Delete_Address_By_PERSON_ID ( long? PERSON_ID);
void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
void Delete_Contact_By_PERSON_ID ( long? PERSON_ID);
void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Conversions_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Conversions_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Coupons_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Coupons_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Currency_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Fees_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Industry_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Industry_By_COUPONS_ID ( Int32? COUPONS_ID);
void Delete_Industry_By_STOCK_ID ( Int32? STOCK_ID);
void Delete_Loc_l1_By_CODE ( string CODE);
void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Machine_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Machine_By_WORKSHOP_ID ( Int32? WORKSHOP_ID);
void Delete_Method_run_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Productdistribution_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Productdistribution_By_STAFF_ID ( Int32? STAFF_ID);
void Delete_Productdistribution_By_SUPPLIER_ID ( Int32? SUPPLIER_ID);
void Delete_Productdistribution_By_COUPONS_ID ( Int32? COUPONS_ID);
void Delete_Salary_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Salary_By_STAFF_ID ( Int32? STAFF_ID);
void Delete_Salary_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Staff_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Staff_By_WORKSHOP_ID ( Int32? WORKSHOP_ID);
void Delete_Staff_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Stock_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Supplier_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Supplier_By_COUPONS_ID ( Int32? COUPONS_ID);
void Delete_Supplier_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Supplier_By_STOCK_ID ( Int32? STOCK_ID);
void Delete_Transaction_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Transaction_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Transaction_By_STAFF_ID ( Int32? STAFF_ID);
void Delete_User_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_By_USERNAME ( string USERNAME);
void Delete_Workshop_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Workshop_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Workshop_By_STOCK_ID ( Int32? STOCK_ID);
void Delete_Workshop_By_MACHINE_ID ( Int32? MACHINE_ID);
void Delete_Workshops_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Workshops_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Workshops_By_STOCK_ID ( Int32? STOCK_ID);
void Delete_Workshops_By_MACHINE_ID ( Int32? MACHINE_ID);
long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Conversions ( Int32? CONVERSIONS_ID, string CONVERSIONS_FROM, string CONVERSIONS_FOR, string CONVERSIONS_DATE, Int32? CURRENCY_ID, string CONVERSIONS_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Coupons ( Int32? COUPONS_ID, string COUPONS_TYPE, string COUPONS_DESCRIPTION, Int32? COUPONS_QUANTITY, string COUPONS_STORE, string COUPONS_DATE, Int32? CURRENCY_ID, string COUPONS_PAYMENT_WAITED, string COUPONS_PAYMENT_DELIVERED, string COUPONS_FOR, string COUPONS_NOTE, string COUPONS_ITEM_TYPE, string COUPONS_ITEM_QUANTITY, string COUPONS_MACHINE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Currency ( Int32? CURRENCY_ID, string CURRENCY_TYPE, string CURRENCY_SYMBOL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Fees ( Int32? FEES_ID, string FEES_DATE, string FEES_DESCRIPTION, Int32? CURRENCY_ID, Int32? WORKSHOP_PAYMENT, string WORKSHOP_PAYMENT_DESCRIPTION, string FEES_STATUS, string FEES_PAYMENT_GATEWAY, Int32? FEES_VALUE_DOLLAR, Int32? FEES_FUEL, string FEES_STORE, Int32? FEES_TOTAL_DOLLAR, Int32? FEES_TOTAL_LBP, string FEES_TYPE, Int32? FEES_DOLLAR_RATE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Industry ( Int32? INDUSTRY_ID, string INDUSTRY_PRODUCT_NAME, Int32? INDUSTRY_PRODUCT_QUANTITY, string INDUSTRY_PRODUCT_DATE, Int32? COUPONS_ID, Int32? STOCK_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Machine ( Int32? MACHINE_ID, string MACHINE_DATE, string MACHINE_DESCRIPTION, Int32? MACHINE_HOURS, Int32? WORKSHOP_ID, string MACHINE_NOTES, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Method_run ( long? METHOD_RUN_ID, string METHOD_NAME, string RUN_DATE, Int32? RUN_HOUR, Int32? RUN_MINUTE, Int32? RUN_SECOND, bool? IS_CACHED, Int32? EXECUTION_TIME, string INPUT_PARAM, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE);
long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE);
Int32? Edit_Productdistribution ( Int32? PRODUCTDISTRIBUTION_ID, string PRODUCTDISTRIBUTION_TYPE, Int32? PRODUCTDISTRIBUTION_QTY, string PRODUCTDISTRIBUTION_DATE, Int32? STAFF_ID, Int32? SUPPLIER_ID, Int32? COUPONS_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Salary ( Int32? SALARY_ID, Int32? STAFF_ID, string SALARY_DATE, Int32? SALARY_PAYMENT_VALUE, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
Int32? Edit_Staff ( Int32? STAFF_ID, string STAFF_NAME, Int32? STAFF_PAYMENT, string STAFF_PAYMENT_DESCRIPTION, Int32? WORKSHOP_ID, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? STAFF_IS_ACTIVE, Int32? STAFF_WORKING_DAYS, Int32? STAFF_EXTRA_HOURS, Int32? STAFF_LOAN, string STAFF_REFERENCE, decimal? STAFF_EXCHANGE_RATE);
Int32? Edit_Stock ( Int32? STOCK_ID, string STOCK_DESCRIPTION, string STOCK_CATEGORY, string STOCK_SCALE, Int32? STOCK_QUANTITY, string STOCK_MAIN_PERSON, string STOCK_NOTE, Int32? STOCK_PRICE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Supplier ( Int32? SUPPLIER_ID, Int32? COUPONS_ID, Int32? SUPPLIER_PAYMENT_COST, string SUPPLIER_PAYMENT_DATE, Int32? CURRENCY_ID, string SUPPLIER_PAYMENT_CAUSE, Int32? STOCK_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Transaction ( Int32? TRANSACTION_ID, Int32? TRANSACTION_AMOUNT, string TRANSACTION_FROM, string TRANSACTION_TO, string TRANSACTION_DATE, Int32? CURRENCY_ID, string TRANSACTION_NOTES, Int32? STAFF_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE);
Int32? Edit_Workshop ( Int32? WORKSHOP_ID, string WORKSHOP_BEGINNING_DATE, string WORKSHOP_FEES_DESCRIPTION, Int32? WORKSHOP_TOTAL_M_TONN, Int32? WORKSHOP_SINGLE_PRICE, Int32? CURRENCY_ID, Int32? STOCK_ID, Int32? MACHINE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Workshops ( Int32? WORKSHOPS_ID, string WORKSHOPS_BEGINNING_DATE, string WORKSHOPS_FEES_DESCRIPTION, Int32? WORKSHOPS_TOTAL_M_TONN, Int32? WORKSHOPS_SINGLE_PRICE, Int32? CURRENCY_ID, Int32? STOCK_ID, Int32? MACHINE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID);
List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE);
List<dynamic> GET_TBL_SETUP ();
List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CONVERSIONS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_COUPONS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CURRENCY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_FEES ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_MACHINE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_METHOD_RUN ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SALARY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_STAFF ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_STOCK ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SUPPLIER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_WORKSHOP ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_WORKSHOPS ( string JSON_CONTENT);
List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS);
List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES);
List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME);
List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME);
List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName);
List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE);
List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE);
List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME);
List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD);
}
}
