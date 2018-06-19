using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _02_Actions_ausfuehren_01_Einzelne_Action
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    cli.Execute("reports");
    return;
  }
}