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
#region Address
public partial class Address
{
#region Advanced Properties
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
#endregion
}
#endregion
#region Contact
public partial class Contact
{
#region Advanced Properties
public Person My_Person {get;set;}
#endregion
}
#endregion
#region Conversions
public partial class Conversions
{
#region Advanced Properties
public Currency My_Currency {get;set;}
#endregion
}
#endregion
#region Coupons
public partial class Coupons
{
#region Advanced Properties
public Currency My_Currency {get;set;}
#endregion
}
#endregion
#region Currency
public partial class Currency
{
#region Advanced Properties
#endregion
}
#endregion
#region Fees
public partial class Fees
{
#region Advanced Properties
public Currency My_Currency {get;set;}
#endregion
}
#endregion
#region Industry
public partial class Industry
{
#region Advanced Properties
public Coupons My_Coupons {get;set;}
public Stock My_Stock {get;set;}
#endregion
}
#endregion
#region Loc_l1
public partial class Loc_l1
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l2
public partial class Loc_l2
{
#region Advanced Properties
public Loc_l1 My_Loc_l1 {get;set;}
#endregion
}
#endregion
#region Loc_l3
public partial class Loc_l3
{
#region Advanced Properties
public Loc_l2 My_Loc_l2 {get;set;}
#endregion
}
#endregion
#region Loc_l4
public partial class Loc_l4
{
#region Advanced Properties
public Loc_l3 My_Loc_l3 {get;set;}
#endregion
}
#endregion
#region Machine
public partial class Machine
{
#region Advanced Properties
public Workshop My_Workshop {get;set;}
#endregion
}
#endregion
#region Method_run
public partial class Method_run
{
#region Advanced Properties
#endregion
}
#endregion
#region Owner
public partial class Owner
{
#region Advanced Properties
#endregion
}
#endregion
#region Person
public partial class Person
{
#region Advanced Properties
#endregion
}
#endregion
#region Productdistribution
public partial class Productdistribution
{
#region Advanced Properties
public Staff My_Staff {get;set;}
public Supplier My_Supplier {get;set;}
public Coupons My_Coupons {get;set;}
#endregion
}
#endregion
#region Salary
public partial class Salary
{
#region Advanced Properties
public Staff My_Staff {get;set;}
public Currency My_Currency {get;set;}
#endregion
}
#endregion
#region Staff
public partial class Staff
{
#region Advanced Properties
public Workshop My_Workshop {get;set;}
public Currency My_Currency {get;set;}
#endregion
}
#endregion
#region Stock
public partial class Stock
{
#region Advanced Properties
#endregion
}
#endregion
#region Supplier
public partial class Supplier
{
#region Advanced Properties
public Coupons My_Coupons {get;set;}
public Currency My_Currency {get;set;}
public Stock My_Stock {get;set;}
#endregion
}
#endregion
#region Transaction
public partial class Transaction
{
#region Advanced Properties
public Currency My_Currency {get;set;}
public Staff My_Staff {get;set;}
#endregion
}
#endregion
#region User
public partial class User
{
#region Advanced Properties
#endregion
}
#endregion
#region Workshop
public partial class Workshop
{
#region Advanced Properties
public Currency My_Currency {get;set;}
public Stock My_Stock {get;set;}
public Machine My_Machine {get;set;}
#endregion
}
#endregion
#region Workshops
public partial class Workshops
{
#region Advanced Properties
public Currency My_Currency {get;set;}
public Stock My_Stock {get;set;}
public Machine My_Machine {get;set;}
#endregion
}
#endregion
}
