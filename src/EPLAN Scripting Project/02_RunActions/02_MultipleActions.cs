using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _02_RunActions_02_MultipleActions
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();

    cli.Execute("XMsgActionStartVerification");
    cli.Execute("reports");
    cli.Execute("ActionName");
  }
}