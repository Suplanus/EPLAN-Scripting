using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _02_Actions_ausfuehren_03_Action_mit_Parameter
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("Name", "XGedIaFormatText");
    acc.AddParameter("height", "20");

    cli.Execute("XGedStartInteractionAction", acc);

    return;
  }
}