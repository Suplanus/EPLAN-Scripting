using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _14_Beispiele_05_Print
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("TYPE", "PROJECT");

    cli.Execute("print", acc);

    MessageBox.Show("Action ausgeführt.");

    return;
  }
}