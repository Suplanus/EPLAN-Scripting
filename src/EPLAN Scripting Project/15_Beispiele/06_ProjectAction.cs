using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _15_Beispiele_06_ProjectAction
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("Project", @"C:\Test\Beispielprojekt.elk");
    acc.AddParameter("Action", "reports");
    acc.AddParameter("NOCLOSE", "1");

    cli.Execute("ProjectAction", acc);

    MessageBox.Show("Action ausgeführt.");
  }
}