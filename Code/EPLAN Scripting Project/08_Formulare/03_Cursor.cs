using Eplan.EplApi.Scripting;
using System.Threading;
using System.Windows.Forms;

public class _08_Formulare_03_Cursor
{
  [Start]
  public void Function()
  {
    Cursor.Current = Cursors.AppStarting;
    Thread.Sleep(3000);
    Cursor.Current = Cursors.WaitCursor;
    Thread.Sleep(3000);

    return;
  }
}