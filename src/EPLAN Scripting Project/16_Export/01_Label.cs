using System;
using System.IO;
using System.Runtime.Remoting.Contexts;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _16_Export_01_Label
{
  [Start]
  public bool AutoTreat()
  {
    Progress progress = new Progress("SimpleProgress");
    progress.SetAllowCancel(true);
    bool bResult = true;
    int nActionsPercent = 100;
    progress.BeginPart(nActionsPercent, "");
    nActionsPercent = 100;
    if (!progress.Canceled())
    {
      progress.BeginPart(nActionsPercent / 2, "label");
      ActionCallingContext context1 = new ActionCallingContext();
      context1.AddParameter("configscheme", "Summarized parts list");
      context1.AddParameter("filterscheme", "");
      context1.AddParameter("sortscheme", "");
      context1.AddParameter("language", "de_DE");
      context1.AddParameter("destinationfile", @"$(DOC)\BOM.xlsx");
      context1.AddParameter("recrepeat", "1");
      context1.AddParameter("taskrepeat", "1");
      context1.AddParameter("showoutput", "1");
      context1.AddParameter("type", "PROJECT");
      bResult &= new CommandLineInterpreter().Execute("label", context1);
      progress.EndPart();
    }
    nActionsPercent = 100;
    if (!progress.Canceled())
    {
      progress.BeginPart(nActionsPercent / 2, "label");
      ActionCallingContext context2 = new ActionCallingContext();
      context2.AddParameter("configscheme", "Device tag list");
      context2.AddParameter("filterscheme", "");
      context2.AddParameter("sortscheme", "");
      context2.AddParameter("language", "de_DE");
      context2.AddParameter("destinationfile", @"$(DOC)\Device-List.xlsx");
      context2.AddParameter("recrepeat", "1");
      context2.AddParameter("taskrepeat", "1");
      context2.AddParameter("showoutput", "1");
      context2.AddParameter("type", "PROJECT");
      bResult &= new CommandLineInterpreter().Execute("label", context2);
      progress.EndPart();
    }
    progress.EndPart(true);
    return bResult;
  }
}