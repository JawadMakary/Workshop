using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ConfigurationManager = System.Configuration.ConfigurationManager;
using BLC;
[Route("api/[controller]")]
[ApiController]
public partial class DataController : ControllerBase
{
#region Members
#endregion
#region Extract_Ticket
private string Extract_Ticket()
{
#region Declaration And Initialization Section.
string str_Ticket = string.Empty;
#endregion
if(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null)
{
str_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
#region Return Section.
return str_Ticket;
#endregion
}
#endregion
#region IsValidWebTicket
private bool IsValidWebTicket(string i_Input)
{
#region Declaration And Initialization Section.
bool Is_Valid = false;
BLCInitializer oBLCInitializer = new BLCInitializer();
#endregion
#region Body Section.
BLC.BLC oBLC_Default = new BLC.BLC();
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
Is_Valid = oBLC.IsValidTicket(i_Input);
}
#endregion
#region Return Section.
return Is_Valid;
#endregion
}
#endregion
#region Edit_Address
[HttpPost]
[Route("Edit_Address")]
public Result_Edit_Address Edit_Address(Address i_Address)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Address oResult_Edit_Address = new Result_Edit_Address();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Address(i_Address);
oResult_Edit_Address.My_Address = i_Address;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Address.ExceptionMsg = string.Format("Edit_Address : {0}", ex.Message);
}
else
{
oResult_Edit_Address.ExceptionMsg = ex.Message;
oResult_Edit_Address.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Address;
#endregion
}
#endregion
#region Edit_Coupons
[HttpPost]
[Route("Edit_Coupons")]
public Result_Edit_Coupons Edit_Coupons(Coupons i_Coupons)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Coupons oResult_Edit_Coupons = new Result_Edit_Coupons();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Coupons(i_Coupons);
oResult_Edit_Coupons.My_Coupons = i_Coupons;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Coupons.ExceptionMsg = string.Format("Edit_Coupons : {0}", ex.Message);
}
else
{
oResult_Edit_Coupons.ExceptionMsg = ex.Message;
oResult_Edit_Coupons.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Coupons;
#endregion
}
#endregion
#region Edit_Currency
[HttpPost]
[Route("Edit_Currency")]
public Result_Edit_Currency Edit_Currency(Currency i_Currency)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Currency oResult_Edit_Currency = new Result_Edit_Currency();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Currency(i_Currency);
oResult_Edit_Currency.My_Currency = i_Currency;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Currency.ExceptionMsg = string.Format("Edit_Currency : {0}", ex.Message);
}
else
{
oResult_Edit_Currency.ExceptionMsg = ex.Message;
oResult_Edit_Currency.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Currency;
#endregion
}
#endregion
#region Edit_Industry
[HttpPost]
[Route("Edit_Industry")]
public Result_Edit_Industry Edit_Industry(Industry i_Industry)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Industry oResult_Edit_Industry = new Result_Edit_Industry();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Industry(i_Industry);
oResult_Edit_Industry.My_Industry = i_Industry;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Industry.ExceptionMsg = string.Format("Edit_Industry : {0}", ex.Message);
}
else
{
oResult_Edit_Industry.ExceptionMsg = ex.Message;
oResult_Edit_Industry.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Industry;
#endregion
}
#endregion
#region Edit_Machine
[HttpPost]
[Route("Edit_Machine")]
public Result_Edit_Machine Edit_Machine(Machine i_Machine)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Machine oResult_Edit_Machine = new Result_Edit_Machine();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Machine(i_Machine);
oResult_Edit_Machine.My_Machine = i_Machine;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Machine.ExceptionMsg = string.Format("Edit_Machine : {0}", ex.Message);
}
else
{
oResult_Edit_Machine.ExceptionMsg = ex.Message;
oResult_Edit_Machine.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Machine;
#endregion
}
#endregion
#region Edit_Productdistribution
[HttpPost]
[Route("Edit_Productdistribution")]
public Result_Edit_Productdistribution Edit_Productdistribution(Productdistribution i_Productdistribution)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Productdistribution oResult_Edit_Productdistribution = new Result_Edit_Productdistribution();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Productdistribution(i_Productdistribution);
oResult_Edit_Productdistribution.My_Productdistribution = i_Productdistribution;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Productdistribution.ExceptionMsg = string.Format("Edit_Productdistribution : {0}", ex.Message);
}
else
{
oResult_Edit_Productdistribution.ExceptionMsg = ex.Message;
oResult_Edit_Productdistribution.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Productdistribution;
#endregion
}
#endregion
#region Edit_Staff
[HttpPost]
[Route("Edit_Staff")]
public Result_Edit_Staff Edit_Staff(Staff i_Staff)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Staff oResult_Edit_Staff = new Result_Edit_Staff();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Staff(i_Staff);
oResult_Edit_Staff.My_Staff = i_Staff;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Staff.ExceptionMsg = string.Format("Edit_Staff : {0}", ex.Message);
}
else
{
oResult_Edit_Staff.ExceptionMsg = ex.Message;
oResult_Edit_Staff.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Staff;
#endregion
}
#endregion
#region Edit_Stock
[HttpPost]
[Route("Edit_Stock")]
public Result_Edit_Stock Edit_Stock(Stock i_Stock)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Stock oResult_Edit_Stock = new Result_Edit_Stock();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Stock(i_Stock);
oResult_Edit_Stock.My_Stock = i_Stock;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Stock.ExceptionMsg = string.Format("Edit_Stock : {0}", ex.Message);
}
else
{
oResult_Edit_Stock.ExceptionMsg = ex.Message;
oResult_Edit_Stock.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Stock;
#endregion
}
#endregion
#region Edit_Transaction
[HttpPost]
[Route("Edit_Transaction")]
public Result_Edit_Transaction Edit_Transaction(Transaction i_Transaction)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Transaction oResult_Edit_Transaction = new Result_Edit_Transaction();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Transaction(i_Transaction);
oResult_Edit_Transaction.My_Transaction = i_Transaction;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Transaction.ExceptionMsg = string.Format("Edit_Transaction : {0}", ex.Message);
}
else
{
oResult_Edit_Transaction.ExceptionMsg = ex.Message;
oResult_Edit_Transaction.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Transaction;
#endregion
}
#endregion
#region Edit_Workshop
[HttpPost]
[Route("Edit_Workshop")]
public Result_Edit_Workshop Edit_Workshop(Workshop i_Workshop)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Workshop oResult_Edit_Workshop = new Result_Edit_Workshop();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Workshop(i_Workshop);
oResult_Edit_Workshop.My_Workshop = i_Workshop;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Workshop.ExceptionMsg = string.Format("Edit_Workshop : {0}", ex.Message);
}
else
{
oResult_Edit_Workshop.ExceptionMsg = ex.Message;
oResult_Edit_Workshop.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Workshop;
#endregion
}
#endregion
#region Get_Address_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Address_By_OWNER_ID_Adv")]
public Result_Get_Address_By_OWNER_ID_Adv Get_Address_By_OWNER_ID_Adv(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Address>  oReturnValue = new List<Address> ();
string i_Ticket = string.Empty;
Result_Get_Address_By_OWNER_ID_Adv oResult_Get_Address_By_OWNER_ID_Adv = new Result_Get_Address_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Address_By_OWNER_ID_Adv(i_Params_Get_Address_By_OWNER_ID);
oResult_Get_Address_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Address_By_OWNER_ID_Adv.My_Params_Get_Address_By_OWNER_ID = i_Params_Get_Address_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Address_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Address_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Address_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Address_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Address_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Coupons_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Coupons_By_OWNER_ID_Adv")]
public Result_Get_Coupons_By_OWNER_ID_Adv Get_Coupons_By_OWNER_ID_Adv(Params_Get_Coupons_By_OWNER_ID i_Params_Get_Coupons_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Coupons>  oReturnValue = new List<Coupons> ();
string i_Ticket = string.Empty;
Result_Get_Coupons_By_OWNER_ID_Adv oResult_Get_Coupons_By_OWNER_ID_Adv = new Result_Get_Coupons_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Coupons_By_OWNER_ID_Adv(i_Params_Get_Coupons_By_OWNER_ID);
oResult_Get_Coupons_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Coupons_By_OWNER_ID_Adv.My_Params_Get_Coupons_By_OWNER_ID = i_Params_Get_Coupons_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Coupons_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Coupons_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Coupons_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Coupons_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Coupons_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Currency_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Currency_By_OWNER_ID_Adv")]
public Result_Get_Currency_By_OWNER_ID_Adv Get_Currency_By_OWNER_ID_Adv(Params_Get_Currency_By_OWNER_ID i_Params_Get_Currency_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Currency>  oReturnValue = new List<Currency> ();
string i_Ticket = string.Empty;
Result_Get_Currency_By_OWNER_ID_Adv oResult_Get_Currency_By_OWNER_ID_Adv = new Result_Get_Currency_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Currency_By_OWNER_ID_Adv(i_Params_Get_Currency_By_OWNER_ID);
oResult_Get_Currency_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Currency_By_OWNER_ID_Adv.My_Params_Get_Currency_By_OWNER_ID = i_Params_Get_Currency_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Currency_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Currency_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Currency_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Currency_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Currency_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Industry_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Industry_By_OWNER_ID_Adv")]
public Result_Get_Industry_By_OWNER_ID_Adv Get_Industry_By_OWNER_ID_Adv(Params_Get_Industry_By_OWNER_ID i_Params_Get_Industry_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Industry>  oReturnValue = new List<Industry> ();
string i_Ticket = string.Empty;
Result_Get_Industry_By_OWNER_ID_Adv oResult_Get_Industry_By_OWNER_ID_Adv = new Result_Get_Industry_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Industry_By_OWNER_ID_Adv(i_Params_Get_Industry_By_OWNER_ID);
oResult_Get_Industry_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Industry_By_OWNER_ID_Adv.My_Params_Get_Industry_By_OWNER_ID = i_Params_Get_Industry_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Industry_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Industry_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Industry_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Industry_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Industry_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Machine_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Machine_By_OWNER_ID_Adv")]
public Result_Get_Machine_By_OWNER_ID_Adv Get_Machine_By_OWNER_ID_Adv(Params_Get_Machine_By_OWNER_ID i_Params_Get_Machine_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Machine>  oReturnValue = new List<Machine> ();
string i_Ticket = string.Empty;
Result_Get_Machine_By_OWNER_ID_Adv oResult_Get_Machine_By_OWNER_ID_Adv = new Result_Get_Machine_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Machine_By_OWNER_ID_Adv(i_Params_Get_Machine_By_OWNER_ID);
oResult_Get_Machine_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Machine_By_OWNER_ID_Adv.My_Params_Get_Machine_By_OWNER_ID = i_Params_Get_Machine_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Machine_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Machine_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Machine_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Machine_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Machine_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Productdistribution_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Productdistribution_By_OWNER_ID_Adv")]
public Result_Get_Productdistribution_By_OWNER_ID_Adv Get_Productdistribution_By_OWNER_ID_Adv(Params_Get_Productdistribution_By_OWNER_ID i_Params_Get_Productdistribution_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Productdistribution>  oReturnValue = new List<Productdistribution> ();
string i_Ticket = string.Empty;
Result_Get_Productdistribution_By_OWNER_ID_Adv oResult_Get_Productdistribution_By_OWNER_ID_Adv = new Result_Get_Productdistribution_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Productdistribution_By_OWNER_ID_Adv(i_Params_Get_Productdistribution_By_OWNER_ID);
oResult_Get_Productdistribution_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Productdistribution_By_OWNER_ID_Adv.My_Params_Get_Productdistribution_By_OWNER_ID = i_Params_Get_Productdistribution_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Productdistribution_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Productdistribution_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Productdistribution_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Productdistribution_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Productdistribution_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Salary_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Salary_By_OWNER_ID_Adv")]
public Result_Get_Salary_By_OWNER_ID_Adv Get_Salary_By_OWNER_ID_Adv(Params_Get_Salary_By_OWNER_ID i_Params_Get_Salary_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Salary>  oReturnValue = new List<Salary> ();
string i_Ticket = string.Empty;
Result_Get_Salary_By_OWNER_ID_Adv oResult_Get_Salary_By_OWNER_ID_Adv = new Result_Get_Salary_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Salary_By_OWNER_ID_Adv(i_Params_Get_Salary_By_OWNER_ID);
oResult_Get_Salary_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Salary_By_OWNER_ID_Adv.My_Params_Get_Salary_By_OWNER_ID = i_Params_Get_Salary_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Salary_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Salary_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Salary_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Salary_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Salary_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Staff_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Staff_By_OWNER_ID_Adv")]
public Result_Get_Staff_By_OWNER_ID_Adv Get_Staff_By_OWNER_ID_Adv(Params_Get_Staff_By_OWNER_ID i_Params_Get_Staff_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Staff>  oReturnValue = new List<Staff> ();
string i_Ticket = string.Empty;
Result_Get_Staff_By_OWNER_ID_Adv oResult_Get_Staff_By_OWNER_ID_Adv = new Result_Get_Staff_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Staff_By_OWNER_ID_Adv(i_Params_Get_Staff_By_OWNER_ID);
oResult_Get_Staff_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Staff_By_OWNER_ID_Adv.My_Params_Get_Staff_By_OWNER_ID = i_Params_Get_Staff_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Staff_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Staff_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Staff_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Staff_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Staff_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Stock_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Stock_By_OWNER_ID_Adv")]
public Result_Get_Stock_By_OWNER_ID_Adv Get_Stock_By_OWNER_ID_Adv(Params_Get_Stock_By_OWNER_ID i_Params_Get_Stock_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Stock>  oReturnValue = new List<Stock> ();
string i_Ticket = string.Empty;
Result_Get_Stock_By_OWNER_ID_Adv oResult_Get_Stock_By_OWNER_ID_Adv = new Result_Get_Stock_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Stock_By_OWNER_ID_Adv(i_Params_Get_Stock_By_OWNER_ID);
oResult_Get_Stock_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Stock_By_OWNER_ID_Adv.My_Params_Get_Stock_By_OWNER_ID = i_Params_Get_Stock_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Stock_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Stock_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Stock_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Stock_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Stock_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Transaction_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Transaction_By_OWNER_ID_Adv")]
public Result_Get_Transaction_By_OWNER_ID_Adv Get_Transaction_By_OWNER_ID_Adv(Params_Get_Transaction_By_OWNER_ID i_Params_Get_Transaction_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Transaction>  oReturnValue = new List<Transaction> ();
string i_Ticket = string.Empty;
Result_Get_Transaction_By_OWNER_ID_Adv oResult_Get_Transaction_By_OWNER_ID_Adv = new Result_Get_Transaction_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Transaction_By_OWNER_ID_Adv(i_Params_Get_Transaction_By_OWNER_ID);
oResult_Get_Transaction_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Transaction_By_OWNER_ID_Adv.My_Params_Get_Transaction_By_OWNER_ID = i_Params_Get_Transaction_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Transaction_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Transaction_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Transaction_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Transaction_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Transaction_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Workshop_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Workshop_By_OWNER_ID_Adv")]
public Result_Get_Workshop_By_OWNER_ID_Adv Get_Workshop_By_OWNER_ID_Adv(Params_Get_Workshop_By_OWNER_ID i_Params_Get_Workshop_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Workshop>  oReturnValue = new List<Workshop> ();
string i_Ticket = string.Empty;
Result_Get_Workshop_By_OWNER_ID_Adv oResult_Get_Workshop_By_OWNER_ID_Adv = new Result_Get_Workshop_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Workshop_By_OWNER_ID_Adv(i_Params_Get_Workshop_By_OWNER_ID);
oResult_Get_Workshop_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Workshop_By_OWNER_ID_Adv.My_Params_Get_Workshop_By_OWNER_ID = i_Params_Get_Workshop_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Workshop_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Workshop_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Workshop_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Workshop_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Workshop_By_OWNER_ID_Adv;
#endregion
}
#endregion
}

#region Action_Result
public partial class Action_Result
{
#region Properties.
public string ExceptionCode { get; set; }
public string ExceptionMsg { get; set; }
#endregion
#region Constructor
public Action_Result()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.ExceptionMsg = string.Empty;
#endregion
}
#endregion
}
#endregion
#region Result_Edit_Address
public partial class Result_Edit_Address : Action_Result
{
#region Properties.
public Address My_Address { get; set; }
#endregion
}
#endregion
#region Result_Edit_Coupons
public partial class Result_Edit_Coupons : Action_Result
{
#region Properties.
public Coupons My_Coupons { get; set; }
#endregion
}
#endregion
#region Result_Edit_Currency
public partial class Result_Edit_Currency : Action_Result
{
#region Properties.
public Currency My_Currency { get; set; }
#endregion
}
#endregion
#region Result_Edit_Industry
public partial class Result_Edit_Industry : Action_Result
{
#region Properties.
public Industry My_Industry { get; set; }
#endregion
}
#endregion
#region Result_Edit_Machine
public partial class Result_Edit_Machine : Action_Result
{
#region Properties.
public Machine My_Machine { get; set; }
#endregion
}
#endregion
#region Result_Edit_Productdistribution
public partial class Result_Edit_Productdistribution : Action_Result
{
#region Properties.
public Productdistribution My_Productdistribution { get; set; }
#endregion
}
#endregion
#region Result_Edit_Staff
public partial class Result_Edit_Staff : Action_Result
{
#region Properties.
public Staff My_Staff { get; set; }
#endregion
}
#endregion
#region Result_Edit_Stock
public partial class Result_Edit_Stock : Action_Result
{
#region Properties.
public Stock My_Stock { get; set; }
#endregion
}
#endregion
#region Result_Edit_Transaction
public partial class Result_Edit_Transaction : Action_Result
{
#region Properties.
public Transaction My_Transaction { get; set; }
#endregion
}
#endregion
#region Result_Edit_Workshop
public partial class Result_Edit_Workshop : Action_Result
{
#region Properties.
public Workshop My_Workshop { get; set; }
#endregion
}
#endregion
#region Result_Get_Address_By_OWNER_ID_Adv
public partial class Result_Get_Address_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Address>  My_Result { get; set; }
public Params_Get_Address_By_OWNER_ID My_Params_Get_Address_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Coupons_By_OWNER_ID_Adv
public partial class Result_Get_Coupons_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Coupons>  My_Result { get; set; }
public Params_Get_Coupons_By_OWNER_ID My_Params_Get_Coupons_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Currency_By_OWNER_ID_Adv
public partial class Result_Get_Currency_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Currency>  My_Result { get; set; }
public Params_Get_Currency_By_OWNER_ID My_Params_Get_Currency_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Industry_By_OWNER_ID_Adv
public partial class Result_Get_Industry_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Industry>  My_Result { get; set; }
public Params_Get_Industry_By_OWNER_ID My_Params_Get_Industry_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Machine_By_OWNER_ID_Adv
public partial class Result_Get_Machine_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Machine>  My_Result { get; set; }
public Params_Get_Machine_By_OWNER_ID My_Params_Get_Machine_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Productdistribution_By_OWNER_ID_Adv
public partial class Result_Get_Productdistribution_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Productdistribution>  My_Result { get; set; }
public Params_Get_Productdistribution_By_OWNER_ID My_Params_Get_Productdistribution_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Salary_By_OWNER_ID_Adv
public partial class Result_Get_Salary_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Salary>  My_Result { get; set; }
public Params_Get_Salary_By_OWNER_ID My_Params_Get_Salary_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Staff_By_OWNER_ID_Adv
public partial class Result_Get_Staff_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Staff>  My_Result { get; set; }
public Params_Get_Staff_By_OWNER_ID My_Params_Get_Staff_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Stock_By_OWNER_ID_Adv
public partial class Result_Get_Stock_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Stock>  My_Result { get; set; }
public Params_Get_Stock_By_OWNER_ID My_Params_Get_Stock_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Transaction_By_OWNER_ID_Adv
public partial class Result_Get_Transaction_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Transaction>  My_Result { get; set; }
public Params_Get_Transaction_By_OWNER_ID My_Params_Get_Transaction_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Workshop_By_OWNER_ID_Adv
public partial class Result_Get_Workshop_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Workshop>  My_Result { get; set; }
public Params_Get_Workshop_By_OWNER_ID My_Params_Get_Workshop_By_OWNER_ID { get; set; }
#endregion
}
#endregion
