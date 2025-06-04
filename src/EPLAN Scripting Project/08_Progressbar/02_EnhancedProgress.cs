using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _08_Progressbar_02_EnhancedProgress
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();

    Progress progress = new Progress("EnhancedProgress");
    progress.SetAllowCancel(false);
    progress.ShowImmediately();

    try
    {
      progress.BeginPart(33, "Part 1");
      cli.Execute("generate /TYPE:CONNECTIONS");
      progress.EndPart();

      progress.BeginPart(33, "Part 2");
      cli.Execute("reports");
      progress.EndPart();

      progress.BeginPart(33, "Part 3");
      cli.Execute("compress /FILTERSCHEME:Standard");
      progress.EndPart();
    }
    finally
    {
      progress.EndPart(true);
    }
  }
}