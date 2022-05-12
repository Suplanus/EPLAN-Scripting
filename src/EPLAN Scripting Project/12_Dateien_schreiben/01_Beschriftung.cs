using System.IO;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _12_Dateien_schreiben_01_Beschriftung
{
  [Start]
  public void Function()
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");

    Progress progress = new Progress("SimpleProgress");
    progress.SetAllowCancel(true);
    progress.SetAskOnCancel(false);
    progress.SetNeededSteps(3);
    progress.SetTitle("Beschriftung");
    progress.ShowImmediately();

    if (!progress.Canceled())
    {
      progress.BeginPart(50,
        "Artikelsummenstückliste wird erstellt...");

      string fileName = Path.Combine(projectPath,
        "Artikelsummenstückliste.xlsx");                 

      ActionCallingContext context1 = new ActionCallingContext();
      context1.AddParameter("configscheme", "Summarized parts list");
      context1.AddParameter("filterscheme", "");
      context1.AddParameter("sortscheme", "");
      context1.AddParameter("language", "de_DE");
      context1.AddParameter("destinationfile", fileName);
      context1.AddParameter("recrepeat", "1");
      context1.AddParameter("taskrepeat", "1");
      context1.AddParameter("showoutput", "1");
      context1.AddParameter("type", "PROJECT");
      new CommandLineInterpreter().Execute("label", context1);

      progress.EndPart();
    }

    if (!progress.Canceled())
    {
      progress.BeginPart(50, 
        "Betriebsmittelbeschriftung wird erstellt...");

      string fileName = Path.Combine(projectPath,
        "Betriebsmittelliste.xlsx");

      ActionCallingContext context2 = new ActionCallingContext();
      context2.AddParameter("configscheme", "Device tag list");
      context2.AddParameter("filterscheme", "");
      context2.AddParameter("sortscheme", "");
      context2.AddParameter("language", "de_DE");
      context2.AddParameter("destinationfile", fileName);
      context2.AddParameter("recrepeat", "1");
      context2.AddParameter("taskrepeat", "1");
      context2.AddParameter("showoutput", "1");
      context2.AddParameter("type", "PROJECT");
      new CommandLineInterpreter().Execute("label", context2);

      progress.EndPart();
    }

    progress.EndPart(true);
  }
}