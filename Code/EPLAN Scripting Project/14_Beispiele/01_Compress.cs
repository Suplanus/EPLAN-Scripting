using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _14_Beispiele_01_Compress
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("CONFIGSCHEME", "Standard");
    acc.AddParameter("FILTERSCHEME", "Allpolig");

    cli.Execute("compress", acc);

    MessageBox.Show("Action ausgeführt.");

    return;
  }
}