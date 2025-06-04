using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_CodeFlow_05_MethodInteger
{
  [DeclareAction("MethodeInt")]
  public void Function(int int1, int int2)
  {
    CalcMessageBox(int1, int2);
    FinishedMessageBox();
  }

  private static void CalcMessageBox(int int1, int int2)
  {
    int result = int1 + int2;
    MessageBox.Show(int1.ToString() +
        " + " + int2.ToString() +
        " = " + result.ToString());
  }

  private static void FinishedMessageBox()
  {
    MessageBox.Show("Calculation was successful.");
  }
}