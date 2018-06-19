using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _02_Actions_ausfuehren_02_Mehrere_Actions
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();

    cli.Execute("XMsgActionStartVerification");
    cli.Execute("reports");
    cli.Execute("Actionname");

    return;
  }
}