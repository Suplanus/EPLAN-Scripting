using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _02_RunActions_03_ActionsWithParameter
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("Name", "XGedIaFormatText");
    acc.AddParameter("height", "20");

    cli.Execute("XGedStartInteractionAction", acc);
  }
}