using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _15_Beispiele_07_XEsSetProjectPropertyAction
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("PropertyId", "10013");
    acc.AddParameter("PropertyIndex", "0");
    acc.AddParameter("PropertyValue", "23542");

    cli.Execute("XEsSetProjectPropertyAction", acc);

    MessageBox.Show("Action ausgeführt.");
  }
}