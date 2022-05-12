using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _15_Beispiele_09_Restore
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("TYPE", "PROJECT");
    acc.AddParameter("ARCHIVENAME", @"C:\test\Beispielprojekt.zw1");
    acc.AddParameter("PROJECTNAME", @"C:\test\Beispielprojekt.elk");
    acc.AddParameter("UNPACKPROJECT", "0");
    acc.AddParameter("MODE", "1");
    acc.AddParameter("NOCLOSE", "1");

    cli.Execute("restore", acc);

    MessageBox.Show("Action ausgeführt.");
  }
}