using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class _02_Actions_ausfuehren_04_Action_ueberladen
{
  [DeclareAction("XSDShowMatchingMasterDialogAction", 50)]
  public void Function()
  {
    MessageBox.Show("Vorsicht!");

    ActionCallingContext acc = new ActionCallingContext();
    Eplan.EplApi.ApplicationFramework.Action action =
        new ActionManager().FindBaseActionFromFunctionAction(false);    
    action.Execute(acc);
  }
}