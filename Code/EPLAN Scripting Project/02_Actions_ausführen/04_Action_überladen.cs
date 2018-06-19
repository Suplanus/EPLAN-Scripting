using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _02_Actions_ausfuehren_04_Action_ueberladen
{
  [DeclareAction("XGedUpdateMacroAction", 50)]
  public void Function()
  {
    ActionCallingContext acc = new ActionCallingContext();
    acc.AddParameter("AutoAssignLastUsedRecord", "1");

    Eplan.EplApi.ApplicationFramework.Action action =
      new ActionManager().FindBaseActionFromFunctionAction(false);
    action.Execute(acc);

    return;
  }
}