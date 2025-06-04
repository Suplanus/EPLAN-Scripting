using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _05_ActionsWithValues_01_ActionWithReturnValue
{
  [Start]
  public void Function()
  {
    string value = string.Empty;

    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext actionCallingContext = new ActionCallingContext();
    actionCallingContext.AddParameter("name", "Neo");
    cli.Execute("ReturnAction", actionCallingContext);

    actionCallingContext.GetParameter("value", ref value);

    MessageBox.Show(value);
  }

  [DeclareAction("ReturnAction")]
  public void ReturnAction(string name, out string value)
  {
    value = "Knock knock " + name;
  }
}