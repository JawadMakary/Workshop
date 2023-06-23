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
#region Get_Salary_By_STAFF_ID
[HttpPost]
[Route("Get_Salary_By_STAFF_ID")]
public Result_Get_Salary_By_STAFF_ID Get_Salary_By_STAFF_ID(Params_Get_Salary_By_STAFF_ID i_Params_Get_Salary_By_STAFF_ID)
{
#region Declaration And Initialization Section.
List<Salary>  oReturnValue = new List<Salary> ();
string i_Ticket = string.Empty;
Result_Get_Salary_By_STAFF_ID oResult_Get_Salary_By_STAFF_ID = new Result_Get_Salary_By_STAFF_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Salary_By_STAFF_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Salary_By_STAFF_ID(i_Params_Get_Salary_By_STAFF_ID);
oResult_Get_Salary_By_STAFF_ID.My_Result = oReturnValue;
oResult_Get_Salary_By_STAFF_ID.My_Params_Get_Salary_By_STAFF_ID = i_Params_Get_Salary_By_STAFF_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Salary_By_STAFF_ID.ExceptionMsg = string.Format("Get_Salary_By_STAFF_ID : {0}", ex.Message);
}
else
{
oResult_Get_Salary_By_STAFF_ID.ExceptionMsg = ex.Message;
oResult_Get_Salary_By_STAFF_ID.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Salary_By_STAFF_ID;
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
#region Result_Get_Salary_By_STAFF_ID
public partial class Result_Get_Salary_By_STAFF_ID : Action_Result
{
#region Properties.
public List<Salary>  My_Result { get; set; }
public Params_Get_Salary_By_STAFF_ID My_Params_Get_Salary_By_STAFF_ID { get; set; }
#endregion
}
#endregion
