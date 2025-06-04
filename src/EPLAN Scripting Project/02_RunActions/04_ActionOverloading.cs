using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class _02_RunActions_04_ActionOverloading
{
  [DeclareAction("XSDShowMatchingMasterDialogAction", 50)]
  public void Function()
  {
    MessageBox.Show("Warning!");

    ActionCallingContext acc = new ActionCallingContext();
    Eplan.EplApi.ApplicationFramework.Action action =
      new ActionManager().FindBaseActionFromFunctionAction(false);    
    action.Execute(acc);
  }
}