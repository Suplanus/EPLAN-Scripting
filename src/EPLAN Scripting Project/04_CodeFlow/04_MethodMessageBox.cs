using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_CodeFlow_04_MethodMessageBox
{
  [DeclareAction("MethodeMessageBox")]
  public void Function(int int1, int int2)
  {
    int intResult = int1 + int2;

    MessageBox.Show(int1.ToString() +
        " + " + int2.ToString() +
        " = " + intResult.ToString());
    FinishedMessageBox();
  }

  private static void FinishedMessageBox()
  {
    MessageBox.Show("Calculation was successful.");
  }
}