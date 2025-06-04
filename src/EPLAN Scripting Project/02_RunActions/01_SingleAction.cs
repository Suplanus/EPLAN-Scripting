using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _02_RunActions_01_SingleAction
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    cli.Execute("reports");
  }
}