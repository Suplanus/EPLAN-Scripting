using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_Programmsteuerung_04_Methode_MessageBox
{
  [DeclareAction("MethodeMessageBox")]
  public void Function(int int1, int int2)
  {
    int intResult = int1 + int2;

    MessageBox.Show(int1.ToString() +
        " + " + int2.ToString() +
        " = " + intResult.ToString());
    FinishedMessageBox();

    return;
  }

  private static void FinishedMessageBox()
  {
    MessageBox.Show("Berechnung abgeschlossen.");
  }
}