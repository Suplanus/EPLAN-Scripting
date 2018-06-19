using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _14_Beispiele_03_Edit
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("DEVICENAME", "=+-FC1");

    cli.Execute("edit", acc);

    return;
  }
}