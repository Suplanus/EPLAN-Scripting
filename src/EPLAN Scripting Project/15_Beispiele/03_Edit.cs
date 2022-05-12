using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _15_Beispiele_03_Edit
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("DEVICENAME", "=GAA+A1-FCC1");

    cli.Execute("edit", acc);
  }
}